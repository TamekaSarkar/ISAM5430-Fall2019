using System;
using System.Collections;
using System.Collections.Generic;

namespace calculator

{
    
    public class Screen : IEnumerable<keyOperator>
    {
        
        private List<keyOperator> _keys = new List<keyOperator>();

        private List<keyOperator> _keys2 = new List<keyOperator>();

        public List<keyOperator> keys
        {
            get
            {
                return this._keys;
            }

        }

        public List<keyOperator> keys2
        {
            get
            {
                return this._keys2;
            }

        }


        public IEnumerator<keyOperator> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return keys.GetEnumerator();
        }


        public keyOperator GetOperator()
        {
            this._keys.Add(new keyOperator('I', KeyType.Conversion, "Binary Conversion"));
            this._keys.Add(new keyOperator('O', KeyType.Conversion, "Octal Conversion"));
            this._keys.Add(new keyOperator('+', KeyType.Operator, "Addition"));
            this._keys.Add(new keyOperator('-', KeyType.Operator, "Substraction"));

            foreach(keyOperator k in keys)
            {
                Console.WriteLine("{0} {1} {2}", k.Key, k.KeyName,k.keyType );
            }

            char Operator = char.Parse(Console.ReadLine());

            KeyType kT = default;

            foreach (keyOperator k in keys)
            {
                if(k.Key == Operator)
                {
                    return k;
                }
            }
            
            return (new keyOperator(Operator,KeyType.Invalid,"Invalid Key"));
        }


        public NumberType GetNumType()
        {
            this._keys2.Add(new keyOperator('B', KeyType.Number, "Binary"));
            this._keys2.Add(new keyOperator('8', KeyType.Number, "Octal"));
            this._keys2.Add(new keyOperator('D', KeyType.Number, "Decimal"));
            this._keys2.Add(new keyOperator('H', KeyType.Number, "HexaDecimal"));

            foreach (keyOperator k in keys2)
            {
                Console.WriteLine("{0} {1} {2}", k.Key, k.KeyName, k.keyType);
            }

            char NumType = char.Parse(Console.ReadLine());

            switch (NumType)
            {
                case 'D': return NumberType.Decimal;
                case '8': return NumberType.Binary;
                case 'O': return NumberType.Octal;
                case 'H': return NumberType.Hexadecimal;
                default: return NumberType.Invalid;

            }
        }
    }
}
