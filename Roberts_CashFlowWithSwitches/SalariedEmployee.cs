using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_CashFlowWithSwitches
{
    internal class SalariedEmployee:Employee
    {
        private decimal _payable;
        
        public SalariedEmployee(string firstName, string lastName, string ssn, decimal weeklySalary):base(firstName, lastName, ssn)
        {
            _payable = weeklySalary;
            base.setPayable(_payable);
            base.setLedgerType(Ledger.LedgerType.Salaried);

        }
        public override string ToString()
        {
            return
                "\n\tSalaried Employee: " + Name +
                "\n\tSSN:               " + SSN +
                "\n\tSalary:            " + string.Format("{0:C}", _payable) +
                "\n\tLedger Payable:    " + string.Format("{0:C}", _payable);
        }

    }
}
