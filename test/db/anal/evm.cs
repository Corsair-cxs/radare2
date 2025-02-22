NAME=push29
FILE=malloc://1024
CMDS=<<EOF
e asm.arch=evm.cs
wx 7c030000000000000000000000000000000000000000000000000000000f9004
pd 3
EOF
EXPECT=<<EOF
            0x00000000      7c0300000000.  push29 0x030000000000000000000000000000000000000000000000000000000f
            0x0000001e      90             swap1
            0x0000001f      04             div
EOF
RUN

NAME=jump
FILE=malloc://1024
CMDS=<<EOF
e asm.arch=evm.cs
wx 62000005565b
pd 3
s 4
ao
EOF
EXPECT=<<EOF
            0x00000000      62000005       push3 0x000005
        ,=< 0x00000004      56             jump
        `-> 0x00000005      5b             jumpdest
address: 0x4
opcode: jump
esilcost: 1
disasm: jump
pseudo: jum 
mnemonic: jump
mask: ff
prefix: 0
id: 86
bytes: 56
refptr: 0
size: 1
sign: false
type: jmp
cycles: 0
esil: 32,sp,-=,sp,[1],pc,:=
jump: 0x00000005
direction: exec
fail: 0x00000005
family: cpu
EOF
RUN