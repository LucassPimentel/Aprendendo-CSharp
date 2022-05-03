# Arrays e tipos genéricos

## Arrays
São coleções de dados com estruturas indexadas, ou seja, dados podem ser acessados,
a partir de seu índice. Podem ser iterados através de laços de repetições e com 
importantes propriedades, como a '.Length'. </br>
Sintaxe: </br>
`<tipoDeDado>[] <nomeDoArray> = new <tipoDeDado>[] {<dados>};` </br>
Exemplo:</br>
`int[] arrs = new int[]
  {
   17, 08, 2, 12
   };` </br>
*OBS:* O array não possui métodos de adicionar e remover pré definidos, ambos são feitos
pelo próprio programador, o que pode ser verboso e até complexo.

### ForEach
Método que executa um bloco de instruções para cada elemento em um array.
*OBS:* Basicamente a mesma coisa do for, porém mais simplificado.</br>
Exemplo e sintaxe: </br>
*Declarando o novo array e atribuindo valores* </br>
`int[] numeros = new int[] 
{
1,2,3
}`</br>
*Executando o foreach*</br>
`foreach(int numero in numeros)
{
Console.WriteLine(numero);
};` 

### Params
Palavra reservada que permite adicionar vários valores como argumentos para o array
no momento da chamada de um método, não sendo preciso declarar-los na construção
do método.</br>
*OBS:* Utilizado quando o argumento do método é um array, pois dessa forma, 
na chamada do método na Main, pode-se usar diversos valores sem se preocupar em 
adicionar mais argumentos na construção do método.</br>
Exemplo e sintaxe: </br>
`static int SomarVarios(params int[] numeros)
	int acumulador = 0;
	foreach(int numero in numeros) 
	{
	acumulador += numero;
	}`</br>
*Exemplo da chamada do método* </br>
`SomarVarios(5,2,4,5);`

### Classes genéricas
As classes genéricas encapsulam operações que não são específicas 
de um determinado tipo de dados, ou seja, sua classe ou método poderá trabalhar 
com qualquer tipo de dado. Em geral, você cria classes genéricas iniciando
com uma classe concreta existente e alterando os tipos para parâmetros 
de tipo, um por vez. O nome, por convênção, é 'T'. </br>
Exemplo e sintaxe: </br>
*OBS:* Primeiro é criado uma nova classe e adicionado o T entre <>. Depois criado
uma variável privada que recebe o tipo genérico (<T>) que vai tratar o valor passado
para a classe, após isso, adicionar um construtor para que ele receba o valor do
tipo <T> (construtor não é obrigatório).</br>
`public classe Exemplo<T>
{
	private T _valor;

	public Exemplo(T valor) 
	{
		_valor = valor;
	}

}`
*Instanciando um objeto de tipo genérico* </br>
`nomeClasse<int)> nomeInstancia = new nomeClasse<int>(valorPedidoNoConstrutor);
