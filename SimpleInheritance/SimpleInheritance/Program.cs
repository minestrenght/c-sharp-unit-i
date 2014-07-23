using System;

namespace SimpleInheritance
{
	class Parent
	{
		public void AboutMe ()
		{
			Console.WriteLine ("I am Human !");
		}
	}

	class Child: Parent
	{
		//nothing in here
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			new Parent ().AboutMe ();
			new Child ().AboutMe ();
			Console.Write ("Press any key to exit ...");
			Console.ReadKey ();
		}
	}
}
