int NumberOfLines(string[] array)
{
   int size = 0;

   for(int i =0; i < array.Length; i++)
      {
         if(array[i].Length < 4)
         size++;
      }
   
   return size;
}

string[] myString = {"hello", "2", "world", ":-)"}; //{"1234", "1567", "-2", "computer science"}; {"Russia", "Denmark", "Kazan"};