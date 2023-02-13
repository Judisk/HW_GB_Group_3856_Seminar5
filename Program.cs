// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
var rnd = new Random();//чтобы не писать new Random() каждый раз
void TaskNum(int number)// Вывод какой номер задания 
{
    System.Console.WriteLine($"__Задание {number}___");
}

void showArrayMetodInt (int [] testArray)// показывает массив с которым работаем для упрощения проверки 
{
    int [ ] showArray = testArray;
    var str = string.Join(",", showArray);
    Console.WriteLine(str);
}
void showArrayMetodDouble (double [] testArray)// тоже самое что и выше только double
{
    double [ ] showArray = testArray;
    var str = string.Join(" ", showArray);
    Console.WriteLine(str);
}
int randomSign(int sign)
{
        int randomSign = 0;
        int signMinus=1;
        if(sign == 0)//если 0 то числа могут иметь рандомный знак если 1 то только +
        {
            randomSign = rnd.Next(0,2);
            if(randomSign==1)
            {
                signMinus = -1;
            }
        }
        return signMinus;
}

int[] createArrayInt(double degree, int maxSizeArray, int sign)// создаем массив если введем 0 , 0 то будет полностью случайный массив degree 
{
        
        int signMinus=1;
        if (degree!=0 && maxSizeArray!=0)
        {
            double maxDegreeDouble = Math.Pow(10,degree);//определяем максимальный размер массив если degree 3 то будет 100-1000 4 1000-10000 
            int maxDegree = Convert.ToInt32(maxDegreeDouble);
            int minDegree = maxDegree/10;//задаем минимальное число

            int sizeArray = rnd.Next(1,maxSizeArray);// рандомим размер массив он может быть как равен введенному maxSizeArray так и меньше
            int [] rndArray = new int [sizeArray];

            for (int i = 0; i<sizeArray; i++)//проходим по каждому пустому индексу массива и заполняем рандомным числом заданным аргументом
                {
                    signMinus=randomSign(sign);
                    rndArray[i] = (rnd.Next(minDegree,maxDegree))*signMinus; 
                }   
                return rndArray;
        }
        else//если 0,0 dct рандомно
        {
            int [] rndArray = new int [10];//изначально делал тоже рандомным но потом когда мне выпало больше 1000 размер массива посчитал что лучше 10 сделать
            for (int i = 0; i<10; i++)
            {
                signMinus=randomSign(sign);
                rndArray[i] = (rnd.Next(0,1000))*signMinus; //числа решил 0-1000 сделать потому что так проще считать но это омжно изменить и хоть брать до 10^7 как и было изначально
            }
            return rndArray;
        }

}
double [] createArrayDouble(int sign)//создание double массивов по принципу 0,0 в методе выше  
{
    double signMinus=1;

    double [] rndArray = new double [10];//изначально делал тоже рандомным но потом когда мне выпало больше 1000 размер массива посчитал что лучше 10 сделать
    for (int i = 0; i<10; i++)
    {
        signMinus=Convert.ToDouble(randomSign(sign));

        double fraction = rnd.Next(10,100);
        double fraction100=fraction/100;
        double whole = rnd.Next(1,100);
        double Resulte = whole+fraction100;
        rndArray[i] = Resulte*signMinus; 
    }
    return rndArray;
}

void resArray(int[] test1 )
{   
    showArrayMetodInt(test1);//показываем массив

    int count = 0 ;
    for (int i = 0 ; i <test1.Length;i++)
    {
            if (test1[i]%2==0)//проверка на четность числа если прошло то прибавляем счетчик
            {
                ++count;
            }
    }
    System.Console.WriteLine($"количество четных чисел : {count}");
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void nechNum(int [] testArray)
{
    showArrayMetodInt(testArray);//показываем массив
    int Res = 0;
    for (int i = 0 ; i<testArray.Length;i++)
    {
        if (i%2!=0)//проверка на нечетность нидекса
        {
        Res=testArray[i]+Res;
        }
    }
    System.Console.WriteLine($"сумма эл на нечетных идексах {Res}");
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
// double [] h = createArrayDouble();
// showArrayMetodDouble(h);

void minMaxInArray(double[] array)
{
    showArrayMetodDouble(array);
    
    double max = array[0];
    double min = array[0];

    for (int i = 1; i<array.Length;i++)
    {
        if(array[i]>max)
        {
            max = array[i];
        }
        else if (array[i]<min)
        {
            min = array[i];
        }
    } 
    double Resulte = max - min;
    System.Console.WriteLine($"max : {max} min: {min} difference: {Resulte}");

}

TaskNum(34);
resArray(createArrayInt(3,10,1));

TaskNum(36);
nechNum(createArrayInt(0,0,0));

TaskNum(38);
minMaxInArray(createArrayDouble(0));


