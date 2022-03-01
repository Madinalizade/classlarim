using System;

namespace classlarim
{
    class pro_dil
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string backendORfrontend { get; set; }
        public string input { get; set; }
        public string output { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            pro_dil cpp = new pro_dil();
            cpp.Id = 1;
            cpp.name = "C++";
            cpp.backendORfrontend = "Backend";
            cpp.input = "cin";
            cpp.output = "cout";

            pro_dil cs = new pro_dil();
            cs.Id = 2;
            cs.name = "C#";
            cs.backendORfrontend = "backend";
            cs.input = "Console.ReadLine()";
            cs.output = "Console.WriteLine()";

            pro_dil js = new pro_dil();
            js.Id = 3;
            js.name = "JavaScript";
            js.backendORfrontend = "frontend";
            js.input = "getElementById()";
            js.output = "window.alert()";


            pro_dil[] Diller = new pro_dil[3];
            Diller[0] = cpp;
            Diller[1] = cs;
            Diller[2] = js;

            foreach (var m in Diller)
            {
                Console.WriteLine(m.Id+"\n"+m.name+"\n"+m.backendORfrontend+"\n"+m.input+"\n"+m.output);
            }
            //------------------------------------ÖZÜM DAXİL ETDİKDE-------------------------------------------------------------------
            pro_dil[] diller = new pro_dil[2];
            for (int i = 0; i < diller.Length; i++)
            {
                diller[i] = new pro_dil
                {
                    Id = int.Parse(Console.ReadLine()),
                    name = Console.ReadLine(),
                    backendORfrontend = Console.ReadLine(),
                    input = Console.ReadLine(),
                    output = Console.ReadLine(),
                };
                Console.WriteLine();
                foreach (var m in diller)
                {
                    Console.WriteLine(m.Id);
                    Console.WriteLine(m.name);
                    Console.WriteLine(m.backendORfrontend);
                    Console.WriteLine(m.input);
                    Console.WriteLine(m.output);
                }
              

            }

        }
    }
}
