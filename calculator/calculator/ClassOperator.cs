using System;
namespace calculator
{
    public abstract class Operation
    {
        
        public abstract string addition(Number N1, Number N2);
        public abstract string substraction(Number N1, Number N2);
        public abstract string multiplication(Number N1, Number N2);
        public abstract string division(Number N1, Number N2);



    }



    public class BinaryOperations:Operation
    {
      


        public override string addition(Number N1, Number N2)
        {
            bool carry = false;
            // char sum = '0'; ;
            char[] a = N1.number.ToCharArray();
            char[] b = N2.number.ToCharArray();
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

           


            return s;



        }

        public override string division(Number N1, Number N2)
        {
            throw new NotImplementedException();
        }

        public override string multiplication(Number N1, Number N2)
        {
            throw new NotImplementedException();
        }

       

        public override string substraction(Number N1, Number N2)
        {
            char[] min = N1.number.ToCharArray();
            char[] sub = N2.number.ToCharArray();

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
            return result;
        }

    }
}