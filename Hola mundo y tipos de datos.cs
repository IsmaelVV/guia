//Tutorial tomado: https://www.youtube.com/watch?v=L-f8u0hwi4Y&t=2s
using System;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // Hola mundo
            Console.WriteLine("Hola, C#"); 

            /*
            Esto
            es
            un
            comentario
            */

            // Variables
            Console.WriteLine("\nDefinir string");
            string myString = "Esto es una cadena de texto";
            myString = "Aquí cambio el valor de la cadena de texto";
            Console.WriteLine(myString);

            Console.WriteLine("\nDefinir int");
            int myInt = 7;
            myInt = myInt + 4;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt - 1);
            Console.WriteLine(myInt);

            Console.WriteLine("\nDefinir double");
            double myDouble = 6.5;
            Console.WriteLine(myDouble);

            Console.WriteLine("\nDefinir float");
            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

            Console.WriteLine("\nSuma de int + double + float");
            Console.WriteLine(myInt + myDouble + myFloat);

            Console.WriteLine("\nDefinir bool");
            bool myBool = true;
            myBool = false;
            Console.WriteLine(myBool);

            Console.WriteLine("\nDefinir datos dinamicos");
            dynamic myDynamic = 6;
            myDynamic = "Mi dato dinámico";
            Console.WriteLine(myDynamic + myFloat);

            Console.WriteLine("\nDefinir var");
            var myVar = "Mi variable de tipo inferido";
            // myVar = 6; Error
            Console.WriteLine(myVar);

            Console.WriteLine("\nconcatenar en un solo lugar");
            Console.WriteLine($"El valor de mi entero es {myInt} y el de mi bool {myBool}");

            // Constantes

            Console.WriteLine("\nDefinir costante");
            const string MyConst = "Mi constante";
            Console.WriteLine(MyConst);

            // Arrays
            Console.WriteLine("\nDefinir arreglos");
            var myArray = new string[] { "Brais", "Moure", "MoureDev" };
            Console.WriteLine(myArray[0]);

            Console.WriteLine("\nCambiar el valor 2 del array");
            myArray[2] = "36";
            Console.WriteLine(myArray[2]);

            // Diccionarios

            Console.WriteLine("\nDefinir diccionario de datos");
            var myDictionary = new Dictionary<string, int>
            {
                {"mouredev", 36},
                {"brookslynx", 5},
                {"cabreragreta", 25}
            };


            Console.WriteLine(myDictionary["mouredev"]);

            // Sets
            Console.WriteLine("\nDefinir set, datos que no se repiten");
            var mySet = new HashSet<string> { "Brais", "Moure", "MoureDev", "MoureDev" };
            Console.WriteLine(mySet);

            // Tuplas
            Console.WriteLine("\nDefinir tuplas");
            var myTuple = ("Brais", "Moure", "MoureDev");
            Console.WriteLine(myTuple);

            // Bucles
            Console.WriteLine("\nBucle for");
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(index);
            }

            Console.WriteLine("\nBucle foreach");
            foreach (var myItem in myArray)
            {
                Console.WriteLine(myItem);
            }

            foreach (var myItem in myDictionary)
            {
                Console.WriteLine(myItem);
            }

            foreach (var myItem in mySet)
            {
                Console.WriteLine(myItem);
            }

            // Control de flujo
            Console.WriteLine("\nCondicional if&&elseif");
            if (myInt == 11 && myBool == true)
            {
                Console.WriteLine("El valor es 11");
            }
            else if (myInt == 12 || myBool == false)
            {
                Console.WriteLine("El valor es 12");
            }
            else
            {
                Console.WriteLine("El valor no es 11 ni 12");
            }

            // Funciones
            Console.WriteLine("funciones");
            MyFunction();
            Console.WriteLine(MyFunctionWithReturn(5));

            // Clases

            var myClass = new MyClass("Brais");
            myClass.myName = "MoureDev";
            Console.WriteLine(myClass.myName);
        }
        static void MyFunction()
        {
            Console.WriteLine("Mi función");
        }

        static int MyFunctionWithReturn(int param)
        {
            return 10 + param;
        }

        class MyClass
        {
            public string myName { get; set; }

            public MyClass(string myName)
            {
                this.myName = myName;
            }
        }
    }


}