public class Moto : Veiculo
{
    public override void Acelerar()
    {
        velocidade += 15;
        Console.WriteLine("A moto acelerou");
    }
    public override void Frear()
    {
        velocidade -= 10;
        Console.WriteLine("A moto freiou");
    }
}