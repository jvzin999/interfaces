using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Ovini : IMaquina, IVoador, IPairador
    {
        void IMaquina.Abastecer()
        {
            Console.WriteLine("Antes de decolar abastece");
        }

        void IMaquina.Alerta()
        {
            Console.WriteLine("O Ovini esta com defeito no sulgador");
        }

        void IVoador.Cair()
        {
            Console.WriteLine("O Ovini esta caindo!!!");
        }

        void IVoador.Decolar()
        {
            Console.WriteLine("O Ovini esta pronto para a decolagem");
        }

        void IMaquina.Desligar()
        {
            Console.WriteLine("Aperte o botão para desligar o Ovini");
        }

        bool IEquatable<IVoador>.Equals(IVoador? other)
        {
            throw new NotImplementedException();
        }

        void IMaquina.Ligar()
        {
            Console.WriteLine("Aperte o botão para ligar");
        }

        void IPairador.Pairar()
        {
            Console.WriteLine("O Ovini esta pairando sobre a cidade");
        }

        void IVoador.Planar()
        {
            Console.WriteLine("O Ovini esta voando lentamente sobre a cidade");
        }   

        void IVoador.Pousar()
        {
            Console.WriteLine("O Ovine esta se preparando para pousar");
        }
    }
}
