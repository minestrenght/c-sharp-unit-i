using System;

namespace SimpleEventDelegate
{
	class Car
	{
		public delegate void Status(string state);
		public event Status Start;
		public event Status Stop;

		public void StartEngine ()
		{
			this.Start("started");
		}
		public void StopEngine ()
		{
			this.Stop("stopped");
		}
	}
	class WatchMen
	{
		public void Monitor (string state)
		{
			Console.WriteLine("Car engine: {0}", state);
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			WatchMen wm = new WatchMen();
			Car c = new Car();
			c.Start += wm.Monitor;
			c.Stop += wm.Monitor;
			c.StartEngine();
			c.StopEngine();
		}
	}
}
