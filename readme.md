# Strings, expressoes regulares...
## Mais sobre a String
### Substring 
O método retorna uma string a partir de outra, passando o índice inicial e o final (se necessário).
### IndexOf
Método usado para retornar o índice de um caractere específico ou palavra </br>
Exemplo: </br>
`string.IndexOf("caractere/palavra desejado");`
### IsNullOrEmpty
Método usado para verificar se um valor é nulo ou vazio, retorna um valor booleano. </br>
Exemplo:</br>
`string.IsNullOrEmpty(nomeDaVarDesejada);`
### Remove
Método para remover de um índice até outro.
### StartsWith, EndsWith, Contains
O método StartsWith verifica se determinada string começa com uma letra/palavra e retorna um booleano. </br>
O endsWith a mesma coisa, só que verifica se determinada string é finalizada com uma letra/palavra. </br>
O Contain verifica se determinada string contém outra string, esteja ela no começo, meio ou fim. 
## Expressões Regulares
OBS: Regex = Regular Expressions.  São padrões utilizados para selecionar combinações de caracteres em uma string.
*Nota:* Para utilizar a classe Regex é necessário utilizar uma diretiva using.
### IsMatch
Método da classe Regex que retorna um valor booleano se determinada string combina com a expressão regular. </br>
Exemplo: </br>
`Regex.IsMatch(string, regex);`
### Match
Retorna um objeto que define as propriedades da string que combinou com a regex. Dispõe algumas funções pré definidas no '.'.
### Quantificadores
Os quantificadores são representados por números entre chaves (ex: {2}), significam
a quantidade de vezes que certa regex repetirá. Pode-se colocar vírgula para representar
que se quer de uma a outra quantidade. </br>
Exemplo: </br>
`string padrao = "[0-9]{4,5}-?[0-9]{4}";` </br>
*Nota:* Nesse exemplo o regex pode retornar um valor da primeira parte de 4 a 5 dígitos,
enquanto a segunda parte retorna 4 dígitos. A interrogação significa que pode ou não conter
o traço que separa os dois blocos de números.
