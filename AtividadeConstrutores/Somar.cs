using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeConstrutores
{
    class Somar
    {
        public int Num1;
        public int Num2;
        public int Num3;
        public int Num4;
        public char Resp;
        public int Total;



        public void Resposta(char Resp)
        {
            if(Resp == 'S' || Resp == 's')
            {
                
                Total = Total+Num1 + Num2+Num3+Num4;

            }
            else
            {
                Total = Total+Num1 + Num2;
            }

        }

     }
}
