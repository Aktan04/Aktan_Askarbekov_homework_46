int totalTime = 0;
object lockObject = new object();

async Task PutKettleOnStove(int minutes)
{
    await Task.Delay(minutes * 100);
    lock (lockObject)
    {
        Console.WriteLine($"Вася поставил чайник на плиту и пошел выполнять другие задачи. Завершил он это за {minutes} минут");
        totalTime += minutes;
    }
}

async Task HeatUpDinner(int minutes)
{
    await Task.Delay(minutes * 100);
    lock (lockObject)
    {
        Console.WriteLine($"Вася потратил на то чтобы разогреть еду {minutes} минут, т.к. он параллельно еще кипятил воду для чая");
        totalTime += minutes;
    }
}

async Task FillBathtub(int minutes)
{
    await Task.Delay(minutes * 100);
    lock (lockObject)
    {
        Console.WriteLine($"Вася наполнил ванну за {minutes} минут, так как он стал дожидаться и пошел разогревать еду");
        totalTime += minutes;
    }
}

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