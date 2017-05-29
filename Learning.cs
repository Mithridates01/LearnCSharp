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
      byte number = 2;
      int count = 10;
      float totalPrice = 20.95f;
      char character = 'A';
      string  firstString = "YAY!";
      bool isWorking = true;
      bool notWork = false;
      Console.WriteLine(number);
      Console.WriteLine(count);
      Console.WriteLine(totalPrice);
      const float Pi = 3.14f;
      // complier wont let constant be changed


      // TYPE Conversion
      // Implicit type conversion
      // fills the 8 bit memory
      byte b = 1; // 0000001
      int i = b; // 000000 000000 00000 0000001

      int i = 1;
      float  f = i;

      int i = 1;
      byte b = i; // wont compiled

      float f = 1.0f;
      int i = f // chance of data lose because
      // float takes up more bytes of space than an int
      // do explicit Casting type conversion
      int i = (int)f; // will work, but may lose data


      // explicit type conversion
      // conversion between non compatible types
      // use convert class or Parse() method to convert between types
      string s = "1";
      int i  = Convert.ToInt32(s); // -> 1
      int j = int.Parse(s);  // -> 1
      string newString = string.Parse(j); // -> "j"

      ToInt32();
      ToInt16();


      try
      {
        // this code will be monitored
        // and if an error occures,
        // the catch block will throw an error
        // without crashing the application
      }
      catch (Exception)
      {
        Console.WriteLine("Warning Error")
      }

      // Operators
        // Arithmetic Operators
        // math same as other langs
        // has -- & ++
      // comparison

      //  && and
      //  || or
      //  ! not
      // Bitwise Operators
      // &    a & b
      // !    a | b

      /* 
        Like CSS comments
      */

    }
  }
}
















