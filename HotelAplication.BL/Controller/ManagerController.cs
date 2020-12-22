using HotelAplication.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HotelAplication.BL.Controller
{

    /// <summary>
    /// Контроллер менеджера.
    /// </summary>
    public class ManagerController
    {

        /// <summary>
        /// Менеджер.
        /// </summary>
        public Manager Manager { get; }

        /// <summary>
        /// Создание нового контроллера менеджера.
        /// </summary>
        /// <param name="manager"></param>
        public ManagerController(string managerName, string roleName, DateTime birthDay, string password, string hotelName)
        {
            // TODO: Проверка

            var hotel = new Hotel(hotelName);
            var role = new Role(roleName);
            Manager = new Manager(managerName, role, birthDay, password, hotel);

        }

        /// <summary>
        /// Получить данные менеджера.
        /// </summary>
        /// <returns>Менеджер.</returns>
        public ManagerController()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is Manager manager)
                {
                    Manager = manager;
                }

                //TODO: что делать, если менеджера не прочитали.
            }
        }

        /// <summary>
        /// Сохранить данные менеджера.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Manager);
            }
        }

        
    }
}
