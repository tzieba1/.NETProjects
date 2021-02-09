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
  /// Class representing a Patient extending from Person base class.
  /// </summary>
  [XmlRoot]
	[XmlType]
  [JsonObject]
  [Serializable]
  public class Patient : Person
  {
    /// <summary>
    /// Property representing DateOfBirth for this Patient as a DateTimeOffset.
    /// </summary>
    [XmlIgnore]
    [JsonProperty]
    public DateTimeOffset DateOfBirth { get; set; }

    /// <summary>
		/// Custom property representing this Patient's date of birth for XML which cannot serialize DateTimeOffset.
		/// </summary>
		/// <value>The date of birth XML.</value>
		[XmlElement]
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

    /// <summary>
    /// Property representing the Gender for this Patient.
    /// </summary>
    [XmlElement]
    [JsonProperty]
    public string Gender { get; set; }

    /// <summary>
    /// Default constructor for this Patient inherits default constructor from Person base class.
    /// </summary>
    public Patient() : base() { }

    /// <summary>
    /// Parametrized constructor for this Patient inherits default constructor from Person base class and
    /// accepts Gender and DateTimeOffset properties as paramters for this Patient.
    /// </summary>
    /// <param name="gender">string representing the Gender property for a Patient instance.</param>
    /// <param name="dateOfBirth">DtaeTimeOffset representing the DateOfBirth property for a Patient instance.</param>
    public Patient(string gender, DateTimeOffset dateOfBirth) : base()
    {
      this.Gender = gender;
      this.DateOfBirth = dateOfBirth;
    }
  }
}
