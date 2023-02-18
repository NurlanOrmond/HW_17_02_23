Console.WriteLine ("\nInput five positive digit number:  ");
int a = Convert.ToInt32(Console.ReadLine());
int count=0;

int i0 = a/10000;                          // still under inventing a formula to make a loop, so this part is a bit hard-coded and
int prom = a-a/10000*10000;                // it works for 5 digit numbers only

int i1 = prom/1000;
int prom1 = prom - prom/1000*1000;

int i2 = prom1/100;
int prom2 = prom1 - prom1/100*100;

int i3 = prom2/10;
int prom3 = prom2-prom2/10*10;

int i4 = prom3%10;

int [] arr1 = {i0,i1,i2,i3,i4};      // arr1 with Integer elements in it
int [] arr2 = new int [5];           // here i've created a copy of arr1

for (int i=0; i<arr1.Length; i++)
{
    arr2[(arr2.Length-1)-i]=arr1[i]; // made a reverse of elements in arr2
      
}
for (int i=0; i<arr1.Length; i++)
{
    

    if (arr1[i] == arr2[i]) // compairing
    {
        count++;            // count matching of elements 
    }
        
}
if (count==5)
{
    Console.WriteLine("Number {0} is Palindrome!", a);
}
else
{
   Console.WriteLine("Number {0} is NOT Palindrome!", a); 
}