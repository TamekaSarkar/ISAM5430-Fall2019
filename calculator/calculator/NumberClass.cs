using System;
using System.Collections;
using System.Collections.Generic;

namespace calculator
{
    
    public abstract class Number : IEnumerable<KeyNumber>
    {
        
        private List<KeyNumber> _keys = new List<KeyNumber>();
        private bool _sign;
        
      
        private string _number;

        public Number()
        {
            this._number = "";
            this._sign = true;
        }

        public Number (string s)
        {
            this._number = s;
        }

       

        public List<KeyNumber> keys
        {
            get
            {
                return _keys;
            }
        }
        //public virtual void Add(KeyNumber key) { }

        
        public IEnumerator GetEnumerator()
        {
            return keys.GetEnumerator();
        }

        public override string ToString()
        {
            foreach (KeyNumber k in keys)
            {
                if (k.KeyValue <= k.MaxValue)
                {
                    this._number = this._number +k.Key;
                }
            }
            return this.number;
        }

        public string number
        {
            get
            {
                return this._number;
            }
        }

      
        public abstract string GetNumber();
        

        IEnumerator<KeyNumber> IEnumerable<KeyNumber>.GetEnumerator()
        {
            return ((IEnumerable<KeyNumber>)keys).GetEnumerator();
        }
    }


    public class OctalNumber : Number
    {
       
        public override string GetNumber()
        {
            char input = char.Parse(Console.ReadLine());


            while (input != 'X')
            {
          

                keys.Add(new KeyOctal(input, KeyType.Number));
                input = char.Parse(Console.ReadLine());
            }
            return (this.ToString());
           

        }

        
    }

    public class BinaryNumber : Number
    {

        public override string GetNumber()
        {
            char input = char.Parse(Console.ReadLine());


            while (input != 'X')
            {
                keys.Add(new keyBinary(input, KeyType.Number));
                input = char.Parse(Console.ReadLine());
            }
            return (this.ToString());


        }


    }



}
