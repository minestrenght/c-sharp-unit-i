using System;

namespace GetSetProperties
{
	class Employee
	{
		private byte _Age;//<-- don't show out-side class
		private string _Name;

		//read-write property
		public string Name
		{
			get
			{
				Console.WriteLine ("Inside get, Name is: {0}", _Name);
				return _Name;
			}

			set
			{
				Console.WriteLine ("Inside set, Old Name is: {0}, New Name: {1}", _Name, value);
				_Name = value;
			}
		}

		//readonly property
		public byte Age
		{
			get
			{
				Console.WriteLine ("Inside get, Age is: {0}", _Age);
				return _Age;
			}
		}

		public Employee(String name, byte age)
		{
			_Name = name;
			_Age = age;
		}
	}

	class Student
	{
		//short hand way, if you don't want any restrictions, works with .Net 4.0 and above
		public string Name
		{
			get;
			set;
		}
		//Note: no extra private members used here !
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Employee e = new Employee ("Adam Smith", 36);
			Console.WriteLine ("Name: {0}, Age: {1}", e.Name, e.Age);
			Console.WriteLine ();
			e.Name = "Will Smith";//<-- works fine
			//e.Age = 38;//<-- Ooops! ERROR **
			Console.WriteLine ("Name: {0}, Age: {1}", e.Name, e.Age);
			Console.WriteLine ();
			Student s = new Student ();
			s.Name = "Humpty Dumpty";
			Console.WriteLine ("Student Name: {0}", s.Name);
			Console.WriteLine ();
			Console.WriteLine ("Press any key to exit ...");
			Console.ReadKey ();
		}
	}
}
