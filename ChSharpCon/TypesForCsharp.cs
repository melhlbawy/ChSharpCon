using System;
using System.Collections.Generic;
using System.Text;

namespace ChSharpCon
{
   public class TypesForCsharp
    {
        /* 
         * The C# typing system contains the following categories:
        Value types     = Variables that are value types store data.
        Reference types = reference types store references to the actual data.
        Reference types are also referred to as objects.
        Pointer types   =  Pointer types can be used only in unsafe mode.
        **
        It is possible to convert a value type to a reference type,
        and back again to a value type, by using boxing and unboxing. 
        With the exception of a boxed value type, 
        you cannot convert a reference type to a value type.
        Value types are also nullable, which means they can store an additional non-value state.
        **
        */
        public void Sample()
        {
        // Value Types
                int i = 123;

        // Reference Types ئ
                object o = i; // convert by using boxing

            // Pointer Type
            /* In an unsafe context, a type may be a pointer type, a value type, or a reference type.
             * A pointer type declaration takes one of the following forms: 
             * Type* identifier;
             * void* identifier; // allowed in c# but not recommand
              
            ---  To set this compiler option in the Visual Studio development environment

            1- Open the project's Properties page.
            2- Click the Build property page.
            3- Select the Allow Unsafe Code check box.
            
            -- To declare variable as pointer Type
                int* myVar;
                */


         }



    }
}
