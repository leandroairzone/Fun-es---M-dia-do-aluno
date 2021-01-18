using System;

namespace Funções__média_de_aluno
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] nomes = new string[10];
            float[] nota1 = new float[10];
            float[] nota2 = new float[10];
            float[] nota3 = new float[10];
            float[] nota4 = new float[10];
            float[] media = new float[10];
            string[] totalaprovados = new string[10];
            string[] totalreprovados = new string[10];
            int ap, rp;


            Console.WriteLine("Média dos alunos\n----------------");
            //Coletando Info
            for (var contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("digite o nome do(a) aluno(a)");
                nomes[contador] = Console.ReadLine();
                while (nomes[contador] == "")
                {
                    Console.Write("Você nâo digitou nenhum nome \nDigite o nome novamente: ");
                    nomes[contador] = Console.ReadLine();
                }
                Console.WriteLine("digite a primeira nota");
                nota1[contador] = float.Parse(Console.ReadLine());
                Console.WriteLine("digite a segunda nota");
                nota2[contador] = float.Parse(Console.ReadLine());
                Console.WriteLine("digite a terceira nota");
                nota3[contador] = float.Parse(Console.ReadLine());
                Console.WriteLine("digite a quarta nota");
                nota4[contador] = float.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------");
                while (nota1[contador] > 10 || nota2[contador] > 10 || nota3[contador] > 10 || nota4[contador] > 10)
                {
                    Console.WriteLine("Nota inválida.");
                    Console.WriteLine("digite a primeira nota");
                    nota1[contador] = float.Parse(Console.ReadLine());
                    Console.WriteLine("digite a segunda nota");
                    nota2[contador] = float.Parse(Console.ReadLine());
                    Console.WriteLine("digite a terceira nota");
                    nota3[contador] = float.Parse(Console.ReadLine());
                    Console.WriteLine("digite a quarta nota");
                    nota4[contador] = float.Parse(Console.ReadLine());
                    Console.WriteLine("-----------------------");
                }
            }
            Console.WriteLine("Alunos cadastrados!\n");
            //Fim do coletando infos

            //Exibindo Alunos e notas
            for (var contador = 0; contador < 10; contador++)
            {
                Console.WriteLine(nomes[contador]);
                Console.WriteLine(nota1[contador]);
                Console.WriteLine(nota2[contador]);
                Console.WriteLine(nota3[contador]);
                Console.WriteLine(nota4[contador]);
                Console.WriteLine("-----------------------");
            }
            //Fim exibindo alunos e notas

            //Mostrando media individual
            Console.WriteLine($"Média\n------------------");
            ap = 0;
            rp = 0;

            //Calculando a média
            for (var contador = 0; contador < 10; contador++)
            {
                media[contador] = (nota1[contador] + nota2[contador] + nota3[contador] + nota4[contador]) / 4;
                Console.WriteLine(nomes[contador]);
                Console.WriteLine("Média: "+notas(nota1[contador], nota2[contador], nota3[contador], nota4[contador]));
                //Verificando reprovação
                if (media[contador] >= 6 && media[contador] <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Aprovado(a)");
                    Console.ResetColor();
                    Console.WriteLine("-----------------");
                    totalaprovados[ap] = nomes[contador];
                    ap = ap + 1;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Reprovado(a)");
                    Console.ResetColor();
                    Console.WriteLine("-----------------");
                    totalreprovados[rp] = nomes[contador];
                    rp = rp + 1;
                }
                //fim verificando reprovação
            }
            //Fim calculando a média

            //Alunos aprovados
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Alunos aprovados");
            Console.ResetColor();
            Console.WriteLine("-----------------");

            string[] apvs = new string[ap];
            
            for (var contador = 0; contador < ap; contador++)
            {
                apvs[contador] = totalaprovados[contador];
            }
            
            for (var contador = 0; contador < ap; contador++)
            {
                Console.WriteLine("-"+apvs[contador]);
            }
            Console.WriteLine("-----------------");
            //Fim alunos aprovados

            //Alunos reprovados
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Alunos reprovados");
            Console.ResetColor();
            Console.WriteLine("-----------------");

            string[] rpvs = new string[rp];

            for (var contador = 0; contador < rp; contador++)
            {
                rpvs[contador] = totalreprovados[contador];
            }

            for (var contador = 0; contador < rp; contador++)
            {
                Console.WriteLine("-"+rpvs[contador]);
            }
            //Fim alunos reprovados

            //Total de alunos aprovados ou não
            Console.WriteLine("-----------------");
            Console.WriteLine($"Total de alunos aprovados: {ap}");
            Console.WriteLine($"Total de alunos reprovados: {rp}");
            //Total de alunos aprovados ou não

            //Media geral da sala
            Console.WriteLine("-----------------");
            Console.WriteLine("Média geral da sala: "+medias(media[0], media[1], media[2], media[3], media[4], media[5], media[6], media[7], media[8], media[9]));
            Console.WriteLine("-----------------");
            //Media geral da sala

            //Calculando media individual
            static float notas(float a, float b, float c, float d){
                float resu = (a + b + c + d) / 4;
                return resu;
            }
            
            //Calculando media geral
            static float medias(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j){
                float resumed = (a + b + c + d + e + f + g + h + i + j) / 10;

                return resumed;
            }
        }
    }
}
