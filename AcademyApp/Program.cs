// See https://aka.ms/new-console-template for more information
using AcademyApp.Business.Services;
using AcademyApp.Controllers;
using AcademyApp.Domain.Models;
using AcademyApp.Helpers;
using static AcademyApp.Helpers.Helper;



Console.WriteLine("Hello, World!");
StudentController studentController=new();
GroupController groupController=new();
Helper.changeTextColor(ConsoleColor.Yellow, "AcademyApp");

while (true) {
    Helper.changeTextColor(ConsoleColor.Green, "enter number" +
    "1.createStudent" +
    "2.getAllStudents"
    + "3.getAllStudentsWithName" +
    "4.getStudentById" +
    "5.DeleteStudent" +
    "6.UpdateStudent" +
    "7.CreateGroup" +
    "8.getAllGroup" +
    "9.getAllStudentsWithGroupName"+
    "0.exitMenu");
 string menu = Console.ReadLine();
    bool result = int.TryParse(menu, out int intMenu);

    if (result && intMenu > 0 && intMenu < 14)
{
        switch(intMenu)
        {
            case (int)Menus.createStudent:
                studentController.CreateStudent();

                break;
                case (int)Menus.getAllStudents:
                studentController.getAll();
                break;
            case (int)Menus.getAllStudentsWithName:
                studentController.getAllStudentsWithName();
                break;
                case (int)Menus.getStudentById: 
                
                break;
                case (int)Menus.DeleteStudent:
                break;
                case (int)Menus.UpdateStudent: 
                studentController.UpdateStudent();
                break;
            case (int)Menus.CreateGroup:
                groupController.CreateGroup();
            break;
               case ( int)Menus.getAllGroups:
                groupController.getAllGroup();
                break;
            case (int)Menus.getAllStudentsWithGroupName:
         studentController.getAllStudentsWithGroupName();
                break;
        }

}else if (intMenu == 0)
    {
        Helper.changeTextColor(ConsoleColor.Red, "you left the menu");
        break;

}
else
{
        Helper.changeTextColor(ConsoleColor.Red, "duzgun eded daxil edin");

        //goto EnterMenu;
}
}