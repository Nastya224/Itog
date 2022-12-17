
Console.WriteLine("Введите натуральное число больше 0:");
int N = int.Parse(Console.ReadLine());
 
void NCounter (int N)
{
    if (N == 0) return;
    Console.Write("{0,4}", N);
    NCounter (N - 1);
}
 
NCounter(N);