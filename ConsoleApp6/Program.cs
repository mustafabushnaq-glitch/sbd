using System;
using System.Numerics;

Console.WriteLine("inpet your name :");
string name1 = Console.ReadLine();
Console.WriteLine("enter your BW :");
    double bw1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter your bench :");
int bench1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter your squat :");        
    int squat1 = Convert.ToInt32(Console.ReadLine());       
    Console.WriteLine("enter your deadlift :");     
    int deadlift1 = Convert.ToInt32(Console.ReadLine());    
int total1 = bench1 + squat1 + deadlift1;

Console.WriteLine("inpet your name :");
string name2 = Console.ReadLine();
Console.WriteLine("enter your BW :");
    double bw2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter your bench :");
int bench2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter your squat :");
int squat2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter your deadlift :");
int deadlift2 = Convert.ToInt32(Console.ReadLine());
int total2 = bench2 + squat2 + deadlift2;

Double ipf1 = total1 / bw1;
Double ipf2 = total2 / bw2;

Console.WriteLine($"{name1} = {ipf1}    {name2} = {ipf2}");

//if (ipf1 > ipf2) { 
//    Console.WriteLine($"{name1} is the winner!");
//}
//else if (ipf2 > ipf1) {
//    Console.WriteLine($"{name2} is the winner!");
//}
Double x = ipf1 * bw2 - total2; 
Double y = ipf2 * bw1 - total1;
bool isWinner = ipf1 > ipf2;

switch (isWinner)
{
    case true:
        Console.WriteLine($"{name1} is the winner!");
        
       Console.WriteLine($"the diferant is {x}");
        break;
        case false: 
        Console.WriteLine($"{name2} is the winner!");
        Console.WriteLine($"the diferant is {y}");
        break;

}

Console.WriteLine("mustafa gym king");    




