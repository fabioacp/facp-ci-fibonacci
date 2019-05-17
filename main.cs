using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		var terms = FibonacciTerms(15);
		
		foreach(var item in terms)
		{
			Console.WriteLine(item);
		}
	}
	
	public static List<long> FibonacciTerms(int numberOfTerms)
	{	
		long firstNumber = 0;
		long secondNumber = 1;
		
		long nextNumber;
		var terms = new List<long>() {firstNumber, secondNumber };
		
		while(numberOfTerms != terms.Count)
		{
			nextNumber = firstNumber + secondNumber;
			terms.Add(nextNumber);
			firstNumber = secondNumber;
			secondNumber = nextNumber;
		}
		
		return terms;
	}
}