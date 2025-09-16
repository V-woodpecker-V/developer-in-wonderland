def collect_numbers(n, result=[]):
    if n <= 0:
        return result
    result.append(n)
    return collect_numbers(n - 1, result)

print("First call:", collect_numbers(3))
print("Second call:", collect_numbers(2))
print("Third call:", collect_numbers(4))