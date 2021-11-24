using System;
using System.Collections.Generic;
using System.Text;

namespace tinhkethua
{
    class Employee: person
    {
        string qualification;
        public new void Accept(string id)
        {
            base.Accept(id);
            Console.Write("Nhập bằng cấp: ");
            this.qualification = Console.ReadLine();
            Console.WriteLine("Đã Nhập xong");

        }
        public new void Display()
        {
            Console.WriteLine("*****");
            base.Display();
            Console.WriteLine("Bằng cấp {0}", this.qualification);
            Console.WriteLine("*****");
        }
    }
}
