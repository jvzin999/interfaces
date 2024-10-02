using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class CamaroAmarelo : IMaquina
    {
        void IMaquina.Abastecer()
        {
            Console.WriteLine("Abastecendo o Camaro para chamar a atenção das novinhas");
        }

        void IMaquina.Alerta()
        {
            Console.WriteLine("O carro está com pouco combustível");
        }

        void IMaquina.Desligar()
        {
            Console.WriteLine("Cheguei em casa, estacionei o carro e fui dormir");
        }

        void IMaquina.Ligar()
        {
            Console.WriteLine("O motor v8 faz um som incrível e chama a atenção de todos");
        }
    }
}
