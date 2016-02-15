using System;


internal class SHNTypeAttribute : Attribute
{
    public Type Type { get; private set; }
    public uint[] Values { get; private set; }

    public SHNTypeAttribute(Type type, params uint[] values)
    {
        Type = type;
        Values = values;
    }
}