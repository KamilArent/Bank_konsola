using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Konsolowy_bank.User;
using static Konsolowy_bank.Operation;

namespace Konsolowy_bank
{
    public class Account
    {
        private static int lastGeneratedId = 0;
        public readonly string id; //zeby ulatwic int zamieniony na string
        public decimal balance;
        public User? owner;
        public List<Operation>? history;

        public Account(User? owner, decimal balance)
        {
            ++lastGeneratedId;
            id = lastGeneratedId.ToString("D8");
            history = new List<Operation>();
            this.balance = balance; 
            this.owner = owner;
        }

        public bool deposit(Account konto, decimal amount)
        {
            try
            {
                konto.balance += amount;
                Operation operacja = new Operation(OperationType.deposit, amount);
                konto.history.Add(operacja);
                return true;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return false;
            }
            

        }

        public bool withdraw(Account konto, decimal amount)
        {
            if (konto.balance < amount) return false;
            try
            {
                Operation operacja = new Operation(OperationType.withdraw, amount);
                konto.history.Add(operacja);
                konto.balance -= amount;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return false;
            }
        }

        public void historia(Account konto) 
        {
            foreach(Operation o in konto.history)
            {
                string typ = o.type.ToString();
                string data = o.data.ToString();
                string amount = o.amount.ToString();
                Console.WriteLine($"Typ transakcji: {typ} | Kwota: {amount} | Data: {data}");
            }
        }

    }
}
