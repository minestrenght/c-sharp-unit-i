using System;

namespace Arrays
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//single dimension array
			char[] letters = new char[2];//no default values
			letters[0] = 'd';
			letters[1] = '9';
			Console.WriteLine ("Array values: {0}, {1}", letters[0], letters[1]);

			bool[] flags = {true, false, true};//default values
			Console.Write("Flag values: ");
			foreach(bool b in flags) {
				Console.Write("{0}, ", b);
			}
			Console.WriteLine();

			//multi-dimensional array
			byte[,] by = new byte[2, 3];//no values
			Console.WriteLine("Total elements in array: {0}", by.Length);
			Console.WriteLine("Size in 1st dim: {0}", by.GetLength(0));
			by[0, 1] = 8;//assign values
			Console.WriteLine("Elements in 1st dim: {0}, {1}", by[0,0], by[0,1]);
			Console.WriteLine();

			char[,] vowels = {
				{'a', 'e'},
				{'i', 'o'},
				{'u', ' '}
			};
			Console.Write("Vowels are: ");
			foreach(char c in vowels) {
				Console.Write("{0}, ", c);
			}
		}
	}
}
