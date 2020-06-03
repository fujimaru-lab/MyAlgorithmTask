# encoding utf-8
def prtArg(num):
    """ sample """
    print("arg is", num)

def sample():
    return "sample"

# main
print(sample())

for i in range(5):
    print(prtArg(i))
else:
    print("loop end")

ipt = input("some words:")
print(ipt)