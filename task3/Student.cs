using System;
namespace task3
{
	public class Student
	{
		public Student()
		{
		}
		public string name;
		public string surname;
		public byte age;
		public string speciality;
		public int groupNo;
        public override string ToString()
        {
			return $"{name}{surname}{age}{speciality}{groupNo}";
        }
    }
}

