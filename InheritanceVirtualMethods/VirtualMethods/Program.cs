using System;

namespace InheritanceVirtualMethods
{
	class Parent
	{
		public virtual void Greet()//<-- virtual keyword required, if want to allow overriding
		{
			Console.WriteLine ("This is parent !");
		}
	}

	class Child: Parent
	{
		public override void Greet()//<-- inform overriding, else it won't
		{
			base.Greet ();//<-- do what parent wants to do
			//base keyword gives reference of the parent class instance
			Console.WriteLine ("This is child !");//<-- i'll do my mine
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			new Parent ().Greet();//<-- of-course parent
			Console.WriteLine ();
			new Child ().Greet ();//<-- from child
			Console.WriteLine ();
			Console.Write("Press any key to exit ...");
			Console.ReadKey ();
		}
	}
}
