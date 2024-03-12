//Task1 tek ededler 
//int[] arr = {1,2,3,4,5,6,7};
//int count  = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 1)
//    {
//        count++;
//    }
//}
//    Console.WriteLine(count);

//Task2 en kicik ve en boyuk ededlerin cemi
//int[] arr = { 3, 8, 2, 10, 5 };
//int max = arr[0];
//int min  = arr[0];
//foreach(int i in arr)
//{
//    if(i > max)
//    {
//        max = i;
//    }
//    if(i < min)
//    {
//        min = i;
//    }
//}
//Console.WriteLine(min + max);

//Task3 en boyuk ve en kicik ededlerin ferqi
//int[] arr = { 5, 8, 15, 3, 7 };
//int max = arr[0];
//int min = arr[0];
//foreach (int i in arr)
//{
//    if (i > max)
//    {
//        max = i;
//    }
//    if (i < min) 
//    {
//        min = i;
//    }
//}
//Console.WriteLine(max - min);

//Task4
//int[] arr = { 3, 4, 1, 5, 2 };
//for (int i = 0; i < arr.Length - 1; i++)
//{
//    for (int j = 0; j < arr.Length - i - 1; j++)
//    {
//        if (arr[j] > arr[j + 1])
//        {
//            int temp = arr[j];
//            arr[j] = arr[j + 1];
//            arr[j + 1] = temp;
//        }
//    }
//}


//Console.WriteLine("Artan sırayla:");
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//Task5 tek ve cut cemi ayri ayrilqda
//int[] arr = { 1, 2, 3, 4, 5 };
//int sumCut = 0;
//int sumTek = 0;
//for (int i = 0;i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 1)
//    {
//        sumTek += arr[i];
//    }
//    if (arr[i] %2 == 0)
//    {
//        sumCut += arr[i];
//    }
//}
//Console.WriteLine(sumTek) ;
//Console.WriteLine(sumCut);

//Task6  arraydeki ededlerin cemini ve ededi ortasini tapin
//int[] arr = {5,7,8,12};
//int sum = 0;
//int count = 0;
//int avg = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    sum += arr[i];
//    count++;
//    avg = sum / count;
//}
//Console.WriteLine(sum);
//Console.WriteLine(avg);

//Task7
int x1, x2, x3, y1, y2, y3;

int slope1, slope2, slope3;

Console.WriteLine("Enter the values of x1 and y1 coordinates of first point");

x1 = Convert.ToInt32(Console.ReadLine());

y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the values of x2 and y2 coordinates of second point");

x2 = Convert.ToInt32(Console.ReadLine());

y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the values of x3 and y3 coordinates of third point");

x3 = Convert.ToInt32(Console.ReadLine());

y3 = Convert.ToInt32(Console.ReadLine());

slope1 = y2 - y1 / x2 - x1;

slope2 = y3 - y1 / x3 - x1;

slope3 = y3 - y2 / x3 - x2;

if (slope1 == slope2 && slope1 == slope3)

{

    Console.WriteLine("\nAll points are fall on one straight line ");

}

else

{

    Console.WriteLine("\nAll points are not fall on one straight line");

}

Console.ReadKey();




    

