///
/// Student Name: Tommy Zieba
/// Student Number: 000797152
/// Statement of Authorship:
///   I, Tommy Zieba, 000797152 certify that this material is my original work. 
///   No other person's work has been used without due acknowledgement.
///

using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

/// <summary>
/// Namespace for this JsonAndXmlSerializer solution that is used for creating a class library
/// including a class for serializing classes.
/// </summary>
namespace JsonAndXmlSerializer
{
  /// <summary>
  /// Class representing serialization/deserialization methods for:
  ///   1. Serializing objects in this project's class library derived from Entity to a
  ///      byte array both generically and non-generically to either XML or JSON.
  ///   2. Deserializing from either XML or JSON byte arrays to both generically and 
  ///      non-generically typed objects derived from Entity in this project's class library.
  /// </summary>
  [XmlRoot]
  [XmlType]
  [JsonObject]
  [Serializable]
  public class Assignment1Serializer
  {
    /// <summary>
    /// Default constructor for this Assignment1Serializer.
    /// </summary>
    public Assignment1Serializer() { }

    /// <summary>
    /// Method used to deserialize JSON byte arrays of known Type derived from Entity class 
    /// in this project's class library.
    /// </summary>
    /// <param name="type">Type of serialized JSON object instance.</param>
    /// <param name="instance">Serialized JSON object represented as byte array.</param>
    /// <returns>Deserialized JSON object instance.</returns>
    public object DeserializeFromJson(Type type, byte[] instance)
    {
      // STEP 1: Check for a valid Type argument in order to serialize objects dervied from Entity.
      if (type.BaseType == typeof(Entity) | type.BaseType == typeof(Person))
      {
        // STEP 2: Create an JSON serializer parametrized by Type passed into this method.
        JsonSerializer deserializer = new JsonSerializer();

        // STEP 3: Create a JsonReader using a StringReader parametrized by a UTF-8 encoded string retrieved 
        //         from the serlialized byte array passed in and formatted as JSON.
        JsonTextReader jsonReader = new JsonTextReader(new StringReader(Encoding.UTF8.GetString(instance)));

        // STEP 4: Return deserialized object from jsonReader based on Type passed into this method.
        return deserializer.Deserialize(jsonReader, type);
      }
      // Otherwise, throw an excpetion for using incorrect Type in arguments.
      else
      {
        throw new ArgumentException("Invalid Type provided; only objects having Type derived from Entity " +
          "are serializable.");
      }
    }

    /// <summary>
    ///   Generic method used to deserialize JSON byte arrays derived from Entity class 
    ///   in this project's class library.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="instance"></param>
    /// <returns>
    ///   Generic type parameter representing deserialized JSON object instance constrained 
    ///   to Entity base class.
    /// </returns>
    public T DeserializeFromJson<T>(byte[] instance) where T : Entity
    {
      // STEP 1: Retreive Type for generically typed instance parameter of this method (to validate and use
      //         during deserialization again).
      Type type = typeof(T);

      // STEP 2: Check for a valid Type argument in order to serialize objects dervied from Entity.
      if (type.BaseType == typeof(Entity) | type.BaseType == typeof(Person))
      {
        // STEP 3: Create an JSON serializer parametrized by Type passed into this method.
        JsonSerializer deserializer = new JsonSerializer();

        // STEP 4: Create a JsonReader using a StringReader parametrized by a UTF-8 encoded string retrieved 
        //         from the serlialized byte array passed in and formatted as JSON.
        JsonTextReader jsonReader = new JsonTextReader(new StringReader(Encoding.UTF8.GetString(instance)));

        // STEP 5: Return deserialized object from jsonReader based on Type passed into this method and by
        //         casting it to the generic type T.
        return (T)deserializer.Deserialize(jsonReader, type);
      }
      // Otherwise, throw an excpetion for using incorrect Type in arguments.
      else
      {
        throw new ArgumentException("Invalid Type provided; only objects having Type derived from Entity " +
          "are serializable.");
      }
    }

