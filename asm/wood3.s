# Derek Wood  wood3.s  CS24: Assignment #3
# Takes two integers and determines whether it is greater than,
# less than, or equal to.

.globl main

.text
main:   add $v0,$zero,4
	# Print out the prompt
	li $v0, 4		# system call for print string is 4
	la $a0, in_string1
	syscall			# prompt

	# Read in the reply
	li $v0, 5		# code for read_int
	syscall
	add $t0,$zero,$v0	# save the 1st entry **

	# Print out the prompt for 2nd number
	li $v0, 4
	la $a0, in_string2
	syscall			# prompt

	# Read in the reply
	li $v0, 5
	syscall
	add $t1,$zero,$v0	# save the 2nd entry **

	# Do the comparison
	beq $t0, $t1, E2	# branch if equal x = y
	slt $t0, $t0, $t1	# if x>y then $t0=1 else $t0=0
	beq $t0, 0, E1		# branch if equal=0  which means x<y 
	li  $v0, 4		# X > Y
	la  $a0, vallt
	syscall
	b app_end
E1:	li  $v0, 4
	la  $a0, valgt
	syscall
	b   app_end
E2:	li  $v0, 4
	la  $a0, valeq
	syscall

app_end:    li $v0, 10		# system call code for exit = 10
     syscall


.data
# Data Definitions
in_string1: .asciiz  "Derek Wood, CS24: Asn #3\nPlease enter  the first integer (X):\n"
in_string2: .asciiz  "second integer (Y)?\n"
valeq:          .asciiz         "\nx is equal to y\n"
valgt:          .asciiz         "\nx is greater than y\n"
vallt:          .asciiz         "\nx is less than y\n"

# blank line at end to keep SPIM happy
