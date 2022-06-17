using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_CashFlowWithSwitches
{
    internal class Invoice:IPayable
    {
        private int _invNum1;
        private int _invNum2;
        private string _partNumber;
        private string _partDescription;
        private int _quantity;
        private decimal _price;
        private decimal _payable;

        public Invoice( string partNumber, string partDescription, int quantity, decimal price)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            _invNum1 = r.Next(1000, 10000);
            _invNum2 = r.Next(1000, 10000);
            _partNumber = partNumber;
            _partDescription = partDescription;
            _quantity = quantity;
            _price = price;
            _payable = _quantity * _price;  
        }
        public decimal Payable
        { get { return _payable; } }
        public Ledger.LedgerType ledgerType
        { get { return Ledger.LedgerType.Invoice; } }
        public override string ToString()
        {
            return
                "\n\tInvoice Num:       " + _invNum1 + "_" + _invNum2 +
                "\n\tPart No.           " + _partNumber +
                "\n\tPart Description:  " + _partDescription +
                "\n\tPrice:             " + string.Format("{0:C}", _price) +
                "\n\tQuantity:          " + _quantity +
                "\n\tLedger Payable:    " + string.Format("{0:C}", _payable);
        }

    }
}
