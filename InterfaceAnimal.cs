using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    class InterfaceAnimal
    {
        public interface IAnimal
        {
            void FaireDuBruit();
        }
        public class Chien : IAnimal
        {
            public void FaireDuBruit()
            {
                Console.WriteLine("Le chien aboie.");
            }
        }
        public class Chat : IAnimal
        {
            public void FaireDuBruit()
            {
                Console.WriteLine("Le chat miaule.");
            }
        }
    }
}
