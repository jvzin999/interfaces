using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class T_rex : ISerVivo
    {
        void ISerVivo.Comer()
        {
            Console.WriteLine("Bem fofinho caçando outros dinos");       
        }

        void ISerVivo.Dormir()
        {
            Console.WriteLine("Dormindo tranquilamente");
        }

        void ISerVivo.Morrer()
        {
            Console.WriteLine("Meteoro KKKKKKKKKKKKKKK");
        }

        void ISerVivo.Respirar()
        {
            Console.WriteLine("Respirando antes de cair uma pedra grandona");
        }
    }
}
