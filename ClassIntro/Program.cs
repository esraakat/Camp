using System;


namespace ClassIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			Course course1 = new Course();
			course1.CourseName = "C#";
			course1.Egitmen = "Engin Demiroğ";
			course1.IzlenmeOranı = 65;


			Course course2 = new Course();
			course2.CourseName = "Java";
			course2.Egitmen = "Esra Akat";
			course2.IzlenmeOranı = 75;


			Course course3 = new Course();
			course3.CourseName = "Python";
			course3.Egitmen = "Kerem Varış";
			course3.IzlenmeOranı = 85;


			Course[] courses = new Course[] { course1, course2, course3 };
			foreach (Course course in courses)
			{
				Console.WriteLine(course.CourseName + ": " + course.Egitmen);
			}
		}
	}


	class Course
	{
		public string CourseName { get; set; }
		public string Egitmen { get; set; }
		public int IzlenmeOranı { get; set; }
	}


}

