package main

import "fmt"

func collectNumbers(n int, result []int) []int {
    if result == nil {
        result = []int{}
    }
    
    if n <= 0 {
        return result
    }
    
    result = append(result, n)
    return collectNumbers(n-1, result)
}

func main() {
    fmt.Println("First call:", collectNumbers(3, nil))
    fmt.Println("Second call:", collectNumbers(2, nil))
    fmt.Println("Third call:", collectNumbers(4, nil))
}