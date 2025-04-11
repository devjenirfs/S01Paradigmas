# Exercício 2: Classes, Herança e Polimorfismo

class Carro
    def descrever
      "Este é um carro comum."
    end
  end
  
  class CarroEsportivo < Carro
    def descrever
      "Este é um carro esportivo, rápido e potente."
    end
  end
  
  class CarroSedan < Carro
    def descrever
      "Este é um carro sedan, confortável e espaçoso."
    end
  end
  
  # Criando instâncias
  carro = Carro.new
  carro_esportivo = CarroEsportivo.new
  carro_sedan = CarroSedan.new
  
  # Chamando o método descrever
  puts carro.descrever
  puts carro_esportivo.descrever
  puts carro_sedan.descrever
  