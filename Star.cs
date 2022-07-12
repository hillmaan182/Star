using System;
  
namespace HelloWorldApp {
  
class HelloWorld {
    static void Main(string[] args)
    {
	  
        int n= 5; // 0 < n <= 100
        int i, j, k;
	  for(i=1; i <= n; i++){
		for(j=1; j <= n-1; j++){
			Console.Write(" ");
		}
		for(k=1; k <= i; k++){
			Console.Write("*");
		}
		Console.WriteLine("");
	  }

	  Console.ReadKey();

    }
}
}