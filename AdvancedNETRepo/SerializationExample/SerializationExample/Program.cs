using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SerializationExample
{
  class Program
  {
    static void Main(string[] args)
    {
      XmlSerialization();
      JsonSerialization();
    }

    static void XmlSerialization()
    {
      // ---- SERIALIZATION ----
      // Create a new serializer and include the serialization library
      var serializer = new XmlSerializer(typeof(Person));

      // Create a Person object to serialize
      var person = new Person
      {
        Name = "Tommy Zieba",
        DateOfBirth = DateTimeOffset.Now,
        Id = Guid.NewGuid()
      };

      // Create a mmemory stream that is required for the first serialization parameter
      MemoryStream memoryStream = new MemoryStream();

      // Serialize the person object created above using the memory stream created above.
      serializer.Serialize(memoryStream, person);

      // Write/export serialized content somewhere (in this case writing to a file).
      byte[] content = memoryStream.ToArray();
      File.WriteAllBytes($"{AppDomain.CurrentDomain.BaseDirectory}\\output.xml", content);



      // ---- DESERIALIZATION ----
      // Deserialization is the same process in reverse; more or less.
      Console.WriteLine("reading the object from file...");
      var bytes = File.ReadAllBytes($"{AppDomain.CurrentDomain.BaseDirectory}\\output.xml");

      // Minimum parameters for deserialization is a Stream , but we use the bytes obtained from the file 
      // to create a new instance of the memory stream required as a deserialization parameter.
      // The object created below must match the type of the Object being deserialized (which is Person in this example).
      Person deserializedObject = (Person) serializer.Deserialize(new MemoryStream(bytes));

      // Can access properties of the deserialized object of the correc type (Person in this case).
      Console.WriteLine(deserializedObject.Name + "|||" + deserializedObject.DateOfBirth + "|||" + deserializedObject.Id);
    }

    static void JsonSerialization()
    {
      // ---- SERIALIZATION ----
      // Create a Person object to serialize
      Person person = new Person
      {
        Name = "Tommy Zieba",
        DateOfBirth = DateTimeOffset.Now,
        Id = Guid.NewGuid()
      };

      // Create a serializer of type JSON.
      var serializer = new JsonSerializer();

      // Create a string writer (similar to an XML stream), then serialize the person created above.
      TextWriter stringWriter = new StringWriter();
      serializer.Serialize(stringWriter, person);

      // Need to use a UTF-8 encoding when getting bytes from stringWriter
      byte[] content = Encoding.UTF8.GetBytes(stringWriter.ToString());
      File.WriteAllBytes($"{AppDomain.CurrentDomain.BaseDirectory}\\output.json", content);



      // ---- DESERIALIZATION ----
      Console.WriteLine("Reading the object from the file...");
      var bytes = File.ReadAllBytes($"{AppDomain.CurrentDomain.BaseDirectory}\\output.json");
      var jsonReader = new JsonTextReader(new StringReader(Encoding.UTF8.GetString(bytes)));
      Person deserializedPerson = (Person) serializer.Deserialize(jsonReader, typeof(Person));
      Console.WriteLine(deserializedPerson.Name + "|||" + deserializedPerson.DateOfBirth);
    }
  }
}
