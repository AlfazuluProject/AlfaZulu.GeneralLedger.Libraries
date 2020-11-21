/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. 
 
   Copyright 2020 Christian Chicoine. All Rights Reserved. 
   For any information please visit https://www.alfazulu.org
   or https://github.com/AlfazuluProject
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using AlfaZulu.GeneralLedger.ChartOfAccounts;
using AlfaZulu.GeneralLedger.Accounts;

namespace AlfaZulu.GeneralLedger.Tests
{
    [TestClass]
    public class ChartOfAccountTests
    {
        private readonly ChartofAccounts _COA = new ChartofAccounts();
        
        public ChartOfAccountTests()
        {

        }

        [TestMethod]
        public void AddAssetAccount()
        {

            GeneralLedgerAccount assetAccount = new GeneralLedgerAccount()
            {
                Id = 2,
                Code = "1000",
                Name = "Bank Account",
                GLAccountType = GeneralLedgerAccountTypeList.GLAccountTypes.Single(s => s.Id == GeneralLedgerAccountTypeEnum.Asset)
            };

            _COA.AssetAccounts.Add(assetAccount);

            Assert.IsTrue(_COA.AssetAccounts.Count == 1);

        }

        [TestMethod]
        public void AddLiabilityAccount()
        {

            GeneralLedgerAccount liabilityAccount = new GeneralLedgerAccount()
            {
                Id = 2,
                Code = "2000",
                Name = "Credit Card",
                GLAccountType = GeneralLedgerAccountTypeList.GLAccountTypes.Single(s => s.Id == GeneralLedgerAccountTypeEnum.Liability)
            };

            _COA.LiabilityAccounts.Add(liabilityAccount);

            Assert.IsTrue(_COA.LiabilityAccounts.Count == 1);

        }

        [TestMethod]
        public void AddRevenuAccount()
        {
            
            GeneralLedgerAccount revenuAccount = new GeneralLedgerAccount()
            {
                Id = 1, 
                Code = "3000",
                Name = "Sales",
                GLAccountType = GeneralLedgerAccountTypeList.GLAccountTypes.Single(s => s.Id == GeneralLedgerAccountTypeEnum.Revenu)
            };
          
            _COA.RevenuAccounts.Add(revenuAccount);

            Assert.IsTrue(_COA.RevenuAccounts.Count == 1);

        }

        [TestMethod]
        public void AddExpenseAccount()
        {

            GeneralLedgerAccount expenseAccount = new GeneralLedgerAccount()
            {
                Id = 2,
                Code = "4000",
                Name = "Electricity",
                GLAccountType = GeneralLedgerAccountTypeList.GLAccountTypes.Single(s => s.Id == GeneralLedgerAccountTypeEnum.Expense)
            };

            _COA.RevenuAccounts.Add(expenseAccount);

            Assert.IsTrue(_COA.RevenuAccounts.Count == 1);

        }

    }
}
