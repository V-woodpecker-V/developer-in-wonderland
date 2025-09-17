package main

import "fmt"

func addCoffees(morningCup, afternoonCup int) int {
    return morningCup + afternoonCup
}

func main() {
    fmt.Println(addCoffees(5, 3))
}