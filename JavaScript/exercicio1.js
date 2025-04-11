// Classe base Animal
class Animal {
    constructor(nome, idade, especie) {
      this.nome = nome;
      this.idade = idade;
      this.especie = especie;
    }
  
    printInfo() {
      console.log(`Nome: ${this.nome}, Idade: ${this.idade}, Espécie: ${this.especie}`);
    }
  }
  
  // Classe Cachorro herdando de Animal
  class Cachorro extends Animal {
    #raca; // atributo privado
  
    constructor(nome, idade, especie, raca) {
      super(nome, idade, especie);
      this.#raca = raca;
    }
  
    printInfo() {
      super.printInfo();
      console.log(`Raça: ${this.#raca}`);
    }
  }
  
  // Classe Gato herdando de Animal
  class Gato extends Animal {
    constructor(nome, idade, especie, cores) {
      super(nome, idade, especie);
      this.cores = cores; // array de cores
    }
  
    printInfo() {
      super.printInfo();
      console.log(`Cores: ${this.cores.join(", ")}`);
    }
  }
  
  // Criando os objetos
  const animalGenerico = new Animal("Tigre", 5, "Felino");
  const cachorro = new Cachorro("Bolt", 3, "Canino", "Golden Retriever");
  const gato = new Gato("Mimi", 2, "Felino", ["branco", "cinza"]);
  
  // Chamando os métodos
  animalGenerico.printInfo();
  console.log("------------");
  cachorro.printInfo();
  console.log("------------");
  gato.printInfo();
  