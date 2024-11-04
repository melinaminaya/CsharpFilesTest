using System.Net;
using System.Text;
using ByteBankIO;

partial class Program
{
     static void Main(string[] args)
    {

        CriarArquivo();
        


        // var enderecoDoArquivo = "../contas.txt";

        // using(var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        // {
            // var leitor = new StreamReader(fluxoDoArquivo);
            // var texto = leitor.ReadLine();

            // var texto = leitor.ReadToEnd(); //if file too big is not so efficient

            // For big files, partition the text using while.
        //     while(!leitor.EndOfStream) 
        //     {

        //         var linha = leitor.ReadLine();
        //         var contaCorrente = ConverterStringParaContaCorrente(linha);

        //         var msg = $"Conta numero: {contaCorrente.Numero}, ag {contaCorrente.Agencia}";
        //         Console.WriteLine(linha);

        //     }
        // }
        Console.ReadLine();
    }
    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        // 375 4644 2483.13 Jonatan
        var campos = linha.Split(',');
        var agencia = campos[0];
        var numero = campos[1];
        var saldo = campos[2].Replace('.', ',');
        var nomeTitular = campos[3];

        var agenciaComInt = int.Parse(agencia);
        var numeroComInt = int.Parse(numero);
        var saldoComInt = double.Parse(saldo);


        var titular = new Cliente();
        titular.Nome = nomeTitular;


        var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
        resultado.Depositar(saldoComInt);
        resultado.Titular = titular;

        return resultado;
    }
}

// class Program
// {
//     static void Main(string[] args)
//     {
//         var enderecoDoArquivo = "../contas.txt";
//         var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);
//         var numeroDeBytesLidos = -1;

//         var buffer = new byte[1024]; //1Kb

//         // numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
//         while (numeroDeBytesLidos != 0)
//         {
//             numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024); //ocupy all positions so maybe duplicate positions

//             Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");
//             EscreverBuffer(buffer, numeroDeBytesLidos);
//         }
//         fluxoDoArquivo.Close(); //allow to edit file
//         // EscreverBuffer(buffer);
//         Console.ReadLine();

//     }

//     static void EscreverBuffer(byte[] buffer, int bytesLidos)
//     {
//         var utf8 = new UTF8Encoding();

//         var texto = utf8.GetString(buffer, 0, bytesLidos); //ensure that does not duplicate positions start at 0 and end in bytesLidos.

//         Console.Write(texto);

//     }
// }


