using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MoreAsynchronousExamples
{
  /// <summary>
  /// Use an HttpClient to return strings representing website content and print corresponding content string lengths asynchronously.
  /// </summary>
  class Program
  {
    private static readonly HttpClient client = new HttpClient();
    public static async Task Main(string[] args)
    {
      // Should retrieve website data using try-catch in case a website being retrieved is not responsive. 
      try
      {
        //await GetSiteLengthAsync();   // Must include await keyword even though nothing asynchronous is happening here by itself.
        var task = GetSiteLengthAsync();

        // This shows that there is some other code that executes during await time for task above.
        Thread.Sleep(3000);
        Console.WriteLine("\nAwaiting Task for retrieving website content is taking longer than 3 seconds...\n");

        await task;


      }
      catch (Exception ex)
      {
        Console.WriteLine($"Main catch: {ex.Message}");
      }

      Console.WriteLine("Done!");
      Console.ReadLine();
      Console.WriteLine("Done! (for real this time)");
    }

    private static async Task GetSiteLengthAsync()
    {
      // Create a list of strings representing websites
      var siteList = new List<string> { "yahoo", "google", "msn", "reddit", "stackoverflow" };
      //var siteList = new List<string> { "yahoo", "Not a site", "msn", "reddit", "stackoverflow" };  // Testing the try-catch in Main()

      // Loop through websites and await each one before printing resulting string length returned.
      foreach (string site in siteList)
      {
        var watch = System.Diagnostics.Stopwatch.StartNew();  // Time the retrieval for each website's content.

        var task = client.GetStringAsync($"http://{site}.com");
        await task;

        watch.Stop();
        Console.WriteLine($"{site} content has length: {task.Result.Length} \n" +
          $"Time taken: {watch.ElapsedMilliseconds}");
      }

      // Use LINQ to return tasks for getting website strings asynchronously to a list.
      List<Task<string>> taskList = (from site in siteList select client.GetStringAsync($"http://{site}.com")).ToList();

      // Sum the size of all websites in the siteList asynchronously in a while loop.
      int sumLength = 0;
      Console.WriteLine("Start WHILE");
      while (taskList.Any())  // Iterate ove the taskList and remove them as they are complete (after await).
      {
        var watch = System.Diagnostics.Stopwatch.StartNew();  // Time the retrieval for each website's content.

        var firstToFinish = await Task.WhenAny(taskList);                       // After task completes, assign to firstToFinish variable.
        watch.Stop();
        Console.WriteLine($"Content length: {firstToFinish.Result.Length}\n" +  // Can only print resulting length of the first to finish 
          $"Time taken: {watch.ElapsedMilliseconds}");    

        sumLength += firstToFinish.Result.Length;                               // Increment the content length of all websites.
        taskList.Remove(firstToFinish);                                         // Remove the last task which was first to finish in the while loop.
      }
      Console.WriteLine("end WHILE");
      Console.WriteLine($"Total length: {sumLength}");
    }
  }
}
