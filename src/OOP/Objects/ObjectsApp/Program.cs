using GIP.Warehouse;

Console.WriteLine("Hello, Objects!");

Battery battery1 = new Battery();
battery1.Capacity = 1000.5f;

Phone phone1 = new Phone("nokia 3310", battery: battery1 ) { serialNumber = "0123456789" }; // tworzymy nowy obiekt klasy Phone
phone1.color = "black";
phone1.cost = 1000;

phone1.Display();

Battery battery2 = new Battery();
battery2.Level = 0.5f;
battery2.Capacity = 2000.5f;

Phone phone2 = new Phone("Samsung 777", "Samsung", battery2) { serialNumber = "0222456789" };
phone2.color = "red";
phone2.Display();





