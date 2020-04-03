using System;
using System.Globalization;
using System.Threading;

public class Example
{
    
    public static void Main()
    {
        Example.PrintDate();      
    }
    private static string PrintDate()
    {
        int i = 1;
        while (true)
        {
            string textToFormat = Example.GetDate();

            string[] A =  textToFormat.Split(",");
            string[] B = A[1].Split(" ");

            Console.WriteLine(i + " - " + "Data: " + B[1] + " " + B[2] +" " + B[3] + " " + " Ora: " + B[4]);
            Thread.Sleep(10000);
            i++;
        }
        return null;
    }
    private static string GetDate()
    {
       
        string[] formats = { "F" };
                                    
        CultureInfo[] cultures = { CultureInfo.CreateSpecificCulture("ro-RO"), };
       
        DateTime now = DateTime.Now;

        return now.ToString("F", CultureInfo.CreateSpecificCulture("ro-RO")).ToUpper();
      
    }
}