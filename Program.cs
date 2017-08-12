using System;

namespace Exercicio6CalculaSalario
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int horasTrabalhadas, horasExtras;
            double salarioHora, salarioHoraExtra, salarioBase, salarioExtra, salarioTotal;
			Console.WriteLine("Digite o número de horas trabalhadas no mês: ");
			horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite o valor so salário por hora: ");
			salarioHora = Convert.ToDouble(Console.ReadLine());
            salarioBase = salarioHora * 160;

            if (horasTrabalhadas > 160)
            {
                horasExtras = horasTrabalhadas - 160;
                salarioHoraExtra = salarioHora * 1.5;
                // Console.WriteLine(salarioHoraExtra);
                salarioExtra = salarioHoraExtra * horasExtras;
                // Console.WriteLine(salarioExtra);
                salarioTotal = salarioBase + salarioExtra;
				Console.Write("O valor total do salário é " + salarioTotal );
				Console.ReadLine();
            }
            else
            {
                salarioTotal = salarioBase;
				Console.Write("O valor total do salário é " + salarioTotal);
				Console.ReadLine();
            }

        }
    }
}
