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

string[] ThreeCharacters(string[] array, int size)
{
   string[] Arr = new string[size];

   for(int i =0; i < array.Length; i++)
         if(array[i].Length < 4)
         {
         Arr[Arr.Length - size] = array[i];
         size--;
         }
   
   return Arr;
}

string[] myString = {"hello", "2", "world", ":-)"}; //{"1234", "1567", "-2", "computer science"}; {"Russia", "Denmark", "Kazan"};