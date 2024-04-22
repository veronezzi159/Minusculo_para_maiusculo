char[] chars = new char[10];
char[] resultado = new char[10];

Console.WriteLine("Digite a palavra desejada");
for (int i = 0; i < 10; i++)
{
    chars[i] = char.Parse(Console.ReadLine());
    switch (chars[i])
    {
        case 'a':
            resultado[i] = 'A';
            break;
        case 'i':
            resultado[i] = 'I';
            break;
        case 'e':
            resultado[i] = 'E';
            break;
        case 'o':
            resultado[i] = 'O';
            break;
        case 'u':
            resultado[i] = 'U';
            break;
        default:
            resultado[i] = chars[i];
            break;
    }
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(resultado[i]);
}
