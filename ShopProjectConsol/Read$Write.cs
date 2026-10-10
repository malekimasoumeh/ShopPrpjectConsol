using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProjectConsol
{
    internal class Read_Write
    {
        String Message=string.Empty;
        int Numberint;
        Decimal NUmberdecimal;
         public string Read()
        {
             return Message = Console.ReadLine();
        }
        public int Readint()
        {
            String NUM;
            while (true)
            {
                NUM = Console.ReadLine();
                if (int.TryParse(NUM, out Numberint))
                {
                    if (Numberint >0) 
                    return Numberint;
                    else
                        Write("it must be greater than 0");
                }
               Write("it must be number");
               

            }
        }
        public decimal Readdecimal()
        {
            String NUM;
            while (true)
            {
                NUM = Console.ReadLine();
                if (decimal.TryParse(NUM, out NUmberdecimal))
                {
                    if ((NUmberdecimal > 0))
                    {
                        return NUmberdecimal;
                    }
                    else
                        Write("it must be greater than 0");


                }
                Write("it must be number");


            }

        }
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
