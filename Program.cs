// See https://aka.ms/new-console-template for more information

  Console.WriteLine("----------------practice 6 ------------");
 string[] monthsofyear =  {"january", "febrary", "march","april", "may", "june","july","august","september","october","november","december"};
string[] NewMonth = new string[14];
Console.WriteLine("---------------------Question1---------------");
 Console.WriteLine(monthsofyear.Length);
 Console.WriteLine("------------------Question2-------------");
 for (int M = 0; M < monthsofyear.Length; M++)
 {
     int rank = M + 1;
    Console.WriteLine($"{rank}.{monthsofyear[M]}"); 

 }
 Console.WriteLine("--------------Question4---------------");
 Console.WriteLine("reverse");
Array.Reverse(monthsofyear);

 foreach (string value in monthsofyear) 
 {
     Console.WriteLine(value);
 }
 Console.WriteLine("-------------Question5----------------");
 Console.WriteLine("alphabetical order");
 Array.Sort(monthsofyear); 
 foreach(string data in monthsofyear)
 {
 Console.WriteLine(data);
}
Console.WriteLine("-------------Question6-----------");
 Console.WriteLine("copy of six month ");
 Array.ConstrainedCopy(monthsofyear,0,NewMonth,0,6);
 foreach (string month in NewMonth)
 {
   Console.WriteLine(month);
 }
Console.WriteLine("----------------cloned months--------------");
string[] clonedmonths = (string[])NewMonth.Clone();
foreach (string clone in clonedmonths)
{
  Console.WriteLine(clone);
}