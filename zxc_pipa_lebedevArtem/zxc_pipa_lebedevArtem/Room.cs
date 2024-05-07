using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zxc_pipa_lebedevArtem
{
    public class Room
    {
        double roomLength;
        double roomWidth; 
        public double RoomLength
    {
        get { return roomLength; }
        set { roomLength = value; }
    }
     public double RoomWidth
     {
        get { return roomWidth; }
        set { roomWidth = value; }
     }
        /// <summary>
        /// метод вычесления периметр комнаты
        /// </summary>
        /// <returns>Возращает значения периметра</returns>
        public double RoomPerimetr()
     {
        return 2 * (roomLength + roomWidth);
     }
     /// <summary>
     /// метод вычесления площадь комнаты
     /// </summary>
     /// <returns>Возращает значения площади</returns>
     public double RoomArea()
     {
            return roomLength * roomWidth;
     }
        /// <summary>
        /// метод вычесляет число квадратных метров
        /// на одного человека 
        /// </summary>
        /// <param name="np">Число человек</param>
        /// <returns>Возращает число квадратых метров</returns>
     public double PersonArea(int np)
     {
            return RoomArea() / np;
     }
    }
   
}



