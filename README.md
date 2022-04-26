# Aprendendo-CSharp
Aprendendo C# através dos cursos da Alura, práticas e pesquisas.


# Definições Importantes

## Classes
  As classes são por exemplo, plantas de casas, pois a partir de uma planta de uma casa, pode ser construídas diversas casas, com diferentes mobílias, ou seja, é um gabarito para a criação de um novo objeto.
  
## Objetos
  São, basicamente, integrantes das classes, seguindo seus parâmetros, especificidades...
  
## Atributos
  São 'características' de um objeto.
  
## Métodos
  São funções que objetos podem realizar que não retornarm nada.
  
## Construtor
  É um método de mesmo nome da classe, que é executado toda vez que se instancia um objeto de determinada classe.
  
## Encapsulamento 
  Restrige o acesso das informações pertencentes a classes, tornando-as publicas, privadas ou protegidas.
  Nota: 
   - private - apenas visível dentro da classe; 
   - protected - visível dentro da classe e também para as filhas, repare também que protected é relacionado com a herança. 
   - public - visível em todo lugar. 
   - internal - visível somente dentro do projeto pertencente.
   - internal protected - visível somente dentro do projeto pertencente e das classes derivadas.
  
## Polimorfismo
  É basicamente a capacidade das classes de invocar métodos 'semelhantes' mas com comportamentos diferentes, ou seja, a utilização 
  de um método em diferentes classes e realizando diferentes tarefas. A utilização requer as palavras reservadas 'virtual', que 
  especifica ao C# que aquele método poderá ser sobrescrevido (sofrer alterações), e o 'override', que especifica que aquele método está
  sobrescrevendo o padrão.
 
## Utilização do 'this'
  É utilizado quando há nomes de atributos e parâmetros iguais. O this sempre vai referenciar o valor do atributo e não do parâmetro.
  
## Abstração
  É uma classe que pode conter métodos obrigatórios para todas as classes que a herdarem, também é possível a criação de métodos abstrados, que acaba tornando obrigatória a sobrescrita na criação de uma classe que herda a classe abstrata.
  Uma classe abstrata não pode ser instanciada.

## Interface
  É utilizada, geralmente, para criar métodos obrigatórios, e são por padrão abstratos e públicos, mas esses métodos não tem corpo, regra, dentro da interface, somente a assinatura, o corpo é feito na classe concreta que a implementa. Uma classe pode implementar várias interfaces. Todas as interfaces, por convenção, devem iniciar o nome com I.
