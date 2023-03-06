using ForLoopDemo;
using System.Globalization;

public class program
{

	public static void Main()
	{
		//PrintNumber();
		//NestedLoop();
		//StarPrint.Pattern1();
		//StarPrint.Pattern2();
		//StarPrint.Pattern3();
		//StarPrint.Pattern4();
		//StarPrint.Pattern5();
		//StarPrint.Pattern6();
		//StarPrint.Pattern7();

		StarPrint.Static1();                   // Static Function Call From Starprint Class

		StarPrint starPrint3 = new StarPrint(); // Nonstatic Function Call From Starprint Class
		starPrint3.Nonstatic1();
	}

	public static void PrintNumber()
	{
		// 1. Print Number 1 To 10
		
		
		        //Initialization  //Condition      //Inc/Dec
		for(int        i=1;          i <=10;           i++)
		{
			Console.Write(" "+i);
		}

		// 2.Print Number 5,10,15,.....,50

		for(int i=5; i <= 50; i = i + 5)
		{
			Console.Write(" "+i);
		}

		// 3. Print Reverse Number Between 20 To 1

		for (int i = 20; i >= 1; i--)
		{
			Console.Write(" "+i);
		}

		// 4.Print Number 6,12,18,......60
		for(int i = 6; i <= 60; i = i + 6)
		{
			Console.Write(" "+i);
		}

		//5. Print Reverse Number 10,8,6,....,1
		for(int i = 10; i >= 0; i = i - 2)
		{
			Console.Write(" "+i);
		}
	}

	public static void NestedLoop()
	{
		// Print Number 54321
		for (int i = 1; i <= 4; i++) //Rows
		{
			for (int j = 5; j >= 1; j--) //Columns
			{
				Console.Write(j);
			}
			Console.WriteLine();
		}

		// Print Number 12345 

		for(int m = 1; m <= 5; m++)
		{
			for(int n = 1; n <= 5; n++)
			{
				Console.Write(n);
			}
			Console.WriteLine();
		}

		// Print Number 11111,22222,....55555

		for(int l = 1; l <= 5; l++)
		{
			for(int m = 1; m <= 5; m++)
			{
				Console.Write(l);
			}
			Console.WriteLine();
		}

		// Print Number 55555,44444,....,11111

		for(int a = 5; a >= 1; a--)
		{
			for(int b = 1; b <= 5; b++)
			{
				Console.Write(a);
			}
			Console.WriteLine();
		}
	}

}
