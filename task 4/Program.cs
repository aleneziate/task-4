// See https://aka.ms/new-console-template for more information

//task1 

Console.WriteLine("loop number 10");


for (int i = 1; i <= 10; i++)

{
    Console.WriteLine(i);
}


Console.WriteLine("------------------");

//bonus 

int x = 5;
while (x >= 0)
{
    Console.WriteLine("numbers " + x);
    x--;
}

Console.WriteLine("------------------");


//challenge 2
string[] daysOfWeek =  ["sun" , "mon" , "tue" , "wed" , "thur" , "fri" , "sat" ]; 

for( var i = 0; i< daysOfWeek.Length; i++)
{
    Console.WriteLine(daysOfWeek[i] + " ");
}
Console.WriteLine("------------------");

//challenge 2 
int sum = 0;
int[] numbers =new int [5];
numbers[0]=4;
numbers[1]=2;
numbers[2]=6;
numbers[3]=7;
numbers[4]=8;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
    
}
Console.WriteLine("the sum is " + sum);


Console.WriteLine("------------------");
 

