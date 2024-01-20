//Нахождение максимума
int [] array = {19,20,3,16,8,4};
int i =0;
int max =array[0];

while (i< array.Length)
{
    if (max<array[i])
    {
        max = array[i];
    }
    i++;
}
Console.WriteLine(max);

max =array[0];

for(int j =0; j<array.Length; j++)

{
    if (max<array[j])
    {
        max = array[j];
    }
}
Console.WriteLine(max);
max =array[0];

foreach (int e in array)
{
    
    if (max<e)
    {
        max = e;
    }
}
Console.WriteLine(max);
