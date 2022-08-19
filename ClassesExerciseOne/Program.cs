using System;
using ClassesExerciseOne;

//Create a new instance of the Car class
Car myCar = new Car();
//Set values in the properties for the object
myCar.Make = "Honda";
myCar.Model = "Pilot";
myCar.Year = 2017;
//Print the values of each property to the Console
var CarList = new List<Car>() { myCar };
foreach (var auto in CarList)
{
    Console.WriteLine($"{auto.Make} {auto.Model} {auto.Year}");
}