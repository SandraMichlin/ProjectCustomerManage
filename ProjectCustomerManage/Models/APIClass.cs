using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectCustomerManage.APIData
{
   
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Bank
        {
            [Key]
            public string key { get; set; }
            public int value { get; set; }
        }

        public class BankBranch
        {
            public string key { get; set; }
            public int value { get; set; }
            public int bankCode { get; set; }
        }

        public class MonthlyIncome
        {
            public string key { get; set; }
            public int value { get; set; }
        }

        public class CreditCardType
        {
            public string key { get; set; }
            public int value { get; set; }
        }

        public class CreditCompany
        {
            public string key { get; set; }
            public int value { get; set; }
        }

        public class AccountType
        {
            public string key { get; set; }
            public int value { get; set; }
            public int bankCode { get; set; }
        }

        public class CalClub
        {
            public int key { get; set; }
            public string value { get; set; }
        }

        public class CardUse
        {
            public string key { get; set; }
            public int value { get; set; }
        }

        public class AccountMode
        {
            public string key { get; set; }
            public int value { get; set; }
        }

        public class BrandDebitDay
        {
            public int key { get; set; }
            public int value { get; set; }
        }

        public class BasicProduct
        {
            public int basicProdCode { get; set; }
            public string displayBasicProdName { get; set; }
        }

        public class Lob
        {
            public int lobCode { get; set; }
            public string lobName { get; set; }
            public List<BasicProduct> basicProducts { get; set; }
        }

        public class CreditPlan
        {
            public int creditPlanCode { get; set; }
            public string creditPlanDisplayName { get; set; }
            public string fullDisclosure { get; set; }
            public string description { get; set; }
        }

        public class Brand
        {
            public int brandCode { get; set; }
            public string brandName { get; set; }
        }

        public class Result
        {
            public List<Bank> bank { get; set; }
            public List<BankBranch> bankBranch { get; set; }
            public List<MonthlyIncome> monthlyIncome { get; set; }
            public List<CreditCardType> creditCardType { get; set; }
            public List<CreditCompany> creditCompany { get; set; }
            public List<AccountType> accountType { get; set; }
            public List<CalClub> calClub { get; set; }
            public List<CardUse> cardUse { get; set; }
            public List<AccountMode> accountMode { get; set; }
            public List<BrandDebitDay> brandDebitDay { get; set; }
            public List<Lob> lob { get; set; }
            public List<int> possibleDebitDays { get; set; }
            public List<CreditPlan> creditPlans { get; set; }
            public List<Brand> brands { get; set; }
        }

        public class Status
        {
            public object description { get; set; }
            public string headlineMessage { get; set; }
            public string message { get; set; }
            public int severityCode { get; set; }
            public string severityNumber { get; set; }
            public bool succeeded { get; set; }
            public object stackTrace { get; set; }
            public object replaceField { get; set; }
            public bool continueProcess { get; set; }
            public int processStatus { get; set; }
            public string systemMessageCode { get; set; }
            public string messageCode { get; set; }
            public object quoteStatus { get; set; }
            public int screenCode { get; set; }
            public object screenName { get; set; }
            public int processCode { get; set; }
            public int telecalOrderStatusCode { get; set; }
            public object telecalOrderStatusReasonCode { get; set; }
            public int telecalBankDebitStatus { get; set; }
        }

        public class APIClass
        {
            public Result result { get; set; }
            public Status status { get; set; }
            public string nextCsPid { get; set; }
        }

    
}