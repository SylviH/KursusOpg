using System;

namespace OpgString
{
    class Program
    {
        static void Main(string[] args)
        {


            String fornavn = "Mikkel";
            String efternavn = "Cronberg";
            String samletNavn = fornavn + " " + efternavn;
            String navnLille = samletNavn.ToLower();
            String navnStort = samletNavn.ToUpper();
            String del = samletNavn.Substring(7);
            String[] navne = samletNavn.Split(' ');
            for (int i = 0; i < navne.Length; i++)
            
                Console.WriteLine(navne[i]);
             System.IO.File.WriteAllText(@"c:\temp\testSylvi.txt", samletNavn);




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
