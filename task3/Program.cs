// See https://aka.ms/new-console-template for more information
using task3;

Console.WriteLine("Hello, World!");
int say;
L1:
Console.Write("TELEBE SAYINI DAXIL EDIN:");
if (!int.TryParse(Console.ReadLine(), out say) || say <= 0)
{
    goto L1;
}
Student[]telebe= new Student[say];
for (int i = 0; i < telebe.Length; i++)
{
    Student student = new Student();
    student.name = Help.Readstring($"{i + 1}.name: ");
    student.surname = Help.Readsstring($"{i + 1}. surname: ");
    student.age = Help.Readint($"{i + 1}. age: ");
    student.speciality = Help.Readstringg($"{i + 1}.speciality: ");
    student.groupNo = Help.Readintt($"{i + 1}.groupNo: ");
    telebe[i] = student;
}
Console.WriteLine("----------------------");
for(int i=0;i<telebe.Length;i++)
{
    Console.Write($"{i + 1}.");
    Console.WriteLine(telebe[i]);
}