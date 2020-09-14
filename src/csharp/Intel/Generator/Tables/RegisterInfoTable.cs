/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using Generator.Enums;

namespace Generator.Tables {
	sealed class RegisterInfo {
		public EnumValue Register { get; }
		public EnumValue Base { get; }
		public EnumValue FullRegister { get; }
		public int Size { get; }

		public RegisterInfo(EnumValue register, EnumValue @base, EnumValue fullRegister, int size) {
			Register = register;
			Base = @base;
			FullRegister = fullRegister;
			Size = size;
		}
	}

	[TypeGen(TypeGenOrders.NoDeps)]
	sealed class RegisterInfoTable {
		public readonly RegisterInfo[] Data;

		RegisterInfoTable(GenTypes genTypes) {
			Data = CreateData(genTypes);
			genTypes.AddObject(TypeIds.RegisterInfoTable, this);
		}

		static RegisterInfo[] CreateData(GenTypes genTypes) {
			var reg = genTypes[TypeIds.Register];
			var result = new List<RegisterInfo> {
				new RegisterInfo(reg[nameof(Register.None)], reg[nameof(Register.None)], reg[nameof(Register.None)], 0),
				new RegisterInfo(reg[nameof(Register.AL)], reg[nameof(Register.AL)], reg[nameof(Register.RAX)], 1),
				new RegisterInfo(reg[nameof(Register.CL)], reg[nameof(Register.AL)], reg[nameof(Register.RCX)], 1),
				new RegisterInfo(reg[nameof(Register.DL)], reg[nameof(Register.AL)], reg[nameof(Register.RDX)], 1),
				new RegisterInfo(reg[nameof(Register.BL)], reg[nameof(Register.AL)], reg[nameof(Register.RBX)], 1),
				new RegisterInfo(reg[nameof(Register.AH)], reg[nameof(Register.AL)], reg[nameof(Register.RAX)], 1),
				new RegisterInfo(reg[nameof(Register.CH)], reg[nameof(Register.AL)], reg[nameof(Register.RCX)], 1),
				new RegisterInfo(reg[nameof(Register.DH)], reg[nameof(Register.AL)], reg[nameof(Register.RDX)], 1),
				new RegisterInfo(reg[nameof(Register.BH)], reg[nameof(Register.AL)], reg[nameof(Register.RBX)], 1),
				new RegisterInfo(reg[nameof(Register.SPL)], reg[nameof(Register.AL)], reg[nameof(Register.RSP)], 1),
				new RegisterInfo(reg[nameof(Register.BPL)], reg[nameof(Register.AL)], reg[nameof(Register.RBP)], 1),
				new RegisterInfo(reg[nameof(Register.SIL)], reg[nameof(Register.AL)], reg[nameof(Register.RSI)], 1),
				new RegisterInfo(reg[nameof(Register.DIL)], reg[nameof(Register.AL)], reg[nameof(Register.RDI)], 1),
				new RegisterInfo(reg[nameof(Register.R8L)], reg[nameof(Register.AL)], reg[nameof(Register.R8)], 1),
				new RegisterInfo(reg[nameof(Register.R9L)], reg[nameof(Register.AL)], reg[nameof(Register.R9)], 1),
				new RegisterInfo(reg[nameof(Register.R10L)], reg[nameof(Register.AL)], reg[nameof(Register.R10)], 1),
				new RegisterInfo(reg[nameof(Register.R11L)], reg[nameof(Register.AL)], reg[nameof(Register.R11)], 1),
				new RegisterInfo(reg[nameof(Register.R12L)], reg[nameof(Register.AL)], reg[nameof(Register.R12)], 1),
				new RegisterInfo(reg[nameof(Register.R13L)], reg[nameof(Register.AL)], reg[nameof(Register.R13)], 1),
				new RegisterInfo(reg[nameof(Register.R14L)], reg[nameof(Register.AL)], reg[nameof(Register.R14)], 1),
				new RegisterInfo(reg[nameof(Register.R15L)], reg[nameof(Register.AL)], reg[nameof(Register.R15)], 1),
				new RegisterInfo(reg[nameof(Register.AX)], reg[nameof(Register.AX)], reg[nameof(Register.RAX)], 2),
				new RegisterInfo(reg[nameof(Register.CX)], reg[nameof(Register.AX)], reg[nameof(Register.RCX)], 2),
				new RegisterInfo(reg[nameof(Register.DX)], reg[nameof(Register.AX)], reg[nameof(Register.RDX)], 2),
				new RegisterInfo(reg[nameof(Register.BX)], reg[nameof(Register.AX)], reg[nameof(Register.RBX)], 2),
				new RegisterInfo(reg[nameof(Register.SP)], reg[nameof(Register.AX)], reg[nameof(Register.RSP)], 2),
				new RegisterInfo(reg[nameof(Register.BP)], reg[nameof(Register.AX)], reg[nameof(Register.RBP)], 2),
				new RegisterInfo(reg[nameof(Register.SI)], reg[nameof(Register.AX)], reg[nameof(Register.RSI)], 2),
				new RegisterInfo(reg[nameof(Register.DI)], reg[nameof(Register.AX)], reg[nameof(Register.RDI)], 2),
				new RegisterInfo(reg[nameof(Register.R8W)], reg[nameof(Register.AX)], reg[nameof(Register.R8)], 2),
				new RegisterInfo(reg[nameof(Register.R9W)], reg[nameof(Register.AX)], reg[nameof(Register.R9)], 2),
				new RegisterInfo(reg[nameof(Register.R10W)], reg[nameof(Register.AX)], reg[nameof(Register.R10)], 2),
				new RegisterInfo(reg[nameof(Register.R11W)], reg[nameof(Register.AX)], reg[nameof(Register.R11)], 2),
				new RegisterInfo(reg[nameof(Register.R12W)], reg[nameof(Register.AX)], reg[nameof(Register.R12)], 2),
				new RegisterInfo(reg[nameof(Register.R13W)], reg[nameof(Register.AX)], reg[nameof(Register.R13)], 2),
				new RegisterInfo(reg[nameof(Register.R14W)], reg[nameof(Register.AX)], reg[nameof(Register.R14)], 2),
				new RegisterInfo(reg[nameof(Register.R15W)], reg[nameof(Register.AX)], reg[nameof(Register.R15)], 2),
				new RegisterInfo(reg[nameof(Register.EAX)], reg[nameof(Register.EAX)], reg[nameof(Register.RAX)], 4),
				new RegisterInfo(reg[nameof(Register.ECX)], reg[nameof(Register.EAX)], reg[nameof(Register.RCX)], 4),
				new RegisterInfo(reg[nameof(Register.EDX)], reg[nameof(Register.EAX)], reg[nameof(Register.RDX)], 4),
				new RegisterInfo(reg[nameof(Register.EBX)], reg[nameof(Register.EAX)], reg[nameof(Register.RBX)], 4),
				new RegisterInfo(reg[nameof(Register.ESP)], reg[nameof(Register.EAX)], reg[nameof(Register.RSP)], 4),
				new RegisterInfo(reg[nameof(Register.EBP)], reg[nameof(Register.EAX)], reg[nameof(Register.RBP)], 4),
				new RegisterInfo(reg[nameof(Register.ESI)], reg[nameof(Register.EAX)], reg[nameof(Register.RSI)], 4),
				new RegisterInfo(reg[nameof(Register.EDI)], reg[nameof(Register.EAX)], reg[nameof(Register.RDI)], 4),
				new RegisterInfo(reg[nameof(Register.R8D)], reg[nameof(Register.EAX)], reg[nameof(Register.R8)], 4),
				new RegisterInfo(reg[nameof(Register.R9D)], reg[nameof(Register.EAX)], reg[nameof(Register.R9)], 4),
				new RegisterInfo(reg[nameof(Register.R10D)], reg[nameof(Register.EAX)], reg[nameof(Register.R10)], 4),
				new RegisterInfo(reg[nameof(Register.R11D)], reg[nameof(Register.EAX)], reg[nameof(Register.R11)], 4),
				new RegisterInfo(reg[nameof(Register.R12D)], reg[nameof(Register.EAX)], reg[nameof(Register.R12)], 4),
				new RegisterInfo(reg[nameof(Register.R13D)], reg[nameof(Register.EAX)], reg[nameof(Register.R13)], 4),
				new RegisterInfo(reg[nameof(Register.R14D)], reg[nameof(Register.EAX)], reg[nameof(Register.R14)], 4),
				new RegisterInfo(reg[nameof(Register.R15D)], reg[nameof(Register.EAX)], reg[nameof(Register.R15)], 4),
				new RegisterInfo(reg[nameof(Register.RAX)], reg[nameof(Register.RAX)], reg[nameof(Register.RAX)], 8),
				new RegisterInfo(reg[nameof(Register.RCX)], reg[nameof(Register.RAX)], reg[nameof(Register.RCX)], 8),
				new RegisterInfo(reg[nameof(Register.RDX)], reg[nameof(Register.RAX)], reg[nameof(Register.RDX)], 8),
				new RegisterInfo(reg[nameof(Register.RBX)], reg[nameof(Register.RAX)], reg[nameof(Register.RBX)], 8),
				new RegisterInfo(reg[nameof(Register.RSP)], reg[nameof(Register.RAX)], reg[nameof(Register.RSP)], 8),
				new RegisterInfo(reg[nameof(Register.RBP)], reg[nameof(Register.RAX)], reg[nameof(Register.RBP)], 8),
				new RegisterInfo(reg[nameof(Register.RSI)], reg[nameof(Register.RAX)], reg[nameof(Register.RSI)], 8),
				new RegisterInfo(reg[nameof(Register.RDI)], reg[nameof(Register.RAX)], reg[nameof(Register.RDI)], 8),
				new RegisterInfo(reg[nameof(Register.R8)], reg[nameof(Register.RAX)], reg[nameof(Register.R8)], 8),
				new RegisterInfo(reg[nameof(Register.R9)], reg[nameof(Register.RAX)], reg[nameof(Register.R9)], 8),
				new RegisterInfo(reg[nameof(Register.R10)], reg[nameof(Register.RAX)], reg[nameof(Register.R10)], 8),
				new RegisterInfo(reg[nameof(Register.R11)], reg[nameof(Register.RAX)], reg[nameof(Register.R11)], 8),
				new RegisterInfo(reg[nameof(Register.R12)], reg[nameof(Register.RAX)], reg[nameof(Register.R12)], 8),
				new RegisterInfo(reg[nameof(Register.R13)], reg[nameof(Register.RAX)], reg[nameof(Register.R13)], 8),
				new RegisterInfo(reg[nameof(Register.R14)], reg[nameof(Register.RAX)], reg[nameof(Register.R14)], 8),
				new RegisterInfo(reg[nameof(Register.R15)], reg[nameof(Register.RAX)], reg[nameof(Register.R15)], 8),
				new RegisterInfo(reg[nameof(Register.EIP)], reg[nameof(Register.EIP)], reg[nameof(Register.RIP)], 4),
				new RegisterInfo(reg[nameof(Register.RIP)], reg[nameof(Register.EIP)], reg[nameof(Register.RIP)], 8),
				new RegisterInfo(reg[nameof(Register.ES)], reg[nameof(Register.ES)], reg[nameof(Register.ES)], 2),
				new RegisterInfo(reg[nameof(Register.CS)], reg[nameof(Register.ES)], reg[nameof(Register.CS)], 2),
				new RegisterInfo(reg[nameof(Register.SS)], reg[nameof(Register.ES)], reg[nameof(Register.SS)], 2),
				new RegisterInfo(reg[nameof(Register.DS)], reg[nameof(Register.ES)], reg[nameof(Register.DS)], 2),
				new RegisterInfo(reg[nameof(Register.FS)], reg[nameof(Register.ES)], reg[nameof(Register.FS)], 2),
				new RegisterInfo(reg[nameof(Register.GS)], reg[nameof(Register.ES)], reg[nameof(Register.GS)], 2),
				new RegisterInfo(reg[nameof(Register.XMM0)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM0)], 16),
				new RegisterInfo(reg[nameof(Register.XMM1)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM1)], 16),
				new RegisterInfo(reg[nameof(Register.XMM2)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM2)], 16),
				new RegisterInfo(reg[nameof(Register.XMM3)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM3)], 16),
				new RegisterInfo(reg[nameof(Register.XMM4)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM4)], 16),
				new RegisterInfo(reg[nameof(Register.XMM5)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM5)], 16),
				new RegisterInfo(reg[nameof(Register.XMM6)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM6)], 16),
				new RegisterInfo(reg[nameof(Register.XMM7)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM7)], 16),
				new RegisterInfo(reg[nameof(Register.XMM8)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM8)], 16),
				new RegisterInfo(reg[nameof(Register.XMM9)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM9)], 16),
				new RegisterInfo(reg[nameof(Register.XMM10)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM10)], 16),
				new RegisterInfo(reg[nameof(Register.XMM11)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM11)], 16),
				new RegisterInfo(reg[nameof(Register.XMM12)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM12)], 16),
				new RegisterInfo(reg[nameof(Register.XMM13)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM13)], 16),
				new RegisterInfo(reg[nameof(Register.XMM14)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM14)], 16),
				new RegisterInfo(reg[nameof(Register.XMM15)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM15)], 16),
				new RegisterInfo(reg[nameof(Register.XMM16)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM16)], 16),
				new RegisterInfo(reg[nameof(Register.XMM17)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM17)], 16),
				new RegisterInfo(reg[nameof(Register.XMM18)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM18)], 16),
				new RegisterInfo(reg[nameof(Register.XMM19)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM19)], 16),
				new RegisterInfo(reg[nameof(Register.XMM20)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM20)], 16),
				new RegisterInfo(reg[nameof(Register.XMM21)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM21)], 16),
				new RegisterInfo(reg[nameof(Register.XMM22)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM22)], 16),
				new RegisterInfo(reg[nameof(Register.XMM23)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM23)], 16),
				new RegisterInfo(reg[nameof(Register.XMM24)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM24)], 16),
				new RegisterInfo(reg[nameof(Register.XMM25)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM25)], 16),
				new RegisterInfo(reg[nameof(Register.XMM26)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM26)], 16),
				new RegisterInfo(reg[nameof(Register.XMM27)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM27)], 16),
				new RegisterInfo(reg[nameof(Register.XMM28)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM28)], 16),
				new RegisterInfo(reg[nameof(Register.XMM29)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM29)], 16),
				new RegisterInfo(reg[nameof(Register.XMM30)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM30)], 16),
				new RegisterInfo(reg[nameof(Register.XMM31)], reg[nameof(Register.XMM0)], reg[nameof(Register.ZMM31)], 16),
				new RegisterInfo(reg[nameof(Register.YMM0)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM0)], 32),
				new RegisterInfo(reg[nameof(Register.YMM1)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM1)], 32),
				new RegisterInfo(reg[nameof(Register.YMM2)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM2)], 32),
				new RegisterInfo(reg[nameof(Register.YMM3)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM3)], 32),
				new RegisterInfo(reg[nameof(Register.YMM4)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM4)], 32),
				new RegisterInfo(reg[nameof(Register.YMM5)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM5)], 32),
				new RegisterInfo(reg[nameof(Register.YMM6)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM6)], 32),
				new RegisterInfo(reg[nameof(Register.YMM7)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM7)], 32),
				new RegisterInfo(reg[nameof(Register.YMM8)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM8)], 32),
				new RegisterInfo(reg[nameof(Register.YMM9)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM9)], 32),
				new RegisterInfo(reg[nameof(Register.YMM10)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM10)], 32),
				new RegisterInfo(reg[nameof(Register.YMM11)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM11)], 32),
				new RegisterInfo(reg[nameof(Register.YMM12)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM12)], 32),
				new RegisterInfo(reg[nameof(Register.YMM13)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM13)], 32),
				new RegisterInfo(reg[nameof(Register.YMM14)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM14)], 32),
				new RegisterInfo(reg[nameof(Register.YMM15)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM15)], 32),
				new RegisterInfo(reg[nameof(Register.YMM16)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM16)], 32),
				new RegisterInfo(reg[nameof(Register.YMM17)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM17)], 32),
				new RegisterInfo(reg[nameof(Register.YMM18)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM18)], 32),
				new RegisterInfo(reg[nameof(Register.YMM19)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM19)], 32),
				new RegisterInfo(reg[nameof(Register.YMM20)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM20)], 32),
				new RegisterInfo(reg[nameof(Register.YMM21)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM21)], 32),
				new RegisterInfo(reg[nameof(Register.YMM22)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM22)], 32),
				new RegisterInfo(reg[nameof(Register.YMM23)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM23)], 32),
				new RegisterInfo(reg[nameof(Register.YMM24)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM24)], 32),
				new RegisterInfo(reg[nameof(Register.YMM25)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM25)], 32),
				new RegisterInfo(reg[nameof(Register.YMM26)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM26)], 32),
				new RegisterInfo(reg[nameof(Register.YMM27)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM27)], 32),
				new RegisterInfo(reg[nameof(Register.YMM28)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM28)], 32),
				new RegisterInfo(reg[nameof(Register.YMM29)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM29)], 32),
				new RegisterInfo(reg[nameof(Register.YMM30)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM30)], 32),
				new RegisterInfo(reg[nameof(Register.YMM31)], reg[nameof(Register.YMM0)], reg[nameof(Register.ZMM31)], 32),
				new RegisterInfo(reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM0)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM1)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM1)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM2)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM2)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM3)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM3)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM4)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM4)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM5)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM5)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM6)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM6)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM7)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM7)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM8)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM8)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM9)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM9)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM10)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM10)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM11)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM11)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM12)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM12)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM13)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM13)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM14)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM14)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM15)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM15)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM16)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM16)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM17)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM17)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM18)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM18)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM19)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM19)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM20)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM20)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM21)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM21)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM22)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM22)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM23)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM23)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM24)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM24)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM25)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM25)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM26)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM26)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM27)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM27)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM28)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM28)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM29)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM29)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM30)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM30)], 64),
				new RegisterInfo(reg[nameof(Register.ZMM31)], reg[nameof(Register.ZMM0)], reg[nameof(Register.ZMM31)], 64),
				new RegisterInfo(reg[nameof(Register.K0)], reg[nameof(Register.K0)], reg[nameof(Register.K0)], 8),
				new RegisterInfo(reg[nameof(Register.K1)], reg[nameof(Register.K0)], reg[nameof(Register.K1)], 8),
				new RegisterInfo(reg[nameof(Register.K2)], reg[nameof(Register.K0)], reg[nameof(Register.K2)], 8),
				new RegisterInfo(reg[nameof(Register.K3)], reg[nameof(Register.K0)], reg[nameof(Register.K3)], 8),
				new RegisterInfo(reg[nameof(Register.K4)], reg[nameof(Register.K0)], reg[nameof(Register.K4)], 8),
				new RegisterInfo(reg[nameof(Register.K5)], reg[nameof(Register.K0)], reg[nameof(Register.K5)], 8),
				new RegisterInfo(reg[nameof(Register.K6)], reg[nameof(Register.K0)], reg[nameof(Register.K6)], 8),
				new RegisterInfo(reg[nameof(Register.K7)], reg[nameof(Register.K0)], reg[nameof(Register.K7)], 8),
				new RegisterInfo(reg[nameof(Register.BND0)], reg[nameof(Register.BND0)], reg[nameof(Register.BND0)], 16),
				new RegisterInfo(reg[nameof(Register.BND1)], reg[nameof(Register.BND0)], reg[nameof(Register.BND1)], 16),
				new RegisterInfo(reg[nameof(Register.BND2)], reg[nameof(Register.BND0)], reg[nameof(Register.BND2)], 16),
				new RegisterInfo(reg[nameof(Register.BND3)], reg[nameof(Register.BND0)], reg[nameof(Register.BND3)], 16),
				new RegisterInfo(reg[nameof(Register.CR0)], reg[nameof(Register.CR0)], reg[nameof(Register.CR0)], 8),
				new RegisterInfo(reg[nameof(Register.CR1)], reg[nameof(Register.CR0)], reg[nameof(Register.CR1)], 8),
				new RegisterInfo(reg[nameof(Register.CR2)], reg[nameof(Register.CR0)], reg[nameof(Register.CR2)], 8),
				new RegisterInfo(reg[nameof(Register.CR3)], reg[nameof(Register.CR0)], reg[nameof(Register.CR3)], 8),
				new RegisterInfo(reg[nameof(Register.CR4)], reg[nameof(Register.CR0)], reg[nameof(Register.CR4)], 8),
				new RegisterInfo(reg[nameof(Register.CR5)], reg[nameof(Register.CR0)], reg[nameof(Register.CR5)], 8),
				new RegisterInfo(reg[nameof(Register.CR6)], reg[nameof(Register.CR0)], reg[nameof(Register.CR6)], 8),
				new RegisterInfo(reg[nameof(Register.CR7)], reg[nameof(Register.CR0)], reg[nameof(Register.CR7)], 8),
				new RegisterInfo(reg[nameof(Register.CR8)], reg[nameof(Register.CR0)], reg[nameof(Register.CR8)], 8),
				new RegisterInfo(reg[nameof(Register.CR9)], reg[nameof(Register.CR0)], reg[nameof(Register.CR9)], 8),
				new RegisterInfo(reg[nameof(Register.CR10)], reg[nameof(Register.CR0)], reg[nameof(Register.CR10)], 8),
				new RegisterInfo(reg[nameof(Register.CR11)], reg[nameof(Register.CR0)], reg[nameof(Register.CR11)], 8),
				new RegisterInfo(reg[nameof(Register.CR12)], reg[nameof(Register.CR0)], reg[nameof(Register.CR12)], 8),
				new RegisterInfo(reg[nameof(Register.CR13)], reg[nameof(Register.CR0)], reg[nameof(Register.CR13)], 8),
				new RegisterInfo(reg[nameof(Register.CR14)], reg[nameof(Register.CR0)], reg[nameof(Register.CR14)], 8),
				new RegisterInfo(reg[nameof(Register.CR15)], reg[nameof(Register.CR0)], reg[nameof(Register.CR15)], 8),
				new RegisterInfo(reg[nameof(Register.DR0)], reg[nameof(Register.DR0)], reg[nameof(Register.DR0)], 8),
				new RegisterInfo(reg[nameof(Register.DR1)], reg[nameof(Register.DR0)], reg[nameof(Register.DR1)], 8),
				new RegisterInfo(reg[nameof(Register.DR2)], reg[nameof(Register.DR0)], reg[nameof(Register.DR2)], 8),
				new RegisterInfo(reg[nameof(Register.DR3)], reg[nameof(Register.DR0)], reg[nameof(Register.DR3)], 8),
				new RegisterInfo(reg[nameof(Register.DR4)], reg[nameof(Register.DR0)], reg[nameof(Register.DR4)], 8),
				new RegisterInfo(reg[nameof(Register.DR5)], reg[nameof(Register.DR0)], reg[nameof(Register.DR5)], 8),
				new RegisterInfo(reg[nameof(Register.DR6)], reg[nameof(Register.DR0)], reg[nameof(Register.DR6)], 8),
				new RegisterInfo(reg[nameof(Register.DR7)], reg[nameof(Register.DR0)], reg[nameof(Register.DR7)], 8),
				new RegisterInfo(reg[nameof(Register.DR8)], reg[nameof(Register.DR0)], reg[nameof(Register.DR8)], 8),
				new RegisterInfo(reg[nameof(Register.DR9)], reg[nameof(Register.DR0)], reg[nameof(Register.DR9)], 8),
				new RegisterInfo(reg[nameof(Register.DR10)], reg[nameof(Register.DR0)], reg[nameof(Register.DR10)], 8),
				new RegisterInfo(reg[nameof(Register.DR11)], reg[nameof(Register.DR0)], reg[nameof(Register.DR11)], 8),
				new RegisterInfo(reg[nameof(Register.DR12)], reg[nameof(Register.DR0)], reg[nameof(Register.DR12)], 8),
				new RegisterInfo(reg[nameof(Register.DR13)], reg[nameof(Register.DR0)], reg[nameof(Register.DR13)], 8),
				new RegisterInfo(reg[nameof(Register.DR14)], reg[nameof(Register.DR0)], reg[nameof(Register.DR14)], 8),
				new RegisterInfo(reg[nameof(Register.DR15)], reg[nameof(Register.DR0)], reg[nameof(Register.DR15)], 8),
				new RegisterInfo(reg[nameof(Register.ST0)], reg[nameof(Register.ST0)], reg[nameof(Register.ST0)], 10),
				new RegisterInfo(reg[nameof(Register.ST1)], reg[nameof(Register.ST0)], reg[nameof(Register.ST1)], 10),
				new RegisterInfo(reg[nameof(Register.ST2)], reg[nameof(Register.ST0)], reg[nameof(Register.ST2)], 10),
				new RegisterInfo(reg[nameof(Register.ST3)], reg[nameof(Register.ST0)], reg[nameof(Register.ST3)], 10),
				new RegisterInfo(reg[nameof(Register.ST4)], reg[nameof(Register.ST0)], reg[nameof(Register.ST4)], 10),
				new RegisterInfo(reg[nameof(Register.ST5)], reg[nameof(Register.ST0)], reg[nameof(Register.ST5)], 10),
				new RegisterInfo(reg[nameof(Register.ST6)], reg[nameof(Register.ST0)], reg[nameof(Register.ST6)], 10),
				new RegisterInfo(reg[nameof(Register.ST7)], reg[nameof(Register.ST0)], reg[nameof(Register.ST7)], 10),
				new RegisterInfo(reg[nameof(Register.MM0)], reg[nameof(Register.MM0)], reg[nameof(Register.MM0)], 8),
				new RegisterInfo(reg[nameof(Register.MM1)], reg[nameof(Register.MM0)], reg[nameof(Register.MM1)], 8),
				new RegisterInfo(reg[nameof(Register.MM2)], reg[nameof(Register.MM0)], reg[nameof(Register.MM2)], 8),
				new RegisterInfo(reg[nameof(Register.MM3)], reg[nameof(Register.MM0)], reg[nameof(Register.MM3)], 8),
				new RegisterInfo(reg[nameof(Register.MM4)], reg[nameof(Register.MM0)], reg[nameof(Register.MM4)], 8),
				new RegisterInfo(reg[nameof(Register.MM5)], reg[nameof(Register.MM0)], reg[nameof(Register.MM5)], 8),
				new RegisterInfo(reg[nameof(Register.MM6)], reg[nameof(Register.MM0)], reg[nameof(Register.MM6)], 8),
				new RegisterInfo(reg[nameof(Register.MM7)], reg[nameof(Register.MM0)], reg[nameof(Register.MM7)], 8),
				new RegisterInfo(reg[nameof(Register.TR0)], reg[nameof(Register.TR0)], reg[nameof(Register.TR0)], 4),
				new RegisterInfo(reg[nameof(Register.TR1)], reg[nameof(Register.TR0)], reg[nameof(Register.TR1)], 4),
				new RegisterInfo(reg[nameof(Register.TR2)], reg[nameof(Register.TR0)], reg[nameof(Register.TR2)], 4),
				new RegisterInfo(reg[nameof(Register.TR3)], reg[nameof(Register.TR0)], reg[nameof(Register.TR3)], 4),
				new RegisterInfo(reg[nameof(Register.TR4)], reg[nameof(Register.TR0)], reg[nameof(Register.TR4)], 4),
				new RegisterInfo(reg[nameof(Register.TR5)], reg[nameof(Register.TR0)], reg[nameof(Register.TR5)], 4),
				new RegisterInfo(reg[nameof(Register.TR6)], reg[nameof(Register.TR0)], reg[nameof(Register.TR6)], 4),
				new RegisterInfo(reg[nameof(Register.TR7)], reg[nameof(Register.TR0)], reg[nameof(Register.TR7)], 4),
				new RegisterInfo(reg[nameof(Register.TMM0)], reg[nameof(Register.TMM0)], reg[nameof(Register.TMM0)], 1024),
				new RegisterInfo(reg[nameof(Register.TMM1)], reg[nameof(Register.TMM0)], reg[nameof(Register.TMM1)], 1024),
				new RegisterInfo(reg[nameof(Register.TMM2)], reg[nameof(Register.TMM0)], reg[nameof(Register.TMM2)], 1024),
				new RegisterInfo(reg[nameof(Register.TMM3)], reg[nameof(Register.TMM0)], reg[nameof(Register.TMM3)], 1024),
				new RegisterInfo(reg[nameof(Register.TMM4)], reg[nameof(Register.TMM0)], reg[nameof(Register.TMM4)], 1024),
				new RegisterInfo(reg[nameof(Register.TMM5)], reg[nameof(Register.TMM0)], reg[nameof(Register.TMM5)], 1024),
				new RegisterInfo(reg[nameof(Register.TMM6)], reg[nameof(Register.TMM0)], reg[nameof(Register.TMM6)], 1024),
				new RegisterInfo(reg[nameof(Register.TMM7)], reg[nameof(Register.TMM0)], reg[nameof(Register.TMM7)], 1024),
			}.ToArray();
			if (result.Length != reg.Values.Length)
				throw new InvalidOperationException();
			if (result.Select(a => a.Register).ToHashSet().Count != reg.Values.Length)
				throw new InvalidOperationException();
			Array.Sort(result, (a, b) => a.Register.Value.CompareTo(b.Register.Value));
			return result;
		}
	}
}
