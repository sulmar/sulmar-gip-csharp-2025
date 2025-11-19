using GIP.Warehouse;

Console.WriteLine("Hello, Objects!");

Phone phone1 = new Phone(); // tworzymy nowy obiekt klasy Phone
phone1.model = "nokia 3310";
phone1.manufacture = "Nokia";
phone1.batteryCapacity = 1000.5f;
phone1.batteryLevel = 1;
phone1.color = "black";
phone1.serialNumber = "0123456789";
phone1.cost = 1000;

phone1.Display();

Phone phone2 = new Phone();
phone2.model = "nokia 7700";
phone2.manufacture = "Nokia";
phone2.batteryCapacity = 2000.5f;
phone2.color = "red";
phone2.serialNumber = "0222456789";

phone2.Display();





