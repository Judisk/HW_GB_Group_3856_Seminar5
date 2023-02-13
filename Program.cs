// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void TaskNum(int number)// Вывод какой номер задания 
{
    System.Console.WriteLine($"__Задание {number}___");
}

void showArraymetod (int [] testArray)// показывает массив с которым работаем для упрощения проверки 
{
    int [ ] showArray = testArray;
    var str = string.Join(",", showArray);
    Console.WriteLine(str);
}

int[] createArray(double degree, int maxSizeArray)// создаем массив если введем 0 , 0 то будет полностью случайный массив degree 
{
    var rnd = new Random();
    if (degree!=0 && maxSizeArray!=0)
    {
        double maxDegreeDouble = Math.Pow(10,degree);//определяем максимальный размер массив если degree 3 то будет 100-1000 4 1000-10000 
        int maxDegree = Convert.ToInt32(maxDegreeDouble);
        int minDegree = maxDegree/10;//задаем минимальное число

        int sizeArray = rnd.Next(1,maxSizeArray);// рандомим размер массив он может быть как равен введенному maxSizeArray так и меньше
        int [] rndArray = new int [sizeArray];

        for (int i = 0; i<sizeArray; i++)//проходим по каждому пустому индексу массива и заполняем рандомным числом заданным аргументом
        {
            rndArray[i] = rnd.Next(minDegree,maxDegree); 
        }
        return rndArray;
    }
    else//если 0,0 dct рандомно
    {
        int [] rndArray = new int [10];//изначально делал тоже рандомным но потом когда мне выпало больше 1000 размер массива посчитал что лучше 10 сделать
        for (int i = 0; i<10; i++)
        {
            rndArray[i] = rnd.Next(0,1000); //числа решил 0-1000 сделать потому что так проще считать но это омжно изменить и хоть брать до 10^7 как и было изначально
        }
        return rndArray;
    }
}

int resArray(int[] test1 )
{   
    showArraymetod(test1);//показываем массив

    int count = 0 ;
    for (int i = 0 ; i <test1.Length;i++)
    {
            if (test1[i]%2==0)//проверка на четность числа если прошло то прибавляем счетчик
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
    showArraymetod(testArray);//показываем массив
    int Res = 0;
    for (int i = 0 ; i<testArray.Length;i++)
    {
        if (i%2!=0)//проверка на нечетность нидекса
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
