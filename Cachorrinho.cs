using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Cachorrinho : ISerVivo
    {
        void ISerVivo.Comer()
        {
            Console.WriteLine("Cachorro comendo sua ração");
        }

        void ISerVivo.Dormir()
        {
            Console.WriteLine("Dormindo no sofá após correr muito na rua");
        }

        void ISerVivo.Morrer()
        {
            Console.WriteLine("Envenenaram o bixinho :(");
        }

        void ISerVivo.Respirar()
        {
            Console.WriteLine("Respirando o ar fresco do parquinho");
        }
    }
}
