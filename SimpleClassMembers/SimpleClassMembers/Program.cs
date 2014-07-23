using System;

namespace SimpleClassMembers
{
	enum Gender
	{
		Male,
		Female,
		Other
	}

	class Person
	{
		private String Name;
		private Gender Gender;

		public void SetName(String name)
		{
			if (null != name || 0 != name.Trim().Length)
			{
				Name = name;
			}
		}
		public String GetName()
		{
			return Name;
		}
		public void SetGender(Gender gender)
		{
			Gender = gender;
		}
		public Gender GetGender()
		{
			return Gender;
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Person p = new Person ();
			Console.Write ("What is your name? ");
			p.SetName (Console.ReadLine());//<-- set name here itself
			Console.Write ("What is your gender[m, f, o]? ");
			string s = Console.ReadLine ().ToLower();
			Gender g = Gender.Male;//<-- by default its Male
			if ("o".Equals (s)) {
				g = Gender.Other;
			} else if ("f".Equals (s)) {
				g = Gender.Female;
			}
			p.SetGender (g);//<-- set gender here
			Console.WriteLine ();
			Console.WriteLine ("Name: {0}, Gender: {1}", p.GetName(), p.GetGender());
			Console.WriteLine ();
			Console.Write ("Press any key to exit ...");
			Console.ReadKey ();
		}
	}
}
