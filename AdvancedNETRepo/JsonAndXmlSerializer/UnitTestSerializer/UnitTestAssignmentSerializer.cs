///
/// Student Name: Tommy Zieba
/// Student Number: 000797152
/// Statement of Authorship:
///   I, Tommy Zieba, 000797152 certify that this material is my original work. 
///   No other person's work has been used without due acknowledgement.
///

using Microsoft.VisualStudio.TestTools.UnitTesting;
using JsonAndXmlSerializer;
using System;

/// <summary>
/// Namespace for the unit testing classes for testing both generic and non generic methods
/// from the JsonAndXmlSerializer project's class library for Assignment 1.
/// </summary>
namespace UnitTestAssignment1Serializer
{
  /// <summary>
  /// Testing the non-generic methods for Assignment1Serializer.
  /// </summary>
  [TestClass]
  public class Assignment1Serializer_NonGeneric
  {
    // Serializer used repeatedly for testing methods.
    Assignment1Serializer serializer = new Assignment1Serializer();

    /// <summary>
    /// Testing to ensure that the non-generic JSON serialization method returns a byte array.
    /// </summary>
    [TestMethod]
    public void SerializeToJson_PersonClass_ReturnByteArray()
    {
      // Arrange
      Person person = new Person("Tommy", "Zieba") ;

      // Act
      var serialized = serializer.SerializeToJson(typeof(Person), person);

      // Assert
      Assert.AreEqual(serialized.GetType(), typeof(byte[]));
    }

    /// <summary>
    /// Testing to ensure that the non-generic JSON deserialization method returns the correct type.
    /// </summary>
    [TestMethod]
    public void DeserializeFromJson_OrganizationClass_ReturnObject()
    {
      // Arrange
      Organization organization = new Organization("Sample Organization");

      // Act
      var serialized = serializer.SerializeToJson(typeof(Organization), organization);
      var deserialized = serializer.DeserializeFromJson(typeof(Organization), serialized);

      // Assert
      Assert.AreEqual(deserialized.GetType(), typeof(Organization));
    }

    /// <summary>
    /// Testing to ensure that the non-generic Xml serialization method throws an exception
    /// if a class not derived from Entity is provided as an argument (in this case Identifier).
    /// </summary>
    [ExpectedException(typeof(ArgumentException))]
    [TestMethod]
    public void SerializeToXml_IdentifierClass_ThrowException()
    {
      // Arrange
      Identifier identifier = new Identifier();

      // Act
      serializer.SerializeToXml(typeof(Identifier), identifier);

      // Assert
      // Not required
    }
  }

  /// <summary>
  /// Testing the generic methods for Assignment1Serializer.
  /// </summary>
  [TestClass]
  public class Assignment1Serializer_Generic
  {
    // Serializer used repeatedly for testing methods.
    Assignment1Serializer serializer = new Assignment1Serializer();

    /// <summary>
    /// Testing to ensure that the generic XML serialization method returns a byte array.
    /// </summary>
    [TestMethod]
    public void SerializeToXml_ProviderClass_ReturnByteArray()
    {
      // Arrange
      Provider provider = new Provider("Physician");

      // Act
      var serialized = serializer.SerializeToXml<Entity>(provider);

      // Assert
      Assert.AreEqual(serialized.GetType(), typeof(byte[]));
    }

    /// <summary>
    /// Testing to ensure that the generic XML deserialization method returns the correct type.
    /// </summary>
    [TestMethod]
    public void DeserializeFromXml_PatientClass_ReturnPatient()
    {
      // Arrange
      Patient patient = new Patient("Male", DateTimeOffset.Now);

      // Act
      var serialized = serializer.SerializeToXml<Entity>(patient);
      var deserialized = serializer.DeserializeFromXml<Patient>(serialized);

      // Assert
      Assert.AreEqual(deserialized.GetType(), typeof(Patient));
    }

    /// <summary>
    /// Testing to ensure that the generic Json serialization method throws an exception
    /// if a class not derived from Entity is provided as an argument (in this case Address).
    /// </summary>
    [ExpectedException(typeof(ArgumentException))]
    [TestMethod]
    public void SerializeToJson_AddressClass_ThrowException()
    {
      // Arrange
      Address address = new Address();

      // Act
      serializer.SerializeToJson(typeof(Address), address);

      // Assert
      // Not required
    }
  }
}