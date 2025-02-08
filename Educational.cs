using System;
class Course
{
    public string CourseName;
    public int Duration;
    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks");
    }
}
class OnlineCourse : Course
{
    public string Platform;
    public bool IsRecorded;
    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks, Platform: {Platform}, Recorded: {IsRecorded}");
    }
}
class PaidOnlineCourse : OnlineCourse
{
    public double Fee;
    public double Discount;
    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount) : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks, Platform: {Platform}, Recorded: {IsRecorded}, Fee: {Fee}, Discount: {Discount}%");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Course c = new Course("Math", 10);
        OnlineCourse o = new OnlineCourse("Physics", 8, "Udemy", true);
        PaidOnlineCourse p = new PaidOnlineCourse("Chemistry", 12, "Coursera", false, 100, 20);
        c.DisplayInfo();
        o.DisplayInfo();
        p.DisplayInfo();
    }
}