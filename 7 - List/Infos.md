# List< T >
É uma lista fortemente tipada de objetos que podem ser acessados por índice. Possui métodos próprios para pesquisar, classificar e manipula-la.
Exemplo e sintaxe:
~~~
List<tipo> nomeLista = new List<tipo>();
~~~
Ou mais simples
~~~
var nomeLista = new List<tipo>();
~~~
*Nota:* O tipo pode ser fixo ou um tipo genérico.
## Métodos Genéricos
É um método declarado com argumentos que podem receber diferentes tipos.
Sintaxe e Exemplo:
~~~~
static void nomeMetodo<T>(arg1 T, arg2 T) 
{
	bloco de código.
}
~~~~
*Nota:* O "T" é o tipo de dado que será recebido em uma futura chamada. Os argumentos podem ser variados, por exemplo, uma lista de tipo "T", ou um array de tipo "T".
## Lambdas
É uma função anônima, para cria-la é necessário especificar os parâmetros de entrada, se houver, e um código ou bloco de códigos. 
Sintaxe e Exemplo:
~~~
Func<int, int, int> Multiplicar = (x, y) => x * y;
~~~
*Nota:* O `func` é o tipo de lambda que está sendo usada no momento (verificar depois os tipos), o que está entre <> é o tipo dos argumentos e do retorno da lambda.
## Var

Variáveis podem ter ter um "tipo" implícito. Uma variável local de tipo implícito é fortemente tipada, como se você mesmo tivesse declarado o tipo, mas o compilador determina o tipo, ou seja, os exemplos a seguir são equivalentes, porém um tem seu tipo explícito e o outro implícito.
Exemplo:
~~~
var i = 10;
int i = 10;
~~~

