# BitField Go

Unlike in some of the other languages, where type conversions and custom indexers are possible, the go version uses some basic functions on an alias type for `uint32`

```go
func main() {
    var a BitField = 0b10

    println(a.Get(1))

    println(a.Get(0))

    a.Set(0, true)
    println(a.Get(0))
}
```
