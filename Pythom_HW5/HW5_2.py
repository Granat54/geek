# 5.2[28]: Напишите рекурсивную функцию sum(a, b), возвращающую сумму двух целых неотрицательных чисел. Из всех арифметических операций допускаются только +1 и -1. Циклы использовать нельзя
# Примеры/Тесты:
# <function_name>(0,0) -> 0
# <function_name>(0,2) -> 2
# <function_name>(3,0) -> 3

a, b = map(int, input("Введите a и b: ").split())
def summa(x,y):
    if (x == 0):
        return y
    else: return summa(x-1, y+1)

print (f"summa{a,b} -> {summa(a,b)}")
