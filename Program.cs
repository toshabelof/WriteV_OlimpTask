using System;
					
public class Program
{
	public static void Main()
	{	
		int count = 4;
		int row = 7;
		
		for (int i = 0; i < count; i++)
		{
			for (int j = 0; j < row; j++)
			{
				if(i >= j)
				{
					if (i == j)
					{
						Console.Write("*");
					}
					else 
					{
						Console.Write(" ");
					}
				}
				else
				{
					if (i + j == row - 1)
					{
						Console.Write("*");
					}
					else 
					{
						Console.Write(" ");
					}
				}
			}
			Console.WriteLine(" ");
			
		}
	}
}