    /// <summary>
    ///   Method used to deserialize XML byte arrays of known Type derived from Entity class 
    ///   in this project's class library.
    /// </summary>
    /// <param name="type">Type of serialized object instance.</param>
    /// <param name="instance">Serialized XML object represented as byte array.</param>
    /// <returns>Deserialized XML object instance.</returns>
    public object DeserializeFromXml(Type type, byte[] instance)
    {
      // STEP 1: Check for a valid Type argument in order to serialize objects dervied from Entity.
      if (type.BaseType == typeof(Entity) | type.BaseType == typeof(Person))
      {
        // STEP 2: Create an XML serializer parametrized by Type passed into this method.
        XmlSerializer deserializer = new XmlSerializer(type);

        // STEP 3: Return deserialized object from a newly created MemoryStream parametrized by byte 
        //         array passed into this method.
        return deserializer.Deserialize(new MemoryStream(instance));
      }
      // Otherwise, throw an excpetion for using incorrect Type in arguments.
      else
      {
        throw new ArgumentException("Invalid Type provided; only objects having Type derived from Entity " +
          "are serializable.");
      }
    }

    /// <summary>
    ///   Generic method used to deserialize XML byte arrays derived from Entity class 
    ///   in this project's class library.
    /// </summary>
    /// <typeparam name="T">Generic type with Entity base class constraint.</typeparam>
    /// <param name="instance">Serialized XML object represented as byte array.</param>
    /// <returns>
    ///   Generic type parameter representing deserialized XML object instance constrained 
    ///   to Entity base class.
    /// </returns>
    public T DeserializeFromXml<T>(byte[] instance) where T : Entity
    {
      // STEP 1: Retreive Type for generically typed instance parameter of this method (to validate and use
      //         during deserialization again).
      Type type = typeof(T);

      // STEP 2: Check for a valid Type argument in order to serialize objects dervied from Entity.
      if (type.BaseType == typeof(Entity) | type.BaseType == typeof(Person))
      {
        // STEP 3: Create an XML serializer parametrized by Type passed into this method.
        XmlSerializer deserializer = new XmlSerializer(type);

        // STEP 4: Return deserialized object from a newly created MemoryStream parametrized by byte 
        //         array passed into this method and cast it to the generic type T.
        return (T)deserializer.Deserialize(new MemoryStream(instance));
      }
      // Otherwise, throw an excpetion for using incorrect Type in arguments.
      else
      {
        throw new ArgumentException("Invalid Type provided; only objects having Type derived from Entity " +
          "are serializable.");
      }
    }

    /// <summary>
    /// Method used to serialize JSON objects derived from the Entity class and return an array 
    /// of bytes representing the serialized object instance based on instance type.
    /// </summary>
    /// <param name="type">Type of object for JSON object instance to be serialized.</param>
    /// <param name="instance">JSON object to be serialized.</param>
    /// <returns>Array of type byte[] representing a serialized JSON object instance.</returns>
    public byte[] SerializeToJson(Type type, object instance)
    {
      // STEP 1: Check for a valid Type argument in order to serialize objects dervied from Entity.
      if (type.BaseType == typeof(Entity) | type.BaseType == typeof(Person))
      {
        // STEP 2: Create a new instance of the required JsonSerializer using the NewtonSoft package.
        JsonSerializer serializer = new JsonSerializer();

        // STEP 3: Create a new instance of a StringWriter (implementation of abstract TextWriter class)
        //         required as the first paramter in serialization to write the result to.
        TextWriter stringWriter = new StringWriter();

        // STEP 4: Perform serialization using object instance converted to Type passed in and stringWriter
        //         created above to store resulting serialized bytes.
        serializer.Serialize(stringWriter, Convert.ChangeType(instance, type));

        // STEP 5: Use UTF-8 encoding for retrieving byte array of content from the stringWriter 
        //         instance holding resulting serialized bytes in a string representation.
        return Encoding.UTF8.GetBytes(stringWriter.ToString());
      }
      // Otherwise, throw an excpetion for using incorrect Type in arguments.
      else
      {
        throw new ArgumentException("Invalid Type provided; only objects having Type derived from " +
          "Entity are serializable.");
      }
    }

