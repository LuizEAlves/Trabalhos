ALGORITMO_MAIOR_2_NUMEROS
VAR   numero1, numero2 : REAL
      resultado : TEXTO
INICIO
 ESCREVA("Informe o primeiro numero")
 LEIA(numero1)
 ESCREVA("Informe o segundo numero")
 LEIA(numero2)
    SE(numero1=numero2) ENTAO
      resultado←"Os numeros informados são iguais"
    SENAO SE (numero1>numero2) ENTAO
      resultado←"O número1 é o maior"
    SENAO
      resultado←"O número2 é o maior"
    FIM-SENAO
 ESCREVA(resultado)
FIM

using Microsoft.AspNetCore.Mvc;

namespace WebAPIExEstruturaDecisao.Controllers
{
    public class Maior2NumerosController : Controller
    {
        [HttpPost("ExercicioMaior2Numeros")]
        public string ExercicioMaior2Numeros(int numero1Usuario, int numero2Usuario)
        {
            int numero1, numero2;
            string resultado;
            numero1 = numero1Usuario;
            numero2 = numero2Usuario;
            if (numero1 == numero2)
            {
                resultado = "Os números são iguais";
            }else if (numero1 > numero2)
            {
                resultado = $"O maior número é{numero1}";
            }
            else
            {
                resultado= $"O maior número é{numero2}";
            }
               return resultado;
        }
    }
}


ALGORITMO_MAIOR_3_NUMEROS
VAR   numero1, numero2, numero3 : REAL
      resultado : TEXTO
INICIO
 ESCREVA("Informe o primeiro numero")
 LEIA(numero1)
 ESCREVA("Informe o segundo numero")
 LEIA(numero2)
 ESCREVA("Informe o terceiro numero")
 LEIA(numero3)
   SE(numero1=numero2) E (numero1=numero3) ENTAO
        resultado← "Os numeros informados são iguais"
    SENAO
            SE(numero1=numero3) E (numero1>numero2) ENTAO
              resultado← "Os Numeros 1 e 3 SÃO OS MAIORES NUMEROS"
            SENAO SE (numero2=numero3) E (numero2>numero2) ENTAO
              resultado← "Os numeros 2 e 3 são os maiores numeros"
            SENAO SE (numero1>numero2) E (numero1>numero3) ENTAO
              resultado← "O numero1 é o maior numero"
            SENAO SE (numero2>numero1) E (numero2>numero3) ENTAO
              resultado← "O numero2 é o maior numero"  
            SENAO SE (numero3>numero1) E (numero3>numero2) ENTAO
            resultado← "O numero3 é o maior numero" 
            FIM-SE
    FIM_SE
FIM

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace WebAPIExEstruturaDecisao.Controllers
{
    public class Maior3NumerosController : Controller
    {
        [HttpPost("Maior3Numeros")]
        public string Maior3Numeros(double numero1Usuario,
            double numero2Usuario,
            double numero3Usuario)
        {
            double numero1, numero2, numero3;
            numero1= numero1Usuario;
            numero2= numero2Usuario;
            numero3 = numero3Usuario;
            


            string resultado;
            if ((numero1 == numero2) && (numero1 == numero3))
            {
                resultado = "Os três números informados são iguais";
            } else if ((numero1 == numero3) && (numero1 > numero2))
            {

                resultado = "Os números 1 e 3 são iguais e são os maiores";
            } else if ((numero1 == numero2) && (numero1 > numero3))
            {

                resultado = "Os números 1 e 2 são iguais e são os maiores";
            } else if ((numero2 == numero3) && (numero2 > numero1))
            {

                resultado = "Os números 2 e 3 são iguais e são os maiores";
            } else if ((numero1 > numero2) && (numero1 > numero3))
            {
                resultado = $"O maior número é o {numero1}";
            } else if ((numero2 > numero1) && (numero2 > numero3))
            {

            } else if ((numero2 > numero1) && (numero2 > numero3))
            {
                resultado = $"O maior número é {numero2}";
            }
            else
            {
                resultado = $"O maior número é {numero3}";
            }         
            
              return resultado;
            }
    }
}


ALGORITMO_IDADE_NADADOR
VAR idadeNadador, categoriaoNadador : REAL
    resultado : 
INICIO
ESCREVA("Informe a idade do nadador")
LEIA("idadeNadador")
SE((idade>=5) E (idade<=7)) ENTAO
ESCREVA("Nadador esta na categoria infantil A")
SENAO SE ((idade>7) E (idade=<11)) ENTAO
ESCRVEA ("Nadador esta na categoria inafntil B")
SENAO SE((idade))

