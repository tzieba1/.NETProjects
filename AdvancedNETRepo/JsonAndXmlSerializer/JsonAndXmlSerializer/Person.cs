///
/// Student Name: Tommy Zieba
/// Student Number: 000797152
/// Statement of Authorship:
///   I, Tommy Zieba, 000797152 certify that this material is my original work. 
///   No other person's work has been used without due acknowledgement.
///

using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

/// <summary>
/// Namespace for this Assignment 1 Serializer project.
/// This project serializes/deserializes a .NET Core 2.2 class library using XML and JSON formats.
/// </summary>
namespace JsonAndXmlSerializer
{
  /// <summary>
  /// Class representing a Person extending from Entity base class.
  /// </summary>
  [XmlRoot]
  [XmlType]
  [JsonObject]
  [Serializable]
  public class Person : Entity
  {
    /// <summary>
    /// Property representing the FirstName for this Person.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public string FirstName { get; set; }

    /// <summary>
    /// Property representing the LastName for this Person.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public string LastName { get; set; }

    /// <summary>
    /// Property representing the MiddleName for this Person.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public string MiddleName { get; set; }

    /// <summary>
    /// Default constructor for this Person inherits default constructor from Entity base class.
    /// </summary>
    public Person() : base() { }

    /// <summary>
    /// Parametrized constructor for this Person inherits default constructor from Entity base class and
    /// accepts FirstName and LastName properties as paramters for this Person.
    /// </summary>
    /// <param name="firstName">string representing FirstName property for a Person instance.</param>
    /// <param name="lastName">string representing LastName property for a Person instance.</param>
    public Person(string firstName, string lastName) : base()
    {
      this.FirstName = firstName;
      this.LastName = lastName;
    }
  }
}
