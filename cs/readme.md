# BitField C# #

BitField is a class for the manipulation of bitfield values,
it has implicit conversions and constructors for:

- int
- short
- uint
- ushort
- byte

You can access a single bit from a bitfield through

```c#
field[n]
```

as a boolean

## Example ##

```c#
BitField b = 0b0100u;

b[0]; // --- False

b[0] = true;
b[0]; // --- True

b[2]; // --- True
```
