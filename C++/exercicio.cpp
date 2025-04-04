#include <iostream>
#include <string>
using namespace std;

// Classe base Pessoa
class Pessoa {
protected:
    string nome;
    int idade;

public:
    Pessoa(string n, int i) : nome(n), idade(i) {}

    void imprimirNome() {
        cout << "O nome é: " << nome << endl;
    }

    virtual void idadeInfo() {
        cout << "Idade da pessoa: " << idade << " anos" << endl;
    }
};

// Classe derivada Professor
class Professor : public Pessoa {
public:
    Professor(string n, int i) : Pessoa(n, i) {}

    void idadeInfo() override {
        cout << "O professor tem " << idade << " anos." << endl;
    }
};

// Classe derivada Aluno
class Aluno : public Pessoa {
private:
    string matricula;

public:
    Aluno(string n, int i, string m) : Pessoa(n, i), matricula(m) {}

    void idadeInfo() override {
        cout << "O aluno tem " << idade << " anos." << endl;
    }

    void imprimirMatricula() {
        cout << "Matrícula do aluno: " << matricula << endl;
    }
};

// Função principal
int main() {
    Pessoa pessoa("Carlos", 45);
    Professor prof("Ana", 38);
    Aluno aluno("João", 20, "202310123");

    // Pessoa
    cout << "Pessoa" << endl;
    pessoa.imprimirNome();
    pessoa.idadeInfo();
    cout << endl;

    // Professor
    cout << "Professor" << endl;
    prof.imprimirNome();
    prof.idadeInfo();
    cout << endl;

    // Aluno
    cout << "Aluno" << endl;
    aluno.imprimirNome();
    aluno.idadeInfo();
    aluno.imprimirMatricula();
    cout << endl;

    return 0;
}
