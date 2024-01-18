int[] array = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

void invertArray(int[] array) {
    int j = array.Length-1;
    int buf = 0;
    for (int i = 0; i < array.Length/2; i++) {
        buf = array[i];
        array[i] = array[j];
        array[j] = buf;
        j--;
    }
}

invertArray(array);
// проверка
foreach (int number in array) {
        Console.Write(number);
}