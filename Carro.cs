public class Carro : Veiculo
{
    public override void Acelerar()
    {
        velocidade += 10;
        Console.WriteLine("A carro acelerou");
    }
    public override void Frear()
    {
        velocidade -= 5;
        Console.WriteLine("O carro freiou");
    }
}