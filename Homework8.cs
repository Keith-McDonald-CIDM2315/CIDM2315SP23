//Question I//

public static void ArraySum(int[] int_array) {
    int sum = 0;
    for (int i = 0; i < int_array.length; i++) {
        sum += int_array[i];
    }
    System.out.println("The sum of the elements in the array is: " + sum);
}

//Question II Part I//

public static int ElementSum(int[,] array_2d) {
    int sum = 0;
    for (int i = 0; i < array_2d.GetLength(0); i++) {
        for (int j = 0; j < array_2d.GetLength(1); j++) {
            sum += array_2d[i,j];
        }
    }
    return sum;
}

//Question II Part II//

public static void PrintAllOddNumber(int[,] array_2d) {
    int rows = array_2d.GetLength(0);
    int cols = array_2d.GetLength(1);
    
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            if (array_2d[i, j] % 2 != 0) {
                Console.WriteLine(array_2d[i, j]);
            }
        }
    }
}

//Question II Part III//

public static int[,] DoubleArray(int[,] array_2d) {
    int rows = array_2d.GetLength(0);
    int cols = array_2d.GetLength(1);
    int[,] doubled_array = new int[rows, cols];
    
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            doubled_array[i, j] = array_2d[i, j] * 2;
        }
    }
    
    return doubled_array;
}
