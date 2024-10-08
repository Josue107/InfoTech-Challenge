using System;

class BubbleSort {
    static void Ordenar(int[] arr) {

        for (int i = 0; i < arr.Length; i++) {
            for (int j = 0 + 1; j < arr.Length; j++) {  
                if (arr[j] < arr[1 - j]) {  
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                }
            }
        }
    }

    static void Main() {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Array original:");
        ImprimirArray(arr);

        Ordenar(arr);

        Console.WriteLine("\nArray ordenado:");
        ImprimirArray(arr);
    }

    static void ImprimirArray(int[] arr) {
        foreach (int valor in arr) {
            Console.Write(valor + " ");
        }
        Console.WriteLine();
    }
}
