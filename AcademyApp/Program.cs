// See https://aka.ms/new-console-template for more information
using AcademyApp.Business.Services;
using AcademyApp.Domain.Models;
using AcademyApp.Helpers;
StudentService studentService = new StudentService();
Console.WriteLine("Hello, World!");
Helpers.changeTextColor("AcademyApp",ConsoleColor.Red);
Helpers.changeTextColor("enter number 1.createStudent 2.getAllStudents", ConsoleColor.Yellow);
EnterMenu:string menu=Console.ReadLine();
bool result=int.TryParse(menu, out int intMenu);
while (true) { 
if (result && intMenu > 0 && intMenu < 3)
{
        switch(intMenu)
        {
            case 1:
                Helpers.changeTextColor("enter student Name", ConsoleColor.Red);
                string name=Console.ReadLine();
                Helpers.changeTextColor("enter student SurName", ConsoleColor.Red);
                string Surname = Console.ReadLine();
                Helpers.changeTextColor("enter group ", ConsoleColor.Red);
                string Groupname = Console.ReadLine();
                Student student=new Student();
                
                student.Name = name;
                student.SurName = Surname;
                studentService.Create(student, Groupname);
                if (studentService.Create(student, Groupname) is null)
                {
                    Helpers.changeTextColor("something went wrong", ConsoleColor.Red);

                }
                else
                {
                    Helpers.changeTextColor("succesfuly created", ConsoleColor.Green);

                }

                break;
        }

}else if (intMenu == 0)
{
        Helpers.changeTextColor("menuyunu terk etdiniz", ConsoleColor.Green);
        break;

}
else
{
    Helpers.changeTextColor("Duzgun eded daxil edin", ConsoleColor.Blue);
        goto EnterMenu;
}
}