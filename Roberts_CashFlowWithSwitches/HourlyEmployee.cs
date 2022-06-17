using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_CashFlowWithSwitches
{
    internal class HourlyEmployee:Employee
    {
        private int _totalHours;
        private int _regularhours;
        private int _overTimehours;
        private decimal _regularPay;
        private decimal _straightPay;
        private decimal _overTimePay;
        private decimal _payable;

        public HourlyEmployee(string firstName, string lastName, string ssn, decimal hourlyPay, int hoursWorked):base(firstName,lastName, ssn)
        {
            if (hoursWorked <= 40)
            {
                _totalHours = hoursWorked;
                _regularhours = hoursWorked;
                _regularPay = hourlyPay;
                _payable = _regularPay * _regularhours;
            }
            else if (hoursWorked > 40)
            {
                _regularhours = 40;
                _overTimehours = hoursWorked - 40;
                _straightPay = hourlyPay * _regularhours;
                _overTimePay = (hourlyPay * 1.5M) * _overTimehours;
                _payable = _straightPay + _overTimePay;
            }
            base.setPayable(_payable);
            base.setLedgerType(Ledger.LedgerType.Hourly);
        }
        public override string ToString()
        {
            return
                "\n\tHourly Employee:   " + Name +
                "\n\tSSN:               " + SSN +
                "\n\tHourly Pay:        " + string.Format("{0:C}", _payable) +
                "\n\tHours Worked:      " + _totalHours +
                "\n\tLedger Payable:    " + string.Format("{0:C}", _payable);
        }
    
    }
}
