
using System;

namespace ConsoleApp2
{

    /*
      class humano
    {
        //mienbro variable
        private string primerNombre = "";
        private string apellido = "";
        private int edad = 0;
        private string colorOjos = "";
        //mienbro costructor 

        public humano(string miPrimerNombre, string apellido, int edad, string colorOjos)
        {
            this.primerNombre = miPrimerNombre;
            this.apellido = apellido;
            this.edad = edad;
            this.colorOjos = colorOjos;
        }


        //mienbro metodo
        public void presentarse()
        {
            Console.WriteLine("hola yo soy {0} {1} tengo {2} de edad y mi color de ojos es {3}", primerNombre, apellido, edad, colorOjos);
           
        }
    }
     */
    class humano
    {
        //mienbro variable
        private string primerNombre = "";
        private string apellido = "";
        private int edad = 0;
        private string colorOjos = "";
        //mienbro costructor 

        public humano()
        {
            Console.WriteLine("construtor llamado,  objeto creado");
        }


        //mienbro metodo
        public void presentarse()
        {
            Console.WriteLine("hola yo soy {0} {1} tengo {2} de edad y mi color de ojos es {3}", primerNombre, apellido, edad, colorOjos);
           
        }
    }
}
