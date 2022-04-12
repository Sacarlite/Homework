   /*
   
   double a = 0.0, b = 0.0;
    a =Convert.ToDouble( Console.ReadLine());
    b = Convert.ToDouble(Console.ReadLine());
    if (a > b) { 
        System.Console.WriteLine(b); 
    }
    else { 
        System.Console.WriteLine(a); 
    }
    */
       /*
  double a = 0.0, b = 0.0,c=0.0;
    a =Convert.ToDouble( Console.ReadLine());
    b = Convert.ToDouble(Console.ReadLine());
    c = Convert.ToDouble(Console.ReadLine());
   if (a >= b&&a>=c) { 
        System.Console.WriteLine(a);
    }
    else if(b>=a&&b>=c){
        System.Console.WriteLine(b); 
    }
    else if(c>=a&&c>=b) { 
        System.Console.WriteLine(c); 
    }
   */
   /*
    double a = 0.0;
    a =Convert.ToDouble( Console.ReadLine());
    if(a%2==0){
        System.Console.WriteLine("Да");
    }
        else { 
        System.Console.WriteLine("Нет");} 
    */
    int N=0;
    N =Convert.ToInt32( Console.ReadLine());
    do{
    if(N%2==0){
        N=N-2;
        System.Console.WriteLine(N);} 
    else{
        N--;
        System.Console.WriteLine(N);
    }
    }while(N!=2);