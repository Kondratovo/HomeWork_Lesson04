int countEvenNumbers(int[] array) {
    int cnt = 0;
    for (int i = 0; i < 10; i++) {
        if (array[i] % 2 == 0) {
            cnt++;
        }
    }
    return cnt;
}

int[] createArray() {
    int[] array = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < 10; i++) {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}
Console.WriteLine(countEvenNumbers(createArray()));