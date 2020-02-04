# DesignPatterns

Singleton
------------

### Design pattern de criação

### Problema:
- Precisamos controlar o acesso as instâncias da classe garantindo que ela seja instanciada apenas uma vez.
- Reduzir a utilização de memória.
- Fornecer mais flexibilidade que a utilização de estruturas estáticas.

### Objetivo:

- O objetivo desse padrão é garantir que apenas uma única instância(o Singleton) da classe possa ser criada.

### Caracteristicas:

- Define uma operação responsável por garantir o acesso a uma única instância.
- Responsável por criar e manter sua própria instância única.

Factory Method - Método de fabrica
------------

> "Abstrações não devem depender de detalhes; Detalhes devem depender de abstrações"

### Design pattern de criação

### Problema:
- Eu não posso antecipar o tipo da classe de objeto que deve ser criada. Pois, tenho objetos de vários tipos.
- Preciso delegar a responsabilidade para que as subclasses especifiquem os objetos que criam.

### Objetivo:
- Também conhecido como Construtor Virtual, o objetivo do padrão é a possibilidade de criar uma fábrica de objetos em tempo de execução e deixar que o objeto decida seu tipo dinamicamente.

### Caracteristicas:
- O Factory Method dispoe uma interface que cria um objeto, mas são as subclasses, que iram decidir qual classe concreta instanciar


Abstract Factory - Fabrica abstrata
------------

### Design pattern de criação

### Problema:
- É preciso criar objetos que podem ter várias famílias de maneira consistente para não enviar objetos de famílias erradas

### Objetivo:
- Diferenciar cada objeto das famílias por interfaces e construir implementações de cada uma das famílias e depois construir uma implementação que vai retornar apenas objetos da mesma família

### Caracteristicas:
- Utilizado quando temos várias objetos e várias famílias de objetos
- A complexidade é mais alta em função das várias classes e interfaces criadas

Builder - Construtor
------------

### Design pattern de criação

### Definição
- Separe a construção de um objeto complexo de sua representação para que o mesmo processo de construção possa criar diferentes representações.

### Problema
- Criação de classes muito complexas, que normalmente envolvem muitos parâmetros específicas, que na grande maioria das vezes não é utilizado, mas está lá
- Construtores gigantes, com vários parâmetros muitas vezes não utilizados e inicialização e configuração do objeto espalhados

### Objetivo
- Separar a parte de construção do objeto de dentro da classe e delega essa responsabilidade para a classe builder, permitindo criar classes que definem passo a passo a construção de objetos complexos

### Caracteristicas
- Permite variar a representação interna de um produto
- Encapsula o código entre construção e representação
- Provê controle durante o processo de construção
- Requer criar um concrete builder específico para cada instância diferente do produto


