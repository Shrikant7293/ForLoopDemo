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
