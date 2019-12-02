using System;
namespace calculator
{
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
			Console.WriteLine("{0}", KeyOp.Key);

			/* What's polymorphism? Polymorphism allows a derived type (class)
             * to become another type (either abstract class or interface). */
			switch (KeyOp.keyType)
			{
				/* In your case, you are repeating a lot of codes and declaring
                 * various variables as their concrete types. For example,
                 * BinaryNumber BN that sets the BinaryNumber. The BN var can be
                 * moved up with the Number data type. This allows you to rescope
                 * your codes that perform data on BN somewhere else. The advantage
                 * is that you are now able to combine all the similar codes, making
                 * the stuff more reusable. I'm going to stop here. */
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
