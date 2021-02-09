using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SerializationExample
{
  [XmlRoot]
  [XmlType]
  [JsonObject]
  public class Person
  {
    /// <summary>
    /// Get of set the person's name.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public string Name { get; set; }
    [XmlElement]
    [JsonProperty]
    public Guid Id { get; set; }
    [XmlIgnore]   // Ignore to use 'trick' below for serializing the date.
    [JsonIgnore]  //Not actually needed (only XML not able to convert dates - no 'trick' needed here necessarily)
    public DateTimeOffset DateOfBirth { get; set; }
    
    // This is the trick used to get the date when it is empty after serialization (need XmlIgnore above with this)
    [XmlElement]
    [JsonProperty]
    public string DateOfBirthXml
    { 
      get 
      {
        return this.DateOfBirth.ToString("o");
      } 
      set 
      {
        this.DateOfBirth = DateTimeOffset.Parse(value);
      }
    }
  }
}
