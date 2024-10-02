using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Pássaro : IVoador, ISerVivo
    {
        void IVoador.Cair()
        {
            Console.WriteLine("Passarinho caiu porque não bateu as asas");
        }

        void ISerVivo.Comer()
        {
            Console.WriteLine("Passarinho comendo minhocas");
        }

        void IVoador.Decolar()
        {
            Console.WriteLine("Passarinho começou a bater as asas e decolou");
        }

        void ISerVivo.Dormir()
        {
            Console.WriteLine("Passarinho ficou com sono, fechou os olhos e dormiu");
        }

        void ISerVivo.Morrer()
        {
            Console.WriteLine("Passarinho erra aterrisagem e morre muito feio");
        }

        void IVoador.Planar()
        {
            Console.WriteLine("Passarinho bate as asas mais devagar e voa sutilmente");
        }

        void IVoador.Pousar()
        {
            Console.WriteLine("Passarinho abre as asas e cai suavemente sobre o solo");
        }

        void ISerVivo.Respirar()
        {
            Console.WriteLine("Passarinho respira pra sobreviver");
        }
    }
}
