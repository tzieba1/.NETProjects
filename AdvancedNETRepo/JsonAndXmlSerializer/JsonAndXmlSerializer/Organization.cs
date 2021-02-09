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
  /// Class representing an Organization extending from Entity base class.
  /// </summary>
  [XmlRoot]
  [XmlType]
  [JsonObject]
  [Serializable]
  public class Organization : Entity
  {
    /// <summary>
    /// Property representing the Name for this Organization.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public string Name { get; set; }

    /// <summary>
    /// Default constructor for this Organiztion inherits default constructor from Entity base class.
    /// </summary>
    public Organization() : base() { }

    /// <summary>
    /// Parametrized constructor for this Organization inherits default constructor from Entity base class and
    /// accepts a Name property as a paramter for this Organization.
    /// </summary>
    /// <param name="name">string representing the Name of this Organization.</param>
    public Organization(string name) : base()
    {
      this.Name = name;
    }
  }
}
