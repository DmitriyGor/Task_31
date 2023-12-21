/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива. 
Например:
в массиве [3 , 9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
сумма отрицательных равна -20.
*/
// Глагол

int[] GetArray (int size, int minValue, int maxValue)
// size = 12, minValue = -9, maxValue = 9
{
    int[] resultArray = new int [size];
    for (int i = 0; i < size; i++) // i < size = i < resultArray.Length
    {
        resultArray[i] = new Random ().Next(minValue, maxValue + 1);
    }
    return resultArray;
}
int[] array = GetArray (12, -9, 9);
// интерполяция $
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");
int positiveSum = 0; // +
int negativeSum = 0; // -
for (int i = 0; i < array.Length; i++) // i < size = i < array.Length
{
    /*
    if (array[i] > 0)
        {
            positiveSum += array[i]; // positiveSum = positiveSum + array[i]
        
        }
    else
        {
            negativeSum += array[i]; // negativeSum = negativeSum + array[i]array[i]
        }
        */

        // Тернарный оператор
        // Условие ? значение_истиное : значение ложное
        positiveSum += array[i] > 0 ? array[i]: 0;
        // иначе прибавляю 0
        negativeSum += array[i] < 0 ? array[i]: 0;

}    
Console.WriteLine($"Сумма положительных чисел массива равна : {positiveSum}");
Console.WriteLine($"Сумма отрицательных чисел массива равна : {negativeSum}");