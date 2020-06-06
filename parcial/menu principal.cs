using System;
using System.Collections.Generic;
using System.Text;

namespace parcial
{
   public class menu_principal
    {
        public void menuP()
        {

            try
            {
                Console.Clear();
                Console.WriteLine("bienvenido al suoer cajero itla.");
                Console.WriteLine("1-modo de dispesacion\n2-retitra dinero.");

                int opcionP = Convert.ToInt32(Console.ReadLine());

                switch (opcionP)
                {
                    case 1:
                        Console.WriteLine("modo");
                        break;

                    case 2:
                        Console.WriteLine("retira.");
                        break;

                    default:
                        Console.WriteLine("error!,elija una ocion valida.");
                        menuP();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("error!,dijite una opcion valida");
                Console.ReadKey();
                menuP();
            }
            


        }
    }
}
