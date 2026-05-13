//Crie um programa que receba dois números inteiros e exiba o resultado da soma, subtração, multiplicação e divisão entre eles.
VAR: numero1, numero2, multiplicacao, divisao,subtracao,adicao,
INICIO
 |ESCREVA("informe o primeiro numero")
 |LEIA(numero1)
 |ESCREVA("informe o segundo numero")
 |LEIA(numero2)
 |  soma←(numero1=numero2)
 |  subtracao←(numero1-numero2)
 |  multiplicacao←(numero1*numero2)
 |  divisao←(numeor1/numero2)
 |ESCREVA("O resultado da operação de adição é "+soma)
 |ESCREVA("O resultado da operação de subtração é " +subtracao)
 |ESCREVA("O resultado da operação de multiplicação é " multiplicacao)
 |ESCREVA("O resultado da operação de divisão é " +divisao)
 FIM    

double numero1, numero2, soma, subtracao, divisao, multiplicacao;
Console.WriteLine("informe o primeiro número");
numero1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("informe o segundo número");
numero2 = Convert.ToDouble(Console.ReadLine());
soma = numero1 + numero2;
subtracao = numero1 - numero2;
divisao = numero1 / numero2;
multiplicacao = numero1 * numero2;
Console.WriteLine("A SOMA DOS NÚMEROS INFORMADOS É:"+ soma);
Console.WriteLine("A SUBTRAÇÃO DOS NÚMEROS INFORMADOS É:" + subtracao);
Console.WriteLine("A DIVISÃO DOS NÚMEROS INFORMADOS É:" + divisao);
Console.WriteLine("A MULTIPLICAÇÃO DOS NÚMEROS INFORMADOS É:" + multiplicacao);

//Desenvolva um algoritmo que peça o raio de um círculo, calcule e mostre sua área (Fórmula: Área = 3.14159 * raio²).
ALGORITMO_AREA_CIRCUNFERENCIA
VAR raio, areaCircunferencia : ReadLine
INICIO
 |LEIA(raio)
 | areaCircunferencia=(3,1416)*raio*raio
 |ESCREVA("A área da circunferência é"+areaCircunferencia)
 FIM
double raio, areaCircunferencia;
Console.WriteLine("informe o raio para saber a área da circunferência");
raio = Convert.ToDouble(Console.ReadLine());
areaCircunferencia = Math.Round(Math.PI * Math.Pow(raio, 2)2);
Console.WriteLine("A área da circunferência é" + areaCircunferencia);

//Faça um programa que peça as 4 notas bimestrais de um aluno e calcule a média aritmética simples final.
ALGORITMO_MEDIA_NOTAS
VAR nota1, nota2, nota3, nota4, mediaNotas : REAL
INICIO
 |ESCREVA("INFORME A NOTA 1")
 |LEIA(nota1)
 |ESCREVA("INFORME A NOTA 2")
 |LEIA(nota2)
 |ESCREVA("INFORME A NOTA 3")
 |LEIA(nota3)
 |ESCREVA("INFORME A NOTA 4")
 |LEIA(nota4)
 |  mediaNotas←(nota1+nota2+nota3+nota4)/4
 |ESCREVA("A MÉDIA DAS NOTAS INFORMADAS É"+ mediaNotas)
 FIM

 double nota1, nota2, nota3, nota4, mediaNotas;
Console.WriteLine("Informe a nota um ");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe a nota dois ");
nota2 = Convert.ToDouble(Console.ReadLine());
Console
.WriteLine("Informe a nota três ");
nota3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe a nota quatro ");
nota4 = Convert.ToDouble(Console.ReadLine());
mediaNotas = (nota1 + nota2 + nota3 + nota4) / 4;
Console.WriteLine("A média das notas informadas é" + mediaNotas);

//Crie um programa que receba um valor em graus Celsius e o converta para Fahrenheit (Fórmula: F = C * 1.8 + 32)
ALGORITMO_CONVERSOR_FAHRENHEIT
VAR     temperaturaCelsius, temperaturaFahrenheit   : REAL;
INICIO
    ESCREVA('informe a temperatura em Celsius')
    LEIA(temperaturaCelsius)
    temperaturaFahrenheit←temperaturaCelsius*1.8+32
    ESCREVA('A conversão da temperatura de Celsius para Fahrenheit é'+ temperaturaFahrenheit)
FIM
double temperaturaCelsius, temperaturaFahrenheit;
Console.WriteLine("informe a temperatura em celcius");
temperaturaCelsius = Convert.ToDouble(Console.ReadLine());
temperaturaFahrenheit = temperaturaCelsius * 1.8 + 32;
Console.WriteLine($"A temperatura {temperaturaCelsius} graus Celsius em celcius  é em Fahrenheit {temperaturaFahrenheit}");

//Escreva um programa que receba o salário fixo de um vendedor e o total de suas vendas. Calcule e exiba a comissão (15%) e o salário total.
ALGORITMO_SALARIO_VENDEDOR
VAR     salárioFixo, valorTotalVendas, salárioTotal, comissao    : REAL
INICIO
    ESCREVA('informe o valor total de vendas do vendedor');
    LEIA(totalVendas)
    ESCREVA('Informe o salário do vendedor');
    LEIA(salárioFixo)
    comissao←valorTotalVendas*0,15
    salárioTotal←comissao+salárioFixo
    ESCREVA('A comissão total do vendedor é de R$'+ comissao 'e seu salário total é de R$'+ salárioTotal)
FIM
double salarioFixo, valorTotalVendas, salárioTotal, comissao;
Console.WriteLine('Informe o valor total de vendas do vendedor');
valorTotalVendas = Convert.ToDouble(Console.ReadLine());
Console.WriteLine('Informe o salário fixo do vendedor');
salarioFixo = Convert.ToDouble(Console.ReadLine());
//Processament
comissao = valorTotalVendas*0,15;
salárioTotal = (comissao + salarioFixo);
//Saída
Console.WriteLine($"A comissão do vendedor" +
    $"cujo salário fixo é {salarioFixo}" +
    $"e que vendeu R$ {valorTotalVendas}" +
    $"sera de R$ {comissao}, já o seu salário" +
    $"total será de R$ {salárioTotal}.");