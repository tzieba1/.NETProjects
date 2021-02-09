using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsynchronousExamples
{
  class Program
  {
    /// <summary>
    /// Useful for accessing web resources (eg. APIs)
    /// </summary>
    private static HttpClient client = new HttpClient();
    
    /// <summary>
    /// Notice that the main method signature has been modified here to be asynchronous.
    /// If the 'await' keyword is used anywhere, then the encapsulating method must be asynchronous.
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    static async Task Main(string[] args)
    {
      // Use the asynchronous method created to retreive an example webpage and 
      //do other work while that Task is returned asynchronously.
      Task exampleTask = GetExampleDotCom();
      Console.WriteLine("Do some other work in the meantime");

      await exampleTask;
      Console.WriteLine("Done all tasks!");
    }

    /// <summary>
    /// Get the example website and return it asynchronously.
    /// Note that this method returns void, but it is returning a Task since all asynchronous methods return Tasks.
    /// </summary>
    static async Task GetExampleDotCom()
    {
      // Use the HttpClient created for this console Program and asynchronously retrieve a web page.
      var result = await client.GetStringAsync("http://example.com");
      
      // Sometimes need to delay the task so that the Main method's sequence of tasks executes in the correct order. 
      // await Task.Delay(4000);       //No matter what we make this delay for this program, it will always happen in the same amount of time.
      Console.WriteLine("IO Task about to be printed");
      Console.WriteLine(result);
    }
  }
}
