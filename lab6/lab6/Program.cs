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
int[] arr = { 1, 2, 3, 4, 5 };
int sumCut = 0;
int sumTek = 0;
for (int i = 0;i < arr.Length; i++)
{
    if (arr[i] % 2 == 1)
    {
        sumTek += arr[i];
    }
    if (arr[i] %2 == 0)
    {
        sumCut += arr[i];
    }
}
Console.WriteLine(sumTek) ;
Console.WriteLine(sumCut);


    

