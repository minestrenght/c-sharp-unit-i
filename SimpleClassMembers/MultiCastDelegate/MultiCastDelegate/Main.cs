using System;

namespace MultiCastDelegate
{
	class MainClass
	{
		public delegate void BuyOne ();

		public void BuyApple ()
		{
			Console.WriteLine ("You bought apple");
		}

		public void BuyBanana ()
		{
			Console.WriteLine ("You bought banana");
		}

		public static void Main (string[] args)
		{
			MainClass mc = new MainClass();
			BuyOne bo = mc.BuyApple;
			bo();
			Console.WriteLine ("-----------");
			bo += mc.BuyBanana;//<-- bind one more
			bo();
			Console.WriteLine ("-----------");
			bo -= mc.BuyApple;//<-- unbind one
			bo();
			Console.ReadKey();
		}
	}
}
