using System;
using System.Collections.Generic;
using System.Text;

namespace tinhkethua
{
    class Customer: person
    {
        public string type;
        public new void Accept(string id)
        {
            base.Accept(id);
            Console.Write(" Nhập loại khách hàng (vip,new,normal): ");
            this.type = Console.ReadLine();
            Console.WriteLine("Đã Nhập xong");

        }
        public new void Display()
        {
            Console.WriteLine("*****");
            base.Display();
            Console.WriteLine("Loại khách hàng :{0}", this.type);
            Console.WriteLine("*****");
        }

    }
}
