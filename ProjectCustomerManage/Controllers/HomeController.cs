using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ProjectCustomerManage.Models;
using ProjectCustomerManage.APIData;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ProjectCustomerManage.Controllers
{
    public class HomeController : Controller 
    {
        CustomersEntities db = new CustomersEntities();
      

        public async Task<ActionResult> Index()
        {
            var cityItems = db.SelectCities.ToList();

            CustomersTBL model = new CustomersTBL();
            foreach (var City in cityItems)
            {
                model.Cities.Add(new SelectListItem { Text = City.NameCity.ToString(), Value = City.IDCity.ToString() });
            }

            var apiData = await GetBanks();
            
            foreach(var Bank in apiData.result.bank)
            {
                model.Banks.Add(new SelectListItem {Text=Bank.key.ToString(), Value = Bank.value.ToString() });
            }
            
            return View(model);


        }
        [HttpPost]
     
        public async Task<ActionResult> Index(int? Bank, int? Branch, CustomersTBL model)
        {
            try
            {
                var cityItems = db.SelectCities.ToList();
                var apiData = await GetBanks();

                foreach (var iCity in cityItems)
                {
                    model.Cities.Add(new SelectListItem { Text = iCity.NameCity.ToString(), Value = iCity.IDCity.ToString() });
                }

                foreach (var iBank in apiData.result.bank)
                {
                    model.Banks.Add(new SelectListItem { Text = iBank.key.ToString(), Value = iBank.value.ToString() });
                }

                if (Bank.HasValue && !Branch.HasValue)
                {
                    var branches = (from bankBranch in apiData.result.bankBranch
                                    where bankBranch.bankCode == Bank
                                    select bankBranch).ToList();
                    foreach (var bankBranch in branches)
                    {
                        model.Branches.Add(new SelectListItem { Text = bankBranch.key, Value = bankBranch.value.ToString() });
                    }

                }
                else if (ModelState.IsValid)
                {
                    db.CustomersTBLs.Add(model);
                    db.SaveChanges();
                    ViewBag.mes = string.Format("Customer created successfully");
                    return RedirectToAction("PrintCustomerTBL");
                }
                return View(model);
            }
            catch(Exception ex)
            {
                ViewBag.mes = string.Format("Error in Customer creation : {0} ,try again",ex.Message);
                return View(model);
            }
        }

        [HttpGet]
        public PartialViewResult PrintCustomerTBL()
        {

            var listCustomers = db.CustomersTBLs.ToList();
            return PartialView(listCustomers);
        }

        private async Task<APIClass> GetBanks()
        {
            Uri myUri = new Uri("https://cal.cal-online.co.il/CalSaleOrderingWS/api/internet/catalog/finance");

            HttpWebRequest httpWebRequest = WebRequest.Create(myUri) as HttpWebRequest;

            httpWebRequest.PreAuthenticate = true;
            httpWebRequest.Method = "GET";
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<APIClass>(result);
            }
         
        }


    }
}