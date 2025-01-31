using System;
class TimeZone{
    static void Main(string[] args){
        
        DateTimeOffset  DateTime = DateTimeOffset.UtcNow;

        Console.WriteLine("GMT: " + DateTime);

        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(DateTime, ist);
        Console.WriteLine("IST: " + istTime);

        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(DateTime, pst);

        Console.WriteLine("PST: " + pstTime);
    }
}