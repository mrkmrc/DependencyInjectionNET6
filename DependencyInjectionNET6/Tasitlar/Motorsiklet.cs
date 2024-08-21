using DependencyInjectionNET6.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionNET6.Tasitlar
{
    public class Motorsiklet : ITasit
    {
        public void FrenYap()
        {
            Console.WriteLine("Motorsiklet Fren Yapıldı.");
        }

        public void GazVer()
        {
            Console.WriteLine("Motorsiklet Gaz Verildi.");
        }
    }
}
