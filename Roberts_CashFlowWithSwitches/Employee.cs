using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_CashFlowWithSwitches
{
    internal class Employee:IPayable
    {
        private string _name;
        private string _ssn;
        private decimal _payable;
        private Ledger.LedgerType _ledgerType;

        public Employee(string firstName, string lastName, string ssn)
        {
            _name = firstName+" "+lastName;
            _ssn = ssn;
            _ledgerType = ledgerType;
        }
        public decimal setPayable(decimal payable)
        {
            _payable = payable;
            return _payable;
        }
        public Ledger.LedgerType setLedgerType(Ledger.LedgerType ledgerType)
        {
            _ledgerType=ledgerType;
            return _ledgerType;
        }

        public decimal Payable
        {
            get { return _payable; }
        }
        public Ledger.LedgerType ledgerType
        {
            get { return _ledgerType; }
        }
        public string Name
        {
            get { return _name; }
        }
        public string SSN
        {
            get { return _ssn; }
        }
    }
   
}
