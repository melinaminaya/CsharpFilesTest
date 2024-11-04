
namespace ByteBankIO;

partial class Program
{
    static void EscritaBinaria()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
        using (var escritor = new BinaryWriter(fs))
        //BinaryWriter does not identify numbers
        {
            escritor.Write(456);
            escritor.Write(546544);
            escritor.Write(4000.50);
            escritor.Write("Guga braga");
        }
    }
    static void LeituraBinaria()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
        using (var leitor = new BinaryReader(fs))
        {
            var agencia = leitor.ReadInt32();
            var numeroConta = leitor.ReadInt32();
            var saldo = leitor.ReadDouble();
            var titular = leitor.ReadString();

            Console.WriteLine($"{agencia}, {numeroConta}, {saldo}, {titular}");
        }
    }
}
