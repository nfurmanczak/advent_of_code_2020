def find_2020_part1(inputList):
    for i in inputList:
        firstNumber=int(i) 
        for x in inputList:
            secondNumber=int(x)
            if (secondNumber+firstNumber == 2020):
                print("Number 1 {} ".format(firstNumber))
                print("Number 2 {} ".format(secondNumber))
                return firstNumber * secondNumber

def find_2020_part2(inputList):
    for i in inputList:
        firstNumber=int(i) 
        for x in inputList:
            secondNumber=int(x)
            for y in inputList:
                thirdNumber=int(y)
                if (secondNumber+firstNumber+thirdNumber == 2020):
                    print("Number 1 {} ".format(firstNumber))
                    print("Number 2 {} ".format(secondNumber))
                    print("Number 3 {} ".format(thirdNumber))
                    return firstNumber * secondNumber * thirdNumber

inputList = []
with open("input.txt") as file_in:
    for line in file_in:
        inputList.append(line.strip())

print(find_2020_part1(inputList))
print(find_2020_part2(inputList))
