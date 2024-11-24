using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

class LINQ
{
    class hocsinh
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    static void Main(string[] args)
    {
        var hocsinh = new List<hocsinh>
        {
            new hocsinh { ID = 1, Name = "Dat", Age = 20 },
            new hocsinh { ID = 2, Name = "Bang", Age = 15 },
            new hocsinh { ID = 3, Name = "Trung", Age = 18 },
            new hocsinh { ID = 4, Name = "Duy", Age = 13 },
            new hocsinh { ID = 5, Name = "Tham", Age = 19 },
            new hocsinh { ID = 6, Name = "Khang" , Age = 21 },
            new hocsinh { ID = 7, Name = "Hieu", Age = 14 },
            new hocsinh { ID = 8, Name = "A", Age = 16 }
        };

        //a
        Console.WriteLine("Danh sach hoc sinh: ");
        foreach (var h in hocsinh)
            Console.WriteLine($"Id: {h.ID}, Name: {h.Name}, Age: {h.Age}");

        //b
        Console.WriteLine("\nHoc sinh co tuoi tu 15 den 18: ");
        var filterAge = hocsinh.Where(h => h.Age >= 15 && h.Age <= 18);
        foreach(var h in filterAge)
            Console.WriteLine($"Id: {h.ID}, Name: {h.Name}, Age: {h.Age}");

        //c
        var filterName = hocsinh.Where(h => h.Name.StartsWith('A'));
        if (!filterName.Any())
        {
            Console.WriteLine("\nKhong thay hoc sinh bat dau bang A");
        }
        else
        {
            Console.WriteLine("\nHoc sinh bat dau bang A");
            foreach(var h in filterName)
                Console.WriteLine($"Id: {h.ID}, Name: {h.Name}, Age: {h.Age}");
        }

        //d
        int tongage = hocsinh.Sum(h => h.Age);
        Console.WriteLine($"\nTong Age: {tongage}");

        //e
        var maxage = hocsinh.OrderByDescending(h => h.Age).First();
        Console.WriteLine($"\nHoc sinh co tuoi lon nhat: Id: {maxage.ID}, Name: {maxage.Name}, Age: {maxage.Age}");

        //f
        Console.WriteLine("\nDanh sach hoc sinh tang dan theo tuoi: ");
        var sapxep = hocsinh.OrderBy(h => h.Age);
        foreach ( var h in sapxep)
            Console.WriteLine($"Id: {h.ID}, Name: {h.Name}, Age: {h.Age}");
    }
}
