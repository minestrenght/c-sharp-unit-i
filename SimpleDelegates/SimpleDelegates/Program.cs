using System;

namespace SimpleDelegates
{
	class MainClass
	{
		//delegate signature must match with the methods to be invoked.
		public delegate void BuyOne ();

		//matches the signature same as delegate
		public void BuyApple()
		{
			Console.WriteLine ("You bought apple");
		}

		//this will also do
		public void BuyBanana()
		{
			Console.WriteLine ("You bought banana");
		}

		//can't invoke this one ! with the above delegate
		public void BuyMangoes(byte howMuch)
		{
			Console.WriteLine ("You bought {0} mangoe(s)", howMuch);
		}

		//okay, let's make one more
		public delegate void BuyMore (byte i);

		public static void Main (string[] args)
		{
			MainClass mc = new MainClass ();

			//long hand coding, to use delegates there is no need to create object of class
			BuyOne bo = new BuyOne (mc.BuyApple);//<-- runtime binding to invoke method
			bo.Invoke ();//<-- invoking method, but don't know which at complie time

			//short hand coding
			bo = mc.BuyBanana;//<-- runtime binding, anything after `=` is always at run time.
			bo ();//<-- invoke here, still don't know which method

			//bo = mc.BuyMangoes;//<-- ERROR!
			BuyMore bm = mc.BuyMangoes;//<-- look no parameters !

			Console.Write ("How many mangoes you want to buy? : ");
			byte c = Convert.ToByte (Console.ReadLine());//<-- ask here

			bm (c);//<-- hey! datz the parameter

			Console.WriteLine ("Press any key to exit ...");
			Console.ReadKey ();
		}
	}
}
