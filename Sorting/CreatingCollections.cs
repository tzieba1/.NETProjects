using System.Collections.Generic;

// a simplified ListBox control
public class ListBoxTest : IEnumerable<String>
{
  private string[] strings;          // maintain a list of strings
  private int ctr = 0;               // keep track of how many strings in the array

  // Enumerable classes return an enumerator
  public IEnumerator<string> GetEnumerator()
  {
    foreach (string s in strings)
    {
      yield return s;
    }
  }

  // required to fulfill IEnumerable
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  {
    throw new NotImplementedException();
  }

  // initialize the ListBox with strings
  public ListBoxTest( params string[] initialStrings )
  {
    // allocate space for the strings
    strings = new String[256];

    // copy the strings passed in to the constructor
    foreach ( string s in initialStrings )
    {
      strings[ctr++] = s;
    }
  }

  // add a single string to the end of the ListBox
  public void Add( string theString )
  {
    if ( ctr >= strings.Length )
    {
      // handle bad index
    }
    else
      strings[ctr++] = theString;
  }

  // publish how many strings you hold
  public int GetNumEntries()
  {
    return ctr;
  }

  // This method iterates through the strings held in MyStrings until it finds a
  // string that starts with the target string used in the index
  private int FindString(string searchString)
  {
    for (int i = 0; i < strings.Length; i++)
    {
      if (strings[i].StartsWith(searchString))
      {
        return i;                        // if found, return the index of the string
      }
    }
    return -1;                           // if not found, return -1
  }

  // index on string
  public string this[string index]
  {
    get
    {
      if (index.Length == 0)
      {
        // handle bad index
      }
      return this[FindString(index)];
    }
    set
    {
      // no need to check the index here because
      // find string will handle a bad index value
      strings[FindString(index)] = value;
    }
  } 

  // allow array-like access
  // the syntax of the indexer is very similar to that for properties
  /* public string this[int index]
  {
    get                                       // implement some basic bounds checking
    {
      if ( index < 0 || index >= strings.Length )
      {
        // handle bad index
      }
      return strings[index];
    }
    set           // make sure the index being set already has a value in the ListBox
    {
      // add new items only through the Add method (illegal to try to add with set)
      if ( index >= ctr )
      {
        // handle error
      }
      else
      {
        strings[index] = value;
      }
    }
  } */
}

public class Tester
{
  static void Main()
  {
    // create a new ListBox and initialize
    ListBoxTest lbt = new ListBoxTest( "Hello", "World" );

    // add a few strings
    lbt.Add( "Proust" );
    lbt.Add( "Faulkner" );
    lbt.Add( "Mann" );
    lbt.Add( "Hugo" );

    // test the access by modifying the second value
    string subst = "Universe";
    lbt[1] = subst;
    lbt["Hel"] = "GoodBye";          // string segment as the index instead of an int
    // lbt["xyz"] = "oops";          // this would return index -1, causing exception

    // access all the strings
    for ( int i = 0; i < lbt.GetNumEntries(); i++ )
    {
      Console.WriteLine( "lbt[{0}]: {1}", i, lbt[i] );
    }
  }
}

