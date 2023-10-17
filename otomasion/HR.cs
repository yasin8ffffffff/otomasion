using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasion
{
    internal class HR
    {
      
        public class person
        {
          string name { get; set; }
            int id { get; set; }
            string position { get; set; }
            int accountnumber { get; set; }
            float salary { get; set; }
           int phonenumber { get; set; }

            public void hire()
            {
                Console.WriteLine("Name is"+name,"id"+id,"position"+position,"account number"+accountnumber,"phone number"+phonenumber);
            }
            public void fire(int id)
            {
                foreach (var name in id )
                {
                    if (name.id== id)
                    {
                        name.remove(id);
                        return;
                    }
                }
                return;
            }
        }       
    }
}
