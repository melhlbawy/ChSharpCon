using System;

namespace SimpleDataTypes
{
	public class IntegralTypes 
    {
        /* 
		 * The following table shows the sizes and ranges of the integral types, which constitute a subset of simple types.
        Type		 Range																Size
		sbyte		 -128 to 127 												Signed 8-bit integer
		byte		 0 to 255 													Unsigned 8-bit integer
		char         U+0000 to													U+ffff Unicode 16-bit character
		short		 -32,768 to 32,767 											Signed 16-bit integer
		ushort       0 to 65,535 												Unsigned 16-bit integer
		int         -2,147,483,648 to 2,147,483,647 							Signed 32-bit integer
		uint        0 to 4,294,967,295 											Unsigned 32-bit integer
		long        -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 	Signed 64-bit integer
		ulong       0 to 18,446,744,073,709,551,615 							Unsigned 64-bit integer
		
		 */
        public sbyte shortByte;
        public byte Byte;
        public char Char;
        public short Short;
        public ushort UnsignedShort;
        public int intger;
        public uint unsignedIntger;
        public long Long;
        public ulong UnsignedLong;

		public void IntegralType()
        {
            sbyte sByteminValue = sbyte.MinValue; // To perview Minimum Value
            sbyte sBytemaxValue = sbyte.MaxValue; // to preview Maximum value
                    }
    }
    public class FloatPointTypes
    {
        /* 
         * The following table shows the precision and approximate ranges for the floating-point types.
            Type            Approximate range               Precision
            float           ±1.5e−45 to ±3.4e38 	        7 digits
            double          ±5.0e−324 to ±1.7e308 	        15-16 digits
            decimal         
             */
    }
}