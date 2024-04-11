namespace GarageConsoleApp;

/// <summary>
/// Класс Program
/// здесь описываем логику приложения
/// вызываем нужные методы пишем обработчики и тд
/// </summary>
public class Program 
{
    public static void Main(string[] args)
    {   
         while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить тип машины");
            Console.WriteLine("2. Просмотреть типы машин");
            Console.WriteLine("3. Добавить водителя");
            Console.WriteLine("4. Просмотреть водителей");
            Console.WriteLine("5. Добавить категорию прав водителю");
            Console.WriteLine("6. Просмотреть категорию прав водителей");
            Console.WriteLine("7. Добавить машину");
            Console.WriteLine("8. Просмотреть машины");
            Console.WriteLine("9. Добавить маршрут");
            Console.WriteLine("10. Просмотреть маршруты");
            Console.WriteLine("11. Добавить рейс");
            Console.WriteLine("12. Просмотреть рейсы");
            Console.WriteLine("0. Выход");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Введите название типа машины:");
                    var typeName = Console.ReadLine();
                    DatabaseRequests.AddTypeCarQuery(typeName);
                    break;
                case "2":
                    DatabaseRequests.GetTypeCarQuery();
                    break;
                case "3":
                    Console.WriteLine("Введите имя водителя:");
                    var firstName = Console.ReadLine();
                    Console.WriteLine("Введите фамилию водителя:");
                    var lastName = Console.ReadLine();
                    Console.WriteLine("Введите дату рождения водителя:");
                    var birthdate = DateTime.Parse(Console.ReadLine());;
                    DatabaseRequests.AddDriverQuery(firstName, lastName, birthdate);
                    break;
                case "4":
                    DatabaseRequests.GetDriverQuery();
                    break;
                case "5":
                    Console.WriteLine("Введите название категории прав:");
                    var categoryName = Console.ReadLine();
                    DatabaseRequests.AddRightsCategoryQuery(categoryName);
                    Console.WriteLine("Введите ID водителя:");
                    var driverIdForRightsCategory = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите ID категории прав:");
                    var categoryIdForRights = int.Parse(Console.ReadLine());
                    DatabaseRequests.AddDriverRightsCategoryQuery(driverIdForRightsCategory, categoryIdForRights);
                    break;
                case "6":
                    Console.WriteLine("Введите ID водителя:");
                    var driverIdForRightsCategoryQuery = int.Parse(Console.ReadLine());
                    DatabaseRequests.GetDriverRightsCategoryQuery(driverIdForRightsCategoryQuery);
                    break;
                case "7":
                    var idTypeCar = int.Parse(Console.ReadLine());
                    var name = Console.ReadLine();
                    var stateNumber = Console.ReadLine(); 
                    var numberPassenger = int.Parse(Console.ReadLine());
                    DatabaseRequests.AddCarQuery(idTypeCar, name, stateNumber, numberPassenger);
                    break;
                case "8":
                    DatabaseRequests.GetCarsQuery();
                    break;
                case "9":
                    Console.WriteLine("Введите название маршрута:");
                    var routeName = Console.ReadLine();
                    DatabaseRequests.AddRouteQuery(routeName);
                    break;
                case "10":
                    DatabaseRequests.GetRoutesQuery();
                    break;
                case "11":
                    Console.WriteLine("Введите ID водителя:");
                    var idDriver = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите ID машины:");
                    var idCars = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите Маршрут:");
                    var idIditnerary = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите количесто пассижров):");
                    var numberPassanger = int.Parse(Console.ReadLine());
                    DatabaseRequests.AddFlightQuery(idDriver, idCars, idIditnerary, numberPassanger);
                    break;
                case "12":
                    DatabaseRequests.GetFlightsQuery();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}
    
    