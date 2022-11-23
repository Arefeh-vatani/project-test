using System;
class HelloWorld {
  static void Main() {
    int days;
    days = Convert.ToInt32(Console.ReadLine());//int days = console.ReadLine()
    //int days = Convert.ToInt32(days)

    //years
    Console.WriteLine("Years : " + days/365);
    days = days%365;
    //month
    Console.WriteLine("Months : " + days/30);
    days = days%30;
    //dayy
    Console.WriteLine("Days : " + days);
  }
}
