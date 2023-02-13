// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
void TaskNum(int number)
{
    System.Console.WriteLine($"__Задание {number}___");
}

void showArraymetod (int [] testArray)
{
    int [ ] showArray = testArray;
    var str = string.Join(",", showArray);
    Console.WriteLine(str);
}

int[] createArray(double degree, int maxSizeArray)
{
    var rnd = new Random();
    if (degree!=0 && maxSizeArray!=0)
    {
        double maxDegreeDouble = Math.Pow(10,degree);
        int maxDegree = Convert.ToInt32(maxDegreeDouble);
        int minDegree = maxDegree/10;
        int sizeArray = rnd.Next(1,maxSizeArray);
        int [] rndArray = new int [sizeArray];
        for (int i = 0; i<sizeArray; i++)
        {
            rndArray[i] = rnd.Next(minDegree,maxDegree); 
        }
        return rndArray;
    }
    else
    {
        int [] rndArray = new int [10];
        for (int i = 0; i<10; i++)
        {
            rndArray[i] = rnd.Next(0,1000); 
        }
        return rndArray;
    }
}

int resArray(int[] test1 )
{   
    showArraymetod(test1);
    int count = 0 ;
    for (int i = 0 ; i <test1.Length;i++)
    {
            if (test1[i]%2==0)
            {
                ++count;
            }
    }
    return count;
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int nechNum(int [] testArray)
{
    showArraymetod(testArray);
    int Res = 0;
    for (int i = 0 ; i<testArray.Length;i++)
    {
        if (i%2!=0)
        {
        Res=testArray[i]+Res;
        }
    }
    return Res;
}

TaskNum(34);
System.Console.WriteLine(resArray(createArray(3,10)));

TaskNum(36);
System.Console.WriteLine(nechNum(createArray(0,0)));
