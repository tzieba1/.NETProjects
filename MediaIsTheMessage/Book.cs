///I, Tommy Zieba, 000797152 certify that this material is my original work. 
///No other person's work has been used without due acknowledgement.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaIsTheMessage
{
  /// <summary>
  ///   Class representing a <c>Book</c> with <c>Author</c> and <c>Summary</c> properties.
  ///   This class extends the abstract <c>Media</c> class and is used by the <c>Lab3A</c>
  ///   class to execute a searchable <c>Media</c> object console application.
  /// </summary>
  class Book : Media, IEncryptable
  {
    /// <summary>
    ///   Property representing the author of a <c>Book</c> object that is privately set.
    /// </summary>
    public string Author { get; }

    /// <summary>
    ///   Property representing the summary of a <c>Book</c> object that is privately set.
    /// </summary>
    public string Summary { get; }

    /// <summary>
    ///   Constructor for a concrete <c>Book</c> object extending abstract <c>Media</c> base class.
    /// </summary>
    /// 
    /// <param name="title">Title of this <c>Book</c>.</param>
    /// <param name="year">Year of this <c>Book</c>'s publication.</param>
    /// <param name="author">Author of this <c>Book</c>.</param>
    /// <param name="summary">Summary of this <c>Book</c>.</param>
    public Book(string title, int year, string author, string summary)
    : base(title, year)
    {
      Author = author;
      Summary = Decrypt(summary);
    }

    #region IEncryptable
    //* Uppercase alphabet used to encrypt and decrypt Summary property of Book and Movie objects.
    public List<char> upperAlphabet = new List<char>()
      {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
       'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

    //* Lowercase alphabet used to encrypt and decrypt Summary property of Book and Movie objects.
    public List<char> lowerAlphabet = new List<char>()
      {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
       'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

    /// <summary>
    ///   Overriding <c>IEncryptable</c> interface's <c>Encrypt</c> method which encrypts text from
    ///   the english alphabet using the ROT13 encryption algorithm. 
    /// </summary>
    /// <param name="unencryptedData">A string of unencrypted data to be encrypted.</param>
    /// <returns>A string of encrypted data.</returns>
    public string Encrypt(string unencryptedData)
      {
      string encryptedData = "";  //Initialize string to iteratively concatenate encrypted text.
      bool lowercase;             //Flag for a lowercase character detected during encryption.
      for (int i = 0; i < unencryptedData.Length; i++)
        {
        //* Condition testing if the character being encrypted is alphabetical.
        if (upperAlphabet.IndexOf(unencryptedData[i]) != -1 ||
            lowerAlphabet.IndexOf(unencryptedData[i]) != -1)
          {
          lowercase = char.IsLower(unencryptedData[i]) ? true : false;  //Flag for lowercase char.
          
          //* Concatenating encrypted char to encryptedData string with correct alphabetical case.
          if (lowercase)
            {
            char upperChar = char.ToUpper(unencryptedData[i]);
            int upperCharIndex = upperAlphabet.IndexOf(upperChar);
            encryptedData += char.ToLower(upperAlphabet[(upperCharIndex + 13) % 26]);
            }
          else
            encryptedData += upperAlphabet[(upperAlphabet.IndexOf(unencryptedData[i]) + 13) % 26];
          }
        //* Adding char to encryptedData string whenever non-alphabetical.
        else
          encryptedData += unencryptedData[i];
        }
      return encryptedData;
      }

    /// <summary>
    ///   Overriding <c>IEncryptable</c> interface's <c>Decrypt</c> method which decrypts text from
    ///   the english alphabet using the ROT13 encryption algorithm. 
    /// </summary>
    /// <param name="encryptedData">A string of encyrpted data to be decrypted.</param>
    /// <returns>A string of decrypted data.</returns>
    public string Decrypt(string encryptedData)
      {
      //* The ROT13 algorithm forms 2 subgroups that are related with the bijective relation
      //  ROT13(alphabet[charIndex]) = ( alphabet[charIndex] + 13 ) % 26. Therefore, applying
      //  the Encrypt() method to encrypted text will also decrypt it. 
      return Encrypt(encryptedData);
      }
    #endregion

    /// <summary>
    ///   Overridden to return a string representation of this <c>Book</c>.
    /// </summary>
    /// <returns>String with <c>Book</c> Title/Year (from base), Author, and Summary</returns>
    public override string ToString()
      {
      return "| BOOK  " + base.ToString() + $" Author: {Author} |\n" +
        $"-------------------------------------------------------------------------------------------------------------------------\n" +
        $"| Summary: |\n" +
        $" {Summary}";
      }
    }
}