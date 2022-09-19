string[] ChooseShirterStrings(string[] ArrayOfStrings, int MaxLength)
{
   int Number =0; //  число строк короче MaxLength+1 

   for (int i=0; i<ArrayOfStrings.Length; i++)  
   {
     if (ArrayOfStrings[i].Length<=MaxLength && ArrayOfStrings[i].Length>0) 
        Number++;
    
   }     
   string[] ArrayOfShirtStrings = new string[Number];
   int j=0;

   for (int i=0; i<ArrayOfStrings.Length && j<Number; i++)
   if (ArrayOfStrings[i].Length<=3 && ArrayOfStrings[i].Length>0 )
      { ArrayOfShirtStrings[j]=ArrayOfStrings[i]; 
        j++; 
      }  
  return ArrayOfShirtStrings;
}
void PrintArray(string[] Array)
{ 
  System.Console.Write("[");
  if(Array.Length>0)
    { int i;
      for ( i = 0; i < Array.Length-1; i++)
        System.Console.Write($"'{Array[i]}',"); 
      System.Console.Write($"'{Array[i]}']");
    }       
  else 
    System.Console.Write("]");    
 }   


int Number=3;
string[] ArrayOfStrings1 = new string[] {"!@#66t","", "34","yg6 ", "ty5", "","6543","76br! g"};
string[] ArrayOfShirterStrings1=ChooseShirterStrings(ArrayOfStrings1,Number);
string[] ArrayOfStrings2 = new string[] {"Сургут", "Тюмень","Краснодар"};
string[] ArrayOfShirterStrings2=ChooseShirterStrings(ArrayOfStrings2,Number);
PrintArray(ArrayOfStrings1);
System.Console.Write("->");
PrintArray(ArrayOfShirterStrings1);
System.Console.WriteLine();
PrintArray(ArrayOfStrings2);
System.Console.Write("->");
//System.Console.WriteLine(ArrayOfShirterStrings2[2]);
PrintArray(ArrayOfShirterStrings2);