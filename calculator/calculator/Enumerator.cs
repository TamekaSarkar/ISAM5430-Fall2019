using System;
namespace calculator
{
    public enum KeyType
    {
        None,
        Number,
        Sign,
        Operator,
        Conversion,
        Invalid
    }

    public enum NumberType
    {
        Invalid,
        Binary,
        Octal,
        Decimal,
        Hexadecimal
    }
}
