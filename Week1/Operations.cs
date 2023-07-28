using System;

class Program{
	static void Main(string[] args){
		
		start:
		Console.WriteLine("Please select the operation you want to perform:");
		Console.WriteLine("1.Addition  2.Substraction 3.Multiplication 4.Division");
		int op=int.Parse(Console.ReadLine());
		int sum,input1,input2;
		switch(op){
			case 1: Console.WriteLine("Please enter the numbers for addition:");
					input1=int.Parse(Console.ReadLine());
					input2=int.Parse(Console.ReadLine());
					sum=input1+input2;
					Console.WriteLine("Sumation of the two numbers:"+ sum);
					break;
			case 2: Console.WriteLine("Please enter the numbers for substraction:");
					input1=int.Parse(Console.ReadLine());
					input2=int.Parse(Console.ReadLine());
					sum=input1-input2;
					Console.WriteLine("substraction of the two numbers:"+ sum);
					break;
			case 3: Console.WriteLine("Please enter the numbers for multiplication:");
					input1=int.Parse(Console.ReadLine());
					input2=int.Parse(Console.ReadLine());
					sum=input1*input2;
					Console.WriteLine("multiplication of the two numbers:"+ sum);
					break;
			case 4: Console.WriteLine("Please enter the numbers for division:");
				    input1=int.Parse(Console.ReadLine());
					input2=int.Parse(Console.ReadLine());
					sum=input1/input2;
					Console.WriteLine("division of the two numbers:"+ sum);
					break;
			default:Console.WriteLine("Invalid input please try again");
					Console.WriteLine();
					goto start;
			
			}
		
	}
	
}