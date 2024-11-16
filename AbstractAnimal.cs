using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    public abstract class AbstractAnimal
    {
        public abstract void FaireDuBruit();
        public void Dormir()
        {
            Console.WriteLine("L'animal dort.");
        }
    }
    public class Chien : AbstractAnimal
    {
        public override void FaireDuBruit()
        {
            Console.WriteLine("Le chien aboie.");
        }
    }

 }



