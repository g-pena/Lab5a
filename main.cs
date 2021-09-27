using System;

class Program {
  public static void Main (string[] args) {
    
//Calculate the speed of 7 cars in a race
//Speed=Distance/Time
double distance;
double time;
double speed;
double average;
double total = 0;
int numofcars=0;

while(numofcars<7)
{
numofcars++;
Console.WriteLine("Enter the distance covered by car #" +numofcars+ ": ");
distance = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the time taken by car #" +numofcars+ ": ");
time = Convert.ToDouble(Console.ReadLine());
speed = distance/time;
total= total + speed;
Console.WriteLine("The speed of this car is: "+speed+ " miles per hour.");
}
average = total/numofcars;

Console.WriteLine("The average speed of the cars is "+average+" miles per hour.");

  }
}