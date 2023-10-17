using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static otomasion.HR.person;
namespace otomasion
{
    internal class finance
    {
        public class bank
        {
            int accountnumber { set; get; }
            float income { get; set; }
            DateTime transaction { set; get; }
            int balance { set; get; } 

            public void pay()
            {
                Console.WriteLine(HR.person.salary "to" + accountnumber);
                Console.WriteLine("the time of transaction"+transaction);
            }
           public void Balance()
            {
                Console.WriteLine(income+balance-salary);
            }
        }

    }
}
