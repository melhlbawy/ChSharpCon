using System;
using System.Collections.Generic;
using System.Text;

namespace ChSharpCon
{
    class ValueDataType
    {
        /* The value types consist of two main categories:
           -- Structs
           -- Enumerations
           && Structs fall into these categories:
           1- Numeric types
           2- Integral types
           3- Floating-point types
           4- decimal
           5- bool
           6- User defined structs.

        Variables that are based on value types directly contain values. 
        Assigning one value type variable to another copies the contained value.
        This differs from the assignment of reference type variables, 
        which copies a reference to the object but not the object itself. 
         All value types are derived implicitly from the System.ValueType.

    ** Unlike with reference types, you cannot derive a new type from a value type.
    However, like reference types, structs can implement interfaces.
    -- Unlike reference types, a value type cannot contain the null value. 
    int i = null; Not Allowed
    However, the nullable types feature does allow for value types to be assigned to null.
    int? i = null; Allowed
    ** Each value type has an implicit default constructor that initializes 
    the default value of that type. 
   
    */

        // Value Types 
        // 1- bool for Boolean Values

        public void boolMethodType()
        {
            bool b = true;

            // print the value b 
            Console.WriteLine(b);

            int days = DateTime.Now.DayOfYear;

            b = (days % 2 == 0);
            if (b)
            {
                Console.WriteLine("days is an even number");
            }
            else
            {
                Console.WriteLine("days is an odd number");
            }
            //Note: the default Vlaue for  bool is false. and bool? is null

           
        }
        /* 2- Byte Value Type:
            byte denotes an integral type that stores values as indicated in the following table.
            you can declare and initialize a byte variable by assigning a decimal literal,
               a hexadecimal literal, or (starting with C# 7) a binary literal to it

               */
        public void ByteType()
        {
            // declare with decimal literal:
            byte decimalLiteral201 = 201;
            // declare with hexadecimal lileral
            byte hexadecimal201 = 0x00C9;
            // declare with binary literal 
            byte binary201 = 0b1100_1001;
            //===============//
            /* Notes:
            ## You use the prefix 0x or 0X to denote a hexadecimal literal and the prefix 0b or 0B
            to denote a binary literal. Decimal literals have no prefix.
            ##Conversions: 
            There is a predefined implicit conversion from byte to short, ushort, int, uint, long, ulong,
            float, double, or decimal.
            You cannot implicitly convert non-literal numeric types of larger storage size to byte.
            ===
            byte x = 10, y = 20;
            The following assignment statement will produce a compilation error,
            because the arithmetic expression on the right-hand side of the assignment operator evaluates
            to int by default.

            // Error: conversion from int to byte:  
                byte z = x + y;  
            To fix this problem, use a cast:
            // OK: explicit conversion:  
            byte z = (byte)(x + y);  

            Also, there is no implicit conversion from floating-point types to byte.
            For example, the following statement generates a compiler error unless an explicit cast is used:

            // Error: no implicit conversion from double:  
            byte x = 3.0;   
            // OK: explicit conversion:  
            byte y = (byte)3.0;  

            When calling overloaded methods, a cast must be used. Consider, for example, the following overloaded methods that use byte and int parameters:

            public static void SampleMethod(int i) {}  
            public static void SampleMethod(byte b) {}  

            Using the byte cast guarantees that the correct type is called, for example:

            // Calling the method with the int parameter:  
            SampleMethod(5);  
            // Calling the method with the byte parameter:  
            SampleMethod((byte)5);
            
                        */

        }
        /*
         // 3- Char
         */
         public void charTypes()
         {
            /* The char keyword is used to declare an instance of the System.Char
             * structure that the .NET Framework uses to represent a Unicode character. 
             * The value of a Char object is a 16 - bit numeric(ordinal) value.
             * Unicode characters are used to represent most of the written languages throughout the world
             Literals:
             Constants of the char type can be written as character literals, hexadecimal escape sequence,
             or Unicode representation. You can also cast the integral character codes.
             
          */
            //In the following example four char variables are initialized with the same character X: 
            Char[] X = new Char[4];
            X[0] = 'X';         // Character literal
            X[1] = '\x0058';    //Hexadecimal
            X[2] = (char) 88;   //cast form Integral
            X[3] = '\u0058';    //Unicode

            foreach(char x in X)
            {
                Console.Write(x);
            }
            /*A char can be implicitly converted to ushort, int, uint, long, ulong, float, double, or decimal.
             * However, there are no implicit conversions from other types to the char type. 
             * */
         }
        /*
         * 4- Decimal
         * The decimal keyword indicates a 128-bit data type. 
         * Compared to other floating-point types, the decimal type has more precision and a smaller range,
         * which makes it appropriate for financial and monetary calculations.
         
         */
         public void DecimalType()
        {
            /*
             * To declare a decimal data type you must use Suffix m or M
             * if you didn`t use it the value compiled as double. and comes back with compiler error
             */
            decimal d = 3.93728363m;    //that `s right decimal vlaue
            // decimal derror = 3.7783728; it`s compiler error
            decimal myMoney = 300;
            /* There is no implicit conversion between other floating-point types and the decimal type;
             * therefore, a cast must be used to convert between these two types
             */
            decimal m = 3.251m;
            double dm = (double) m;
            m = (decimal)dm;
            /*
             * You can also mix decimal and numeric integral types in the same expression.
             * However, mixing decimal and other floating-point types without a cast causes a compilation error. 
             * and we cann`t use operrands between two valuble float piont without casting
             */
            decimal myMoney2 = 3.254m;
            double mydouble = 3.1545;

            // decimal sum = myMoney2 + mydouble; without casting create compiler error

            decimal sum = myMoney2 + (decimal)mydouble; //that the right way with casying

            // Fprmat String with decimal:

            Console.Write($"Currency Format string for my money: {sum:C}");
            /* Output:
             Currency Format string for my money: $6.154;
              */
        }
        /* 5- Double 
         * The double keyword signifies a simple type that stores 64-bit floating-point values.
         */
        public void DoubleTypes() {
            /*
                *By default, a real numeric literal on the right side of the assignment operator is treated as double.
                *However, if you want an integer number to be treated as double, use the suffix d or D, for example:
              double x = 3D;
           *Conversions
              You can mix numeric integral types and floating - point types in an expression.
              In this case, the integral types are converted to floating - point types.
              The evaluation of the expression is performed according to the following rules:
                1 - If one of the floating - point types is double, the expression evaluates to double,
                or bool in relational or Boolean expressions.
                2 - If there is no double type in the expression, it evaluates to float,
                or bool in relational or Boolean expressions.
              A floating - point expression can contain the following sets of values:
                  *Positive and negative zero.
                  * Positive and negative infinity.
                  * Not - a - Number value(NaN).
                  * The finite set of nonzero values.
               */
            // Mixing types in expressions
            int x = 3;
            float y = 4.5f;
            short z = 5;
            double w = 1.7E+3;
            // Result of the 2nd argument is a double:
            Console.WriteLine("The sum is {0}", x + y + z + w);

            // the output will be double
            //  The sum is 1712.5
            // To get the result Type
            var resualtType = x + y + z + w;
            Console.WriteLine(resualtType.GetType());
            // the resual will be System.Double -- Refrences for Double data types

        }
        /* 6- float 
         * The float keyword signifies a simple type that stores 32-bit floating-point values
         */
         public void FloatType()
        {
            /* 
             * Literals
             * By default, a real numeric literal on the right side of the assignment operator is treated as double.
             * Therefore, to initialize a float variable, use the suffix f or F, as in the following example:C#
             *  float x = 3.5F;  
             *  If you do not use the suffix in the previous declaration, you will get a compilation error because you 
             are trying to store a double value into a float variable. 
              */

            int x = 3;
            float y = 4.5f;
            short z = 5;
            var result = x * y / z;
            Console.WriteLine("The result is {0}", result);
            Type type = result.GetType();
            Console.WriteLine("result is of type {0}", type.ToString());
            
            /* Output: 
              The result is 2.7
              result is of type System.Single //'float' is alias for 'Single'
             */
         }
        /* 7- int
         * int denotes an integral type that stores values according to the size and range:
         * -2,147,483,648 to 2,147,483,647.
         * 
         */
         public void IntType()
        {
            /* 
             * You can declare and initialize an int variable by assigning a decimal literal, a hexadecimal literal, 
             * or (starting with C# 7) a binary literal to it.
             * if the initialize value outside of the int range that give an compiler error
             * 
             */
             // Declare int type
            int intValue1 = 90946; // decimal literal
            Console.WriteLine(intValue1);
            int intValue2 = 0x16342; // Hexadecimal 
            Console.WriteLine(intValue2);

            int intValue3 = 0b0001_0110_0011_0100_0010; //binar literal
            Console.WriteLine(intValue3);
            // The example displays the following output:
            //          90946
            //          90946
            //          90946

            //Conversions
            // There is a predefined implicit conversion from int to long, float, double, or decimal. For example:
            //  // '123' is an int, so an implicit conversion takes place here: float f = 123; 
            //  There is a predefined implicit conversion from sbyte, byte, short, ushort, or char to int.
            //  For example, the following assignment statement will produce a compilation error without a cast:
             long aLong = 22;
            //  int i1 = aLong;       // Error: no implicit conversion from long.
              int i2 = (int)aLong;  // OK: explicit conversion. 
            //  Notice also that there is no implicit conversion from floating-point types to int.
            //  For example, the following statement generates a compiler error unless an explicit cast is used:
            //  int x = 3.0;         // Error: no implicit conversion from double.
              int y = (int)3.0;    // OK: explicit conversion.


            }
        /* 
         * There are more Types have the same rules of int 
         * 8- uint 9- long 10- ulong
         * 
         * there are some types have some rules different  like:
         * 11- sbyte 12- short 14- ushort
         */

        /* 14 - Enum
         * The enum keyword is used to declare an enumeration, a distinct type that consists of a set of named constants
         * called the enumerator list. 
         */
        
    }
    public class EnumerationTypes
    {
            // Usually it is best to define an enum directly within a namespace so that all classes in the namespace can access it with equal convenience. 
            // However, an enum can also be nested within a class or struct.
            // By default, the first enumerator has the value 0, and the value of each successive enumerator is increased by 1.
            // For example, in the following enumeration, Sat is 0, Sun is 1, Mon is 2, and so forth.
        enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
            // Enumerators can use initializers to override the default values, as shown in the following example.
        enum DaysChangeDefault { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };
        // In this enumeration, the sequence of elements is forced to start from 1 instead of 0. 
        // However, including a constant that has the value of 0 is recommended.
        // Every enumeration type has an underlying type, which can be any integral type except char.
        // The default underlying type of enumeration elements is int.
        // To declare an enum of another integral type, such as byte, use a colon after the identifier followed by the type,
        // as shown in the following example.
       enum DaysChangeType : byte { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };
        // The approved types for an enum are byte, sbyte, short, ushort, int, uint, long, or ulong. 
    }
}
