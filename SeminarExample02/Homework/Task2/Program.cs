// See https://aka.ms/new-console-template for more information
void Boom(int[] bah, int n)
{
int length = bah.Length - 1;

 while (0 <= length)
 {
     int len = n % 10;
     bah[length] = len;
     length--;
     n = n / 10;
}} 
Console.WriteLine("Enter number ");
int num =Convert.ToInt32(Console.ReadLine());
int i = 0;   
int ii = num;  

while (num > 0)
{    
    i++;
    num = num / 10;
}

if (i<3)
    Console.WriteLine("there is no third digit in this number");
else
{
int[] mas = new int[i];
Boom(mas, ii);
//int[] mas1 = new int[i];
Console.WriteLine() ;

//  void Revmas(int[] rev1, int[] rev2)
//  {
//      int r1 = rev1.Length - 1;
//      int r3 = r1;
//      int r2 = 0;
//      while (r2 <= r1)
//      {
//        rev2[r3] = rev1[r2]; 
//          r3--;
//          r2++;
//      }
//  }
 //Revmas(mas, mas1);
  
Console.WriteLine(mas[2]) ;   
}   

    

    






