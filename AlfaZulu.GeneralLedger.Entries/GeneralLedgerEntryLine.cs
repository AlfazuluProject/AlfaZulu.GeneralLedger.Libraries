/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. 
 
   Copyright 2020 Christian Chicoine. All Rights Reserved. 
   For any information please visit https://www.alfazulu.org
   or https://github.com/AlfazuluProject
 */

using System;
using System.Collections.Generic;
using AlfaZulu.GeneralLedger.Common;
using AlfaZulu.GeneralLedger.Accounts;


namespace AlfaZulu.GeneralLedger.Entries
{
    public class GeneralLedgerEntryLine
    {
        public int Id { get; set; }

        public int LineNumber { get; set; }
        
        public GeneralLedgerAccount GLAccount { get; set; }


    public DebitCredit DebitCredit { get; set; }

        public Decimal Amount { get; set; }

        public string Note { get; set; }

    }
}
