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
Console.Write(max);