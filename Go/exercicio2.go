package main

import (
	"fmt"
	"math/rand"
	"time"
)

func fatorial(n int) int {
	if n == 0 {
		return 1
	}
	return n * fatorial(n-1)
}

func main() {
	rand.Seed(time.Now().UnixNano()) // garante números diferentes a cada execução
	num := rand.Intn(11) // número entre 0 e 10
	fmt.Printf("Número aleatório gerado: %d\n", num)
	fmt.Printf("Fatorial de %d é %d\n", num, fatorial(num))
}
