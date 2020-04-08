using System;
using System.Globalization;
using System.Threading;

public class DateAndTime
{
    
    public static void Main()
    {
        PrintCurrentDate();      
    }
    private static string PrintCurrentDate()
    {
        int id = 1;

        TextInfo textInfo = new CultureInfo("ro-RO", false).TextInfo;

        string formats = "F";

        while (true)
        {
            DateTime dateToFormat = GetCurrentDate();
            while (dateToFormat.Second % 10 == 0)
            {
                string[] dayOfWeek = dateToFormat.ToString(formats, CultureInfo.CreateSpecificCulture("ro-RO")).Split(",");
                string[] currentDateSplit = dayOfWeek[1].Split(" ");
                string date = currentDateSplit[1] + " " + textInfo.ToTitleCase(currentDateSplit[2]) + " " + currentDateSplit[3];
                string hour = currentDateSplit[4];

                Console.WriteLine($"{id} - Data: {date} Ora: {hour}");
                
                Thread.Sleep(10000);
                id++;
                break;
            }
            
        }

    }
    private static DateTime GetCurrentDate()
    {    
       return DateTime.Now;
    }
}