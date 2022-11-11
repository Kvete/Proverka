string [] massive={"5890","22f","sd","wqew qe","=)", "dsdwasc"};
int count=0;
Console.WriteLine("старый массив:");
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i].Length<4) count++;
    Console.Write($"{massive[i]}, ");
}
Console.WriteLine();
Console.WriteLine("новый массив:");
string [] newMassive=new string[count];
count=0;
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i].Length<4)
    {
        newMassive[count]=massive[i];
        Console.Write($"{newMassive[count]}, ");
        count++;     
    }
}

Console.WriteLine();
