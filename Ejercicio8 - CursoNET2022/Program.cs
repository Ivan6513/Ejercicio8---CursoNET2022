/*
1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) 
mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion
correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios
 */


//notasEstudiante representa numero de filas de la matrizNotas
Console.WriteLine("Ingrese numero de notas por estudiante = ");
int notasEstudiante = int.Parse(Console.ReadLine());


//numeroEstudiantes representa numero de columnas de la matrizNotas
Console.WriteLine("Ingrese numero de estudiantes = ");
int numeroEstudiantes = int.Parse(Console.ReadLine());


//Declaracion matrizNotas
int[,] matrizNotas = new int[notasEstudiante, numeroEstudiantes];


//Carga de datos matrizNotas
for (int i = 0; i < numeroEstudiantes; i++)
{
    Console.WriteLine($"Estudiante N° {i + 1}" );

    for (int j = 0; j < notasEstudiante; j++)
    {
        Console.WriteLine($"Ingrese nota = {j + 1}");
        matrizNotas[j,i] = int.Parse(Console.ReadLine());
    }
}


//Vector promedios
double[] promedios = new double[numeroEstudiantes];


//Calculo del promedio de los estudiantes
for (int i = 0; i < numeroEstudiantes; i++)
{
    int totalNotas = 0;
    double sumaNotas = 0;

    for (int j = 0; j < notasEstudiante; j++)
    {
        sumaNotas = sumaNotas + matrizNotas[j,i];
        totalNotas++;
    }

    promedios[i] = Math.Round((sumaNotas / totalNotas),2);
    Console.WriteLine($"Promedio del estudiante {i + 1} = {promedios[i]}");
}

