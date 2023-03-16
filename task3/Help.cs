using System;
namespace task3
{
	public class Help
	{
		static public string Readstring(string question)
		{
		l1:
			Console.Write(question);
			string name = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(name))
			{
				goto l1;
			}
			return name;
		}
		static public string Readsstring(string question)
		{
		l2:
			Console.Write(question);
			string surname = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(surname))
			{
				goto l2;
			}
			return surname;
		}
		static public int Readint(string question)
		{
		l3:
			int age;
			Console.Write(question);
			if (!int.TryParse(Console.ReadLine(), out age))
			{
				Console.WriteLine("EDED DAXIL EDILMELIDIR");
				goto l3;
			}
			return age;
		}
		static public string Readstringg(string question)
		{
		l1:
			Console.Write(question);
			string speciality = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(speciality))
			{
				goto l1;
			}
			return speciality;
		}
		static public int Readintt(string question)
		{
			int groupNo;
		l2:
			Console.Write(question);
			if (!int.TryParse(Console.ReadLine(), out groupNo))
			{
				Console.WriteLine("EDED SEHV DAXIL EDILIB");
				goto l2;
			}
			return groupNo;
		}
	}
}
