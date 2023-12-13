//Calculadora


    double numero1 = 0.0;
    double numero2 = 0.0;
    double resultado = 0.0;
    string pregunta;
    string salida;


do
{

    Console.WriteLine("Primera calculadora");
    Console.WriteLine("Elige una opcion");
    Console.WriteLine("1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Multiplicar");
    Console.WriteLine("4.Division");
    Console.WriteLine("5.Salir");
    Console.WriteLine("Elige una opcion");
    pregunta = Console.ReadLine();
    
    
    switch (pregunta)
    {
        case "1":
            Console.WriteLine("Introduzca un numero para Sumar");

            Console.WriteLine("Introduzca el valor del primer numero");

            while (!Double.TryParse(Console.ReadLine(), out numero1))
            {
                Console.WriteLine("El dato ingresado no es un número. Inténtalo de nuevo.");
            }


            Console.WriteLine("Introduzca el valor del segundo numero");
            while (!Double.TryParse(Console.ReadLine(), out numero2))
            {
                Console.WriteLine("El dato ingresado no es un número. Inténtalo de nuevo.");
            }




            resultado = numero1 + numero2;
            Console.WriteLine("El resultado de la suma es: " + resultado);
            break;



    }

    switch (pregunta)
    {
        case "2":
            Console.WriteLine("Introduzca un numero para Restar");

            Console.WriteLine("Introduzca el valor del primer numero");

            while (!Double.TryParse(Console.ReadLine(), out numero1))
            {
                Console.WriteLine("El dato ingresado no es un número. Inténtalo de nuevo.");
            }



            Console.WriteLine("Introduzca el valor del segundo numero");
            while (!Double.TryParse(Console.ReadLine(), out numero2))
            {
                Console.WriteLine("El dato ingresado no es un número. Inténtalo de nuevo.");
            }




            resultado = numero1 - numero2;
            Console.WriteLine("El resultado de la resta es: " + resultado);
            break;


    }

    switch (pregunta)
    {
        case "3":
            Console.WriteLine("Introduzca un numero para Multiplicacion");

            Console.WriteLine("Introduzca el valor del primer numero");

            while (!Double.TryParse(Console.ReadLine(), out numero1))
            {
                Console.WriteLine("El dato ingresado no es un número. Inténtalo de nuevo.");
            }



            Console.WriteLine("Introduzca el valor del segundo numero");
            while (!Double.TryParse(Console.ReadLine(), out numero2))
            {
                Console.WriteLine("El dato ingresado no es un número. Inténtalo de nuevo.");
            }




            resultado = numero1 * numero2;
            Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
            break;


    }

    switch (pregunta)
    {
        case "4":
            Console.WriteLine("Introduzca un numero para Division");

            Console.WriteLine("Introduzca el valor del primer numero");

            while (!Double.TryParse(Console.ReadLine(), out numero1))
            {
                Console.WriteLine("El dato ingresado no es un número. Inténtalo de nuevo.");
            }



            Console.WriteLine("Introduzca el valor del segundo numero");
            while (!Double.TryParse(Console.ReadLine(), out numero2))
            {
                Console.WriteLine("El dato ingresado no es un número. Inténtalo de nuevo.");
            }

            resultado = numero1 / numero2;
            Console.WriteLine("El resultado de la division es: " + resultado);
            break;

        case "5":
            Console.WriteLine("Saliendo de la calculadora");
            break;
        default:
            Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
            break;

    }
    


    Console.WriteLine("Desea realizar otra operacion?: (s/n)");
    pregunta = Console.ReadLine();

 

}
while (pregunta.ToLower() == "s");










