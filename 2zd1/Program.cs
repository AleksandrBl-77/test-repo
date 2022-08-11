void learnSecond(){
Random random = new Random();
int valeue = random.Next(100, 1000);
Console.WriteLine(valeue);
int number2 = ((valeue / 10) % 10);
Console.WriteLine(number2);
}
learnSecond();