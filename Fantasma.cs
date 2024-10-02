using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Fantasma : IVoador, IPairador
    {
        void IVoador.Cair()
        {
            Console.WriteLine("O Fantasma dateu a testa na porta e caiu");
        }

        void IVoador.Decolar()
        {
            Console.WriteLine("O Fantasma saiu voando atras de pessoas");
        }

        bool IEquatable<IVoador>.Equals(IVoador? other)
        {
            throw new NotImplementedException();
        }

        void IPairador.Pairar()
        {
            Console.WriteLine("O Fantasma esta pairando sobre a casa");
        }

        void IVoador.Planar()
        {
            Console.WriteLine("O Fantasma esta andando lentamente sobre a casa");
        }

        void IVoador.Pousar()
        {
            Console.WriteLine("O Fantasma pousou sobre a casa");
        }
    }
}
