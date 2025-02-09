using System;

class Lesson23{

    static void Main(){
        
        int[] array1 = new int[5];
        int[] array2 = new int[5];
        int[] array3 = new int[5];
        int[,] matrix = new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};

        Random random = new Random();
        for(int i = 0; i < array1.Length; i++){
            array1[i] = random.Next(50);
        }

        Console.WriteLine("Elements of array1");
        foreach(int n in array1){
            Console.WriteLine(n);
        }

        //public static int BinarySearch(array,value);
        Console.WriteLine("BinarySearch");
        int searchedValue = 33;
        int position = Array.BinarySearch(array1, searchedValue);
        Console.WriteLine("Value {0} is at position {1}", searchedValue, position);
        Console.WriteLine("-------------------------------------------");

        //public static void Copy(sourceArray,destinationArray,elementCount);
        Console.WriteLine("Copy");
        Array.Copy(array1, array2, array1.Length);
        foreach(int n in array2){
            Console.WriteLine(n);
        }

        //public void CopyTo(destinationArray,startingPosition);
        Console.WriteLine("CopyTo");
        array1.CopyTo(array3, 0);
        foreach(int n in array3){
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");

        //public long GetLongLength(dimension);
        Console.WriteLine("GetLongLength");
        long elementCountArray = array1.GetLongLength(0);
        Console.WriteLine("Number of elements {0}", elementCountArray);
        Console.WriteLine("-------------------------------------------");

        //public int GetLowerBound(dimension);
        Console.WriteLine("GetLowerBound");
        int lowerIndexArray = array1.GetLowerBound(0);
        int lowerIndexMatrix_D1 = matrix.GetLowerBound(1);
        Console.WriteLine("Lower index of array1 {0}", lowerIndexArray);
        Console.WriteLine("-------------------------------------------");

        //public int GetUpperBound
        Console.WriteLine("GetUpperBound");
        int upperIndexArray = array1.GetUpperBound(0);
        int upperIndexMatrix_D1 = matrix.GetUpperBound(1);
        Console.WriteLine("Upper index of array1 {0}", upperIndexArray);
        Console.WriteLine("-------------------------------------------");

        //public object GetValue(long index);
        Console.WriteLine("GetValue");
        int value0 = Convert.ToInt32(array1.GetValue(3));
        int value1 = Convert.ToInt32(matrix.GetValue(1,3));
        Console.WriteLine("Value at position 3 of array1: {0}", value0);
        Console.WriteLine("-------------------------------------------");

        //public static int IndexOf(array,value);
        Console.WriteLine("IndexOf");
        int index1 = Array.IndexOf(array1, 3);
        Console.WriteLine("Index of the first value 3: {0}", index1);
        Console.WriteLine("-------------------------------------------");

        //public static int LastIndexOf(array,value);
        Console.WriteLine("LastIndexOf");
        int index2 = Array.LastIndexOf(array1, 3);
        Console.WriteLine("Index of the last value 3: {0}", index2);
        Console.WriteLine("-------------------------------------------");

        //public static void Reverse(array);
        Array.Reverse(array1);
        foreach(int n in array1){
            Console.WriteLine(n);
        }   

        //public void SetValue(object value, long pos);
        array2.SetValue(99, 0);
        for(int i = 0; i < array2.Length; i++){
            array2.SetValue(0, i);
        }
        Console.WriteLine("Array 2");
        foreach(int n in array2){
            Console.WriteLine(n);
        }

        //public static void Sort(array);
        Array.Sort(array1);
        Array.Sort(array2);
        Array.Sort(array3);
        Console.WriteLine("Array1");
        foreach(int n in array1){
            Console.WriteLine(n);
        }
        Console.WriteLine("\nArray2");
        foreach(int n in array2){
            Console.WriteLine(n);
        }
        Console.WriteLine("\nArray3");
        foreach(int n in array3){
            Console.WriteLine(n);
        }
    }
}
