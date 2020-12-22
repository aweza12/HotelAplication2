using HotelAplication.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAplication.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение HotelApp");
            Console.WriteLine("Введите имя менеджера");
            var name = Console.ReadLine();

            Console.WriteLine("Введите роль");
            var role = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            var birthDate = DateTime.Parse(Console.ReadLine()); //TODO: Переписать.

            Console.WriteLine("Введите пароль");
            var password = Console.ReadLine();

            Console.WriteLine("Введите название отеля");
            var hotelName = Console.ReadLine();

            var managerController = new ManagerController(name, role, birthDate, password, hotelName);
            managerController.Save();
        }
    }
}
