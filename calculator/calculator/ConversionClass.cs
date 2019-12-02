using System;
namespace calculator
{
    public abstract class Conversion
    {
        
        private Number _Source;

        public abstract string ToBinary();
        public abstract string ToDecimal();
        public abstract string ToHexaDecimal();
        public abstract string ToOctal();

        public Conversion (Number B1)
        {
            this._Source = B1;
        }

        public Number Source
        {
            get
            {
                return this._Source;
            }
        }
    }

    public class BinaryConversion : Conversion
    {
        public BinaryConversion(BinaryNumber B1):base(B1)
        {
            
        }
        /* Binary to Binary: simply clone or return the original number, e.g.
         * "Source". */
        public override string ToBinary()
        {
            return Source.number;
        }

        public override string ToDecimal()
        {
            throw new NotImplementedException();
        }

        public override string ToHexaDecimal()
        {
            throw new NotImplementedException();
        }

        public override string ToOctal()
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
            /* An app cannot consume an output in the Console.
             * Consider returning oc.
             */
            Console.WriteLine(oc);
            return Convert.ToString(oc);
        }
    }


    public class OctalConversion : Conversion
    {
        public OctalConversion(OctalNumber oN):base(oN)
        {
            
        }
        public override string ToBinary()
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
            /* Return */
            Console.WriteLine(bin);
            return bin;

        }



        public override string ToDecimal()
        {
            throw new NotImplementedException();
        }

        public override string ToHexaDecimal()
        {
            throw new NotImplementedException();
        }

        /* Octal to Octal should be unchanged */
        public override string ToOctal()
        {
            return Source.number;
        }
    }

}
