using System;


namespace Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] courses = new string[] {"C# Yazılım Geliştirme Kampı",
				"Programlamaya Başlangıç Kursu", "Python Kursu"};


			for (int i = 0; i < courses.Length; i++)
			{
				Console.WriteLine(courses[i]);
			}


			Console.WriteLine("---------------");


			foreach (string course in courses)
			{
				Console.WriteLine(course);
			}


			Console.WriteLine("---------------");


			int j = 0;


			while (j < courses.Length)
			{
				Console.WriteLine(courses[j]);
				j++;
			}


			Console.WriteLine("---------------");
		}
	}
}
