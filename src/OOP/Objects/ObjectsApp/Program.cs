using GIP.Warehouse;

Console.WriteLine("Hello, Objects!");

Phone phone1 = new Phone("nokia 3310") { serialNumber = "0123456789" }; // tworzymy nowy obiekt klasy Phone
phone1.batteryCapacity = 1000.5f;
phone1.color = "black";
phone1.cost = 1000;

phone1.Display();

Phone phone2 = new Phone("Samsung 777", "Samsung") { serialNumber = "0222456789" };
phone2.batteryLevel = 0.5f;
phone2.batteryCapacity = 2000.5f;
phone2.color = "red";
phone2.Display();





