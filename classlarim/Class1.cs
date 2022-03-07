using System;

namespace classlarim
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string FathertName { get; set; }
        public string sinif { get; set; }
    }
    class Madi
    {
        static void Main(string[] args)
        {
            Student elon = new Student();
            elon.Id = 1;
            elon.Name = "Elon";
            elon.Surname = "Musk";
            elon.Gender = "Male";
            elon.FathertName = "Errol Musk";
            elon.sinif = "Sahibkar";

            Student steve = new Student();
            steve.Id = 2;
            steve.Name = "Steve";
            steve.Surname = "Jobs";
            steve.Gender = "Male";
            steve.FathertName = "Paul Jobs";
            steve.sinif = "Bilgisayar uzmanı";

            Student jeff = new Student();
            jeff.Id = 3;
            jeff.Name = "Jeff";
            jeff.Surname = "Bezos";
            jeff.Gender = "Male";
            jeff.FathertName = "Miguel Bezos";
            jeff.sinif = "Sahibkar";

            Student bill = new Student();
            bill.Id = 4;
            bill.Name = "Bill";
            bill.Surname = "Gates";
            bill.Gender = "Male";
            bill.FathertName = "William Henry Gates ";
            bill.sinif = "Sahibkar";

            Student mark = new Student();
            mark.Id = 5;
            mark.Name = "Mark";
            mark.Surname = "Zuckerberg";
            mark.Gender = "Male";
            mark.FathertName = "Edward Zuckerberg";
            mark.sinif = "Sahibkar";

            Student[] arr = new Student[5];
            arr[0] = elon;
            arr[1] = steve;
            arr[2] = jeff;
            arr[3] = bill;
            arr[4] = mark;
            foreach (var item in arr)
            {
                Console.WriteLine(item.Id + "\n" + item.Name + "\n" + item.Surname + "\n"+item.Gender+"\n"+item.FathertName+"\n"+item.sinif) ;
            }
            //----------------------------------------------------OZUM DAXIL EDIREM------------------------------------------------------------------------------------------------
            Student[] array = new Student[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Student
                {
                    Id = int.Parse(Console.ReadLine()),
                    Name = Console.ReadLine(),
                    Surname = Console.ReadLine(),
                    Gender = Console.ReadLine(),
                    FathertName = Console.ReadLine(),
                    sinif=Console.ReadLine(),
                };
                foreach (var m in array)
                {
                    Console.WriteLine(m.Id);
                    Console.WriteLine(m.Name);
                    Console.WriteLine(m.Surname);
                    Console.WriteLine(m.Gender);
                    Console.WriteLine(m.FathertName);
                    Console.WriteLine(m.sinif);
                }
            }
        }
    }
}
