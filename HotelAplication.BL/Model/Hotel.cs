using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAplication.BL.Model
{
    /// <summary>
    /// Отель.
    /// </summary>
    [Serializable]
    public class Hotel
    {
        /// <summary>
        /// Имя.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Создать новый отель.
        /// </summary>
        /// <param name="name"> Имя отеля.</param>
        public Hotel(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Название отеля не может быть пусто либо налл", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
