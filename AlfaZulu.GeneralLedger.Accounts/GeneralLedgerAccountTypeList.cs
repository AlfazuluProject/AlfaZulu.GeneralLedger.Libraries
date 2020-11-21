/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. 
 
   Copyright 2020 Christian Chicoine. All Rights Reserved. 
   For any information please visit https://www.alfazulu.org
   or https://github.com/AlfazuluProject
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfaZulu.GeneralLedger.Accounts
{

    public static class GeneralLedgerAccountTypeList
    {

        private static IList<GeneralLedgerAccountType> _GLAccountTypes;

        static GeneralLedgerAccountTypeList()
        {
            _GLAccountTypes = new List<GeneralLedgerAccountType>()
            {
                new GeneralLedgerAccountType()
                {
                    Id=GeneralLedgerAccountTypeEnum.Revenu,
                    Name= "Revenu",
                    HelpText="Revenue describes income earned through the provision of a business's primary goods or services."
                },
                new GeneralLedgerAccountType()
                {
                    Id=GeneralLedgerAccountTypeEnum.Expense,
                    Name= "Expense",
                    HelpText="Revenue describes income earned through the provision of a business's primary goods or services."
                },
                new GeneralLedgerAccountType()
                {
                    Id=GeneralLedgerAccountTypeEnum.Asset,
                    Name= "Asset",
                    HelpText="An asset account is an account that records the assets owned by a company."
                },
                new GeneralLedgerAccountType()
                {
                    Id=GeneralLedgerAccountTypeEnum.Liability,
                    Name= "Liability",
                    HelpText="Liabilities are any debts a company has."
                },
                new GeneralLedgerAccountType()
                {
                    Id=GeneralLedgerAccountTypeEnum.Equity,
                    Name= "Equity",
                    HelpText="Equity represents the value that would be returned to a company's shareholders if all of the assets were liquidated and all of the company's debts were paid off."
                },

            };
        }

        public static IList<GeneralLedgerAccountType> GLAccountTypes
        {
            get
            {
                return _GLAccountTypes;
            }
        }

    }

}
