using System;


namespace classlarim
{
    class KitabNovu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Novu { get; set; }
        public string Muellif { get; set; }

        static void Main(string[] args)
        {
            KitabNovu x = new KitabNovu();
            x.Id = 1;
            x.Name = "Scarlet";
            x.Novu = "Roman ";
            x.Muellif = "Marissa Meyer";

            KitabNovu y = new KitabNovu();
            y.Id = 2;
            y.Name = "Olaganustu bir gece";
            y.Novu = "Heyat hekayesi";
            y.Muellif = "Stefan Zweig";

            KitabNovu z = new KitabNovu();
            z.Id = 3;
            z.Name = "Ecdadlarin harayi";
            z.Novu = "Hekaye";
            z.Muellif = "Cek London";

            KitabNovu[] arr = new KitabNovu[3];
            foreach (var m in arr)
            {
                Console.WriteLine(m.Id+" "+m.Name+" "+m.Novu+" "+m.Muellif);
            }
            //-----------------------------------------------------------------------------------------------------------------------------
            KitabNovu[] array = new KitabNovu[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new KitabNovu
                {
                    Id = int.Parse(Console.ReadLine()),
                    Name = Console.ReadLine(),
                    Novu=Console.ReadLine(),
                    Muellif=Console.ReadLine()
                };
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].Id);
                Console.WriteLine(array[i].Name);
                Console.WriteLine(array[i].Novu);
                Console.WriteLine(array[i].Muellif);
            }
        }
    }
}
