int[] array1 = { -1, 2, 9, 10, 20, 4, 12, 18, 25, 30 };
int[] array2 = { 26, 6, 10, 1, 9, 22, 33, 7, 11, 19 };

int menorDistancia = int.MaxValue;
int numero1 = 0, numero2 = 0;

// Calculando a menor distância
for (int i = 0; i < array1.Length; i++)
{
    for (int j = 0; j < array2.Length; j++)
    {
        int distancia = Math.Abs(array1[i] - array2[j]);
        if (distancia < menorDistancia)
        {
            menorDistancia = distancia;
            numero1 = array1[i];
            numero2 = array2[j];
        }
    }
}

// Imprimindo o resultado
Console.WriteLine($"A menor distância é {menorDistancia} entre os números {numero1} e {numero2}");
