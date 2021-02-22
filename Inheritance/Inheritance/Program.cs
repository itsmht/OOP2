using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Digital Banking System");
            Console.WriteLine("From Savings");
            Savings a = new Savings(101, "Shahed",20000);
            Savings b = new Savings(102, "Talha", 10000);
            Savings c = new Savings(103, "Tanvir",17000);
            a.Transfer(5000, b);
            c.Transfer(1000, b);
            b.ShowInfo();
            Console.WriteLine("From Special Current");
            SpecialCurrent d = new SpecialCurrent(101, "Piya", 20000);
            SpecialCurrent e = new SpecialCurrent(102, "Talha", 10000);
            d.Transfer(1000, e);
            e.ShowInfo();
            Console.WriteLine("From Fixed");
            Fixed f = new Fixed(101, "Munna", 20000, 3);
            Fixed g = new Fixed(102, "Talha", 10000,12);
            f.Transfer(5000,g);
            g.ShowInfo();
            Console.WriteLine("From Over Draft");
            OverDraft h = new OverDraft(101, "Hossain",20000);
            OverDraft i = new OverDraft(102, "Talha", 10000);
            h.Transfer(5000, i);
            i.ShowInfo();
            Console.WriteLine("Thanks for staying with us!");
        }
    }
}
