using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.Helpers
{
    public class Helper
    {
        public static void changeTextColor(ConsoleColor consoleColor,string word)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(word);
            Console.ResetColor();
        }
        public enum Menus
        {
            createStudent=1,
            getAllStudents,
            getAllStudentsWithName,
            getStudentById,
            DeleteStudent,
            UpdateStudent,
            CreateGroup,
            getAllGroups,
            getAllStudentsWithGroupName,



            //         "1.createStudent"+ 
            //"2.getAllStudents"
            //+"3.getAllStudentsWithName"+
            //"4.getStudentById"+
            //"DeleteStudent"+
            //"6.exitMenu"
        }
    }
}
