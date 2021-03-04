import fileinput
import re
import itertools


p1 = 0
p2 = 0

lines = list([int(x) for x in fileinput.input()])
lines.append('')
for i in range(25, len(lines)):
	ok = True
	prev = lines[i-25:i]
	assert len(prev) == 25
	for y,z in itertools.combinations(prev, 2):
		if y+z == lines[i]:
			print(y,z)
			ok = False 
	print(lines[i], prev)
	if ok: 
		print(lines[i])
		break
