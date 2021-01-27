using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
  {
  public class BankAccountArchive
    {
    private List<BankAccount> accountsArchive;
    public int NumberOfAccounts
      {
      get { return BankAccount.nextBankAccountNumber - 10000; }
      }

    public BankAccountArchive()
      {
      accountsArchive = new List<BankAccount>();
      }

    public void AddAccount(BankAccount account) { accountsArchive.Add(account); }
    public List<BankAccount> GetAccounts() { return accountsArchive; }
    }
  }
