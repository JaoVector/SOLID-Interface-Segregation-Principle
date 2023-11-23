using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Interfaces;

namespace ISP.Classes
{
    public class Canivete : ICanivete
    {

        private readonly IFaca _faca;
        private readonly IAbridor _abridor;

        public Canivete(IFaca faca, IAbridor abridor)
        {
            _faca = faca;
            _abridor = abridor;
        }

        public void Abrir()
        {
            _abridor.Abrir();
        }

        public void Cortar()
        {
            _faca.Cortar();
        }

        public void ChaveFenda()
        {
            Console.WriteLine("Chave para desparafusar");
        }
    }
}