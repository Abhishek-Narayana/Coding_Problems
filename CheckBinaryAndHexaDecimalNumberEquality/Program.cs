using System;
using System.IO;

namespace CheckBinaryAndHexaDecimalNumberEquality
{
    public enum Base
    {
        Binary = 2,
        Octal = 8,
        Decimal = 10,
        Hexa = 16
    }

    class Number
    {
        public string number;
        public Base Base;

        public Number(string number, Base @base)
        {
            this.number = number;
            Base = @base;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Number binary = new Number("1111", Base.Binary);
            //Number hexa = new Number("F", Base.Hexa);
            //CheckNumberWithDifferentBaseAreEqual(binary, hexa);
        }

        //private static bool CheckNumberWithDifferentBaseAreEqual(Number number_1, Number number_2)
        //{
        //    if (number_1 == null || number_2 == null)
        //        return false;

        //    if (String.IsNullOrEmpty(number_1.number) || String.IsNullOrEmpty(number_2.number))
        //        return false;

        //    if ((number_1.Base == number_2.Base) && (number_1.number == number_2.number))
        //        return true;

        //    Number convertedNumber = new Number("", Base.Binary);
        //    switch (number_2.Base)
        //    {
        //        case Base.Binary:
        //            convertedNumber = ConvertToBase(number_1, Base.Binary);
        //            break;
        //        case Base.Decimal:
        //            convertedNumber = ConvertToBase(number_1, Base.Decimal);
        //            break;
        //        case Base.Octal:
        //            convertedNumber = ConvertToBase(number_1, Base.Octal);
        //            break;
        //        case Base.Hexa:
        //            convertedNumber = ConvertToBase(number_1, Base.Hexa);
        //            break;
        //        default:
        //            break;
        //    }
        //    return number_1 == convertedNumber;
        //}

        //private static Number ConvertToBase(Number number, Base binary)
        //{
        //    if (String.IsNullOrEmpty(number.number))
        //        return null;
        //    int temp;

        //    switch (number.Base)
        //    {
        //        case Base.Binary:
        //            convertedNumber = ConvertBinaryToBase(number, Base.Binary);
        //            break;
        //        case Base.Decimal:
        //            convertedNumber = ConvertToBase(number, Base.Decimal);
        //            break;
        //        case Base.Octal:
        //            convertedNumber = ConvertToBase(number, Base.Octal);
        //            break;
        //        case Base.Hexa:
        //            convertedNumber = ConvertToBase(number, Base.Hexa);
        //            break;
        //        default:
        //            break;
        //    }

        //    for (int count = number.number.Length; count > 0; --count)
        //    {
        //        temp = number.number[0] / 2;
        //    }
        //    return null;
        //}
    }
}
