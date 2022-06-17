using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_CashFlowWithSwitches
{
    internal interface IPayable
    {
        public Ledger.LedgerType ledgerType { get; }
        public decimal Payable { get;}
    }
}
