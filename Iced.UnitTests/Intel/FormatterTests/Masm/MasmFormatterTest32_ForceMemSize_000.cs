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

#if !NO_MASM_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Masm {
	public sealed class MasmFormatterTest32_ForceMemSize_000 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, MasmFormatterFactory.Create_ForceMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos32_000.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos32_000.AllInfos_Length] {
			"pushw es",
			"push es",
			"popw es",
			"pop es",
			"pushw cs",
			"push cs",
			"pushw ss",
			"push ss",
			"popw ss",
			"pop ss",
			"pushw ds",
			"push ds",
			"popw ds",
			"pop ds",
			"daa",
			"das",
			"aaa",
			"aas",
			"inc ax",
			"inc eax",
			"inc cx",
			"inc ecx",
			"inc dx",
			"inc edx",
			"inc bx",
			"inc ebx",
			"inc sp",
			"inc esp",
			"inc bp",
			"inc ebp",
			"inc si",
			"inc esi",
			"inc di",
			"inc edi",
			"dec ax",
			"dec eax",
			"dec cx",
			"dec ecx",
			"dec dx",
			"dec edx",
			"dec bx",
			"dec ebx",
			"dec sp",
			"dec esp",
			"dec bp",
			"dec ebp",
			"dec si",
			"dec esi",
			"dec di",
			"dec edi",
			"push eax",
			"push ecx",
			"push edx",
			"push ebx",
			"push esp",
			"push ebp",
			"push esi",
			"push edi",
			"pop eax",
			"pop ecx",
			"pop edx",
			"pop ebx",
			"pop esp",
			"pop ebp",
			"pop esi",
			"pop edi",
			"pushaw",
			"pusha",
			"popaw",
			"popa",
			"bound bx,dword ptr [eax]",
			"bound ebx,qword ptr [eax]",
			"arpl dx,si",
			"arpl word ptr [eax],bx",
			"push 3412A55Ah",
			"push -5Bh",
			"jo short 004Dh",
			"jo short 8000004Ch",
			"jno short 004Dh",
			"jno short 8000004Ch",
			"jb short 004Dh",
			"jb short 8000004Ch",
			"jae short 004Dh",
			"jae short 8000004Ch",
			"je short 004Dh",
			"je short 8000004Ch",
			"jne short 004Dh",
			"jne short 8000004Ch",
			"jbe short 004Dh",
			"jbe short 8000004Ch",
			"ja short 004Dh",
			"ja short 8000004Ch",
			"js short 004Dh",
			"js short 8000004Ch",
			"jns short 004Dh",
			"jns short 8000004Ch",
			"jp short 004Dh",
			"jp short 8000004Ch",
			"jnp short 004Dh",
			"jnp short 8000004Ch",
			"jl short 004Dh",
			"jl short 8000004Ch",
			"jge short 004Dh",
			"jge short 8000004Ch",
			"jle short 004Dh",
			"jle short 8000004Ch",
			"jg short 004Dh",
			"jg short 8000004Ch",
			"pop esi",
			"pop dword ptr [eax]",
			"call far ptr 7856h:3412h",
			"call far ptr 0BC9Ah:78563412h",
			"pushfd",
			"popfd",
			"retnw -5AA6h",
			"ret -5AA6h",
			"retnw",
			"ret",
			"les bx,dword ptr [eax]",
			"les ebx,fword ptr [eax]",
			"lds bx,dword ptr [eax]",
			"lds ebx,fword ptr [eax]",
			"enter -5AA6h,-5Ah",
			"leave",
			"into",
			"aam",
			"aad",
			"loopnew 004Eh",
			"loopnew 8000004Dh",
			"loopne 004Dh",
			"loopne 8000004Ch",
			"loopew 004Eh",
			"loopew 8000004Dh",
			"loope 004Dh",
			"loope 8000004Ch",
			"loopw 004Eh",
			"loopw 8000004Dh",
			"loop 004Dh",
			"loop 8000004Ch",
			"jcxz 004Eh",
			"jcxz 8000004Dh",
			"jecxz 004Dh",
			"jecxz 8000004Ch",
			"call 0A54Eh",
			"call 255A3407h",
			"jmp near ptr 0A54Eh",
			"jmp near ptr 255A3407h",
			"jmp far ptr 7856h:3412h",
			"jmp far ptr 0BCEAh:78563412h",
			"jmp short 004Dh",
			"jmp short 8000004Ch",
			"call cx",
			"call word ptr [eax]",
			"call ecx",
			"call dword ptr [eax]",
			"jmp dx",
			"jmp word ptr [eax]",
			"jmp edx",
			"jmp dword ptr [eax]",
			"push esi",
			"push dword ptr [eax]",
			"bndmov bnd1,bnd2",
			"bndmov bnd1,qword ptr [eax]",
			"bndcl bnd1,edx",
			"bndcl bnd1,dword ptr [eax]",
			"bndcu bnd1,edx",
			"bndcu bnd1,dword ptr [eax]",
			"bndmov bnd2,bnd1",
			"bndmov qword ptr [eax],bnd1",
			"bndmk bnd1,dword ptr [eax]",
			"bndcn bnd1,edx",
			"bndcn bnd1,dword ptr [eax]",
			"mov esi,cr3",
			"mov esi,dr3",
			"mov cr3,esi",
			"mov dr3,esi",
			"vmread esi,ecx",
			"vmread dword ptr [eax],ebx",
			"vmwrite ecx,esi",
			"vmwrite ebx,dword ptr [eax]",
			"jo near ptr 0A54Fh",
			"jo near ptr 0B412A550h",
			"jno near ptr 0A54Fh",
			"jno near ptr 0B412A550h",
			"jb near ptr 0A54Fh",
			"jb near ptr 0B412A550h",
			"jae near ptr 0A54Fh",
			"jae near ptr 0B412A550h",
			"je near ptr 0A54Fh",
			"je near ptr 0B412A550h",
			"jne near ptr 0A54Fh",
			"jne near ptr 0B412A550h",
			"jbe near ptr 0A54Fh",
			"jbe near ptr 0B412A550h",
			"ja near ptr 0A54Fh",
			"ja near ptr 0B412A550h",
			"js near ptr 0A54Fh",
			"js near ptr 0B412A550h",
			"jns near ptr 0A54Fh",
			"jns near ptr 0B412A550h",
			"jp near ptr 0A54Fh",
			"jp near ptr 0B412A550h",
			"jnp near ptr 0A54Fh",
			"jnp near ptr 0B412A550h",
			"jl near ptr 0A54Fh",
			"jl near ptr 0B412A550h",
			"jge near ptr 0A54Fh",
			"jge near ptr 0B412A550h",
			"jle near ptr 0A54Fh",
			"jle near ptr 0B412A550h",
			"jg near ptr 0A54Fh",
			"jg near ptr 0B412A550h",
			"push fs",
			"pop fs",
			"push gs",
			"pop gs",
			"rdpid edx",
			"invept edx,oword ptr [eax]",
			"invvpid edx,oword ptr [eax]",
			"invpcid edx,oword ptr [eax]",
			"salc",
			"pushw -5AA6h",
			"pushw -5Bh",
			"ins byte ptr [di],dx",
			"insb",
			"ins word ptr [di],dx",
			"insw",
			"ins dword ptr [di],dx",
			"insd",
			"outs dx,byte ptr [si]",
			"outsb",
			"outs dx,word ptr [si]",
			"outsw",
			"outs dx,dword ptr [si]",
			"outsd",
			"mov fs,si",
			"mov ds,word ptr [eax]",
			"mov fs,esi",
			"mov ds,word ptr [eax]",
			"pop si",
			"pop word ptr [eax]",
			"xchg ax,ax",
			"nop",
			"pushf",
			"popf",
			"mov al,byte ptr ds:[0F0DEBC9Ah]",
			"mov al,byte ptr ds:[0F0DEh]",
			"mov ax,word ptr ds:[0F0DEBC9Ah]",
			"mov ax,word ptr ds:[0F0DEh]",
			"mov eax,dword ptr ds:[0F0DEBC9Ah]",
			"mov eax,dword ptr ds:[0F0DEh]",
			"mov byte ptr ds:[0F0DEBC9Ah],al",
			"mov byte ptr ds:[0F0DEh],al",
			"mov word ptr ds:[0F0DEBC9Ah],ax",
			"mov word ptr ds:[0F0DEh],ax",
			"mov dword ptr ds:[0F0DEBC9Ah],eax",
			"mov dword ptr ds:[0F0DEh],eax",
			"movs byte ptr [di],byte ptr [si]",
			"movsb",
			"movs word ptr [di],word ptr [si]",
			"movsw",
			"movs dword ptr [di],dword ptr [si]",
			"movsd",
			"cmps byte ptr [si],byte ptr [di]",
			"cmpsb",
			"cmps word ptr [si],word ptr [di]",
			"cmpsw",
			"cmps dword ptr [si],dword ptr [di]",
			"cmpsd",
			"stos byte ptr [di]",
			"stosb",
			"stos word ptr [di]",
			"stosw",
			"stos dword ptr [di]",
			"stosd",
			"lods byte ptr [si]",
			"lodsb",
			"lods word ptr [si]",
			"lodsw",
			"lods dword ptr [si]",
			"lodsd",
			"scas byte ptr [di]",
			"scasb",
			"scas word ptr [di]",
			"scasw",
			"scas dword ptr [di]",
			"scasd",
			"xbegin 7FFFA54Fh",
			"xbegin 0B412A550h",
			"enterw -5AA6h,-5Ah",
			"leavew",
			"retfw -5AA6h",
			"retf -5AA6h",
			"retfw",
			"retf",
			"iret",
			"iretd",
			"rol cl,cl",
			"rol byte ptr [eax],cl",
			"ror dl,cl",
			"ror byte ptr [eax],cl",
			"rcl bl,cl",
			"rcl byte ptr [eax],cl",
			"rcr ah,cl",
			"rcr byte ptr [eax],cl",
			"shl ch,cl",
			"shl byte ptr [eax],cl",
			"shr dh,cl",
			"shr byte ptr [eax],cl",
			"sar al,cl",
			"sar byte ptr [eax],cl",
			"rol cx,cl",
			"rol word ptr [eax],cl",
			"rol ecx,cl",
			"rol dword ptr [eax],cl",
			"ror dx,cl",
			"ror word ptr [eax],cl",
			"ror edx,cl",
			"ror dword ptr [eax],cl",
			"rcl bx,cl",
			"rcl word ptr [eax],cl",
			"rcl ebx,cl",
			"rcl dword ptr [eax],cl",
			"rcr sp,cl",
			"rcr word ptr [eax],cl",
			"rcr esp,cl",
			"rcr dword ptr [eax],cl",
			"shl bp,cl",
			"shl word ptr [eax],cl",
			"shl ebp,cl",
			"shl dword ptr [eax],cl",
			"shr si,cl",
			"shr word ptr [eax],cl",
			"shr esi,cl",
			"shr dword ptr [eax],cl",
			"sar ax,cl",
			"sar word ptr [eax],cl",
			"sar eax,cl",
			"sar dword ptr [eax],cl",
			"fldcw word ptr [eax]",
			"fnstcw word ptr [eax]",
			"fnstsw word ptr [eax]",
			"call dword ptr [eax]",
			"call fword ptr [eax]",
			"jmp dword ptr [eax]",
			"jmp fword ptr [eax]",
			"push si",
			"push word ptr [eax]",
			"sgdtw fword ptr [eax]",
			"sgdt fword ptr [eax]",
			"sidtw fword ptr [eax]",
			"sidt fword ptr [eax]",
			"lgdtw fword ptr [eax]",
			"lgdt fword ptr [eax]",
			"lidtw fword ptr [eax]",
			"lidt fword ptr [eax]",
			"lar cx,si",
			"lar bx,word ptr [eax]",
			"lar ecx,esi",
			"lar ebx,word ptr [eax]",
			"lsl cx,si",
			"lsl bx,word ptr [eax]",
			"lsl ecx,esi",
			"lsl ebx,word ptr [eax]",
			"bndldx bnd1,dword ptr [eax]",
			"bndstx dword ptr [eax],bnd1",
			"kmovw k2,k3",
			"kmovw k1,word ptr [eax]",
			"kmovb k2,k3",
			"kmovb k1,byte ptr [eax]",
			"kmovd k2,k3",
			"kmovd k1,dword ptr [eax]",
			"kmovw word ptr [eax],k1",
			"kmovb byte ptr [eax],k1",
			"kmovd dword ptr [eax],k1",
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
			"pushw fs",
			"popw fs",
			"shld si,cx,cl",
			"shld word ptr [eax],bx,cl",
			"shld esi,ecx,cl",
			"shld dword ptr [eax],ebx,cl",
			"pushw gs",
			"popw gs",
			"shrd si,cx,cl",
			"shrd word ptr [eax],bx,cl",
			"shrd esi,ecx,cl",
			"shrd dword ptr [eax],ebx,cl",
			"lss bx,dword ptr [eax]",
			"lss ebx,fword ptr [eax]",
			"lfs bx,dword ptr [eax]",
			"lfs ebx,fword ptr [eax]",
			"lgs bx,dword ptr [eax]",
			"lgs ebx,fword ptr [eax]",
			"movzx cx,dh",
			"movzx bx,byte ptr [eax]",
			"movzx ecx,dh",
			"movzx ebx,byte ptr [eax]",
			"movzx cx,si",
			"movzx bx,word ptr [eax]",
			"movzx ecx,si",
			"movzx ebx,word ptr [eax]",
			"movsx cx,dh",
			"movsx bx,byte ptr [eax]",
			"movsx ecx,dh",
			"movsx ebx,byte ptr [eax]",
			"movsx cx,si",
			"movsx bx,word ptr [eax]",
			"movsx ecx,si",
			"movsx ebx,word ptr [eax]",
			"cmpxchg8b qword ptr [eax]",
			"crc32 ecx,dh",
			"crc32 ebx,byte ptr [eax]",
			"crc32 ecx,si",
			"crc32 ebx,word ptr [eax]",
			"crc32 ecx,esi",
			"crc32 ebx,dword ptr [eax]",
			"maskmovq mmword ptr [di],mm2,mm3",
			"maskmovq mm2,mm3",
			"maskmovdqu xmmword ptr [di],xmm2,xmm3",
			"maskmovdqu xmm2,xmm3",
			"vmaskmovdqu xmmword ptr [di],xmm2,xmm3",
			"vmaskmovdqu xmm2,xmm3",
			"outs dx,byte ptr fs:[esi]",
			"outs dx,word ptr fs:[esi]",
			"outs dx,dword ptr fs:[esi]",
			"movs byte ptr es:[edi],byte ptr fs:[esi]",
			"movs word ptr es:[edi],word ptr fs:[esi]",
			"movs dword ptr es:[edi],dword ptr fs:[esi]",
			"cmps byte ptr fs:[esi],byte ptr es:[edi]",
			"cmps word ptr fs:[esi],word ptr es:[edi]",
			"cmps dword ptr fs:[esi],dword ptr es:[edi]",
			"lods byte ptr fs:[esi]",
			"lods word ptr fs:[esi]",
			"lods dword ptr fs:[esi]",
			"xlat byte ptr [bx]",
			"xlat byte ptr fs:[ebx]",
			"maskmovq mmword ptr fs:[edi],mm2,mm3",
			"maskmovdqu xmmword ptr fs:[edi],xmm2,xmm3",
			"vmaskmovdqu xmmword ptr fs:[edi],xmm2,xmm3",
			"xlatb",
			"aam -6",
			"aad -6",
			"fldenv fpuenv14 ptr [eax]",
			"fldenv [eax]",
			"fnstenv fpuenv14 ptr [eax]",
			"fnstenv [eax]",
			"frstor fpustate98 ptr [eax]",
			"frstor [eax]",
			"fnsave fpustate98 ptr [eax]",
			"fnsave [eax]",
			"monitor ax,ecx,edx",
			"monitor eax,ecx,edx",
			"mwait eax,ecx",
			"mov al,byte ptr fs:[0F0DEBC9Ah]",
			"mov al,byte ptr fs:[0F0DEh]",
			"mov ax,word ptr fs:[0F0DEBC9Ah]",
			"mov ax,word ptr fs:[0F0DEh]",
			"mov eax,dword ptr fs:[0F0DEBC9Ah]",
			"mov eax,dword ptr fs:[0F0DEh]",
			"mov byte ptr fs:[0F0DEBC9Ah],al",
			"mov byte ptr fs:[0F0DEh],al",
			"mov word ptr fs:[0F0DEBC9Ah],ax",
			"mov word ptr fs:[0F0DEh],ax",
			"mov dword ptr fs:[0F0DEBC9Ah],eax",
			"mov dword ptr fs:[0F0DEh],eax",
			"mov cl,byte ptr [eax]",
			"mov cl,byte ptr [eax-12h]",
			"mov cl,byte ptr [eax-12345678h]",
			"mov cl,byte ptr ds:[0EDCBA988h]",
			"mov cl,byte ptr [eax+12h]",
			"mov cl,byte ptr [eax+12345678h]",
			"mov cl,byte ptr ds:[12345678h]",
			"mov cl,byte ptr [eax+ecx]",
			"mov cl,byte ptr [eax+ecx*2]",
			"mov cl,byte ptr [eax+ecx*4]",
			"mov cl,byte ptr [eax+ecx*8]",
			"mov cl,byte ptr [eax+ecx-12h]",
			"mov cl,byte ptr [eax+ecx*2-12h]",
			"mov cl,byte ptr [eax+ecx*4-12h]",
			"mov cl,byte ptr [eax+ecx*8-12h]",
			"mov cl,byte ptr [eax+ecx+12h]",
			"mov cl,byte ptr [eax+ecx*2+12h]",
			"mov cl,byte ptr [eax+ecx*4+12h]",
			"mov cl,byte ptr [eax+ecx*8+12h]",
			"mov cl,byte ptr [eax+ecx-12345678h]",
			"mov cl,byte ptr [eax+ecx*2-12345678h]",
			"mov cl,byte ptr [eax+ecx*4-12345678h]",
			"mov cl,byte ptr [eax+ecx*8-12345678h]",
			"mov cl,byte ptr [eax+ecx+12345678h]",
			"mov cl,byte ptr [eax+ecx*2+12345678h]",
			"mov cl,byte ptr [eax+ecx*4+12345678h]",
			"mov cl,byte ptr [eax+ecx*8+12345678h]",
			"mov cl,byte ptr [ecx*1-12345678h]",
			"mov cl,byte ptr [ebp+ecx*2-12h]",
			"mov cl,byte ptr [ebp+ecx*4-12345678h]",
			"mov cl,byte ptr [ecx*8-12345678h]",
			"mov cl,byte ptr [ecx*1+12345678h]",
			"mov cl,byte ptr [ebp+ecx*2+12h]",
			"mov cl,byte ptr [ebp+ecx*4+12345678h]",
			"mov cl,byte ptr [ecx*8+12345678h]",
			"mov cl,byte ptr fs:[eax]",
			"mov cl,byte ptr fs:[eax-12h]",
			"mov cl,byte ptr fs:[eax-12345678h]",
			"mov cl,byte ptr fs:[0EDCBA988h]",
			"mov cl,byte ptr fs:[eax+12h]",
			"mov cl,byte ptr fs:[eax+12345678h]",
			"mov cl,byte ptr fs:[12345678h]",
			"mov cl,byte ptr fs:[eax+ecx]",
			"mov cl,byte ptr fs:[eax+ecx*2]",
			"mov cl,byte ptr fs:[eax+ecx*4]",
			"mov cl,byte ptr fs:[eax+ecx*8]",
			"mov cl,byte ptr fs:[eax+ecx-12h]",
			"mov cl,byte ptr fs:[eax+ecx*2-12h]",
			"mov cl,byte ptr fs:[eax+ecx*4-12h]",
			"mov cl,byte ptr fs:[eax+ecx*8-12h]",
			"mov cl,byte ptr fs:[eax+ecx+12h]",
			"mov cl,byte ptr fs:[eax+ecx*2+12h]",
			"mov cl,byte ptr fs:[eax+ecx*4+12h]",
			"mov cl,byte ptr fs:[eax+ecx*8+12h]",
			"mov cl,byte ptr fs:[eax+ecx-12345678h]",
			"mov cl,byte ptr fs:[eax+ecx*2-12345678h]",
			"mov cl,byte ptr fs:[eax+ecx*4-12345678h]",
			"mov cl,byte ptr fs:[eax+ecx*8-12345678h]",
			"mov cl,byte ptr fs:[eax+ecx+12345678h]",
			"mov cl,byte ptr fs:[eax+ecx*2+12345678h]",
			"mov cl,byte ptr fs:[eax+ecx*4+12345678h]",
			"mov cl,byte ptr fs:[eax+ecx*8+12345678h]",
			"mov cl,byte ptr fs:[ecx*1-12345678h]",
			"mov cl,byte ptr fs:[ebp+ecx*2-12h]",
			"mov cl,byte ptr fs:[ebp+ecx*4-12345678h]",
			"mov cl,byte ptr fs:[ecx*8-12345678h]",
			"mov cl,byte ptr fs:[ecx*1+12345678h]",
			"mov cl,byte ptr fs:[ebp+ecx*2+12h]",
			"mov cl,byte ptr fs:[ebp+ecx*4+12345678h]",
			"mov cl,byte ptr fs:[ecx*8+12345678h]",
			"vmrun ax",
			"vmrun eax",
			"vmload ax",
			"vmload eax",
			"vmsave ax",
			"vmsave eax",
			"invlpga ax,ecx",
			"invlpga eax,ecx",
			"monitorx ax,ecx,edx",
			"monitorx eax,ecx,edx",
			"clzero",
			"clzero",
		};
	}
}
#endif
