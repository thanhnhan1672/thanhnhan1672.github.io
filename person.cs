using System;
using System.Collections.Generic;
using System.Text;

namespace tinhkethua
{
    class person
    {
        string id, name, gender, birthday;
        protected void Accept(string id)
        {
            this.id = id;
            Console.Write("Nhập tên: ");
            this.name = Console.ReadLine();
            Console.Write("Nhập giới tính : ");
            this.gender = Console.ReadLine();
            Console.Write(" Nhập ngày sinh (dd/MM/yyyy): ");
            this.birthday = Console.ReadLine();
        }

        protected void Display()
        {
            Console.WriteLine("Mã: {0}", this.id);
            Console.WriteLine("Tên: {0}", this.name);
            Console.WriteLine("Giới tính : {0}", this.gender);
            Console.WriteLine("Ngày sinh: {0}", this.birthday);
        }
    }
}
