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
  /// Class representing an Identifier for Lists in this class library for the Entity class.
  /// </summary>
  [XmlRoot]
  [XmlType]
  [JsonObject]
  [Serializable]
  public class Identifier
  {
    /// <summary>
    /// Property representing this Identifier's Authority as a string.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public string Authority { get; set; }

    /// <summary>
    /// Property representing this Identifier's EntityId as a Guid.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public Guid EntityId { get; set; }

    /// <summary>
    /// Property representing this Identifier's Value as a string.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public string Value { get; set; }

    /// <summary>
    /// Default constructor for this Identifier.
    /// </summary>
    public Identifier() { }

    /// <summary>
    /// Paramettrized constructor for this Identifier that accepts a corresponding Authority and Value.
    /// </summary>
    /// <param name="authority"></param>
    /// <param name="value"></param>
    public Identifier(string authority, string value)
    {
      this.Authority = authority;
      this.Value = value;
    }
  }
}
