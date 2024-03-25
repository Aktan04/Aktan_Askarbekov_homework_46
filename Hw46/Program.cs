int totalTime = 0;
object lockObject = new object();

void WakeUpAndLieInBed(int minutes)
{
    Thread.Sleep(minutes * 100);
    Console.WriteLine($"Вася встал в 7:30 и пролежал {minutes} минут, так как ему нужно успеть на работу");
    totalTime += minutes;
}

void TakeBath(int minutes)
{
    totalTime += minutes;
    Console.WriteLine($"Затрачено времени на принятие ванны: {minutes} минут");
    Thread.Sleep(minutes * 100);
}

void HaveBreakfast(int minutes)
{
    Thread.Sleep(minutes * 100);
    Console.WriteLine($"Вася не будет есть дома, он собрал свой завтрак за {minutes} минуту поест в дороге свой завтрак");
    totalTime += minutes;
}

void GetDressed(int minutes)
{
    totalTime += minutes;
    Console.WriteLine($"Затрачено времени на одевание: {minutes} минут");
    Thread.Sleep(100 * minutes);
}

void GoToWork(int minutes)
{
    Thread.Sleep(minutes * 100);
    Console.WriteLine($"Вася едет на работу {minutes} минут, он чудом успел");
    totalTime += minutes;

}