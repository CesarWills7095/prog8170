using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_PROG8170
{
    public class Rectangle
    {
        private int _length;
        private int _width;
        public Rectangle()
        {
            _width = 1;
            _length = 1;
        }
        public Rectangle(int width, int length)
        {
            _width = width;
            _length = length;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetLength()
        {
            return _length;
        }
        public int SetLength(int length)
        {
            if (length > 0)
            {
                _length = length;
                return _length;
            }
            else return -1;
        }
        public int SetWidth(int width)
        {
            if (width > 0)
            {
                _width = width;
                return _width;
            }
            else return -1;
        }
        public int GetPerimeter()
        {
            return (2*_width + 2*_length);
        }
        public int GetArea()
        {
            return (_width * _length);
        }

    }
}
