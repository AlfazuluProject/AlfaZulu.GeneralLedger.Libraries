/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. 
 
   Copyright 2020 Christian Chicoine. All Rights Reserved. 
   For any information please visit https://www.alfazulu.org
   or https://github.com/AlfazuluProject
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlfaZulu.GeneralLedger.Accounts
{
    public class GeneralLedgerAccountType
    {
        public GeneralLedgerAccountTypeEnum Id { get; set; } 

        public string Name { get; set; }

        public string HelpText { get; init; }

    }

}
