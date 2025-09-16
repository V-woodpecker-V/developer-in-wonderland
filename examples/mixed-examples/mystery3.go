package main

import "fmt"

func mystery(x int) string {
    if x > 0 {
        return "positive"
    } else if x < 0 {
        return "negative"
    } else {
        return "zero"
    }
}

func main() {
    fmt.Println(mystery(5))
    fmt.Println(mystery(-3))
    fmt.Println(mystery(0))
}