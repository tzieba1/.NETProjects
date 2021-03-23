using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples
{
  // Creating a class called DatabaseConnection which follows a non-lazy Singleton design pattern.
  class DatabaseConnector
  {
    private static readonly DatabaseConnector _instance;
    private DatabaseConnector()
    {

    }

    public static DatabaseConnector GetInstance()
    {
      return _instance;
    }
  }
}
