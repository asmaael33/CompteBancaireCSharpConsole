using System;
namespace CompteBancaire
{
    class CompteBancaireSimple
    {
        public string owner = "Full name";
        public double balance=0;
        public double amount=0;        
        public double Crediter(double amount)
        {
            balance = balance + amount;
            return balance;
        }
        public void Debiter(double amount)
        {
            balance = balance - amount;
        }
        static void Main(string[] args)
        {
            var cb = new CompteBancaireSimple();
            Console.WriteLine("Saisir montant");
            double amount = Console.Read();            
            Console.Write(amount);
            Console.WriteLine("Nouveau solde");
            double solde = cb.Crediter(amount);
            Console.WriteLine(cb.balance);
            Console.ReadKey();
        }
    }
}
