from math import sqrt


def IsPrime(number):
    prime_nums = [num for num in range(
        1, number+1) if all(num % val or val == num for val in range(2, int(sqrt(number)+1)))]
    return number in prime_nums


n = input('Введите натуральное число больше 100: ')
subset = set()
prime_subset = set()
for i in range(0, pow(10, (len(n)-1))):
    if str(i) in n:
        subset.add(i)
for i in subset:
    if IsPrime(i) and i > 1:
        prime_subset.add(i)
print(f'Число {n} имеет {len(subset)} подчисел -> {subset}')
print(f'Из них простых {len(prime_subset)} -> {prime_subset}')
