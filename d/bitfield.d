import std.stdio : writeln;

/// Class for bit field logic, implicitly converted into uint
class BitField
{
	/// Underlying data
	uint data;
	alias data this;
	// Expose data to casting methods

	/// Constructor
	this() { data = 0u;}

	/// Constructor
	this(uint d) { data = d; }
	/// Constructor
	this(ushort d) { data = d; }
	/// Constructor
	this(ubyte d) { data = d; }

	/// Constructor
	this(int d) { data = d; }
	/// Constructor
	this(short d) { data = d; }
	/// Constructor
	this(byte d) { data = d; }

	/// Indexer
	bool opIndex(size_t index)
	{
		return (data & (1u << index)) != 0;
	}

	/// Indexer
	void opIndexAssign()(bool value, size_t index)
	{
		if (value) {
			data |= 1 << index;
		} else {
			data &= ~(1 << index);
		}
	}
}

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