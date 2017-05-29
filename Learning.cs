using System;

namespace LearningCSharp
{
  class Learning
  {
    static void Main(string[] args)
    {
      // void key word is saying nothing is returned from method
      // Main entry poin of application
      // Assembly Manifest
      //references any assemblies needed for project

            // Overflowing

      byte number = 255;

      number = number + 1; // --> 0

      // prevents overflow and throws exception
      // almost never use checked keyword
      checked
      {
        byte number = 255;

        number = number + 1;
      }

      // Scope
      {
        byte a = 1;

        {
          byte b = 2;

          {
            byte c = 3;
          }
        }
      }
      // program will throw compile time error if accessed
      // outside of scope.
      

    }
  }
}



// 