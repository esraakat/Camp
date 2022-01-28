using System;


namespace ClassIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			Course course1 = new Course();
			course1.courseName = "C#";
			course1.egitmen = "Engin Demiroğ";
			course1.izlenmeOranı = 65;


			Course course2 = new Course();
			course2.courseName = "Java";
			course2.egitmen = "Esra Akat";
			course2.izlenmeOranı = 75;


			Course course3 = new Course();
			course3.courseName = "Python";
			course3.egitmen = "Kerem Varış";
			course3.izlenmeOranı = 85;


			Course[] courses = new Course[] { course1, course2, course3 };
			foreach (Course course in courses)
			{
				Console.WriteLine(course.courseName + ": " + course.egitmen);
			}
		}
	}


	class Course
	{
		public string courseName { get; set; }
		public string egitmen { get; set; }
		public int izlenmeOranı { get; set; }
	}


}

