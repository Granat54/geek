# 5.1[26]: Напишите рекурсивную функцию для возведения числа a в степень b. Разрешается использовать только операцию умножения. Циклы использовать нельзя
# Примеры/Тесты:
# <function_name>(2,0) -> 1
# <function_name>(2,1) -> 2
# <function_name>(2,3) -> 8
# <function_name>(2,4) -> 16

a, b = map(int, input("Введите a и b: ").split())


def degree(x, y):
    if (x==0):
        return 0
    if (x==1 or y==0):
        return 1
    if (y>1):
        return x*degree(x,y-1)
    else: return x

print (f"degree{a,b} -> {degree(a,b)}")