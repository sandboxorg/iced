﻿/*
    Copyright (C) 2018 de4dot@gmail.com

    This file is part of Iced.

    Iced is free software: you can redistribute it and/or modify
    it under the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Iced is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with Iced.  If not, see <https://www.gnu.org/licenses/>.
*/

#if !NO_NASM_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Nasm {
	public sealed class NasmFormatterTest16_ForceMemSize_000 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, NasmFormatterFactory.Create_ForceMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos16_000.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos16_000.AllInfos_Length] {
			"push es",
			"o32 push es",
			"pop es",
			"o32 pop es",
			"push cs",
			"o32 push cs",
			"push ss",
			"o32 push ss",
			"pop ss",
			"o32 pop ss",
			"push ds",
			"o32 push ds",
			"pop ds",
			"o32 pop ds",
			"pusha",
			"pushad",
			"popa",
			"popad",
			"push dword 0x3412a55a",
			"o32 push byte -0x5b",
			"jo short 0x804c",
			"o32 jo short 0x0000804d",
			"jno short 0x804c",
			"o32 jno short 0x0000804d",
			"jb short 0x804c",
			"o32 jb short 0x0000804d",
			"jae short 0x804c",
			"o32 jae short 0x0000804d",
			"je short 0x804c",
			"o32 je short 0x0000804d",
			"jne short 0x804c",
			"o32 jne short 0x0000804d",
			"jbe short 0x804c",
			"o32 jbe short 0x0000804d",
			"ja short 0x804c",
			"o32 ja short 0x0000804d",
			"js short 0x804c",
			"o32 js short 0x0000804d",
			"jns short 0x804c",
			"o32 jns short 0x0000804d",
			"jp short 0x804c",
			"o32 jp short 0x0000804d",
			"jnp short 0x804c",
			"o32 jnp short 0x0000804d",
			"jl short 0x804c",
			"o32 jl short 0x0000804d",
			"jge short 0x804c",
			"o32 jge short 0x0000804d",
			"jle short 0x804c",
			"o32 jle short 0x0000804d",
			"jg short 0x804c",
			"o32 jg short 0x0000804d",
			"pop esi",
			"pop dword [bx+si]",
			"call 0x7856:0x3412",
			"call dword 0xbc9a:0x78563412",
			"pushfd",
			"popfd",
			"ret -0x5aa6",
			"retd -0x5aa6",
			"ret",
			"retd",
			"les bx,[bx+si]",
			"les ebx,[bx+si]",
			"lds bx,[bx+si]",
			"lds ebx,[bx+si]",
			"o32 enter -0x5aa6,-0x5a",
			"o32 leave",
			"loopne 0x804c",
			"o32 loopne 0x0000804d",
			"loopne 0x804d,ecx",
			"o32 loopne 0x0000804e,ecx",
			"loope 0x804c",
			"o32 loope 0x0000804d",
			"loope 0x804d,ecx",
			"o32 loope 0x0000804e,ecx",
			"loop 0x804c",
			"o32 loop 0x0000804d",
			"loop 0x804d,ecx",
			"o32 loop 0x0000804e,ecx",
			"jcxz 0x804c",
			"o32 jcxz 0x0000804d",
			"jecxz 0x804d",
			"o32 jecxz 0x0000804e",
			"call 0x254d",
			"call dword 0xa55ab408",
			"jmp 0x254d",
			"jmp dword 0xa55ab408",
			"jmp 0x7856:0x3412",
			"jmp dword 0xbcea:0x78563412",
			"jmp short 0x804c",
			"o32 jmp short 0x0000804d",
			"call cx",
			"call word [bx+si]",
			"call ecx",
			"call dword [bx+si]",
			"jmp dx",
			"jmp word [bx+si]",
			"jmp edx",
			"jmp dword [bx+si]",
			"push esi",
			"push dword [bx+si]",
			"bndmov bnd1,bnd2",
			"bndmov bnd1,[bx+si]",
			"bndcl bnd1,edx",
			"bndcl bnd1,[bx+si]",
			"bndcu bnd1,edx",
			"bndcu bnd1,[bx+si]",
			"bndmov bnd2,bnd1",
			"bndmov [bx+si],bnd1",
			"bndmk bnd1,[bx+si]",
			"bndcn bnd1,edx",
			"bndcn bnd1,[bx+si]",
			"vmread esi,ecx",
			"vmread dword [bx+si],ebx",
			"vmwrite ecx,esi",
			"vmwrite ebx,dword [bx+si]",
			"jo near 0x254e",
			"jo near dword 0x34132551",
			"jno near 0x254e",
			"jno near dword 0x34132551",
			"jb near 0x254e",
			"jb near dword 0x34132551",
			"jae near 0x254e",
			"jae near dword 0x34132551",
			"je near 0x254e",
			"je near dword 0x34132551",
			"jne near 0x254e",
			"jne near dword 0x34132551",
			"jbe near 0x254e",
			"jbe near dword 0x34132551",
			"ja near 0x254e",
			"ja near dword 0x34132551",
			"js near 0x254e",
			"js near dword 0x34132551",
			"jns near 0x254e",
			"jns near dword 0x34132551",
			"jp near 0x254e",
			"jp near dword 0x34132551",
			"jnp near 0x254e",
			"jnp near dword 0x34132551",
			"jl near 0x254e",
			"jl near dword 0x34132551",
			"jge near 0x254e",
			"jge near dword 0x34132551",
			"jle near 0x254e",
			"jle near dword 0x34132551",
			"jg near 0x254e",
			"jg near dword 0x34132551",
			"o32 push fs",
			"o32 pop fs",
			"o32 push gs",
			"o32 pop gs",
			"invept edx,oword [bx+si]",
			"invvpid edx,oword [bx+si]",
			"invpcid edx,oword [bx+si]",
			"push -0x5aa6",
			"push byte -0x5b",
			"a32 insb",
			"insb",
			"a32 insw",
			"insw",
			"a32 insd",
			"insd",
			"a32 outsb",
			"outsb",
			"a32 outsw",
			"outsw",
			"a32 outsd",
			"outsd",
			"mov fs,si",
			"mov ds,word [bx+si]",
			"mov fs,esi",
			"o32 mov ds,word [bx+si]",
			"pop si",
			"pop word [bx+si]",
			"nop",
			"xchg eax,eax",
			"pushf",
			"popf",
			"mov al,byte [0xf0de]",
			"mov al,byte [dword 0x78563412]",
			"mov ax,word [0xf0de]",
			"mov ax,word [dword 0x78563412]",
			"mov eax,dword [0xf0de]",
			"mov eax,dword [dword 0x78563412]",
			"mov byte [0xf0de],al",
			"mov byte [dword 0x78563412],al",
			"mov word [0xf0de],ax",
			"mov word [dword 0x78563412],ax",
			"mov dword [0xf0de],eax",
			"mov dword [dword 0x78563412],eax",
			"a32 movsb",
			"movsb",
			"a32 movsw",
			"movsw",
			"a32 movsd",
			"movsd",
			"a32 cmpsb",
			"cmpsb",
			"a32 cmpsw",
			"cmpsw",
			"a32 cmpsd",
			"cmpsd",
			"a32 stosb",
			"stosb",
			"a32 stosw",
			"stosw",
			"a32 stosd",
			"stosd",
			"a32 lodsb",
			"lodsb",
			"a32 lodsw",
			"lodsw",
			"a32 lodsd",
			"lodsd",
			"a32 scasb",
			"scasb",
			"a32 scasw",
			"scasw",
			"a32 scasd",
			"scasd",
			"xbegin 0x254e",
			"xbegin dword 0x2551",
			"enter -0x5aa6,-0x5a",
			"leave",
			"retf -0x5aa6",
			"retfd -0x5aa6",
			"retf",
			"retfd",
			"iret",
			"iretd",
			"rol cl,cl",
			"rol byte [bx+si],cl",
			"ror dl,cl",
			"ror byte [bx+si],cl",
			"rcl bl,cl",
			"rcl byte [bx+si],cl",
			"rcr ah,cl",
			"rcr byte [bx+si],cl",
			"shl ch,cl",
			"shl byte [bx+si],cl",
			"shr dh,cl",
			"shr byte [bx+si],cl",
			"sar al,cl",
			"sar byte [bx+si],cl",
			"rol cx,cl",
			"rol word [bx+si],cl",
			"rol ecx,cl",
			"rol dword [bx+si],cl",
			"ror dx,cl",
			"ror word [bx+si],cl",
			"ror edx,cl",
			"ror dword [bx+si],cl",
			"rcl bx,cl",
			"rcl word [bx+si],cl",
			"rcl ebx,cl",
			"rcl dword [bx+si],cl",
			"rcr sp,cl",
			"rcr word [bx+si],cl",
			"rcr esp,cl",
			"rcr dword [bx+si],cl",
			"shl bp,cl",
			"shl word [bx+si],cl",
			"shl ebp,cl",
			"shl dword [bx+si],cl",
			"shr si,cl",
			"shr word [bx+si],cl",
			"shr esi,cl",
			"shr dword [bx+si],cl",
			"sar ax,cl",
			"sar word [bx+si],cl",
			"sar eax,cl",
			"sar dword [bx+si],cl",
			"fldcw word [bx+si]",
			"fnstcw word [bx+si]",
			"fnstsw word [bx+si]",
			"call far [bx+si]",
			"call dword far [bx+si]",
			"jmp far [bx+si]",
			"jmp dword far [bx+si]",
			"push si",
			"push word [bx+si]",
			"sgdt [bx+si]",
			"o32 sgdt [bx+si]",
			"sidt [bx+si]",
			"o32 sidt [bx+si]",
			"lgdt [bx+si]",
			"o32 lgdt [bx+si]",
			"lidt [bx+si]",
			"o32 lidt [bx+si]",
			"lar cx,si",
			"lar bx,word [bx+si]",
			"lar ecx,esi",
			"lar ebx,word [bx+si]",
			"lsl cx,si",
			"lsl bx,word [bx+si]",
			"lsl ecx,esi",
			"lsl ebx,word [bx+si]",
			"bndldx bnd1,[bx+si]",
			"bndstx [bx+si],bnd1",
			"kmovw k2,k3",
			"kmovw k1,word [bx+si]",
			"kmovb k2,k3",
			"kmovb k1,byte [bx+si]",
			"kmovd k2,k3",
			"kmovd k1,dword [bx+si]",
			"kmovw word [bx+si],k1",
			"kmovb byte [bx+si],k1",
			"kmovd dword [bx+si],k1",
			"kmovw k2,ebx",
			"kmovb k2,ebx",
			"kmovd k2,ebx",
			"kmovw edx,k3",
			"kmovb edx,k3",
			"kmovd edx,k3",
			"kortestw k2,k3",
			"kortestq k2,k3",
			"kortestb k2,k3",
			"kortestd k2,k3",
			"ktestw k2,k3",
			"ktestq k2,k3",
			"ktestb k2,k3",
			"ktestd k2,k3",
			"push fs",
			"pop fs",
			"shld si,cx,cl",
			"shld word [bx+si],bx,cl",
			"shld esi,ecx,cl",
			"shld dword [bx+si],ebx,cl",
			"push gs",
			"pop gs",
			"shrd si,cx,cl",
			"shrd word [bx+si],bx,cl",
			"shrd esi,ecx,cl",
			"shrd dword [bx+si],ebx,cl",
			"lss bx,[bx+si]",
			"lss ebx,[bx+si]",
			"lfs bx,[bx+si]",
			"lfs ebx,[bx+si]",
			"lgs bx,[bx+si]",
			"lgs ebx,[bx+si]",
			"movzx cx,dh",
			"movzx bx,byte [bx+si]",
			"movzx ecx,dh",
			"movzx ebx,byte [bx+si]",
			"movzx cx,si",
			"movzx bx,word [bx+si]",
			"movzx ecx,si",
			"movzx ebx,word [bx+si]",
			"movsx cx,dh",
			"movsx bx,byte [bx+si]",
			"movsx ecx,dh",
			"movsx ebx,byte [bx+si]",
			"movsx cx,si",
			"movsx bx,word [bx+si]",
			"movsx ecx,si",
			"movsx ebx,word [bx+si]",
			"cmpxchg8b [bx+si]",
			"crc32 ecx,dh",
			"crc32 ebx,byte [bx+si]",
			"crc32 ecx,si",
			"crc32 ebx,word [bx+si]",
			"crc32 ecx,esi",
			"crc32 ebx,dword [bx+si]",
			"a32 maskmovq mm2,mm3",
			"maskmovq mm2,mm3",
			"a32 maskmovdqu xmm2,xmm3",
			"maskmovdqu xmm2,xmm3",
			"a32 vmaskmovdqu xmm2,xmm3",
			"vmaskmovdqu xmm2,xmm3",
			"fs outsb",
			"fs outsw",
			"fs outsd",
			"fs movsb",
			"fs movsw",
			"fs movsd",
			"fs cmpsb",
			"fs cmpsw",
			"fs cmpsd",
			"fs lodsb",
			"fs lodsw",
			"fs lodsd",
			"a32 xlatb",
			"fs xlatb",
			"fs maskmovq mm2,mm3",
			"fs maskmovdqu xmm2,xmm3",
			"fs vmaskmovdqu xmm2,xmm3",
			"xlatb",
			"aam",
			"aad",
			"aam -6",
			"aad -6",
			"fldenv [bx+si]",
			"o32 fldenv [bx+si]",
			"fnstenv [bx+si]",
			"o32 fnstenv [bx+si]",
			"frstor [bx+si]",
			"o32 frstor [bx+si]",
			"fnsave [bx+si]",
			"o32 fnsave [bx+si]",
			"monitor",
			"a32 monitor",
			"mwait",
			"mov al,byte [fs:0xf0de]",
			"mov al,byte [dword fs:0x78563412]",
			"mov ax,word [fs:0xf0de]",
			"mov ax,word [dword fs:0x78563412]",
			"mov eax,dword [fs:0xf0de]",
			"mov eax,dword [dword fs:0x78563412]",
			"mov byte [fs:0xf0de],al",
			"mov byte [dword fs:0x78563412],al",
			"mov word [fs:0xf0de],ax",
			"mov word [dword fs:0x78563412],ax",
			"mov dword [fs:0xf0de],eax",
			"mov dword [dword fs:0x78563412],eax",
			"mov cl,byte [bx+si]",
			"mov cl,byte [bx+di]",
			"mov cl,byte [bp+si]",
			"mov cl,byte [bp+di]",
			"mov cl,byte [si]",
			"mov cl,byte [di]",
			"mov cl,byte [0xedcc]",
			"mov cl,byte [0x1234]",
			"mov cl,byte [bx]",
			"mov cl,byte [bx+si-0x12]",
			"mov cl,byte [bx+di-0x12]",
			"mov cl,byte [bp+si-0x12]",
			"mov cl,byte [bp+di-0x12]",
			"mov cl,byte [si-0x12]",
			"mov cl,byte [di-0x12]",
			"mov cl,byte [bp-0x12]",
			"mov cl,byte [bx-0x12]",
			"mov cl,byte [bx+si+0x12]",
			"mov cl,byte [bx+di+0x12]",
			"mov cl,byte [bp+si+0x12]",
			"mov cl,byte [bp+di+0x12]",
			"mov cl,byte [si+0x12]",
			"mov cl,byte [di+0x12]",
			"mov cl,byte [bp+0x12]",
			"mov cl,byte [bx+0x12]",
			"mov cl,byte [bx+si-0x1234]",
			"mov cl,byte [bx+di-0x1234]",
			"mov cl,byte [bp+si-0x1234]",
			"mov cl,byte [bp+di-0x1234]",
			"mov cl,byte [si-0x1234]",
			"mov cl,byte [di-0x1234]",
			"mov cl,byte [bp-0x1234]",
			"mov cl,byte [bx-0x1234]",
			"mov cl,byte [bx+si+0x1234]",
			"mov cl,byte [bx+di+0x1234]",
			"mov cl,byte [bp+si+0x1234]",
			"mov cl,byte [bp+di+0x1234]",
			"mov cl,byte [si+0x1234]",
			"mov cl,byte [di+0x1234]",
			"mov cl,byte [bp+0x1234]",
			"mov cl,byte [bx+0x1234]",
			"mov cl,byte [fs:bx+si]",
			"mov cl,byte [fs:bx+di]",
			"mov cl,byte [fs:bp+si]",
			"mov cl,byte [fs:bp+di]",
			"mov cl,byte [fs:si]",
			"mov cl,byte [fs:di]",
			"mov cl,byte [fs:0xedcc]",
			"mov cl,byte [fs:0x1234]",
			"mov cl,byte [fs:bx]",
			"mov cl,byte [fs:bx+si-0x12]",
			"mov cl,byte [fs:bx+di-0x12]",
			"mov cl,byte [fs:bp+si-0x12]",
			"mov cl,byte [fs:bp+di-0x12]",
			"mov cl,byte [fs:si-0x12]",
			"mov cl,byte [fs:di-0x12]",
			"mov cl,byte [fs:bp-0x12]",
			"mov cl,byte [fs:bx-0x12]",
			"mov cl,byte [fs:bx+si+0x12]",
			"mov cl,byte [fs:bx+di+0x12]",
			"mov cl,byte [fs:bp+si+0x12]",
			"mov cl,byte [fs:bp+di+0x12]",
			"mov cl,byte [fs:si+0x12]",
			"mov cl,byte [fs:di+0x12]",
			"mov cl,byte [fs:bp+0x12]",
			"mov cl,byte [fs:bx+0x12]",
			"mov cl,byte [fs:bx+si-0x1234]",
			"mov cl,byte [fs:bx+di-0x1234]",
			"mov cl,byte [fs:bp+si-0x1234]",
			"mov cl,byte [fs:bp+di-0x1234]",
			"mov cl,byte [fs:si-0x1234]",
			"mov cl,byte [fs:di-0x1234]",
			"mov cl,byte [fs:bp-0x1234]",
			"mov cl,byte [fs:bx-0x1234]",
			"mov cl,byte [fs:bx+si+0x1234]",
			"mov cl,byte [fs:bx+di+0x1234]",
			"mov cl,byte [fs:bp+si+0x1234]",
			"mov cl,byte [fs:bp+di+0x1234]",
			"mov cl,byte [fs:si+0x1234]",
			"mov cl,byte [fs:di+0x1234]",
			"mov cl,byte [fs:bp+0x1234]",
			"mov cl,byte [fs:bx+0x1234]",
			"arpl dx,si",
			"arpl word [bx+si],bx",
			"vmrun",
			"a32 vmrun",
			"vmload",
			"a32 vmload",
			"vmsave",
			"a32 vmsave",
			"invlpga ax,ecx",
			"invlpga eax,ecx",
			"monitorx",
			"a32 monitorx",
			"clzero",
			"o32 clzero",
		};
	}
}
#endif
