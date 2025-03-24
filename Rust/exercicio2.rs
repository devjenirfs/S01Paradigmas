fn preenche_arr(arr: &mut [i32; 10], x: i32) {
    for i in 0..10 {
        arr[i] = i as i32 * x;
    }
}

fn main() {
    let mut arr = [0; 10]; // Inicializa um array de 10 elementos com zeros

    // Solicita ao usuário um número para multiplicar os índices
    println!("Digite um número para preencher o array:");
    let mut input = String::new();
    std::io::stdin().read_line(&mut input).expect("Erro ao ler entrada");
    let number_cvt: i32 = input.trim().parse().expect("Digite um número válido!");

    // Chama a função para preencher o array
    preenche_arr(&mut arr, number_cvt);

    // Exibe o array preenchido
    println!("Array preenchido: {:?}", arr);
}
