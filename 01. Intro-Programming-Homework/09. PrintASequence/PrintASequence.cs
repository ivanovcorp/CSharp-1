using System;
/*Problem 6. Print a Sequence
------------------------------------------------------------------------------------------
Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
*/ 

class PrintASequence
{
	static void Main()
	{
		int number = 2;
		for (int i = 0; i < 10; i++)
		{			
            if (i % 2 == 0)
            {
                Console.Write(" {0},", number);
            } 
            else
            {
                Console.Write(" -{0},", number);
            }
			number++;
		}
		Console.WriteLine();
	}
}