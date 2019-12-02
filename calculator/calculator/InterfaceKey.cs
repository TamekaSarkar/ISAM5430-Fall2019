using System;
namespace calculator
{
    public interface Ikey
    {   public char Key { get; }
        public int KeyValue { get; }
        public KeyType keyType { get; }
    }

    public interface Ikeyname:Ikey
    {
        public string KeyName { get; }
    }
}
