using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HttpListenerClassExample
{
  class Program
  {
    // Dictionary of existing persons.
    private static Dictionary<int, Person> personDictionary = new Dictionary<int, Person>();
    public static void Main(string[] args)
    {
      // Instantiate listener for http protocol.
      HttpListener listener = new HttpListener();   

      // Adding prefixes to the listener allows it to listen to requests served by prefixes.
      // Prefixes must start with the protocol and end with a forward slash.
      listener.Prefixes.Add("http://127.0.0.1/test1/");
      listener.Prefixes.Add("http://127.0.0.1/test2/");
      listener.Prefixes.Add("http://127.0.0.1/getPerson/");
      listener.Prefixes.Add("http://127.0.0.1/postPerson/");
      listener.Prefixes.Add("http://*:2100/");  // Using wildcards for a specific port.

      // Start Listening and output prefixes being listened to (in green).
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Listener starting...");
      listener.Start();
      foreach (var prefix in listener.Prefixes)
        Console.WriteLine($"Listening for http requests on: {prefix}");

      // Synchronous method shouldn't be used in scenario with multiple users.
      //listener.GetContext();  

      // Async method - should be used to ensure system does not halt on one user doing something.
      // The HandleRequest method was created after-the-fact as a callback function that accepts an asynchronous result as a param
      listener.BeginGetContext(HandleRequest, listener); 

      Console.ResetColor();
      Console.Read();
    }

    /// <summary>
    /// Callback function when an http request is being listened to.
    /// </summary>
    /// <param name="asyncResult"></param>
    private static async void HandleRequest(IAsyncResult asyncResult)
    {
      // Recover listener from asynchronous result.
      HttpListener listener = (HttpListener)asyncResult.AsyncState;

      // Create a context based on the listener end context from asynch result.
      HttpListenerContext context = listener.EndGetContext(asyncResult);

      Console.WriteLine($"Received a request from: {context.Request.RemoteEndPoint}");

      // Creating a serailizer for the Person class for this program. 
      XmlSerializer serializer = new XmlSerializer(typeof(Person));
      MemoryStream memoryStream = new MemoryStream();


      // Response is a byte array that switched based on context request url's local path.
      // Use switch case to return a serialized byte[] response.
      byte[] response;
      switch (context.Request.Url.LocalPath)
      {
        case "/test1/":
          response = SerializeResponse("This is the test1 endpoint.");  // Method created in this program class to return a serialized response. 
          break;
        case "/test2/":
          response = SerializeResponse("This is the test2 endpoint.");
          break; 
        case "/getPerson/":
          context.Response.ContentType = "application/xml";
          Person person = personDictionary[int.Parse(context.Request.QueryString.GetValues("id").FirstOrDefault())];
          serializer.Serialize(memoryStream, person);
          response = memoryStream.ToArray();
          break;
        case "/postPerson/":
          context.Response.ContentType = "application/xml";
          serializer.Serialize(memoryStream, HandlePostPerson(context));
          response = memoryStream.ToArray();
          break;
        default:
          response = SerializeResponse("Error: Specified endpoints not found.");
          break;
      }

      // Sending the response back as success code (200) and close the context before listening for other responses.
      Task writeTask = context.Response.OutputStream.WriteAsync(response, 0, response.Length);
      context.Response.StatusCode = 200;
      await writeTask;
      context.Response.Close();

      // Begin listening for the next request.
      listener.BeginGetContext(HandleRequest, listener);
    }

    /// <summary>
    /// A serialized response for an http request (Person -> XML).
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    private static Person HandlePostPerson(HttpListenerContext context)
    {
      // Instantiate a serializer and memory stream to deserialzie a person from XML.
      XmlSerializer serializer = new XmlSerializer(typeof(Person));
      MemoryStream memoryStream = new MemoryStream();

      // Deserialize the memory stream of bytes into a person (to add to the dictionary) and return them.
      Person person = (Person)serializer.Deserialize(context.Request.InputStream);
      personDictionary.Add(person.Id, person);
      return person;
    }

    /// <summary>
    /// A serialized response for an http request (XML -> Person).
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    private static byte[] SerializeResponse(string content)
    {
      Console.WriteLine($"Sending response: {content}");
      return Encoding.UTF8.GetBytes(content);
    }
  }

  /// <summary>
  /// Simple class used to demonstrate sending http requests.
  /// </summary>
  [XmlRoot]
  [XmlType]
  public class Person
  {
    [XmlElement]
    public int Id { get; set; }
    [XmlElement]
    public string Name { get; set; }
  }
}
