using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
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
    public interface Ikey
    {
        public void getKey(char k);
        public void getKeyType(KeyType Kt);

    }

    public interface IkeyPad
    {
        public void getKeyName(string Kn);
    }

    public abstract class KeyNumber
    {
        public char Key;
        public int KeyValue;
        public int MaxValue;
        public KeyType keyType;
        public NumberType NumType;

        public KeyNumber(char k, KeyType kT)
        {
            this.Key = k;
            this.keyType = kT;
            this.KeyValue = (int)Char.GetNumericValue(this.Key);
        }

        public int CharToNum(char c)
        {
            KeyValue = (int)Char.GetNumericValue(c);
            return KeyValue;
        }
        public void getKey(char k)
        {
            this.Key = k;
        }
        public void getKeyType(KeyType Kt)
        {
            this.keyType = Kt;
        }

       

        public bool isValid()
        {
            switch (this.keyType)
            {
                case KeyType.Invalid:
                    return false;
                default:
                    return true;

            }
        }
    }

    public class keyDecimal : KeyNumber
    {
        public keyDecimal(char k, KeyType kT):base(k,kT)
        {
            this.MaxValue = 9;
            NumType = NumberType.Decimal;
        }
    }

    public class keyBinary : KeyNumber
    {
        public keyBinary(char k, KeyType kT) : base(k, kT)
        {
            this.MaxValue = 1;
            NumType = NumberType.Binary;
        }
    }

    public class keyOctal : KeyNumber
    {
        public keyOctal(char k, KeyType kT) : base(k, kT)
        {
            this.MaxValue = 7;
            NumType = NumberType.Octal;
        }
    }


    public class keyHexaDecimal : KeyNumber
    {
        public keyHexaDecimal(char k, KeyType kT) : base(k, kT)
        {
            this.MaxValue = 15;
            NumType = NumberType.Hexadecimal;
        }
    }

    public class keyOperator : KeyNumber
    {
        public keyOperator(char k, KeyType kT) : base(k, kT)
        {
            this.MaxValue = 0;
            NumType = NumberType.Invalid;
        }
    }

    public abstract class Number : IEnumerable
    {
        public List<KeyNumber> keys = new List<KeyNumber>();
        public bool sign;
        public string number;

        public Number() 
        {
            number = "";
            sign = true;
        }
        public virtual void Add(KeyNumber key) { }
        
        public abstract IEnumerator GetEnumerator();
        
        public abstract void convertToString();

        public abstract void GetNumber();
    }


    public class OctalNumber : Number
    {
        public override void Add (KeyNumber key)
        {
            keys.Add(key);
        }
        public override IEnumerator GetEnumerator()
        {
            return keys.GetEnumerator();
        }

        public override void convertToString()
        {
            foreach (keyOctal k in keys)
            {
                if (k.KeyValue <= k.MaxValue)
                {
                    this.number = this.number + k.Key;
                }
            }
        }

        public override void GetNumber()
        {
            char input = char.Parse(Console.ReadLine());
            

            while (input != 'X')
            {
                //Console.WriteLine("key entered {0}    {1}", input,k.Key);

                keys.Add(new keyOctal(input, KeyType.Number));
                input = char.Parse(Console.ReadLine());
            }
            this.convertToString();
            // Console.WriteLine(this.number);

        }
    }

    public class BinaryNumber : Number
    {
        public override void Add(KeyNumber key)
        {
            keys.Add(key);
        }
        public override IEnumerator GetEnumerator()
        {
            return keys.GetEnumerator();
        }
        public override void convertToString()
        {
            foreach (keyBinary k in keys)
            {
                if (k.KeyValue <= k.MaxValue)
                {
                    this.number = this.number + k.Key;
                }
            }

           // Console.WriteLine("{0}", this.number);
        }

        public override void GetNumber()
        {
            char input = char.Parse(Console.ReadLine());
            int i = 0;

            while (input != 'X')
            {
                //Console.WriteLine("key entered {0}    {1}", input,k.Key);
                
                keys.Add(new keyBinary(input, KeyType.Number));
                input = char.Parse(Console.ReadLine());
            }
            this.convertToString();
           // Console.WriteLine(this.number);
          
        }
    }

    public abstract class Conversion
    {
        public Number Source;

        public abstract void ToBinary();
        public abstract void ToDecimal();
        public abstract void ToHexaDecimal();
        public abstract void ToOctal();
    }

    public class BinaryConversion : Conversion
    {
        public BinaryConversion (BinaryNumber B1)
        {
            this.Source = B1;
        }
        public override void ToBinary()
        {
            throw new NotImplementedException();
        }

        public override void ToDecimal()
        {
            throw new NotImplementedException();
        }

        public override void ToHexaDecimal()
        {
            throw new NotImplementedException();
        }

        public override void ToOctal()
        {
            int i = 0;
            double decimalNumber = 0;
            string b = this.Source.number;
            char[] a = b.ToCharArray();
            for (i = 0; i < a.Length; i++)
            {
                double c = (double)Char.GetNumericValue(a[a.Length - i - 1]);
               // Console.WriteLine(c);
                decimalNumber = decimalNumber + c * Math.Pow(2, i);
            }
           // Console.WriteLine(decimalNumber);
            int k = 1;
            int j;
            int n;
            int oc = 0;
            n = (int)decimalNumber;

            for (j = n; j > 0; j = j / 8)
            {
                oc = oc + (j % 8) * k;
                k = k * 10;
                n = n / 10;
                //octalNumber = n.ToString();
            }
            Console.WriteLine(oc);
        }
    }


    public class OctalConversion : Conversion
    {
        public OctalConversion (OctalNumber oN)
        {
            this.Source = oN;
        }
        public override void ToBinary()
        {
            int deci = 0;
            string n = this.Source.number;
            int num = Convert.ToInt32(n);
            int b_ase = 1;

            int temp = num;
            int remainder;
            string bin = string.Empty;
            while (temp > 0)
            {
                int last_digit = temp % 10;
                temp = temp / 10;
                deci += last_digit
                      * b_ase;

                b_ase = b_ase * 8;
            }


            while (deci > 0)
            {
                remainder = deci % 2;
                deci /= 2;
                bin = remainder.ToString() + bin;


            }
            Console.WriteLine(bin);

        }



        public override void ToDecimal()
        {
            throw new NotImplementedException();
        }

        public override void ToHexaDecimal()
        {
            throw new NotImplementedException();
        }

        public override void ToOctal()
        {
            throw new NotImplementedException();
        }
    }
    public class BinaryOperations
    {
        public BinaryNumber BinNum1;
        public BinaryNumber BinNum2;

        public BinaryOperations(BinaryNumber B1, BinaryNumber B2)
        {
            this.BinNum1 = B1;

            this.BinNum2 = B2;
        }


        public BinaryNumber Addition()
        {
            bool carry = false;
            // char sum = '0'; ;
            char[] a = this.BinNum1.number.ToCharArray();
            char[] b = this.BinNum2.number.ToCharArray();
            int len;
            if (a.Length > b.Length)
            {
                len = a.Length;
            }
            else
            {
                len = b.Length;
            }
            if (a[0] == 1 && b[0] == 1)
            {
                len = len + 1;
            }
            char[] c = new char[len];
            for (int i = 0; i < len; i++)
            {
                int aIndex = a.Length - 1 - i;
                int bIndex = b.Length - 1 - i;
                char bitA;
                char bitB;
                bitA = aIndex >= 0 ? a[aIndex] : '0';
                bitB = bIndex >= 0 ? b[bIndex] : '0';
                if (carry == false)

                {

                    if ((bitB == '1') && (bitA == '1'))
                    {
                        c[c.Length - 1 - i] = '0';
                        carry = true;
                    }
                    else if ((bitB == '0') && (bitA == '0'))
                    {
                        c[c.Length - 1 - i] = '0';
                        carry = false;
                    }
                    else if ((bitB == '1') && (bitA == '0'))
                    {
                        c[c.Length - 1 - i] = '1';
                        carry = false;
                    }
                    else if ((bitB == '0') && (bitA == '1'))
                    {
                        c[c.Length - 1 - i] = '1';
                        carry = false;
                    }
                }
                else
                {
                    if ((bitA == '1') && (bitB == '1'))
                    {
                        c[c.Length - 1 - i] = '1';
                        carry = true;
                    }
                    else if ((bitA == '0') && (bitB == '1'))
                    {
                        c[c.Length - 1 - i] = '1';
                        carry = true;
                    }
                    else if ((bitA == '1') && (bitB == '0'))
                    {
                        c[c.Length - 1 - i] = '1';
                        carry = true;
                    }
                    else if ((bitA == '0') && (bitB == '0'))
                    {
                        c[c.Length - 1 - i] = '1';
                        carry = false;
                    }
                }

            }

            string s = new string(c);
            
            BinaryNumber BinResult = new BinaryNumber();
            BinResult.number = s;

            if (BinNum1.sign == false && BinNum2.sign == false)
            {
                BinResult.sign = false;
            }
            Console.WriteLine(BinResult.number);
            
            return BinResult;

            

        }

        public BinaryNumber Subtraction()
        {
            char[] min = BinNum1.number.ToCharArray();
            char[] sub = BinNum2.number.ToCharArray();
            
            int len = min.Length > sub.Length ? min.Length : sub.Length;
            int[] ans = new int[len];
            string result = "";
            bool borrow = false;
            for (int i = len - 1; i >= 0; --i)
            {
                ans[i] = Convert.ToInt32(min[i]) - Convert.ToInt32(sub[i]);
                if (borrow == true)
                {
                    ans[i] = ans[i] - 1;
                }
                if (ans[i] == -1)
                {
                    ans[i] = ans[i] + 2;
                    borrow = true;
                }
            }


            for (int i = 0; i < len; i++)
            {
                result = result + ans[i];
            }
            BinaryNumber BinResult = new BinaryNumber();
            BinResult.number = result;

            Console.WriteLine(BinResult.number);

            return BinResult;
        }

    }
   public class Operation
    {

    }

    public class Screen
    {
        keyOperator KeyOp;
        public keyOperator PrintOperators()
        {
            Console.WriteLine("Key:?           HELP               ");
            Console.WriteLine("Key:(ESCAPE)    QUIT      ");
            Console.WriteLine("Key:M           DECIMAL  CONVERSION");
            Console.WriteLine("Key:I           BINARY  CONVERSION");
            Console.WriteLine("Key:O           OCTAL   CONVERSION");
            Console.WriteLine("Key:H           HEXADECIMAL  CONVERSION");
            Console.WriteLine("Key:+           ADD  OPERATOR");
            Console.WriteLine("Key:--          MINUS  OPERATOR");
            Console.WriteLine("Key:*           MULTIPLY  OPERATOR");
            Console.WriteLine("Key:/           DIVIDE  OPERATOR");
            Console.WriteLine("Key:%           MODULE  OPERATOR");
            Console.WriteLine("Key:&           AND  OPERATOR");
            Console.WriteLine("Key:|           OR  OPERATOR");
            Console.WriteLine("Key:^           XOR  OPERATOR");
            Console.WriteLine("Key:=           EQUALS  OPERATOR");
            Console.WriteLine("Key:(back)      BACK  OPERATOR");
            Console.WriteLine("Key:(space)     ALL CLEAR  OPERATOR");
            Console.WriteLine("Key:X          CLEAR THIS  OPERATOR");
            Console.WriteLine("Key:-          NEGATION  SIGN");
            Console.WriteLine("Choose operator .........");

            char Operator = char.Parse(Console.ReadLine());

            KeyType kT; // = KeyType.Operator;
            KeyOp = new keyOperator(Operator,KeyType.None);
            KeyOp.Key = Operator;
           
            if (Operator == 'M' | Operator == 'I' | Operator == 'O' | Operator == 'H')
            {
                
                KeyOp.keyType = KeyType.Conversion;
            } 
                
            else
            { 
                KeyOp.keyType = KeyType.Operator;
            }
        
        return KeyOp;

        }

        public NumberType PrintNumberType()
        {
            Console.WriteLine("Key:D           DECIMAL");
            Console.WriteLine("Key:B           BINARY");
            Console.WriteLine("Key:O           OCTAL");
            Console.WriteLine("Key:H           HEXADECIMAL");
            Console.WriteLine("Choose Number Type .........");

            char NumType = char.Parse(Console.ReadLine());
            switch (NumType)
            {
                case 'D': return NumberType.Decimal;
                case 'B': return NumberType.Binary;
                case 'O': return NumberType.Octal;
                case 'H': return NumberType.Hexadecimal;
                default: return NumberType.Invalid;

            }
           
        }

        //public  Number GetNumber(List<KeyNumber> k, Number N)
        //{
        //    char input = char.Parse(Console.ReadLine());
        //    int i = 0;

        //    while (input != 'X')
        //    {
        //        //Console.WriteLine("key entered {0}    {1}", input,k.Key);
        //        k.Add(new KeyNumber(input, KeyType.Number));
        //        input = char.Parse(Console.ReadLine());
        //    }
        //    N.convertToString();
        //    Console.WriteLine(N.number);
        //    return N;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            //keyBinary k1 = new keyBinary('1', KeyType.Number);
            //keyBinary k2 = new keyBinary('0', KeyType.Number);
            //keyBinary k3 = new keyBinary('1', KeyType.Number);
            //keyBinary k4 = new keyBinary('0', KeyType.Number);

            //BinaryNumber b1 = new BinaryNumber();
            //b1.Add(k1);
            //b1.Add(k2);
            //b1.Add(k3);
            //b1.Add(k4);

            //b1.convertToString();

            //BinaryConversion BC1 = new BinaryConversion(b1);
            //BC1.ToOctal();


            //keyOctal kO1 = new keyOctal('5', KeyType.Number);
            //keyOctal kO2 = new keyOctal('6', KeyType.Number);

            //OctalNumber O1 = new OctalNumber();
            //O1.Add(kO1);
            //O1.Add(kO2);
            //O1.convertToString();

            //OctalConversion OC1 = new OctalConversion(O1);
            //OC1.ToBinary();

            //keyBinary k5 = new keyBinary('1', KeyType.Number);
            //keyBinary k6 = new keyBinary('0', KeyType.Number);
            //keyBinary k7 = new keyBinary('0', KeyType.Number);
            //keyBinary k8 = new keyBinary('0', KeyType.Number);

            //BinaryNumber b2 = new BinaryNumber();
            //b2.Add(k5);
            //b2.Add(k6);
            //b2.Add(k7);
            //b2.Add(k8);

            //b2.convertToString();

            //BinaryOperations BO1 = new BinaryOperations(b1, b2);
            //BO1.Subtraction();

            Screen Screen1 = new Screen();
            keyOperator KeyOp = Screen1.PrintOperators();
            NumberType NumType = Screen1.PrintNumberType();
            Console.WriteLine("{0}",KeyOp.Key);


            switch (KeyOp.keyType)
            {
                case KeyType.Conversion:
                {
                    switch (NumType)
                    {
                        case NumberType.Binary:

                                Console.WriteLine("Enter Binary Number. (press Enter after each digit. Enter 'X' to stop)");

                                BinaryNumber BN = new BinaryNumber();
                                BN.GetNumber();
                                BinaryConversion BC = new BinaryConversion(BN);
                                if (KeyOp.Key == 'M')
                                {
                                    BC.ToDecimal();
                                }
                                else if (KeyOp.Key == 'I')
                                {
                                    Console.WriteLine("cannot convert binary to binary");
                                }
                                else if (KeyOp.Key == 'O')
                                {
                                    BC.ToOctal();
                                }
                                else if (KeyOp.Key == 'H')
                                {
                                    BC.ToHexaDecimal();
                                }
                                break;
                            case NumberType.Octal:

                                Console.WriteLine("Enter Octal Number. (press Enter after each digit. Enter 'X' to stop)");

                                OctalNumber ON = new OctalNumber();
                                ON.GetNumber();
                                OctalConversion OC = new OctalConversion(ON);
                                if (KeyOp.Key == 'M')
                                {
                                    OC.ToDecimal();
                                }
                                else if (KeyOp.Key == 'I')
                                {
                                    OC.ToBinary();
                                }
                                else if (KeyOp.Key == 'O')
                                {
                                    OC.ToOctal();
                                }
                                else if (KeyOp.Key == 'H')
                                {
                                    OC.ToHexaDecimal();
                                }
                                break;

                        }
                        break;
                }
                case KeyType.Operator:
                {

                        switch (NumType)
                        {
                            case NumberType.Binary:

                                Console.WriteLine("Enter 1st Binary Number. (press Enter after each digit. Enter 'X' to stop");

                                BinaryNumber BN1 = new BinaryNumber();
                                BN1.GetNumber();


                                Console.WriteLine("Enter 2nd Binary Number (press Enter after each digit. Enter 'X' to stop");
                                BinaryNumber BN2 = new BinaryNumber();
                                BN2.GetNumber();
                                BinaryOperations BO = new BinaryOperations(BN1, BN2);
                                //Console.WriteLine("{0}", BN1.number);
                                //Console.WriteLine("{0}", BN2.number);
                                if (KeyOp.Key == '+')
                                {
                                    BO.Addition();
                                }
                                else if (KeyOp.Key == '-')
                                {
                                    BO.Subtraction();
                                }
                                else if (KeyOp.Key == '*')
                                {
                                    Console.WriteLine("Not implemented");
                                }
                                else if (KeyOp.Key == '/')
                                {
                                    Console.WriteLine("Not implemented");
                                }


                                break;
                            default:
                                break;
                        }
                        break;
                }

            }
        }
    }


}  


