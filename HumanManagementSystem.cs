using System;
using System.Collections.Generic;
using System.Text;

namespace tinhkethua
{
    class HumanManagementSystem:person
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string option;
            List<Employee> empLst = new List<Employee>();
            List<Customer> cusLst = new List<Customer>();
            int cusId = 0, empId = 0;
            
            do
            {

                Console.WriteLine("Thêm khách hàng (nhập:ac)");
                Console.WriteLine("Thêm nhân viên (nhập:ae)");
                Console.WriteLine("Hiển thị thông tin nhân viên (nhập:dae)");
                Console.WriteLine("Thống kê khách hàng (nhập:cs)");

                Console.WriteLine("Thoát chương trình (nhập:ea)");
                option = Console.ReadLine();
                switch (option)
                {
                    case "ac":
                        Customer customer = new Customer();
                        cusId++;
                        customer.Accept("c" + cusId);
                        cusLst.Add(customer);
                        break;
                    case "ae":
                        Employee employee = new Employee();
                        empId++;
                        employee.Accept("e" + empId);
                        empLst.Add(employee);
                        break;
                    case "dae":
                        foreach (Employee emp in empLst)
                        {
                            emp.Display();
                        }
                        break;
                    case "dac":
                        foreach (Customer cus in cusLst)
                        {
                            cus.Display();

                        }
                        break;
                    case "cs":
                        int vipCnt = 0, newCnt = 0, normalCnt = 0;
                        foreach (Customer cus in cusLst)
                        {
                            switch (cus.type)
                            {
                                case "vip":
                                    vipCnt++;
                                    break;
                                case "new":
                                    newCnt++;
                                    break;
                                case "nomal":
                                    normalCnt++;
                                    break;

                            }
                        }
                        Console.WriteLine("Khách hàng vip:{0},vipCnt");
                        Console.WriteLine("Khách hàng new:{0},newCnt");
                        Console.WriteLine("Khách hàng normal:{0},normalCnt");
                        break;

                }
            }
            while (!option.Equals("ea"));
            { }

            
        }

    }
}
