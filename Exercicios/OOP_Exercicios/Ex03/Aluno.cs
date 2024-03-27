using System;

namespace Ex03
{
    class Aluno
    {
        public string Nome;
        public double NotaUm;
        public double NotaDois;
        public double NotaTres;

        public void MediaFinal() {
            double media = (NotaUm + NotaDois + NotaTres) / 3;
            if(media < 5) {
                Console.WriteLine($"MÉDIA FINAL: {media:N2}\nREPROVADO\nFaltou {5 - media:N2} pontos para ser aprovado.");
            } else {
                Console.WriteLine($"MÉDIA FINAL: {media}\nAPROVADO");
            };
        }
    }
}