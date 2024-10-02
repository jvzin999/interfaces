using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Avião : IVoador, IMaquina
    {
        void IMaquina.Abastecer()
        {
            Console.WriteLine("Abastecendo avião para decolagem");
        }

        void IMaquina.Alerta()
        {
            Console.WriteLine("Dano na asa esquerda");
        }

        void IVoador.Cair()
        {
            Console.WriteLine("Os caras não ajeitaram a asa e o avião caiu");
        }

        void IVoador.Decolar()
        {
            Console.WriteLine("O piloto liga as turbinas no máximo e o avião sai do chão");
        }

        void IMaquina.Desligar()
        {
            Console.WriteLine("O avião chega ao destino e fica no galpão");
        }

        void IMaquina.Ligar()
        {
            Console.WriteLine("Ligando o avião para decolagem");
        }

        void IVoador.Planar()
        {
            Console.WriteLine("A potência dos motores diminui e o avião voa mais tranquilo");
        }

        void IVoador.Pousar()
        {
            Console.WriteLine("O avião diminui a altitude e pousa suavemente na pista");
        }
    }
}
