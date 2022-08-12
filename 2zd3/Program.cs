void knowdayOff(){
Console.Write("Введите номер дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number <= 5){
    Console.WriteLine("нет");
}
else{
    Console.WriteLine("да");
}
}
knowdayOff();