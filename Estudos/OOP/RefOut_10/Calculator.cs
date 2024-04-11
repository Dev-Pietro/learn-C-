using System;

namespace RefOut_10
{
    class Calculator
    {
        //ref - referencia à variavel a ser alterada do escopo Main que foi utilizada como parametro
        public static void Triple(ref int x) { 
            x = x * 3;
        }

        //out - guarda o valor do metodo (no caso do exemplo o dobro do valor original) na variavel inicializada como result
        public static void Double(int origin, out int result) {
            result = origin * 2;
        }
    }
}