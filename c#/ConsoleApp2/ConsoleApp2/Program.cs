using System;

namespace ConsoleApp2
{
    /**internal class holamundo
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Hola");
            Console.Read();
            
        } 
    }**/



    /** public class leccionEdad
     {
         public static void Main(string[] args)
         {
             int edad = 15;
             Console.WriteLine(edad);
         }
     }**/



    /** internal class programSum
     {
         static void Main(string[] args)
         {
             int num1 = 13;
             int num2 = 5; 
             int sum = num1 + num2;
             // tambien puedes declarar bariable continuas o varias en el mismo int 
             double d1 = 3.2;
             double d2 = 1.3337;
             double sumd = d1 + d2;
             double sumdesimal = d1 + num2;
             Console.WriteLine(sum);
             Console.WriteLine(sumd);
             Console.WriteLine(sumdesimal);
             Console.Read();
             
         } 
     }**/
    /**
     * 
     * **/
    /**
     *    internal class programUpperLower
{
static void Main(string[] args)
{
        string MiNombre = "juan";

        string mensajeM = MiNombre.ToUpper();
        string mensajeM2 = MiNombre.ToLower();
        Console.WriteLine(mensajeM2);
        Console.WriteLine(mensajeM);
        Console.Read();


}
}
     * **/
    /**
     * 
     *  internal class programParse
{
        static void Main(string[] args)
        {
            string miString = "15";
            string miSegundoString = "10";

            string resultado = miString + miSegundoString;

            int num1 = Int32.Parse(miString);
            int num2 = Int32.Parse(miSegundoString);
                        
            int resultado2 = num1 + num2;

            Console.WriteLine(resultado2);
            Console.Read();
            



        }
}
     * **/

    /**
     * internal class programSum
{
        const double PI = 3.14159265359;
        const int senanas = 52, meses = 12;
        
        static void Main(string[] args)
        {

            Console.WriteLine("mi nacimiento fue el: {0}", nacimiento);
            Console.Read();


        }
}
     * **/



    // esto es un metodo o declaracion de un metodo puclico 
    /**
    * public int sumar(int num1, int num2)
{
        int resultado = num1 + num2;
        return resultado;
}
    * **/

    /**
internal class programSum
{
        const string nacimiento = "12.07.2002";

        static void Main(string[] args)
        {
            string spawm = nacimiento;
            escribeAlgo(spawm);
        }

        //nivel de acceso - (static) - tipo de retorno - nombre del metodo (parametro1, parametro2)
        //(esto metodo se pueden referecinar o acimilar mucho como las funciones es js o node.js)

        public static void escribeAlgo(string dato)
        {
            Console.WriteLine("yo naci en {0}", dato);
            Console.Read();
        }
}
    **/

    /** internal class programSum
     {


         static void Main(string[] args)
         {
             Console.WriteLine(dividir(31, 12));
             Console.Read();
         }



         public static int sumar(int parametro1, int parametro2)
         {
             return parametro1 + parametro2;

         }
         public static int restar(int parametro1, int parametro2)
         {
             return parametro1 - parametro2;

         }
         public static int multiplicar(int parametro1, int parametro2)
         {
             return parametro1 * parametro2;

         }
         public static double dividir(double parametro1, double parametro2)
         {
             return parametro1 / parametro2;

         }

     }**/

