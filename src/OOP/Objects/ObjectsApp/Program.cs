using GIP.Warehouse;

Console.WriteLine("Hello, Objects!");

Battery battery1 = new Battery();
battery1.Capacity = 1000.5f;

Phone phone1 = new CellPhone("nokia 3310", battery: battery1) { SerialNumber = "0123456789" }; // tworzymy nowy obiekt klasy Phone
phone1.Color = "black";
phone1.Cost = 1000;

Console.WriteLine(phone1);

TouchScreen touchScreen1 = new TouchScreen
{
    Height = 400,
    Width = 500,
    Dpi = 1000,
};

Phone smartphone1 = new Smartphone("iPhone 17", touchScreen1, battery: new Battery()) { SerialNumber = "00000044343"};

Console.WriteLine(smartphone1);



Battery battery2 = new Battery();
battery2.Capacity = 2000.5f;

battery2.Level = 0.5f;

Console.WriteLine(battery2.Level);

// ladowanie baterii

try
{
    for (int i = 0; i < 10; i++)
    {
      battery2.Charge(-0.2f);

    }
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(e.Message);
    Console.ResetColor();
}