ALGORITMO_CLASSIFICACAO_TRIANGULO
VAR ladoTriangulo1, ladoTriangulo2, LadoTriangulo3 : REAL
INICIO
ESCREVA("Informe o 1º lado do triangulo")
LEIA(ladoTriangulo1)
ESCREVA("Informe o 2º lado do triangulo")
LEIA(ladoTriangulo2)
ESCREVA("Informe o 3º lado do triangulo")
LEIA(ladoTriangulo3)
SE ((ladoTriangulo1 + ladoTriangulo2>ladoTriangulo3) E (LadoTriangulo3+ladoTriangulo2>ladoTriangulo1) E (ladoTriangulo1 + ladoTriangulo3>ladoTriangulo2) ENTAO
 SE ((ladoTriangulo1=ladoTriangulo2)) E (ladoTriangulo2=ladoTriangulo3) ENTAO
 ESCREVA("Triangulo Equilatero")
 SENAO SE
 ESCREVA("Triangulo Escaleno")
 SENAO
 ESCREVA ("Os lados informados não representam um triangulo")

 using Microsoft.AspNetCore.Mvc;

namespace WebAPIExEstruturaDecisao.Controllers
{
    public class TrianguloController : Controller
    {
        [HttpGet("VerificacaoTriangulo")]
        public string VerificacaoTriangulo(double trianguloLado1, double trianguloLado2,
                                           double trianguloLado3)
        {
            double ladoTriangulo1, ladoTriangulo2, ladoTriangulo3;
            string classificacaoTriangulo;
            ladoTriangulo1 = trianguloLado1;
            ladoTriangulo2 = trianguloLado2;
            ladoTriangulo3 = trianguloLado3;

            // Verifica se forma um triângulo
            if ((ladoTriangulo1 + ladoTriangulo2 > ladoTriangulo3) &&
                (ladoTriangulo2 + ladoTriangulo3 > ladoTriangulo1) &&
                (ladoTriangulo1 + ladoTriangulo3 > ladoTriangulo2))
            {
                // Equilátero
                if (ladoTriangulo1 == ladoTriangulo2 && ladoTriangulo2 == ladoTriangulo3)
                {
                    classificacaoTriangulo = ("TRIÂNGULO EQUILÁTERO");
                }
                // Isósceles
                else if (ladoTriangulo1 == ladoTriangulo2 ||
                         ladoTriangulo1 == ladoTriangulo3 ||
                         ladoTriangulo2 == ladoTriangulo3)
                {
                    classificacaoTriangulo = ("TRIÂNGULO ISÓSCELES");
                }
                // Escaleno
                else
                {
                    classificacaoTriangulo = ("TRIÂNGULO ESCALENO");
                }
            }
            else
            {
                classificacaoTriangulo = ("OS LADOS INFORMADOS NÃO REPRESENTAM UM TRIÂNGULO");
            }
            return classificacaoTriangulo;
        }
    }
}

ALGORITMO_MEDIA_ALUNO
VAR matricula, nota1, nota2, mediaAluno : REAL
    resultado : TEXTO
INICIO
ESCREVA("Informe a matricula do aluno")
LEIA("matricula")
ESCREVA("Informe a primeira nota do aluno")
LEIA("nota1")
ESCREVA("Informe a segunda nota do aluno")
LEIA("nota2")
mediaAluno←nota1+nota2/2 
SE (mediaAluno > 7) ENTAO
ESCREVA("Aluno aprovado")
SENAO SE (mediaAluno = 7) ENTAO
ESCREVA ("Aluno em recuperacao")
SENAO SE(mediaAluno < 7) ENTAO
ESCREVA("Aluno reprovado")
FIM_SE
FIM

using Microsoft.AspNetCore.Mvc;

namespace WebAPIExEstruturaDecisao.Controllers
{
    public class MediaAluno1Controller : Controller
    {
        public string MediaAluno(string matriculaAluno,
                                 double nota1Aluno,
                                 double nota2Aluno)
        {
            string matricula, mediaMensagem;
                double nota1, nota2, mediaNota;
            matricula = matriculaAluno;
            nota1 = nota1Aluno;
            nota2 = nota2Aluno;
            mediaNota = (nota1 + nota2) / 2;
            if (mediaNota > 7)
            {
                mediaMensagem = "ALUNO APROVADO";
            }else if (mediaNota == 7)
            {
                mediaMensagem = "ALUNO EM RECUPERAÇÃO";
            }
            else
            {
                mediaMensagem = "ALUNO REPROVADO";
            }
            return mediaMensagem;
        }
    }
}
