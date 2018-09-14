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

#if !NO_INTEL_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Intel {
	public sealed class IntelFormatterTest16_NoMemSize_000 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, IntelFormatterFactory.Create_NoMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos16_000.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos16_000.AllInfos_Length] {
			"push es",
			"data32 push es",
			"pop es",
			"data32 pop es",
			"push cs",
			"data32 push cs",
			"push ss",
			"data32 push ss",
			"pop ss",
			"data32 pop ss",
			"push ds",
			"data32 push ds",
			"pop ds",
			"data32 pop ds",
			"pusha",
			"pushad",
			"popa",
			"popad",
			"data32 push 0x3412a55a",
			"data32 push 0xffffffa5",
			"jo 0x804c",
			"data32 jo 0x0000804d",
			"jno 0x804c",
			"data32 jno 0x0000804d",
			"jb 0x804c",
			"data32 jb 0x0000804d",
			"jae 0x804c",
			"data32 jae 0x0000804d",
			"je 0x804c",
			"data32 je 0x0000804d",
			"jne 0x804c",
			"data32 jne 0x0000804d",
			"jbe 0x804c",
			"data32 jbe 0x0000804d",
			"ja 0x804c",
			"data32 ja 0x0000804d",
			"js 0x804c",
			"data32 js 0x0000804d",
			"jns 0x804c",
			"data32 jns 0x0000804d",
			"jp 0x804c",
			"data32 jp 0x0000804d",
			"jnp 0x804c",
			"data32 jnp 0x0000804d",
			"jl 0x804c",
			"data32 jl 0x0000804d",
			"jge 0x804c",
			"data32 jge 0x0000804d",
			"jle 0x804c",
			"data32 jle 0x0000804d",
			"jg 0x804c",
			"data32 jg 0x0000804d",
			"pop esi",
			"pop dword ptr [bx+si]",
			"call far 0x3412, 0x7856",
			"data32 call far 0x78563412, 0xbc9a",
			"pushfd",
			"popfd",
			"ret 0xa55a",
			"data32 ret 0xa55a",
			"ret",
			"data32 ret",
			"les bx, [bx+si]",
			"les ebx, [bx+si]",
			"lds bx, [bx+si]",
			"lds ebx, [bx+si]",
			"data32 enter 0xa55a, 0xa6",
			"data32 leave",
			"loopne 0x804c",
			"data32 loopne 0x0000804d",
			"addr32 loopne 0x804d",
			"data32 addr32 loopne 0x0000804e",
			"loope 0x804c",
			"data32 loope 0x0000804d",
			"addr32 loope 0x804d",
			"data32 addr32 loope 0x0000804e",
			"loop 0x804c",
			"data32 loop 0x0000804d",
			"addr32 loop 0x804d",
			"data32 addr32 loop 0x0000804e",
			"jcxz 0x804c",
			"data32 jcxz 0x0000804d",
			"jecxz 0x804d",
			"data32 jecxz 0x0000804e",
			"call 0x254d",
			"data32 call 0xa55ab408",
			"jmp 0x254d",
			"data32 jmp 0xa55ab408",
			"jmp far 0x3412, 0x7856",
			"data32 jmp far 0x78563412, 0xbcea",
			"jmp 0x804c",
			"data32 jmp 0x0000804d",
			"call cx",
			"call word ptr [bx+si]",
			"call ecx",
			"call dword ptr [bx+si]",
			"jmp dx",
			"jmp word ptr [bx+si]",
			"jmp edx",
			"jmp dword ptr [bx+si]",
			"push esi",
			"push dword ptr [bx+si]",
			"bndmov bnd1, bnd2",
			"bndmov bnd1, qword ptr [bx+si]",
			"bndcl bnd1, edx",
			"bndcl bnd1, [bx+si]",
			"bndcu bnd1, edx",
			"bndcu bnd1, [bx+si]",
			"bndmov bnd2, bnd1",
			"bndmov qword ptr [bx+si], bnd1",
			"bndmk bnd1, dword ptr [bx+si]",
			"bndcn bnd1, edx",
			"bndcn bnd1, [bx+si]",
			"vmread esi, ecx",
			"vmread dword ptr [bx+si], ebx",
			"vmwrite ecx, esi",
			"vmwrite ebx, dword ptr [bx+si]",
			"jo 0x254e",
			"data32 jo 0x34132551",
			"jno 0x254e",
			"data32 jno 0x34132551",
			"jb 0x254e",
			"data32 jb 0x34132551",
			"jae 0x254e",
			"data32 jae 0x34132551",
			"je 0x254e",
			"data32 je 0x34132551",
			"jne 0x254e",
			"data32 jne 0x34132551",
			"jbe 0x254e",
			"data32 jbe 0x34132551",
			"ja 0x254e",
			"data32 ja 0x34132551",
			"js 0x254e",
			"data32 js 0x34132551",
			"jns 0x254e",
			"data32 jns 0x34132551",
			"jp 0x254e",
			"data32 jp 0x34132551",
			"jnp 0x254e",
			"data32 jnp 0x34132551",
			"jl 0x254e",
			"data32 jl 0x34132551",
			"jge 0x254e",
			"data32 jge 0x34132551",
			"jle 0x254e",
			"data32 jle 0x34132551",
			"jg 0x254e",
			"data32 jg 0x34132551",
			"data32 push fs",
			"data32 pop fs",
			"data32 push gs",
			"data32 pop gs",
			"invept edx, [bx+si]",
			"invvpid edx, [bx+si]",
			"invpcid edx, [bx+si]",
			"push 0xa55a",
			"push 0xffa5",
			"insb [edi], dx",
			"insb [di], dx",
			"insw [edi], dx",
			"insw [di], dx",
			"insd [edi], dx",
			"insd [di], dx",
			"outsb dx, [esi]",
			"outsb dx, [si]",
			"outsw dx, [esi]",
			"outsw dx, [si]",
			"outsd dx, [esi]",
			"outsd dx, [si]",
			"mov fs, si",
			"mov ds, [bx+si]",
			"mov fs, esi",
			"data32 mov ds, [bx+si]",
			"pop si",
			"pop word ptr [bx+si]",
			"nop",
			"xchg eax, eax",
			"pushf",
			"popf",
			"mov al, [0xf0de]",
			"addr32 mov al, [0x78563412]",
			"mov ax, [0xf0de]",
			"addr32 mov ax, [0x78563412]",
			"mov eax, [0xf0de]",
			"addr32 mov eax, [0x78563412]",
			"mov [0xf0de], al",
			"addr32 mov [0x78563412], al",
			"mov [0xf0de], ax",
			"addr32 mov [0x78563412], ax",
			"mov [0xf0de], eax",
			"addr32 mov [0x78563412], eax",
			"movsb [edi], [esi]",
			"movsb [di], [si]",
			"movsw [edi], [esi]",
			"movsw [di], [si]",
			"movsd [edi], [esi]",
			"movsd [di], [si]",
			"cmpsb [esi], [edi]",
			"cmpsb [si], [di]",
			"cmpsw [esi], [edi]",
			"cmpsw [si], [di]",
			"cmpsd [esi], [edi]",
			"cmpsd [si], [di]",
			"stosb [edi]",
			"stosb [di]",
			"stosw [edi]",
			"stosw [di]",
			"stosd [edi]",
			"stosd [di]",
			"lodsb [esi]",
			"lodsb [si]",
			"lodsw [esi]",
			"lodsw [si]",
			"lodsd [esi]",
			"lodsd [si]",
			"scasb [edi]",
			"scasb [di]",
			"scasw [edi]",
			"scasw [di]",
			"scasd [edi]",
			"scasd [di]",
			"xbegin 0x254e",
			"data32 xbegin 0x2551",
			"enter 0xa55a, 0xa6",
			"leave",
			"ret far 0xa55a",
			"data32 ret far 0xa55a",
			"ret far",
			"data32 ret far",
			"iret",
			"iretd",
			"rol cl, cl",
			"rol byte ptr [bx+si], cl",
			"ror dl, cl",
			"ror byte ptr [bx+si], cl",
			"rcl bl, cl",
			"rcl byte ptr [bx+si], cl",
			"rcr ah, cl",
			"rcr byte ptr [bx+si], cl",
			"shl ch, cl",
			"shl byte ptr [bx+si], cl",
			"shr dh, cl",
			"shr byte ptr [bx+si], cl",
			"sar al, cl",
			"sar byte ptr [bx+si], cl",
			"rol cx, cl",
			"rol word ptr [bx+si], cl",
			"rol ecx, cl",
			"rol dword ptr [bx+si], cl",
			"ror dx, cl",
			"ror word ptr [bx+si], cl",
			"ror edx, cl",
			"ror dword ptr [bx+si], cl",
			"rcl bx, cl",
			"rcl word ptr [bx+si], cl",
			"rcl ebx, cl",
			"rcl dword ptr [bx+si], cl",
			"rcr sp, cl",
			"rcr word ptr [bx+si], cl",
			"rcr esp, cl",
			"rcr dword ptr [bx+si], cl",
			"shl bp, cl",
			"shl word ptr [bx+si], cl",
			"shl ebp, cl",
			"shl dword ptr [bx+si], cl",
			"shr si, cl",
			"shr word ptr [bx+si], cl",
			"shr esi, cl",
			"shr dword ptr [bx+si], cl",
			"sar ax, cl",
			"sar word ptr [bx+si], cl",
			"sar eax, cl",
			"sar dword ptr [bx+si], cl",
			"fldcw [bx+si]",
			"fnstcw [bx+si]",
			"fnstsw [bx+si]",
			"call far dword ptr [bx+si]",
			"call far fword ptr [bx+si]",
			"jmp far dword ptr [bx+si]",
			"jmp far fword ptr [bx+si]",
			"push si",
			"push word ptr [bx+si]",
			"sgdt [bx+si]",
			"sgdt [bx+si]",
			"sidt [bx+si]",
			"sidt [bx+si]",
			"lgdt [bx+si]",
			"lgdt [bx+si]",
			"lidt [bx+si]",
			"lidt [bx+si]",
			"lar cx, si",
			"lar bx, [bx+si]",
			"lar ecx, esi",
			"lar ebx, [bx+si]",
			"lsl cx, si",
			"lsl bx, [bx+si]",
			"lsl ecx, esi",
			"lsl ebx, [bx+si]",
			"bndldx bnd1, dword ptr [bx+si]",
			"bndstx dword ptr [bx+si], bnd1",
			"kmovw k2, k3",
			"kmovw k1, word ptr [bx+si]",
			"kmovb k2, k3",
			"kmovb k1, byte ptr [bx+si]",
			"kmovd k2, k3",
			"kmovd k1, dword ptr [bx+si]",
			"kmovw word ptr [bx+si], k1",
			"kmovb byte ptr [bx+si], k1",
			"kmovd dword ptr [bx+si], k1",
			"kmovw k2, ebx",
			"kmovb k2, ebx",
			"kmovd k2, ebx",
			"kmovw edx, k3",
			"kmovb edx, k3",
			"kmovd edx, k3",
			"kortestw k2, k3",
			"kortestq k2, k3",
			"kortestb k2, k3",
			"kortestd k2, k3",
			"ktestw k2, k3",
			"ktestq k2, k3",
			"ktestb k2, k3",
			"ktestd k2, k3",
			"push fs",
			"pop fs",
			"shld si, cx, cl",
			"shld [bx+si], bx, cl",
			"shld esi, ecx, cl",
			"shld [bx+si], ebx, cl",
			"push gs",
			"pop gs",
			"shrd si, cx, cl",
			"shrd [bx+si], bx, cl",
			"shrd esi, ecx, cl",
			"shrd [bx+si], ebx, cl",
			"lss bx, [bx+si]",
			"lss ebx, [bx+si]",
			"lfs bx, [bx+si]",
			"lfs ebx, [bx+si]",
			"lgs bx, [bx+si]",
			"lgs ebx, [bx+si]",
			"movzx cx, dh",
			"movzx bx, byte ptr [bx+si]",
			"movzx ecx, dh",
			"movzx ebx, byte ptr [bx+si]",
			"movzx cx, si",
			"movzx bx, word ptr [bx+si]",
			"movzx ecx, si",
			"movzx ebx, word ptr [bx+si]",
			"movsx cx, dh",
			"movsx bx, byte ptr [bx+si]",
			"movsx ecx, dh",
			"movsx ebx, byte ptr [bx+si]",
			"movsx cx, si",
			"movsx bx, word ptr [bx+si]",
			"movsx ecx, si",
			"movsx ebx, word ptr [bx+si]",
			"cmpxchg8b [bx+si]",
			"crc32 ecx, dh",
			"crc32 ebx, byte ptr [bx+si]",
			"crc32 ecx, si",
			"crc32 ebx, word ptr [bx+si]",
			"crc32 ecx, esi",
			"crc32 ebx, dword ptr [bx+si]",
			"addr32 maskmovq mmx2, mmx3",
			"maskmovq mmx2, mmx3",
			"addr32 maskmovdqu xmm2, xmm3",
			"maskmovdqu xmm2, xmm3",
			"addr32 vmaskmovdqu xmm2, xmm3",
			"vmaskmovdqu xmm2, xmm3",
			"outsb dx, fs:[si]",
			"outsw dx, fs:[si]",
			"outsd dx, fs:[si]",
			"movsb es:[di], fs:[si]",
			"movsw es:[di], fs:[si]",
			"movsd es:[di], fs:[si]",
			"cmpsb fs:[si], es:[di]",
			"cmpsw fs:[si], es:[di]",
			"cmpsd fs:[si], es:[di]",
			"lodsb fs:[si]",
			"lodsw fs:[si]",
			"lodsd fs:[si]",
			"xlat [ebx]",
			"xlat fs:[bx]",
			"maskmovq mmx2, mmx3, fs",
			"maskmovdqu xmm2, xmm3, fs",
			"vmaskmovdqu xmm2, xmm3, fs",
			"xlat [bx]",
			"aam 0xa",
			"aad 0xa",
			"aam 0xfa",
			"aad 0xfa",
			"fldenv [bx+si]",
			"fldenv fpuenv28 ptr [bx+si]",
			"fnstenv [bx+si]",
			"fnstenv fpuenv28 ptr [bx+si]",
			"frstor [bx+si]",
			"frstor fpustate108 ptr [bx+si]",
			"fnsave [bx+si]",
			"fnsave fpustate108 ptr [bx+si]",
			"monitor",
			"addr32 monitor",
			"mwait",
			"mov al, fs:[0xf0de]",
			"addr32 mov al, fs:[0x78563412]",
			"mov ax, fs:[0xf0de]",
			"addr32 mov ax, fs:[0x78563412]",
			"mov eax, fs:[0xf0de]",
			"addr32 mov eax, fs:[0x78563412]",
			"mov fs:[0xf0de], al",
			"addr32 mov fs:[0x78563412], al",
			"mov fs:[0xf0de], ax",
			"addr32 mov fs:[0x78563412], ax",
			"mov fs:[0xf0de], eax",
			"addr32 mov fs:[0x78563412], eax",
			"mov cl, [bx+si]",
			"mov cl, [bx+di]",
			"mov cl, [bp+si]",
			"mov cl, [bp+di]",
			"mov cl, [si]",
			"mov cl, [di]",
			"mov cl, [0xedcc]",
			"mov cl, [0x1234]",
			"mov cl, [bx]",
			"mov cl, [bx+si-0x12]",
			"mov cl, [bx+di-0x12]",
			"mov cl, [bp+si-0x12]",
			"mov cl, [bp+di-0x12]",
			"mov cl, [si-0x12]",
			"mov cl, [di-0x12]",
			"mov cl, [bp-0x12]",
			"mov cl, [bx-0x12]",
			"mov cl, [bx+si+0x12]",
			"mov cl, [bx+di+0x12]",
			"mov cl, [bp+si+0x12]",
			"mov cl, [bp+di+0x12]",
			"mov cl, [si+0x12]",
			"mov cl, [di+0x12]",
			"mov cl, [bp+0x12]",
			"mov cl, [bx+0x12]",
			"mov cl, [bx+si-0x1234]",
			"mov cl, [bx+di-0x1234]",
			"mov cl, [bp+si-0x1234]",
			"mov cl, [bp+di-0x1234]",
			"mov cl, [si-0x1234]",
			"mov cl, [di-0x1234]",
			"mov cl, [bp-0x1234]",
			"mov cl, [bx-0x1234]",
			"mov cl, [bx+si+0x1234]",
			"mov cl, [bx+di+0x1234]",
			"mov cl, [bp+si+0x1234]",
			"mov cl, [bp+di+0x1234]",
			"mov cl, [si+0x1234]",
			"mov cl, [di+0x1234]",
			"mov cl, [bp+0x1234]",
			"mov cl, [bx+0x1234]",
			"mov cl, fs:[bx+si]",
			"mov cl, fs:[bx+di]",
			"mov cl, fs:[bp+si]",
			"mov cl, fs:[bp+di]",
			"mov cl, fs:[si]",
			"mov cl, fs:[di]",
			"mov cl, fs:[0xedcc]",
			"mov cl, fs:[0x1234]",
			"mov cl, fs:[bx]",
			"mov cl, fs:[bx+si-0x12]",
			"mov cl, fs:[bx+di-0x12]",
			"mov cl, fs:[bp+si-0x12]",
			"mov cl, fs:[bp+di-0x12]",
			"mov cl, fs:[si-0x12]",
			"mov cl, fs:[di-0x12]",
			"mov cl, fs:[bp-0x12]",
			"mov cl, fs:[bx-0x12]",
			"mov cl, fs:[bx+si+0x12]",
			"mov cl, fs:[bx+di+0x12]",
			"mov cl, fs:[bp+si+0x12]",
			"mov cl, fs:[bp+di+0x12]",
			"mov cl, fs:[si+0x12]",
			"mov cl, fs:[di+0x12]",
			"mov cl, fs:[bp+0x12]",
			"mov cl, fs:[bx+0x12]",
			"mov cl, fs:[bx+si-0x1234]",
			"mov cl, fs:[bx+di-0x1234]",
			"mov cl, fs:[bp+si-0x1234]",
			"mov cl, fs:[bp+di-0x1234]",
			"mov cl, fs:[si-0x1234]",
			"mov cl, fs:[di-0x1234]",
			"mov cl, fs:[bp-0x1234]",
			"mov cl, fs:[bx-0x1234]",
			"mov cl, fs:[bx+si+0x1234]",
			"mov cl, fs:[bx+di+0x1234]",
			"mov cl, fs:[bp+si+0x1234]",
			"mov cl, fs:[bp+di+0x1234]",
			"mov cl, fs:[si+0x1234]",
			"mov cl, fs:[di+0x1234]",
			"mov cl, fs:[bp+0x1234]",
			"mov cl, fs:[bx+0x1234]",
			"arpl dx, si",
			"arpl [bx+si], bx",
			"vmrun",
			"addr32 vmrun",
			"vmload",
			"addr32 vmload",
			"vmsave",
			"addr32 vmsave",
			"invlpga",
			"addr32 invlpga",
			"monitorx",
			"addr32 monitorx",
			"clzero ax",
			"clzero eax",
		};
	}
}
#endif
