using System;

class MainClass {
  public static void Main (string[] args) {
    int counter = 0;
    while (counter < 10)
    {
      Console.WriteLine ("Enter Name");
      string name = Console.ReadLine();

      Console.WriteLine ("Enter height in inches");
      double height = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine ("Enter weight in pounds");
      double weight = Convert.ToDouble(Console.ReadLine());

      double BMI = (703 * weight)/(height * height);

      if(BMI <= 18.5)
      {
        Console.WriteLine(name + " is Underweight with a BMI of " + BMI);
      }
      else if(BMI <= 24.9)
      {
        Console.WriteLine(name + " is at a Normal Weight with a BMI of " + BMI);
      }
      else if(BMI <= 29.9)
      {
        Console.WriteLine(name + " is Overweight with a BMI of " + BMI);
      }
      else
      {
        Console.WriteLine(name + " is Obese with a BMI of " + BMI);
      }

      counter++;

    }


    
  }
}