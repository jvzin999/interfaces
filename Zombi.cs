using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Zombi : ISerVivo
    {
        void ISerVivo.Comer()
        {
            Console.WriteLine("O Zombi esta comendo carne de humano");
        }

        void ISerVivo.Dormir()
        {
            Console.WriteLine("O zombi cansou de comer e foi dormir")
        }

        void ISerVivo.Morrer()
        {
            Console.WriteLine("O zombi tomou um tiro e morreu");
        }

        void ISerVivo.Respirar()
        {
            Console.WriteLine("O zombi esta respirando um ar fresco");
        }
    }
}
