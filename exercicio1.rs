use std::io;

fn main() {
    loop {
        let mut num1 = String::new();
        let mut num2 = String::new();
        let mut operacao = String::new();

        println!("Digite o primeiro número:");
        io::stdin().read_line(&mut num1).expect("Erro ao ler a entrada");
        let num1: i32 = num1.trim().parse().expect("Digite um número válido!");

        println!("Digite o segundo número:");
        io::stdin().read_line(&mut num2).expect("Erro ao ler a entrada");
        let num2: i32 = num2.trim().parse().expect("Digite um número válido!");

        println!("Escolha a operação (+ para soma, * para multiplicação):");
        io::stdin().read_line(&mut operacao).expect("Erro ao ler a entrada");
        let operacao = operacao.trim();

        let resultado = match operacao {
            "+" => num1 + num2,
            "*" => num1 * num2,
            _ => {
                println!("Operação inválida!");
                continue;
            }
        };

        println!("O resultado é: {}", resultado);

        println!("Deseja continuar? (s/n)");
        let mut continuar = String::new();
        io::stdin().read_line(&mut continuar).expect("Erro ao ler a entrada");
        if continuar.trim().to_lowercase() != "s" {
            break;
        }
    }
}
