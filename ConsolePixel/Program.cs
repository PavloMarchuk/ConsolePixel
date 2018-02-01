using System;
using System.IO;
using System.Net;

namespace ConsolePixel
{
    class Program
    {		
        static void Main(string[] args)
        {
			Console.WriteLine("побочная диагональ прямоугольной матрицы");
			int n = 10;
			int m = 20;
			Print(PixelFunc(n, m), n, m);
			

			n = 20;
			m = 10;
			Print(PixelFunc(n, m), n ,m );

			Console.ReadKey(); 
		}

		

		 static int[,] PixelFunc(int n, int m)
		{			
			int[,] arr = new int[n, m]; 

			double index =((double) n) / (double)m;
			if ((double)n / (double)m < 1)
			{
				index = ((double) (n-1)) / (double)m;
			}
			else
			{
				index = ((double)(n +1)) / (double)m;
			}

			for (int h = 0; h < n; h++)
			{
				for (int l = 0; l < m; l++)
				{
					if ((l + (h / index)) < m - 1)
					{
						arr[h, l] = 1;
					}
						
					else
					{
						break;
					}						
				}				
			}
			return arr;
		}

		static void  Print(int[,] arr, int n, int m)
		{
			

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.Write(arr[i, j]);
				}
				Console.WriteLine();
			}
		}

    }
}
