using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Gatinho : ISerVivo
    {
        void ISerVivo.Comer()
        { 
            Console.WriteLine("Ele está comendo um rato que tava atrás da geladeira");
        }

        void ISerVivo.Dormir()
        {
            Console.WriteLine("De 24 horas no dia, ele dorme 16");
        }

        void ISerVivo.Morrer()
        {
            Console.WriteLine("Infelizmente já estava velho...");
        }

        void ISerVivo.Respirar()
        {
            Console.WriteLine("Respirando livremente para aproveitar a liberdade");
        }
    }
}
