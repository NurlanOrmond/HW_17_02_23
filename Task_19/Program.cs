Console.WriteLine ("\nInput five positive digit number:  ");
int a = Convert.ToInt32(Console.ReadLine());
int b =a;
int count=0;
int [] arr1 = new int [5];     
int [] arr2 = new int [5];   

for (int i = arr1.Length - 1; i>=0; i--)
{
    arr1 [i] = a%10;
    a=a/10;
}

   for (int i=0; i<arr1.Length; i++)
{
    arr2[(arr2.Length-1)-i]=arr1[i]; 
      
}
for (int i=0; i<arr1.Length; i++)
{
    
    if (arr1[i] == arr2[i])  count++;            
            
}
if (count==arr1.Length) Console.WriteLine($"Number {b} is Palindrome!");

else
Console.WriteLine($"Number {b} is NOT Palindrome!"); 