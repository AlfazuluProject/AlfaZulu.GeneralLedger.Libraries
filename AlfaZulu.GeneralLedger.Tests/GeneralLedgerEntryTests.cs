/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. 
 
   Copyright 2020 Christian Chicoine. All Rights Reserved. 
   For any information please visit https://www.alfazulu.org
   or https://github.com/AlfazuluProject
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using AlfaZulu.GeneralLedger;
using AlfaZulu.GeneralLedger.Common;
using AlfaZulu.GeneralLedger.ChartOfAccounts;
using AlfaZulu.GeneralLedger.Accounts;
using AlfaZulu.GeneralLedger.Entries;


namespace AlfaZulu.GeneralLedger.Tests
{
    [TestClass]
    public class GeneralLedgerEntryTests
    {
        private readonly ChartofAccounts _COA = new ChartofAccounts();
        private readonly GeneralLedger _GeneralLedger = new GeneralLedger();


        public ChartofAccounts COA { get { return _COA;} }

        public GeneralLedgerEntryTests()
        {
            SetupChartOfAccounts();
        }

        private void SetupChartOfAccounts()
        {

            GeneralLedgerAccount assetAccount = new GeneralLedgerAccount()
            {
                Id = 2,
                Code = "1000",
                Name = "Bank Account",
                GLAccountType = GeneralLedgerAccountTypeList.GLAccountTypes.Single(s => s.Id == GeneralLedgerAccountTypeEnum.Asset)
            };

            _COA.AssetAccounts.Add(assetAccount);

            GeneralLedgerAccount liabilityAccount = new GeneralLedgerAccount()
            {
                Id = 2,
                Code = "2000",
                Name = "Credit Card",
                GLAccountType = GeneralLedgerAccountTypeList.GLAccountTypes.Single(s => s.Id == GeneralLedgerAccountTypeEnum.Liability)
            };

            _COA.LiabilityAccounts.Add(liabilityAccount);

            GeneralLedgerAccount revenuAccount = new GeneralLedgerAccount()
            {
                Id = 1,
                Code = "3000",
                Name = "Sales",
                GLAccountType = GeneralLedgerAccountTypeList.GLAccountTypes.Single(s => s.Id == GeneralLedgerAccountTypeEnum.Revenu)
            };

            _COA.RevenuAccounts.Add(revenuAccount);



            GeneralLedgerAccount expenseAccount = new GeneralLedgerAccount()
            {
                Id = 2,
                Code = "4000",
                Name = "Electricity",
                GLAccountType = GeneralLedgerAccountTypeList.GLAccountTypes.Single(s => s.Id == GeneralLedgerAccountTypeEnum.Expense)
            };

            _COA.RevenuAccounts.Add(expenseAccount);






        }


        /* 
         * Test the entry of a sale transaction, deposed into a bank account.
         */
        [TestMethod]
        public void BankAccountEntry()
        {
            GeneralLedgerEntry glentry = new GeneralLedgerEntry();


            //Debit the bank account
            GeneralLedgerEntryLine bankEntryLine = new GeneralLedgerEntryLine
            {
                Amount = 100,
                DebitCredit = DebitCredit.Debit,

            };
            glentry.AddEntryLine(bankEntryLine);


            //Credit the sale account
            GeneralLedgerEntryLine saleEntryLine = new GeneralLedgerEntryLine
            {
                Amount = 100,
                DebitCredit = DebitCredit.Credit,
                GLAccount = _COA.RevenuAccounts.Single(s => s.Code == "3000")
            };
            glentry.AddEntryLine(saleEntryLine);


            _GeneralLedger.EntreesForDate.Add(glentry);

            //Testing that the entry is balanced
            Assert.IsTrue(glentry.TotalDebit == glentry.TotalCredit);


        }
    }
}
