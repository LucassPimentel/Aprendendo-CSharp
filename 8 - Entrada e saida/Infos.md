# Entrada e Saída (I/O)

## FileStream
Fornece um Stream, que é uma exibição genérica de uma sequência de bytes, para um 
arquivo, dando suporte a operações de leitura e gravação síncronas e assíncronas.
Precisa da diretiva `using System.IO`; Entrada e saída de dados. </br>
Exemplo e Sintaxe: </br>
`var fluxoDoArquivo = new FileStream(endereçoDoArquivo, açaoQueSeraFeita);`</br>
*Nota:* Há diversas ações que podem ser feitas, abrir, criar, escrever. É uma boa
prática utiliza-los com a diretiva using.

## Read
Basicamente o método Read lê o próximo caractere do fluxo de entrada e retorna
um int positivo se houver mais caracteres, ou zero quando houver acabado. 
Exemplo e Sintaxe: </br>
`fluxoDoArquivo.Read(arrayDoTipoByte, indiceQueComeçaráASerPreenchido, quantosBytesSeraoLidos)`
*Nota:* O array do tipo byte é aonde serão armazenadas as informações lidas, e tem
um nome comum, *buffer*.

## Encoding
Representa uma codificação ou decodificação de caracteres. A codificação é o 
processo de transformar um conjunto de caracteres Unicode em uma sequência de bytes.
A decodificação é o processo de transformar uma sequência de bytes codificados 
em um conjunto de caracteres Unicode. Há várias implementações de encoding, como: </br>
UTF8Encoding, UTF32Encoding, ASCIIEncoding...</br>
E vários métodos, como: </br>
GetString(byte[]) que decodifica os bytes.

## StreamReader
Implementa um TextReader que lê caracteres de um fluxo de bytes em uma codificação 
específica. Faz todo o processo de buffers, verificação por baixo dos panos. </br>
Exemplo e Sintaxe: </br>
~~~
var leitor = new StreamReader(varDeFileStream);
leitor.ReadLine();
~~~

## Manipulando arquivos CSV
### StreamWriter
Implementa um TextWriter para gravar caracteres em um fluxo em uma codificação 
específica. Lê e grava dados em um arquivo de determinada extensão em um diretório
específico ou genérico (local onde está o executável da aplicação.)</br>
Exemplo e Sintaxe: </br>
~~~
var escritor = new StreamWriter(varDeFileStream, Encoding)
escritor.Write('Olá, mundo.');
~~~
*Nota:* O arquivo que foi criado terá escrito 'Olá, mundo.'. O encoding é facultativo, 
é obrigatório ter o fluxo de arquivo (fileStream),e nesse caso de criação, o 
fileMode é o create.

## Método Flush
Limpa os buffers desse fluxo e faz com que todos os dados armazenados em buffer 
sejam gravados no arquivo, ou seja, não aguarda todos os dados serem armazenados
no buffer, ele lê e já grava um por um, é uma tarefa mais demorada.