    /// <summary>
    /// Generic method use to serialize JSON objects derived from the Entity class and return an array of 
    /// bytes representing the serialized object instance (based on generic type supplied with constraint
    /// such that it has the base type Entity).
    /// </summary>
    /// <typeparam name="T">Generic type with Entity base class constraint.</typeparam>
    /// <param name="instance">JSON object to be serialized.</param>
    /// <returns>Array of type byte[] representing a serialized JSON object instance.</returns>
    public byte[] SerializeToJson<T>(T instance) where T : Entity
    {
      // STEP 1: Retreive Type for generically typed instance parameter of this method (to validate and use
      //         during serialization again).
      Type type = instance.GetType();

      // STEP 2: Check for a valid Type argument in order to serialize objects dervied from Entity.
      if (type.BaseType == typeof(Entity) | type.BaseType == typeof(Person))
      {
        // STEP 3: Create a new instance of the required JsonSerializer using the NewtonSoft package.
        JsonSerializer serializer = new JsonSerializer();

        // STEP 4: Create a new instance of a StringWriter (implementation of abstract TextWriter class)
        //         required as the first paramter in serialization to write the result to.
        TextWriter stringWriter = new StringWriter();

        // STEP 5: Perform serialization using object instance converted to Type passed in and stringWriter
        //         created above to store resulting serialized bytes.
        serializer.Serialize(stringWriter, type);

        // STEP 6: Use UTF-8 encoding for retrieving byte array of content from the stringWriter 
        //         instance holding resulting serialized bytes in a string representation.
        return Encoding.UTF8.GetBytes(stringWriter.ToString());
      }
      // Otherwise, throw an excpetion for using incorrect Type in arguments.
      else
      {
        throw new ArgumentException("Invalid Type provided; only objects having Type derived from Entity " +
          "are serializable.");
      }
    }

    /// <summary>
    /// Method used to serialize XML objects derived from the Entity class and return an array of bytes
    /// representing the serialized object instance into XML format (based on instance type).
    /// </summary>
    /// <param name="type">Type of object for XML object instance to be serialized.</param>
    /// <param name="instance">XML object to be serialized.</param>
    /// <returns>Array of type byte[] representing a serialized XML object instance.</returns>
    public byte[] SerializeToXml(Type type, object instance)
    {
      // STEP 1: Check for a valid Type argument in order to serialize objects dervied from Entity.
      if (type.BaseType == typeof(Entity) | type.BaseType == typeof(Person))
      {
        // STEP 2: Create a new instance of the required JsonSerializer using the Xml.Serialization namespace.
        XmlSerializer serializer = new XmlSerializer(type);

        // STEP 3: Create a new instance of a MemoryStream required as the first paramter in serialization 
        //         to write the result to.
        MemoryStream memoryStream = new MemoryStream();

        // STEP 4: Perform serialization using object instance converted to Type passed in and memoryStream
        //         created above to store resulting serialized bytes.
        serializer.Serialize(memoryStream, Convert.ChangeType(instance, type));

        // STEP 5: Return the memoryStream by copying the contents (bytes) to an array of bytes.
        return memoryStream.ToArray();
      }
      // Otherwise, throw an excpetion for using incorrect Type in arguments.
      else
      {
        throw new ArgumentException("Invalid Type provided; only objects having Type derived from Entity " +
          "are serializable.");
      }
    }

    /// <summary>
    /// Generic method use to serialize XML objects derived from the Entity class and return an array of 
    /// bytes representing the serialized object instance (based on generic type supplied with constraint
    /// such that it has the base type Entity).
    /// </summary>
    /// <typeparam name="T">Generic type with Entity base class constraint.</typeparam>
    /// <param name="instance">XML object to be serialized.</param>
    /// <returns>Array of type byte[] representing a serialized XML object instance.</returns>
    public byte[] SerializeToXml<T>(T instance) where T : Entity
    {
      // STEP 1: Retreive Type for generically typed instance parameter of this method (to validate and use
      //         during serialization again).
      Type type = instance.GetType();

      // STEP 2: Check for a valid Type argument in order to serialize objects dervied from Entity.
      if (type.BaseType == typeof(Entity) | type.BaseType == typeof(Person))
      {
        // STEP 3: Create a new instance of the required JsonSerializer using the Xml.Serialization namespace.
        XmlSerializer serializer = new XmlSerializer(type);

        // STEP 4: Create a new instance of a MemoryStream required as the first paramter in serialization 
        //         to write the result to.
        MemoryStream memoryStream = new MemoryStream();

        // STEP 5: Perform serialization using object instance converted to Type passed in and memoryStream
        //         created above to store resulting serialized bytes.
        serializer.Serialize(memoryStream, Convert.ChangeType(instance, type));

        // STEP 6: Return the memoryStream by copying the contents (bytes) to an array of bytes.
        return memoryStream.ToArray();
      }
      // Otherwise, throw an excpetion for using incorrect Type in arguments.
      else
      {
        throw new ArgumentException("Invalid Type provided; only objects having Type derived from Entity " +
          "are serializable.");
      }
    }
  }
}
