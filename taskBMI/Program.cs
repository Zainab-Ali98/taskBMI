// See https://aka.ms/new-console-template for more information

//1
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");

Console.WriteLine(" Enter your weight");
Console.WriteLine(" Enter your height");

double  weight = Convert.ToDouble(Console.ReadLine());
double  height = Convert.ToDouble(Console.ReadLine());

 height = height / 100;
double BMI = weight / (height * height);

Console.WriteLine(" Your MBI" + BMI);

//2
string  BMIState;

if (BMI < 18.5)
{
   
   BMIState = "under weight";

}
else if (BMI >= 18.5 && BMI <= 24.9)
{
    BMIState = "healthy";
}
else if (BMI >= 25.0 && BMI <= 29.9)
{
    BMIState = "over weight";

}
else
{
    BMIState= "obese";
}
Console.WriteLine("Your BMI state is" + BMIState+"");

//3
Console.WriteLine("enter your age");
int age = Convert.ToInt32(Console.ReadLine());

if(age >= 19 && age <= 24)
{
    if(BMI>=19 && BMI <= 24)
    {
        Console.WriteLine("healthy");
    }
    else { Console.WriteLine("unhelthy");
    }
}
 else if(age>= 25 && age<= 34){
    if (BMI >= 20 && BMI <= 25)
    {
        Console.WriteLine("helthy");

    }
    else Console.WriteLine("unhealthy");

}

else if(age>= 35 && age <= 44)
{
    if(BMI>= 21 && BMI<= 26)
    {
        Console.WriteLine("healthy");
    }
    else
    {
        Console.WriteLine("unhealthy");
    }
}

else if ( age>= 45 && age<= 54)
{
    if(BMI>=22 && BMI <= 27)
    {
        Console.WriteLine("healthy");
    }
    else
    {
        Console.WriteLine("unhealthy");
    }
}
else if (age >= 55 && age <= 64)
{
    if (BMI >= 23 && BMI <= 28)
    {
        Console.WriteLine("healthy");
    }
    else
    {
        Console.WriteLine("unhealthy");
    }
}
else if(age> 65) { 
    if (BMI>= 24 && BMI <= 29)
    {
        Console.WriteLine("healthy");
    }
    else
    {
        Console.WriteLine("unhealthy");
    }
    }

Console.WriteLine("your BMI is" + BMIState + "");