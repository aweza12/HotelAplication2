using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAplication.BL.Model
{
    /// <summary>
    /// Роль.
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Создать новую роль.
        /// </summary>
        /// <param name="name"> Имя роли.</param>
        public Role(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Роль не может быть пуста либо налл", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
