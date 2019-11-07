using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.EntityFramwork
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NORTHWINDEntities db = new NORTHWINDEntities())
            {
                var cust = "P";
                var customers = db.Customers.Include("Orders").Where(r => r.CompanyName.StartsWith(cust) && r.Orders.Any(order => order.OrderID > 10100)).ToList();
                foreach (var item in customers)
                {
                    Console.WriteLine(item.CompanyName.ToString());
                }                
            }
            Console.ReadLine();
        }
    }
}
