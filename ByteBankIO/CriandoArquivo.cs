using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "../contasExportadas.csv";
        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895,485.40, Gustavo Santos";
            var encoding = Encoding.UTF8;
            var bytes = encoding.GetBytes(contaComoString);

            fluxoDoArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "../contasExportadas.csv";

        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDoArquivo))
        {
            escritor.Write("456,65465,456.0,Pedro");
        }
    }

    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "../teste.csv";

        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDoArquivo))
        {
            for (int i = 0; i < 100000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush();
                 // Until here nothing was written in the file. That is why we use flush before
                Console.WriteLine($"Linha {i} foi escrita no arquivo.Tecle enter...");
                Console.ReadLine();
            }
        }
    }
}
