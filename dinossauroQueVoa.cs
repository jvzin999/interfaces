using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class dinossauroQueVoa : ISerVivo, IVoador
    {
        void IVoador.Cair()
        {
            Console.WriteLine("O que caiu foi o meteoro, consequentemente ele também");
        }

        void ISerVivo.Comer()
        {
            Console.WriteLine("Se alimentando de uns bixo pré-histórico aí");
        }

        void IVoador.Decolar()
        {
            Console.WriteLine("Bate as asas e sai suavemente do chão");
        }

        void ISerVivo.Dormir()
        {
            Console.WriteLine("Dormindo tranquilamento perto de um lago");
        }

        void ISerVivo.Morrer()
        {
            Console.WriteLine("METEOROOOO");
        }

        void IVoador.Planar()
        {
            Console.WriteLine("Bate as asas um pouco mais lento e voa tranquilamente");
        }

        void IVoador.Pousar()
        {
            Console.WriteLine("Abre bem as asas e pousa perto de uma árvore");
        }

        void ISerVivo.Respirar()
        {
            Console.WriteLine("Respirando pra viver");
        }
    }
}
