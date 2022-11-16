using System;
class HelloWorld {
  static void Main() {
    int days;
    days = Convert.ToInt32(Console.ReadLine());

    //years
    Console.WriteLine("Y: " + days/365);
    days = days%365;
    //month
    Console.WriteLine("M: " + days/30);
    days = days%30;
    //dayy
    Console.WriteLine("D: " + days);
  }
}