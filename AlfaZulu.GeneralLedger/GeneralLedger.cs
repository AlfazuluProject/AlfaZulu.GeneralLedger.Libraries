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
using AlfaZulu.GeneralLedger.Entries;

namespace AlfaZulu.GeneralLedger
{
    public class GeneralLedger
    {

        private readonly List<GeneralLedgerEntry> _EntreesForDate = new List<GeneralLedgerEntry>();

        public List<GeneralLedgerEntry> EntreesForDate { get { return _EntreesForDate; } }

    }
}
