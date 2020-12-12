﻿using System;

/**
 * BitField is a class for the manipulation of bitfield values,
 * it has implicit conversions and constructors for:
 * 
 * - int
 * - short
 * - uint
 * - ushort
 * - byte
 * 
 * You can access a single bit from a bitfield through
 * 
 * ```c#
 * field[n]
 * ```
 * 
 * as a boolean
 * 
 * EXAMPLE
 * 
 * ```c#
 * BitField b = 0b0100u;
 * 
 * b[0]; // --- False
 * 
 * b[0] = true;
 * b[0]; // --- True
 * 
 * b[2]; // --- True
 * ```
 */

namespace bitfield
{
    public class BitField
    {
		// Internal Data
		protected uint data;

		// Constructors
		public BitField() => data = 0;

		// SIGNED
		public BitField(int data) => this.data = (uint)data;
		public BitField(short data) => this.data = (uint)data;

		// UNSIGNED
		public BitField(uint data) => this.data = data;
		public BitField(ushort data) => this.data = (uint)data;
		public BitField(byte data) => this.data = (uint)data;


		// Implicit conversions into BitField
		// SIGNED
		public static implicit operator BitField(int source) => new BitField(source);
		public static implicit operator BitField(short source) => new BitField(source);

		// UNSIGNED
		public static implicit operator BitField(uint source) => new BitField(source);
		public static implicit operator BitField(ushort source) => new BitField(source);
		public static implicit operator BitField(byte source) => new BitField(source);


		// Implicit conversions from BitField
		// SIGNED
		public static implicit operator int(BitField bit) => (int)bit.data;
		public static implicit operator short(BitField bit) => (short)bit.data;

		// UNSIGNED
		public static implicit operator uint(BitField bit) => bit.data;
		public static implicit operator ushort(BitField bit) => (ushort)bit.data;
		public static implicit operator byte(BitField bit) => (byte)bit.data;

		
		// Indexer
		public bool this[int index]
		{
			get => (data & (1u << index)) != 0;
			set => data = (value 
				? (data | (1u << index)) // value = true --> set bit
				: (data & ~(1u << index)) // value = false --> clear bit
			);
		}
	}
}

