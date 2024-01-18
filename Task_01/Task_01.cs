int number = 0;
string inputText;
while (true) {
    Console.Write("Введите целое число: ");
    inputText = Console.ReadLine();
    if (inputText == "q") {
        //Console.Write(inputText); // Для отчета почему программа остановилась
        return;
    }
    number = Convert.ToInt32(inputText);
    int sum = 0;
    while (number > 0) {
        sum += number % 10;
        number /= 10;
    }
    if (sum % 2 == 0) {
        //Console.Write(sum); // Для отчета почему программа остановилась
        return;
    }
}
