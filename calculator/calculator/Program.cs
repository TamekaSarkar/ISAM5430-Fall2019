using System;

namespace calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Screen Screen1 = new Screen();
            keyOperator KeyOp = Screen1.GetOperator();
            NumberType NumType = Screen1.GetNumType();
            Console.WriteLine("{0}", KeyOp.Key);

     
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
                                Console.WriteLine(BN.number);
                                BinaryConversion BC = new BinaryConversion(BN);
                                if (KeyOp.Key == 'M')
                                {
                                   Console.WriteLine(BC.ToDecimal());
                                }
                                else if (KeyOp.Key == 'I')
                                {
                                   Console.WriteLine(BC.ToBinary());
                                }
                                else if (KeyOp.Key == 'O')
                                {
                                   Console.WriteLine(BC.ToOctal());
                                }
                                else if (KeyOp.Key == 'H')
                                {
                                   Console.WriteLine(BC.ToHexaDecimal());
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
                                BinaryOperations BO = new BinaryOperations();
                                //Console.WriteLine("{0}", BN1.number);
                                //Console.WriteLine("{0}", BN2.number);
                                if (KeyOp.Key == '+')
                                {
                                    BO.addition(BN1,BN2);
                                }
                                else if (KeyOp.Key == '-')
                                {
                                    BO.substraction(BN1,BN2);
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
