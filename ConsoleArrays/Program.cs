using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть кількість елементів у масиві: ");
int N = int.Parse(Console.ReadLine());
double[] array = new double[N];
double sumaOfNegatives = 0, minElement = array[0], maxAbsElement = Math.Abs(array[0]);
int indexOfMaxElement = 0, sumaIndexesPos = 0, countIntegers = 0;

Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(random.NextDouble() * (100 - (-100)) - 100, 2);
}

Console.WriteLine("Елементи масиву: ");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"\t{array[i]}");
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
        sumaOfNegatives += array[i];

    if (array[i] < minElement)
        minElement = array[i];

    if (array[i] > array[indexOfMaxElement])
        indexOfMaxElement = i;

    if (Math.Abs(array[i]) > maxAbsElement)
        maxAbsElement = Math.Abs(array[i]);

    if (array[i] > 0)
        sumaIndexesPos += i;

    if (array[i] % 1 == 0)
        countIntegers++;
}

Console.WriteLine($"Сума від'ємних елементів: {sumaOfNegatives}\n" +
    $"Мінімальний елемент масиву: {minElement}\n" +
    $"Номер максимального елемента масиву: {indexOfMaxElement}\n" +
    $"Максимальний за модулем елемент масиву: {maxAbsElement}\n" +
    $"Сума індексів додатніх елементів: {sumaIndexesPos}\n" +
    $"Кількість цілих чисел у масиві: {countIntegers}");
