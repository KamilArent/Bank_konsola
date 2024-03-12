using Konsolowy_bank;
using System;
using System.Net;
using static Konsolowy_bank.Account;
using static Konsolowy_bank.User;

User user = new User();
Account konto = new Account(user, 10000);

konto.deposit(konto, 100);
konto.withdraw(konto, 900);


Console.WriteLine(konto.balance.ToString());
konto.historia(konto);
