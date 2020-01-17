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
