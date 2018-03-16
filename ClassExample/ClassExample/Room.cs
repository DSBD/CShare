using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExample
{
    public class Room
    {
        private int _size;
        private string _roomNumber;

        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                if(value > 0)
                {
                    _size = value;
                }
            }
        }

        public bool HasWifi { get; set; }
        
        public string RoomNumber
        {
            get
            {
                return _roomNumber;
            }
            set
            {
                _roomNumber = value;
            }
        }

    }
}