# BitField D

D implementation of bitfield, aliased to `uint`

```d
void main(string[] args)
{
    BitField b = new BitField(0b10u);

    writeln(b[1]);

    writeln(b[0]);

    b[0] = true;
    writeln(b[0]);

    b[0] = false;
    writeln(b[0]);
}
```
