using DependencyInjectionNET6.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionNET6.Tasitlar
{
    public class Otobus : ITasit
    {
        public void FrenYap()
        {
            Console.WriteLine("Otobüs Fren Yapıldı.");
        }

        public void GazVer()
        {
            Console.WriteLine("Otobüs Gaz Verildi.");
        }
    }
}
