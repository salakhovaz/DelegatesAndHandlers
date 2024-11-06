using DelegatesAndHandlers.Delegates;
using DelegatesAndHandlers.Events;


List<Car> cars = new()
{
    new Car { Name = "LADA 2114", Price = 1500.5f },
    new Car { Name = "Porsche Cayenne", Price = 900.3f },
    new Car { Name = "ЗИЛ-133", Price = 1899.9f }
};

Car mostExpensiveCar = cars.GetMax(car => car.Price);
Console.WriteLine($"Самая дорогая машина: {mostExpensiveCar.Name} стоит {mostExpensiveCar.Price}\n");


FileSearcher fileSearcher = new FileSearcher();
fileSearcher.FileFound += FileFoundHandler.Handle;

Console.WriteLine("Поиск файлов");
fileSearcher.SearchFiles("C:\\Users\\Artem\\Desktop\\DelegatesAndHandlers\\FilesForTest");
