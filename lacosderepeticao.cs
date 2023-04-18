
            double salario = 0.00;
            double numeroFilhos = 0.00;
            double mediaSalario = 0.00;
            double totalSalario = 0.00;
            double totalFilhos = 0.00;
            double mediaNumeroFilhos = 0.00;
            double maiorSalario = 0.00;
            double percentualSalarioAte100 = 0.00;
            double contadorSalarioAte100 = 0.00;

            int habitantes = 3;

            for (int i = 1; i <= habitantes; i++)
            {
                Console.Write("Digite seu salário:");
                salario = double.Parse(Console.ReadLine());
                Console.Write("Número de filhos:");
                numeroFilhos = double.Parse(Console.ReadLine());

                //totalizar o salario
                totalSalario = totalSalario + salario;
                totalFilhos += numeroFilhos;

                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }

                if ( salario >= 100 )
                {
                    contadorSalarioAte100++;
                }
            }

            mediaNumeroFilhos = (totalFilhos / habitantes);
            mediaSalario = (totalSalario / habitantes);
            percentualSalarioAte100 = (contadorSalarioAte100 / habitantes) * 100;
            Console.WriteLine("Total Salarios:" + totalSalario);
            Console.WriteLine("Media salario:" + mediaSalario);

            Console.WriteLine("Total Filhos:" + totalFilhos);
            Console.WriteLine("Media filhos:" + mediaNumeroFilhos);

            Console.WriteLine("Percentual:" + percentualSalarioAte100 + "%");
         
