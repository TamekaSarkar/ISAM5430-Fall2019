using System;
namespace calculator
{
    public abstract class KeyNumber:Ikey, Ikeyname
    {
        /* Encapsulations: all fields should expect to be private or public,
         * as you don't want anyone to change these fields from outside the class.*/
        private char _Key;
        private int _KeyValue;
        private KeyType _keyType;
        private string _keyName;


        public abstract int MaxValue { get; }

        public char Key
        {
            get
            {
                return this._Key;
            }
        }

        public int KeyValue
        {
            get
            {
                return this._KeyValue;
            }
        }

        public KeyType keyType
        {
            get
            {
                return this._keyType;
            }
        }

        public string KeyName
        { 
            get
            {
                return this._keyName;
                
            }
        }

        public KeyNumber(char k, KeyType kT)
        {
            this._Key = k;
            this._keyType = kT;
            this._KeyValue = (int)Char.GetNumericValue(this._Key);
            this._keyName = "number"; //default name for number type
        }

        public KeyNumber(char k, KeyType kT,string keyname)
        {
            this._Key = k;
            this._keyType = kT;
            this._KeyValue = (int)Char.GetNumericValue(this._Key);
            this._keyName = keyname; //default name for number type
        }




    }

    public class keyDecimal : KeyNumber
    {
        public keyDecimal(char k, KeyType kT) : base(k, kT)
        {

        }

        public override int MaxValue
        {
            get
            {
                return 9;
            }
        }


    }

    public class keyBinary : KeyNumber
    {
        public keyBinary(char k, KeyType kT) : base(k, kT)
        {

        }

        public override int MaxValue
        {
            get
            {
                return 1;
            }
        }


    }

    public class KeyOctal : KeyNumber
    {
        public KeyOctal(char k, KeyType kT) : base(k, kT)
        {

        }

        public override int MaxValue
        {
            get
            {
                return 7;
            }
        }


    }

    public class keyHexaDecimal : KeyNumber
    {
        public keyHexaDecimal(char k, KeyType kT) : base(k, kT)
        {

        }

        public override int MaxValue
        {
            get
            {
                return 15;
            }
        }


    }

    public class keyOperator : KeyNumber
    {
        public keyOperator(char k, KeyType kT, string keyname) : base(k, kT, keyname)
        {

        }

        public override int MaxValue
        {
            get
            {
                return 0;
            }
        }


    }
}
      