# Aula - 2 - Variáveis

  As variáveis são declaradas da seguinte forma:
  <br/>
  `'tipo-da-var' 'nome-da-var' = 'valor-da-var';`
#### Exemplo: `int idade = 17;`

## TIPOS NUMÉRICOS:

 - Int = Número inteiro (positivo ou negativo).

 - Long = Número inteiro com a capacidade bem maior de caracteres

 - Short = Número inteiro com a capacidade bem menor de caracteres.

 - Float = Número decimal (pouco usado) com baixa precisão dos decimais. <br/>
   OBS: Para utilizar o float é necessário adicionar um 'f' como sufixo. Exemplo: `float altura = 1.80f;`

 - Double = Número decimal preciso, mais utilizado no C#.


### OBS's: 
Em caso de operações matemáticas entre double ou float com int's, normalmente é adicionado o
'.0' em números double que não possuam decimais, pois quando não adicionado os decimais podem ser ignorados e transformados em int's.


## CONVERSÃO: 
  Para realizar uma conversão é necessário adicionar o tipo na frente da variável a qual se quer converter. 
  #### Exemplo: `double salario = 1350.26` <br/> `int salarioInteiro = (int)salario`
  
### OBS's: Nota-se que a variável 'salário', perderá o decimal '0.26'. 
  
