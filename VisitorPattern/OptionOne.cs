using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    interface IComponent
    {
        void Accept(IVisitor visitor);
    }

    internal class Invoice : IComponent
    {
        //some specific data and behaviour

        public void Accept(IVisitor visitor) 
            => visitor.Visit(this);
    }

    internal class Receipt : IComponent
    {
        //some specific data and behaviour

        public void Accept(IVisitor visitor) 
            => visitor.Visit(this);
    }

    internal interface IVisitor
    {
        void Visit(Invoice invoice);
        void Visit(Receipt invoiceReceipt);
    }

    internal class GanaratePDFVisitor : IVisitor
    {
        public void Visit(Invoice invoice)
        {
            Console.WriteLine("Displaying invoice data..");
        }

        public void Visit(Receipt invoiceReceipt)
        {
            Console.WriteLine("Displaying receipt data..");

        }
    }
}
