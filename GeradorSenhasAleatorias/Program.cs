string alfaNumerico = "0123456789!@#$%&*()[]+-/|.abcdefghjkmnpqrstuvwxyz";
string senhaGerada = null;


Random random = new Random();
for (int i = 0; i <= 10; i++)
{
    senhaGerada += alfaNumerico.Substring(random.Next(0, alfaNumerico.Length - 1), 1);
}
Console.WriteLine("Sua senhha é:\n");
Console.WriteLine(senhaGerada);