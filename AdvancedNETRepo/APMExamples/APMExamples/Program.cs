using System;
using System.IO;

namespace APMExamples
{
  class Program
  {
    public static void Main(string[] args)
    {
      var path = @"C:\Users\tzieb\Documents\MOHAWK_WINTER2021_SEM5\COMP10068_Advanced.NETProgramming";
      DirectoryInfo directoryInfo = new DirectoryInfo(path);

      var files = directoryInfo.GetFiles("*.pdf");

      Console.WriteLine($"Found {files.Length} files.");

      var buffer = new byte[1024];
      foreach (var fileInfo in files)
      {
        //Try to read the file.
        var stream = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.Read);
        // Must have a callback "handleRead" which does the work for reading the file's bytes.
        stream.BeginRead(buffer, 0, buffer.Length, HandleRead, stream);
      }

      Console.ReadLine();
    }

    //This is the "end" method.
    private static void HandleRead(IAsyncResult result)
    {
      var fileStream = (FileStream)result.AsyncState;
      var bytesRead = fileStream.EndRead(result);

      Console.WriteLine($"Read {bytesRead} bytes from file: {fileStream.Name}");
    }
  }
}
