using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Interfaces;

namespace ISP.Classes
{
    public class Abridor : IAbridor
    {
        public void Abrir()
        {
            Console.WriteLine("Abridor abre uma Lata");
        }
    }
}