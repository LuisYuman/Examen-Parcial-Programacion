using System;


        Console.Write("Ingrese un numero entero positivo N mayor que cero: ");
        int N = int.Parse(Console.ReadLine());

        // Inciso 1
        int[] cuadrados = new int[N];
        for (int i = 1; i <= N; i++)
        {
            cuadrados[i - 1] = i * i;
        }

        // Incisio 2
        Console.WriteLine("Los numeros primos menores o iguales que {0} son:", N);
        for (int i = 2; i <= N; i++)
        {
            bool esPrimo = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            if (esPrimo)
            {
                Console.WriteLine(i);
            }
        }

        // Inciso 3
        Console.WriteLine("Los multiplos de 4 menores o iguales que {0} son:", N);
        for (int i = 1; i <= N; i++)
        {
            if (i % 4 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // Inciso 4
        Console.WriteLine("La secuencia de numeros enteros positivos que comienzan en 1 y se incrementan en 3 hasta que se alcance un valor mayor que {0} es:", N);
        for (int i = 1; i <= N; i += 3)
        {
            Console.WriteLine(i);
        }

        // Inciso 5
        Console.WriteLine("Los cuadrados de los numeros enteros menores o iguales que {0} son:", N);
        foreach (int cuadrado in cuadrados)
        {
            if (cuadrado > 0)
            {
                Console.WriteLine(cuadrado);
            }
        }

    

