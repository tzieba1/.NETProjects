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
  /// Class representing an Address for Lists in this class library for the Entity class.
  /// </summary>
  [XmlRoot]
  [XmlType]
  [JsonObject]
  [Serializable]
  public class Address
  {
    /// <summary>
    /// Property representing this Address's local street AddressLine as a string.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public string AddressLine { get; set; }

    /// <summary>
    /// Property representing this Address's Cityas a string.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public string City { get; set; }

    /// <summary>
    /// Property representing this Address's Country as a string.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public string Country { get; set; }

    /// <summary>
    /// Property representing this Address's EntityId as a Guid.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public Guid EntityId { get; set; }

    /// <summary>
    /// Property representing this Address's PostalCode as a string.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public string PostalCode { get; set; }

    /// <summary>
    /// Property representing this Address's Province as a string.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public string Province { get; set; }

    /// <summary>
    /// Default constructor for this Address.
    /// </summary>
    public Address() { }

    /// <summary>
    /// Parametrized constructor for this Address that accepts a corresponding PostalCode.
    /// </summary>
    /// <param name="postalCode">Postal code associated to a </param>
    public Address(string postalCode)
    {
      this.PostalCode = postalCode;
    }
  }
}
