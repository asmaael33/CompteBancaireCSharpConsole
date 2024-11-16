using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    public class CompteEpargne: CompteBancairePOOFondamentaux
    {

        private double tauxInteret;

        public CompteEpargne(string fullName, double balance) : base(fullName, balance)
        {
        }
    }
}
