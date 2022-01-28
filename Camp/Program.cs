using System;


namespace CampIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			string categoryLabel = "Kategori";
			int studentNumber = 32000;
			double dolarDun = 7.35;
			double dolarBugün = 7.45;
			bool isEntered = true;


			Console.WriteLine(categoryLabel);
			Console.WriteLine(studentNumber);


			if (dolarDun > dolarBugün)
			{
				Console.WriteLine("Azalış oku");
			}
			else if (dolarDun < dolarBugün)
			{
				Console.WriteLine("Artış oku");
			}
			else
			{
				Console.WriteLine("Değişmedi oku");
			}


			if (isEntered)
			{
				Console.WriteLine("Kullanıcı ayarları butonu");
			}
			else
			{
				Console.WriteLine("Giriş yap butonu");
			}
		}
	}
}
