using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ForLoopDemo
{
	internal class StarPrint
	{

		// StarPrint Print Updated
		public int num { get; set; }

		private void GetNumberFromUser()
		{
			Console.WriteLine("Enter Any Number");
			num = Convert.ToInt32(Console.ReadLine());
		}

		public void StarPattern()
		{
			GetNumberFromUser();

			for (int i =1 ; i <= num; i++)
			{
				for (int j = 1; j <= i;j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}

		public static void StarPrint2()
		{
			//StarPrint starPrint = new StarPrint();
			//starPrint.StarPattern();

			StarPrint3();
		}

		public int num2 { get; set; }

		public void GetNumberFromUser2()
		{	
			Console.WriteLine("Enter Any Number");
			num2 = Convert.ToInt32(Console.ReadLine());
		}

		public static void StarPrint3()
		{
			StarPrint starPrint=new StarPrint();
			starPrint.GetNumberFromUser2();

			for (int i = starPrint.num2; i >= 1; i--)
			{
				for(int j=1; j<=i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}


		// Static And NonStatic Function

		public void Nonstatic()
		{
			Static();       // Call Function Static To Nonstatic
			Nonstatic1();  // Call Function Nonstatic To Nonstatic
		}

		public static void Static()
		{
			StarPrint starPrint = new StarPrint();
			starPrint.Nonstatic();                 // Call Function Nonstatic To Static        

			Static1();                             // Call Function Static To Static

		}

		public void Nonstatic1()
		{
			Console.WriteLine("HELLO I AM NONSTATIC1 FUNCTION");
		}

		public static void Static1()
		{
			StarPrint starPrint1 = new StarPrint();
			starPrint1.Nonstatic();                   // Call Function Nonstatic To Static1

			Static();                                 // Call Function Static To Static1

			StarPrint starPrint2 = new StarPrint();
			starPrint2.Nonstatic1();                  // Call Function Nonstatic1 To Static1
		}





		// Print Character Star *

		public static void Pattern1()
		{
			Console.WriteLine("Enter Number Of Rows");
			int rows=Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Number Of Columns");
			int columns = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(columns+ " x " +rows);
			Console.WriteLine();

			for (int i = 1; i <=rows; i++)
			{
				for(int j=1; j <=columns; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();

			}
		}

		// Print Character ABCD,ABCD,.....,ABCD

		public static void Pattern2()
		{
			Console.WriteLine("Enter Number Of Rows");
			int rows=Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Number Between 1 To 26");
			int columns=Convert.ToInt32(Console.ReadLine());

			for(int i=1; i <= rows; i++)
			{
				for(int j=1;j<=columns; j++)
				{
					Console.Write(" "+Convert.ToChar(64+j)) ;
				}
				Console.WriteLine();
			}
		}

		// Print Character AAAAA,BBBBB,......,DDDDD

		public static void Pattern3()
		{
			Console.WriteLine("Enter Number Between 1 To 26");
			int rows=Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Number Of Columns");
			int columns = Convert.ToInt32(Console.ReadLine());

			for(int i = 1; i <= rows; i++)
			{
				for(int j = 1; j <= columns; j++)
				{
					Console.Write(" "+Convert.ToChar(64 + i));
				}
				Console.WriteLine();
			}
		}

		// Print Reverse Character DCBA,DCBA,......,DCBA

		public static void Pattern4()
		{
			Console.WriteLine("Enter Number Of Rows");
			int rows = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Number Between 1 To 26");
			int columns = Convert.ToInt32(Console.ReadLine());

			for(int i = 1; i <= rows; i++)
			{
				for(int j = columns; j >= 1; j--)
				{
					Console.Write(" "+Convert.ToChar(64 + j));
				}
				Console.WriteLine();
			}
		}

		// Print Reverse Character DDDD,CCCC,....,AAAA

		public static void Pattern5()
		{
			Console.WriteLine("Enter Number Between 1 To 26");
			int rows=Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Number Columns");
			int columns=Convert.ToInt32(Console.ReadLine());

			for(int i = columns; i >= 1; i--)
			{
				for(int j = 1; j <= columns; j++)
				{
					Console.Write(" " + Convert.ToChar(64 + i));
				}
				Console.WriteLine() ;
			}
		}

		// Print Number 123,.....,10

		public static void Pattern6()
		{
			Console.WriteLine("Enter Number Of Rows");
			int rows= Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Number Of Columns");
			int columns = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enetr Any Number");
			int q = Convert.ToInt32(Console.ReadLine());

			for(int i = 1; i <= rows; i++)
			{
				for(int j = 1; j <= columns; j++)
				{
					Console.Write(q++);
				}
				Console.WriteLine();
			}
			

		}

		// Print Character ABCD,......,GHIJ

		public static void Pattern7()
		{
			Console.WriteLine("Enter Number Of Rows");
			int rows=Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Number Of Columns");
			int columns= Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Number Between 1 To 26");
			int w=Convert.ToInt32(Console.ReadLine());

			for(int i = 1; i <= rows; i++)
			{
				for(int j=1;j<=columns; j++)
				{
					Console.Write(Convert.ToChar(64 + w++));
				}
				Console.WriteLine();
			}
		}
	}
}
