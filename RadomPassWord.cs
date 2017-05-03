using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXDoAnXML
{
    class RadomPassWord
    {   /// <summary>
        /// hàm tạo mật khẩu ngẫu nhiên
        /// </summary>
        /// <returns>tạo ra một mật khẩu có độ dài 10 với 4 chữ cái đầu tiên chữ thường, 4 chữ cái tiếp theo là số, và 2 chữ cái cuối cùng là chữ hoa</returns>
        public string GetPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        /// <summary>
        /// Tạo ra một chuỗi ngẫu nhiên với độ dài cho trước
        /// </summary>
        /// <param name="size">Kích thước của chuỗi </param>
        /// <param name="lowerCase">Nếu đúng, tạo ra chuỗi chữ thường</param>
        /// <returns>Random string</returns>
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
    }
}
