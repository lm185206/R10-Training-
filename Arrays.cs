using System;

class Program{
	static void Main(string[] args)
	{
		int[] array1 = new int[5];
		int initiate=0;
		Console.WriteLine("The elements are:");
		for(int i=0;i<array1.Length;i++){
			array1[i]=initiate;
			initiate++;
			Console.Write(array1[i]+" ");
		}
		array1[2]=20;
		Console.WriteLine();
		Console.WriteLine("Updated array:");
		foreach(int j in array1){
		    Console.Write(j+" ");
		}
	}
	
}