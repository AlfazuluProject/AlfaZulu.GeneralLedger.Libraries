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


namespace AlfaZulu.GeneralLedger.Entries
{
    public class GeneralLedgerEntry
    {
        readonly private List<GeneralLedgerEntryLine> _EntryLines=new List<GeneralLedgerEntryLine>();
        private decimal _TotalDebit = 0;
        private decimal _TotalCredit = 0;
        private GeneralLedgerEntryPostingStatusEnum _EntryStatus;

        public GeneralLedgerEntry()
        {
            _EntryStatus = GeneralLedgerEntryPostingStatusEnum.New;
        }

        public DateTime TransactionDate { get; set; }

        public List<GeneralLedgerEntryLine> EntryLines { get { return _EntryLines; } }

        public decimal TotalDebit { get { return _TotalDebit; } }

        public decimal TotalCredit { get { return _TotalCredit; } }

        public GeneralLedgerEntryPostingStatusEnum EntryStatus { get { return _EntryStatus; } }


        public void AddEntryLine(GeneralLedgerEntryLine entryLine)
        {

            _EntryLines.Add(entryLine);

            if (entryLine.DebitCredit == DebitCredit.Debit)
            {
                _TotalDebit += entryLine.Amount;
            }
            else
            {
                _TotalCredit+= entryLine.Amount;
            }

        }

    }
}
