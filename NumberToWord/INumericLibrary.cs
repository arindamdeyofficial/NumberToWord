using System;

namespace NumberToWord
{
    public interface INumericLibrary
    {
        string SpellNumber(Int64 num);
        Int64 ReverseNumber(Int64 num);
    }
}