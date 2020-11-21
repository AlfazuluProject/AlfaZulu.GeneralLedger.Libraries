﻿/* This Source Code Form is subject to the terms of the Mozilla Public
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
    public enum GeneralLedgerAccountTypeEnum : int
    {
        Revenu = 1,
        Expense = 2,
        Asset = 3,
        Liability = 4,
        Equity = 5
    }

}
