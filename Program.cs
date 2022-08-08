int[,,] arr = new int[2,2,2];

int n = 10;

for (int i = 0; i < 2; i++)
{
for (int j = 0; j < 2; j++)
{
for (int k = 0; k < 2; k++)
{
arr[i,j,k] = n;
Console.WriteLine($"{arr[i,j,k]} ({i}{j}{k})");

n++;
}
}
}