using System;
using System.Collections.Generic;
using System.Text;

namespace Solucion_Lab_21_abril
{
    public class User
    {
        public delegate void DelegateVerified();
        public event DelegateVerified EmailVerified;

        public void OnEmailSent()
        {
            Console.WriteLine("Si desea Verificar su Correo presione 1, de otro modo presione 0.");
            int n;
            bool aux0;

            do{
                string p;
                p = Console.ReadLine();
                aux0 = int.TryParse(p, out n);
                if (aux0 == false) { Console.WriteLine("---ERROR: INGRESE SOLO 1 o 0---"); }
            }while (!aux0 & n <= 0);


            if (n == 1)
            {
                EmailVerified();
            }
        }
        
    }
}
