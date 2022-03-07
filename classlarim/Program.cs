using System;

namespace classlarim
{
   
   class ProDil
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BackendOrFrontend { get; set; }
        public string İnput { get; set; }
        public string Output { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProDil cpp = new ProDil();
            cpp.Id = 1;
            cpp.Name = "C++";
            cpp.BackendOrFrontend = "Backend";
            cpp.İnput = "cin";
            cpp.Output = "cout";

            ProDil cs = new ProDil();
            cs.Id = 2;
            cs.Name = "C#";
            cs.BackendOrFrontend = "backend";
            cs.İnput = "Console.ReadLine()";
            cs.Output = "Console.WriteLine()";

            ProDil js = new ProDil();
            js.Id = 3;
            js.Name = "JavaScript";
            js.BackendOrFrontend = "frontend";
            js.İnput = "getElementById()";
            js.Output = "window.alert()";


            ProDil[] Diller = new ProDil[3];
            Diller[0] = cpp;
            Diller[1] = cs;
            Diller[2] = js;

            foreach (var m in Diller)
            {
                Console.WriteLine(m.Id+"\n"+m.Name+"\n"+m.BackendOrFrontend+"\n"+m.İnput+"\n"+m.Output);
            }
            //------------------------------------ÖZÜM DAXİL ETDİKDE-------------------------------------------------------------------
            ProDil[] diller = new ProDil[2];
            for (int i = 0; i < diller.Length; i++)
            {
                diller[i] = new ProDil
                {
                    Id = int.Parse(Console.ReadLine()),
                    Name = Console.ReadLine(),
                    BackendOrFrontend = Console.ReadLine(),
                    İnput = Console.ReadLine(),
                    Output = Console.ReadLine(),
                };
                Console.WriteLine();
                foreach (var m in diller)
                {
                    Console.WriteLine(m.Id);
                    Console.WriteLine(m.Name);
                    Console.WriteLine(m.BackendOrFrontend);
                    Console.WriteLine(m.İnput);
                    Console.WriteLine(m.Output);
                }


            }   
        }

    }
}
