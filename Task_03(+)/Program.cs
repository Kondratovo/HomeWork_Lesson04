int [] digitsArray = {1, 2, 3};

int spliceNumber(int[] array) {
    int temp = array[0];
    for (int i = 1; i < array.Length; i++) {
        temp = temp * 10 + array[i];
    }
    return temp;
}

Console.WriteLine(spliceNumber(digitsArray));