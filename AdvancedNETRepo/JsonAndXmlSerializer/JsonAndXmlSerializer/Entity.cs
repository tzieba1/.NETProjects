///
/// Student Name: Tommy Zieba
/// Student Number: 000797152
/// Statement of Authorship:
///   I, Tommy Zieba, 000797152 certify that this material is my original work. 
///   No other person's work has been used without due acknowledgement.
///

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Xml.Serialization;

/// <summary>
/// Namespace for this Assignment 1 Serializer project.
/// This project serializes/deserializes a .NET Core 2.2 class library using XML and JSON formats.
/// </summary>
namespace JsonAndXmlSerializer
{
  /// <summary>
  /// Class representing the base Entity class for this class library.
  /// </summary>
  [XmlRoot]
  [XmlType]
  [JsonObject]
  [Serializable]
  public class Entity
  {
    /// <summary>
    /// Property representing a List of type Address for this Entity.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public List<Address> Addresses { get; set; }

    /// <summary>
    /// Property representing this Entity's Guid.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public Guid Id { get; set; }

    /// <summary>
    /// Property representing a List of type Identifier for this Entity.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public List<Identifier> Identifiers { get; set; }

    /// <summary>
    /// Default constructor for this Entity. 
    /// </summary>
    public Entity() { }

    /// <summary>
    /// Paramterized constructor for this Entity that accepts an existing Guid instance as an id.
    /// </summary>
    /// <param name="id">Id for this Entity.</param>
    public Entity(Guid id)
    {
      this.Id = id;
    }
  }
}
