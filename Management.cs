using System;
class Order
{
    public int OrderId;
    public string OrderDate;
    public Order(int orderId, string orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }
    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }
}
class ShippedOrder : Order
{
    public string TrackingNumber;
    public ShippedOrder(int orderId, string orderDate, string trackingNumber) : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }
    public override string GetOrderStatus()
    {
        return "Order Shipped";
    }
}
class DeliveredOrder : ShippedOrder
{
    public string DeliveryDate;
    public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate) : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }
    public override string GetOrderStatus()
    {
        return "Order Delivered";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Order o = new Order(1, "2025-02-08");
        ShippedOrder s = new ShippedOrder(2, "2025-02-07", "TRK12345");
        DeliveredOrder d = new DeliveredOrder(3, "2025-02-06", "TRK67890", "2025-02-09");
        Console.WriteLine(o.GetOrderStatus());
        Console.WriteLine(s.GetOrderStatus());
        Console.WriteLine(d.GetOrderStatus());
    }
}