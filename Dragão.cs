using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Dragão : ISerVivo, IVoador
    {
        void IVoador.Cair()
        {
            Console.WriteLine("Outro dragão atacou sua asa e ele se espatifou");
        }

        void ISerVivo.Comer()
        {
            Console.WriteLine("Devorando reinos próximos");
        }

        void IVoador.Decolar()
        {
            Console.WriteLine("Bate as asas muito forte e sai do chão lançando uma grande rajada de vento");
        }

        void ISerVivo.Dormir()
        {
            Console.WriteLine("Dormindo depois de queimar alguns lugares");
        }

        void ISerVivo.Morrer()
        {
            Console.WriteLine("Outro dragão comeu o coitado");
        }

        void IVoador.Planar()
        {
            Console.WriteLine("Diminui o ritmo do bater das asas e voa sutilmente");
        }

        void IVoador.Pousar()
        {
            Console.WriteLine("Vem do céu com seu peso absurdo e acaba destruindo tudo, pelo menos funcionou");
        }

        void ISerVivo.Respirar()
        {
            Console.WriteLine("Respirar né, fazer oque");
        }
    }
}
