using AsyncDBExamples.Data;
using System;
using System.Threading.Tasks;

namespace AsyncDBExamples
{
  class Program
  {
    // Use the prepared database context.
    private static AppDbContext db = new AppDbContext();
    static async Task Main(string[] args)
    {
      //Start the synchronized database operation to compare to same operation, but asynchronous
      Console.WriteLine("Starting Sync Db Operation");
      DbSave();
      Console.WriteLine("Continue...");


      Console.WriteLine("Starting Async Db Operation");
      var task = DbSaveAsync();
      Console.WriteLine("Continue again...");

      await task;
      Console.WriteLine("Press any key to continue...");
      Console.ReadKey();
    }

    /// <summary>
    /// Can check performance of this method which saves to a database asynchronously.
    /// </summary>
    /// <returns></returns>
    private static async Task DbSaveAsync()
    {
      for (int i = 0; i < 10000; i++)
      {
        Person newPerson = new Person()
        {
          FirstName = "Sync",
          LastName = "Zieba",
          CreationTime = DateTime.Now
        };
        db.Persons.Add(newPerson);
      }

      Console.WriteLine("Before async...");
      await db.SaveChangesAsync();
      Console.WriteLine("Async complete!");
    }

    /// <summary>
    /// Can check performance of this method which saves to a database synchronously.
    /// </summary>
    /// <returns></returns>
    private static void DbSave()
    {
      for (int i = 0; i < 10000; i++)
      {
        Person newPerson = new Person() //Creating new person with specific properties
        {
          FirstName = "Sync",
          LastName = "Zieba",
          CreationTime = DateTime.Now
        };
        db.Persons.Add(newPerson);      // Add newly created person to db.
      }
      db.SaveChanges();                 // Must save changes to db after anything is done.
      Console.WriteLine("Sync complete!");
    }
  }
}
