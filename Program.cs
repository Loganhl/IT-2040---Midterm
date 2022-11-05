Employee employee1 = new Employee("Truman", "Tiger", "12345", EmployeeType.Sales);
SalesPerson salesPerson1 = new SalesPerson("Mickey", "Mouse", "23456", "Sporting Goods", 7500);
Manager manager1 = new Manager("Elmer", "Fudd", "56789", "Electronics", "Midwest");

Console.WriteLine("\n-------Employee 1-------------");
employee1.Person();

Console.WriteLine("\n-------Sales Person 1-------------");
salesPerson1.Person();
Console.WriteLine($"Sales Level: {salesPerson1.GetSalesLevel()} | Sales: ${salesPerson1.getSales()}");
salesPerson1.updateSales(5250.70f);
Console.WriteLine($"Updated Sales Level: {salesPerson1.GetSalesLevel()} | Updated Sales: ${salesPerson1.getSales()}");

Console.WriteLine("\n-------Manager 1-------------");
manager1.Person();
Console.WriteLine($"Dept: {manager1.getDepartment()} | Region: {manager1.getRegion()}");
manager1.setFirst("Wiley");
manager1.setLast("Coyote");
manager1.setRegion("Southeast");
manager1.setDepartment("Automotive");

Console.WriteLine($"New Dept: {manager1.getDepartment()} | New Region: {manager1.getRegion()}");

//The above is the program code provided to us with some edits made.