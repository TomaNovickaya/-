class StringArrays {
	static void Main() {
		string[] arr1 = new string [4]  { "Hello", "2", "world", ":-)" };
        string[] arr2 = new string [arr1.Length];
       
        Console.WriteLine();
		Console.WriteLine("Исходный массив: ");
		for(int i=0; i < arr1.Length; i++)
			Console.Write(arr1[i] + " ");
		Console.WriteLine("\n");
		
		Console.WriteLine("Новый массив массив: ");
        
		for(int i=0; i < arr1.Length; i++)
      {
        if (arr1[i].Length<=3) 
       {
        arr2[i]=arr1[i];
        
       }
        Console.Write(arr2[i] + " ");
      }
		
	}
}