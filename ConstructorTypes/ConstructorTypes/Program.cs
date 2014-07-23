using System;

namespace ConstructorTypes
{
	class MyClass
	{
		static MyClass ()
		{
			Console.WriteLine ("Static constructor");
		}

		public MyClass ()
		{
			Console.WriteLine ("Default constructor");
		}

		public MyClass (char c)
		{
			Console.WriteLine ("Parameter constructor");
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			new MyClass ('A');
			for (byte i = 1; 3 >= i; i++) {
				new MyClass ();
			}
			Console.Write ("Press any key to exit ...");
			Console.ReadKey ();
		}
	}
}
