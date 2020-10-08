
//Un banco tiene 3 clientes que pueden hacer depósitos y extracciones. 
//También el banco requiere que al final del día calcule la cantidad de dinero que hay depositada.
//La Solución tendrá el siguiente esquema: Debemos definir los atributos y los métodos de cada clase:
//Cliente  
    //atributos
        //nombre
        //saldo
    //métodos
        //Depositar
        //Extraer
        
//Banco
    //atributos
        //3 Cliente (3 objetos de la clase Cliente)
    //métodos
         //Operar
         //saldosTotales

using System;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {

            Banco banco_1 = new Banco();
            banco_1.Operar();
            banco_1.SaldosTotales();

            Console.WriteLine(nombre + " tiene depositado la suma de " + monto);

            Console.ReadKey();

        }
    }
}
