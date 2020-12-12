package bitfield

// package main

/**
 * Unlike in some of the other languages, where type conversions and custom indexers are possible,
 * the go version uses some basic functions on an alias type
 */

// BitField - Wrapper for `uint32`, does bit field things
type BitField uint32

// Get - Retrieve value from BitField
func (x *BitField) Get(i int) bool {
	return ((*x) & (1 << i)) != 0
}

// Set - Set value of bitfield
func (x *BitField) Set(i int, v bool) {
	if v {
		// Set
		*x |= 1 << i
	} else {
		// Clear
		// max XOR bit makes a bitmask, because go doesn't have ~
		*x &= 0xFFFFFFFF ^ (1 << i)
	}
}

/*
// Example test
func main() {
	var a BitField = 0b10

	println(a.Get(1))

	println(a.Get(0))

	a.Set(0, true)
	println(a.Get(0))
}*/
