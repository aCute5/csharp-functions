
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;


 //Parte di creazione dell' Array  
Console.WriteLine("Ciao, dimmi quanto vuoi che l'array sia lungo");
int arrLenght = Convert.ToInt16(Console.ReadLine());

int[] inputArr = new int[arrLenght];


for (int i = 0; i < arrLenght; i++)
{
    Console.WriteLine("Ciao dimmi un numero per l'array");
    int n = Convert.ToInt16(Console.ReadLine());
    inputArr[i] = n;
}
// Fine Parte dell'input

// Programma

programma(inputArr);
void programma(int[] array)
{
    printArray(array);
    Console.WriteLine(sommaElementiArray(quadratoArray(array)));
    Console.WriteLine(arrayToString(quadratoArray(array)));
    printArray(array);
}
// Alla fine del Programma

//Stampare l'Array (function della lezione) 
void printArray(int[] array)
{
    Console.WriteLine(arrayToString(array));
}

string arrayToString(int[] array)
{
    var result = "[";

    for (int i = 0; i < array.Length; i++)
    {
        result += array[i].ToString();

        if (i < array.Length - 1)
        {
            result += ", ";
        }
    }

    result += "]";

    return result;
}


//Function del quadrato
int Quadrato(int numero)
{
    int quadrato = numero * numero;
    return quadrato;
}

//Function del quadrato array


//Console.WriteLine(arrayToString(quadratoArray(arrElementes)));

int[] quadratoArray(int[] array)
{
    int[] copyArr = (int[])array.Clone();
    for (int i = 0; i < array.Length; i++)
    {
        copyArr[i] = Quadrato(copyArr[i]);
    }
    return copyArr;
}
//Console.WriteLine(sommaElementiArray(arrElementes));

int sommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; ++i)
    {
        somma += array[i];
    }
    return somma;
}
//Input per la console

// L'array originale non viene modificato? 

