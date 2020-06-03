# encoding utf-8
def f(ham: str, eggs: str = 'eggs') -> str:
    print("Annotations:", f.__annotations__)
    print("Arguments", ham, eggs)

    return ham + ' and' + eggs

# main
squares = list(map(lambda x: x**2, range(10)))
print(squares)

ham = input("ham or something:")
f(ham)