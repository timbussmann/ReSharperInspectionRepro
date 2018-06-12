using System;

namespace InspectionRepro.Source
{
    public class SharedClass
    {
        public static void Main()
        {
            Console.WriteLine(NonSharedClass.Location);
            Console.ReadKey();
        }
    }
}