    /**
   * 
   * internal class programSum
    {

        static void Main(string[] args)
        {
            // readline sirve para leer una linia que ingrese el usuario atrave de la consola para una variable 
            string input = Console.ReadLine();
            Console.WriteLine(input);
            Console.Read();
        }

    }
    internal class programError
    {

        static void Main(string[] args)
        {
            TuNumero();
            
        }
        
        public static void TuNumero()
        {
            Console.WriteLine("porfavor ingresa un numero");
            string valorIngresado = Console.ReadLine();

            try
            {
                int valorComoInt = int.Parse(valorIngresado);
                Console.WriteLine("su numero es {0}", valorComoInt);
            }
            catch (FormatException)
            {
                Console.WriteLine("el formato ingresado es incorrecto escriba un numero en #01");

            }
            catch (OverflowException)
            {
                Console.WriteLine("el formato ingresado es muy corto o demaciado largo");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("no se a ingresado ningun valor");
            }
            finally
            {
                Console.WriteLine("esta ejecucion aparece pase lo que pase");
            }

            Console.Read();
        }

    }
    internal class program
    {

        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3 = 0;

            //operadores unarios

            num3 = -num1;
            

            bool haySol = true;

            // Console.WriteLine("hay sol {0} seguro que hay sol {1}", !haysol, haysol );

            int num = 0;
            num++;
            Console.WriteLine("num es {0}", num);
            


            //oprador modular
            int resultado;
            resultado = num1 % num2;

            Console.WriteLine("el modular es {0}", resultado);
            Console.Read();

            
        }
        
       
    }

     internal class program
    {

        static void Main(string[] args)
        {
            // if es igual a js o nodejs
            int temperatura1 = 10;
            int temperatura2 = 20;
            if (temperatura1 <= 10)
            {
                Console.WriteLine("abrigate!");
                Console.Read();
            }
            else if (temperatura1 < 20)
            {
                Console.WriteLine("esta el clima lindo");
                Console.Read();
            }
        }
    }
    internal class program
    {

        static void Main(string[] args)
        {
            // metodo tryParse()
            string numeroComoString = "128";
            float valorParseado;


            bool exitoSioNo = float.TryParse(numeroComoString, out valorParseado);

            if (exitoSioNo)
            {
                Console.WriteLine("parsing exitoso - el numero es {0}" , valorParseado);
                Console.Read();
            }
            else
            {
                Console.WriteLine("parsing fallido");
                Console.Read();
            }


             // el valor booleano de retorno sera true si parse es posible 
           // se toma un integer y se almacena para intentar hacer un parce puede ser un booleano si es el string no son convertibles a numero
        }
    }
    internal class program
    {

        static void Main(string[] args)
        {
            // metodo tryParse()
            string numeroComoString = "128asdf";
            float valorParseado;


            
            if (float.TryParse(numeroComoString, out valorParseado))
            {
                Console.WriteLine("parsing exitoso - el numero es {0}" , valorParseado);
                Console.Read();
            }
            else
            {
                Console.WriteLine("parsing fallido");
                Console.Read();
            }


             // el valor booleano de retorno sera true si parse es posible 
           // se toma un integer y se almacena para intentar hacer un parce puede ser un booleano si es el string no son convertibles a numero
        }
    }
    internal class program
    {

        static void Main(string[] args)
        {
            

           
            int autos = 5;
            // switch es otro metodo de toma de desiciones
            switch (autos)
            {
                case 0:
                    Console.WriteLine("usted no paga inpuestos");
                    break;
                case 1:
                    Console.WriteLine("usted paga 15$");
                    break ;
                case 2:
                    Console.WriteLine("usted paga 30$");
                    break;
                default:
                    Console.WriteLine("usted paga por cada auto que tenga 15$ por cada uno");
                    break;
            }
            Console.Read();

        }
    }
    internal class program
    {

        static void Main(string[] args)
        {
            //if mejorado 
            // condicion ? primera_expresion : segunda expresion ;
            // la operacion solo puede ser verdadero o falso
            // el operador condicional es corrrecto o sea que es asociativo
            // la expresion a ? b : c ? d : e
            // es evaluada como a ? b : (c ? d : e)
            // no como (a ? b : c ) ? d : e
            int temperatura = 150;
            string estadoDelAgua = "solido";
            
            if (temperatura < 0)
                estadoDelAgua = "solido";
            else 
                estadoDelAgua = "liquido";
            // se puede agregar un if el cual no usaria las llaves 
            Console.WriteLine("el estado de agua es {0} ", estadoDelAgua);
            Console.Read();
            
            estadoDelAgua = temperatura > 99 ? "gaseoso" : temperatura < 0 ? "solido" : "liquido";
            Console.WriteLine("el estado de agua es {0} ", estadoDelAgua);
            Console.Read();


    internal class program
    {

        static void Main(string[] args)
        {

            // for es muy similar o igual a el de javascript o nodejs
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.Read();



        }
    }
        }
    }
     internal class program
    {

        static void Main(string[] args)
        {
            int contador = 10;
            do
            {
                Console.WriteLine(contador);
                contador++;
            }while (contador <= 15);
            Console.Read();



        }
    }
     internal class program
    {

        static void Main(string[] args)
        {
            int contador = 0;
           
            while(contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            Console.Read();


     internal class program
    {

        static void Main(string[] args)
        {
            int contador = 0;
            string textoIngresado = "";



            while(textoIngresado == "")
            {
                textoIngresado = Console.ReadLine();
                Console.WriteLine("porfa tu contador va en {0} y dele enter para aumentar", contador);
                contador++;

            }
            Console.Read();


        }
    }

        }
    }
    internal class program
    {

        static void Main(string[] args)
        {

            // se crea un objeto desde mi clase es una instacia de humano
           humano juan = new humano("laura", "martinez", 18, "azules");
            // acediendo a una varible publica externa 
            // llamando un metodo de la clase
            juan.presentarse();

            humano pedro = new humano("santi", "garcia", 28, "verdes");
            pedro.presentarse();
            Console.Read();
        }
    }

   * **/


    // una clase es un plano de un objeto
    // tiene acciones / habilidades, llamadas funciones de mienbros o metodos
    // tiene propiedades, llamadas variables de miembro

    internal class program
    {

        static void Main(string[] args)
        {
            humano humanoBasico =  new humano();
            humanoBasico.presentarse();
         
            Console.Read();
        }
    }


}

