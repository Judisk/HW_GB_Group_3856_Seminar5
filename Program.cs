// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
void TaskNum(int number)
{
    System.Console.WriteLine($"__Задание {number}___");
}
// TaskNum(34);

int[] createArray(double degree, int maxSizeArray)
{
    
    double maxDegreeDouble = Math.Pow(10,degree);
    int maxDegree = Convert.ToInt32(maxDegreeDouble);
    int minDegree = maxDegree/10;
    int sizeArray = new Random().Next(1,maxSizeArray);
    int [] rndArray = new int [sizeArray];
    for (int i = 0; i<sizeArray; i++)
    {
        rndArray[i] = new Random().Next(minDegree,maxDegree); 
    }
    return rndArray;
}

int resArray(int[] test1 )
{   
    int [ ] testArray = test1;
    var str = string.Join(",", testArray);
    Console.WriteLine(str);
    int checkRes=0;
    int count = 0 ;
    for (int i = 0 ; i <test1.Length;i++)
    {
        while (test1[i]>1)
        {
            checkRes = test1[i]%10;
            test1[i]/=10;
            if (checkRes%2==0)
            {
                ++count;
            }
            checkRes=0;
        }
    }
    return count;
}


System.Console.WriteLine(resArray(createArray(3,10)));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// TaskNum(36);

// int 