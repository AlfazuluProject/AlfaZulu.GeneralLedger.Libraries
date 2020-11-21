/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. 
 
   Copyright 2020 Christian Chicoine. All Rights Reserved. 
   For any information please visit https://www.alfazulu.org
   or https://github.com/AlfazuluProject
 */

using System;
using System.Collections.Generic;
using AlfaZulu.GeneralLedger.Accounts;

namespace AlfaZulu.GeneralLedger.ChartOfAccounts
{
    public class ChartofAccounts
    {
        readonly List<GeneralLedgerAccount> _RevenuAccounts;
        readonly List<GeneralLedgerAccount> _ExpenseAccounts;
        readonly List<GeneralLedgerAccount> _AssetAccounts;
        readonly List<GeneralLedgerAccount> _LiabilityAccounts;
        readonly List<GeneralLedgerAccount> _EquityAccounts;


        public ChartofAccounts()
        {
            _RevenuAccounts = new List<GeneralLedgerAccount>();
            _ExpenseAccounts = new List<GeneralLedgerAccount>();
            _AssetAccounts = new List<GeneralLedgerAccount>();
            _LiabilityAccounts = new List<GeneralLedgerAccount>();
            _EquityAccounts = new List<GeneralLedgerAccount>();
        }

        public List<GeneralLedgerAccount> RevenuAccounts { get { return _RevenuAccounts; } }

        public List<GeneralLedgerAccount> ExpenseAccounts { get { return _ExpenseAccounts; } }

        public List<GeneralLedgerAccount> AssetAccounts { get { return _AssetAccounts; } }

        public List<GeneralLedgerAccount> LiabilityAccounts { get { return _LiabilityAccounts; } }

        public List<GeneralLedgerAccount> EquityAccounts { get { return _EquityAccounts; } }

    }
}
