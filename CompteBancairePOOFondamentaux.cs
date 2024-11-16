using System;

namespace CompteBancaire
{
    public class CompteBancairePOOFondamentaux
    {
        private string owner;
        private double balance;

        public CompteBancairePOOFondamentaux(string fullName, double balance)
        {
            this.owner = fullName;
            this.balance = balance;
        }
        private double getBalance()
        {
            return this.balance;
        }

        private void setBalance(double balance)
        {
            this.balance = balance;
        }
        public void Crediter(double amount)
        {
            balance = balance + amount;
        }

        public void Debiter(double amount)
        {
            balance = balance - amount;
        }


        static void Main(string[] args)
        {
            var compteBancaireClient = new CompteBancairePOOFondamentaux("Nom prenom", 0);
            compteBancaireClient.Crediter(1200);
            Console.Write(compteBancaireClient.getBalance());
            Console.ReadKey();
        }
    }

}
