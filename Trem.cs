using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Trem : IMaquina
    {
        void IMaquina.Abastecer()
        {
            Console.WriteLine("Movido a carvão");
        }

        void IMaquina.Alerta()
        {
            Console.WriteLine("O trem esta ficando sem carvão");
        }

        void IMaquina.Desligar()
        {
            Console.WriteLine("Aperte o botão para desligar");
        }

        void IMaquina.Ligar()
        {
            Console.WriteLine("Aperte o botão para ligar");
        }
    }
}
