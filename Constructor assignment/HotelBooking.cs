using System;

class HotelBooking
{
    private string guestName;
    private string roomType;
    private int nights;

    public HotelBooking()
    {
        guestName = "Guest";
        roomType = "Guest";
        nights = 1;
    }
    public HotelBooking(string Name, string room, int nights)
    {
        this.guestName = Name;

        this.roomType = room;
        this.nights = nights;
    }


    public HotelBooking(HotelBooking other)
    {
        this.guestName = other.guestName;
        this.roomType = other.roomType;
        this.nights = other.nights;
    }

    public void BookingInfo()
    {
        Console.WriteLine("Guest Name: " + guestName);

        Console.WriteLine("Room Type: " + roomType);

        Console.WriteLine("Nights: " + nights);
    }

    static void Main(string[] args)
    {
        HotelBooking booking1 = new HotelBooking();
        Console.WriteLine("Default Booking:");
        booking1.BookingInfo();
        Console.WriteLine("Enter booking details:");
        Console.Write("Guest Name: ");
        string guestName = Console.ReadLine();
        Console.Write("Room Type: ");
        string roomType = Console.ReadLine();
        Console.Write("Nights: ");
        int nights = int.Parse(Console.ReadLine());

        HotelBooking booking2 = new HotelBooking(guestName, roomType, nights);
        Console.WriteLine("\nCustom Booking:");
        booking2.BookingInfo();
        HotelBooking booking3 = new HotelBooking(booking2);
        Console.WriteLine("\nCopied Booking:");
        booking3.BookingInfo();
    }
}
