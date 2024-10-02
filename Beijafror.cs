using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Beijaflor : IPairador, IVoador
    {
        void IVoador.Cair()
        {
            Console.WriteLine("O beijaflor esta caindo");
        }

        void IVoador.Decolar()
        {
            Console.WriteLine("O beijaflor começou a dater as asas e saiu do chão");
        }

        bool IEquatable<IVoador>.Equals(IVoador? other)
        {
            throw new NotImplementedException();
        }

        void IPairador.Pairar()
        {
            Console.WriteLine("O beijaflor paira sobre uma flor");
        }

        void IVoador.Planar()
        {
            Console.WriteLine("O beijaflor esta planando sobre uma flor");
        }

        void IVoador.Pousar()
        {
            Console.WriteLine("O beijaflor esta se preparando para pousar");
        }
    }
}
