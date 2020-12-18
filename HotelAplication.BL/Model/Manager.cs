using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAplication.BL.Model
{
    /// <summary>
    /// Менеджер.
    /// </summary>
    public class Manager
    {
        #region Properties
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Роль.
        /// </summary>
        public Role Role { get; }

        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// Пароль.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Отель.
        /// </summary>
        public Hotel Hotel { get; }
        #endregion

        /// <summary>
        /// Создать нового менеджера
        /// </summary>
        /// <param name="name"> Имя.</param>
        /// <param name="role"> Роль.</param>
        /// <param name="birthDate"> Дата рождения.</param>
        /// <param name="password"> Пароль</param>
        /// <param name="hotel"> Отель.</param>
        public Manager(string name, 
            Role role, 
            DateTime birthDate, 
            string password, 
            Hotel hotel)
        {
            #region Data verification
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя менеджера не может быть пустым либо null", nameof(name));
            }

            if(role == null)
            {
                throw new ArgumentNullException("Роль не может быть пуста", nameof(role));
            }
            
            if(birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentNullException("Невозможная дата рождения", nameof(birthDate));
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException("Пароль не может быть пустым либо null", nameof(password));
            }

            if(hotel == null)
            {
                throw new ArgumentNullException("Отель не может быть пустым", nameof(hotel));
            }
            #endregion

            Name = name;
            Role = role;
            BirthDate = birthDate;
            Password = password;
            Hotel = hotel;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
