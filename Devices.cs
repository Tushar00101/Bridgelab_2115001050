using System;
class Device
{
    public int DeviceId;
    public string Status;
    public Device(int deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }
    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}");
    }
}
class Thermostat : Device
{
    public int TemperatureSetting;
    public Thermostat(int deviceId, string status, int temperatureSetting) : base(deviceId, status)
    {
        TemperatureSetting = temperatureSetting;
    }
    public override void DisplayStatus()
    {
        Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}, Temperature Setting: {TemperatureSetting}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Thermostat t = new Thermostat(101, "On", 22);
        t.DisplayStatus();
    }
}
