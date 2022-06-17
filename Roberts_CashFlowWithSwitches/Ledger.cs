using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_CashFlowWithSwitches
{
    internal class Ledger
    {
        private decimal _hourlyTotal=0;
        private decimal _salariedTotal=0;
        private decimal _invoiceTotal = 0;

        public enum LedgerType
        {
            Salaried,
            Hourly,
            Invoice
        }
        public decimal setHourlyTotal(decimal hourly)
        {
            _hourlyTotal += hourly;
            return _hourlyTotal;
        }
        public decimal setSalariedTotal(decimal salary)
        {
            _salariedTotal += salary;
            return _salariedTotal;
        }
        public decimal setInvoiceTotal(decimal invoice)
        {
            _invoiceTotal += invoice;
            return _invoiceTotal;
        }
        public decimal getHourlyTotal
        { get { return _hourlyTotal; } }

        public decimal getSalariedTotal
        { get { return _salariedTotal; } }

        public decimal getInvoiceTotal
        { get { return _invoiceTotal; } }

        public decimal getTotalTotal
        { get { return _hourlyTotal+_salariedTotal+_invoiceTotal; }}

        public override string ToString()
        {
            return
                "\n\tTotal Weekly Ledger Payables: " + string.Format("{0:C}", getTotalTotal) +
                "\n\tPayables Breakdown:           " +
                "\n\tHourly:                       " + string.Format("{0:C}", getHourlyTotal) +
                "\n\tSalaried:                     " + string.Format("{0:C}", getSalariedTotal) +
                "\n\tInvoices:                     " + string.Format("{0:C}", getInvoiceTotal) + "\n\n";
        }

        public string Menu1()
        {
            return
            "\n\tSelect Payable to Add to Ledger------>" +
            "\n\t\t1: Hourly Employee " +
            "\n\t\t2: Salaried Employee" +
            "\n\t\t3: Invoice " +
            "\n\t\t4: Print Ledger and Exit."; 
        }
        public string Menu2()
        {
            return
         
            "\n\t\t1: Hourly Employee " +
            "\n\t\t2: Salaried Employee" +
            "\n\t\t3: Invoice " +
            "\n\t\t4: Print Ledger and Exit. ";
        }



    }
}
