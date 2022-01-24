using System;

namespace HWS_MethodAdvance_Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example of system overloading
            //1. Console.WriteLine();
            //int.Parse()
            //DateTime dt = new DateTime();
            //Random random = new Random().Next();

            #region Computer Exr

            string[] openFiles = null;//only in stack
            //openFiles.Clone();//ERROR
            //openFiles[0] = "C://";//ERROR
            openFiles = new string[10];
            openFiles = new string[3] { "File Explorer", "VS", "Zoom" };

            Computer c1 = new Computer(openFiles);
            SmartComp sc1 = new SmartComp(openFiles);
            sc1.TurnOff(true, true);

            #endregion
        }
    }
}
