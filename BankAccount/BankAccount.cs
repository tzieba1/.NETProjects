using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
  {
  public enum BankAccountType { CHEQUING, SAVINGS };
  public class BankAccount
    { 
    public static int nextBankAccountNumber = 10000;
    private decimal balance;
    public decimal Balance
      {
      get
        {
        if (Transactions != null)
          {
          foreach (Transaction t in Transactions)
            {
            if (t.Type == TransactionType.WITHDRAWAL)
              balance -= t.Amount;
            else if (t.Type == TransactionType.DEPOSIT)
              balance += t.Amount;
            }
          }
        else
          balance = 0;
        return balance;
        }
      }
    public int Number { get; }
    public BankAccountType Type { get; }
    public Person Owner { get; }
    public List<Transaction> Transactions { get; }

    public BankAccount(Person owner, BankAccountType type)
      {
      Owner = owner;
      Type = type;

      Transactions = new List<Transaction>();
      nextBankAccountNumber++;
      }

    public void AddToTransactionList(Transaction t)
      {
     
      if ((t.Type == TransactionType.WITHDRAWAL && t.Amount <= Balance) || t.Type == TransactionType.DEPOSIT)
        Transactions.Add(t);
      }

    public override string ToString()
      {
      return $"BankAccount[Type={Type}, Number={Number:F0}, Owner={Owner}, Balance={Balance:C2}]";
      }
    }
  }
