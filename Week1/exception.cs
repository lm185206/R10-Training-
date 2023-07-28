using System;

class Program{
	static void Main(string[] args){
		
		Console.WriteLine("Please select the operation you want to perform:");
		Console.WriteLine("1.Addition  2.Substraction 3.Multiplication 4.Division");
		int op=int.Parse(Console.ReadLine());
		int sum,input1,input2,flag=1;
		try{
			do{
				if(op==1){
					Console.WriteLine("Please enter the numbers for addition:");
					input1=int.Parse(Console.ReadLine());
					input2=int.Parse(Console.ReadLine());
					sum=input1+input2;
					Console.WriteLine("Sumation of the two numbers:"+ sum);
				}
				else if(op==2){
					Console.WriteLine("Please enter the numbers for substraction:");
					input1=int.Parse(Console.ReadLine());
					input2=int.Parse(Console.ReadLine());
					sum=input1-input2;
					Console.WriteLine("substraction of the two numbers:"+ sum);
				}
				else if(op==3){
					Console.WriteLine("Please enter the numbers for multiplication:");
					input1=int.Parse(Console.ReadLine());
					input2=int.Parse(Console.ReadLine());
					sum=input1*input2;
					Console.WriteLine("multiplication of the two numbers:"+ sum);
				}
				else if(op==4){
					Console.WriteLine("Please enter the numbers for division:");
				    input1=int.Parse(Console.ReadLine());
					input2=int.Parse(Console.ReadLine());
					if(input2==0){
					    throw new DivideByZeroException("cannot enter 0 as denominator");
					}
					sum=input1/input2;
					Console.WriteLine("division of the two numbers:"+ sum);
				}
				else{
					flag=0;
					Console.WriteLine("Invalid input please try again");
					Console.WriteLine();
				}
			}while(flag==0);
		}
		catch(Exception ex){
		    Console.WriteLine("Unhandled exception");
		    Console.WriteLine(ex.Message);
		}
	}
	
}