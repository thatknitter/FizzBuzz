using System;
using System.Text;

namespace FizzBuzz
{
	class Program
	{
		public static void Main (string[] args)
		{

			//Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” 
			//instead of the number and for the multiples of five print “Buzz”. For numbers which are multiples of both three 
			//and five print “FizzBuzz”.
		
			Console.WriteLine ("Let's FizzBuzz!");
			//for i from 1 to 100
			for (int i = 1; i <= 100; i++) {
				Console.WriteLine (FizzBuzz(i));
			}
			//if multiple of 3 print Fizz
			//if multiple of 5 print Buzz
			//if multiple of both 3 and 5 print FizzBuzz
			Console.WriteLine ("Press any key to exit...");
			Console.ReadKey();
		}

		public static string FizzBuzz(int i) {
			StringBuilder sb = new StringBuilder ();
			if (i % 3 == 0) {
				sb.Append ("Fizz");
			}
			if (i % 5 == 0) {
				sb.Append ("Buzz");
			}
			if (sb.Length == 0) {
				sb.Append (i);
			}
			return sb.ToString ();
		}
	}
}
