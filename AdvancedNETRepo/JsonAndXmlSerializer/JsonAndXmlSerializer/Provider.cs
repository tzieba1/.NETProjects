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
  /// Class representing a Provider extending from Person base class.
  /// </summary>
  [XmlRoot]
  [XmlType]
  [JsonObject]
  [Serializable]
  public class Provider : Person
  {
    /// <summary>
    /// Property representing this Provider's Specialty.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public string Specialty { get; set; }

    /// <summary>
    /// Default constructor for this Provider inherits default constructor from Person base class.
    /// </summary>
    public Provider() : base() { }

    /// <summary>
    /// Parametrized constructor for this Provider inherits default constructor from Person base class and
    /// accepts a Specialty property as paramters for this Provider.
    /// </summary>
    /// <param name="specialty">string representing the Specialty property for a Provider instance.</param>
    public Provider(string specialty) : base()
    {
      this.Specialty = specialty;
    }
  }
}
