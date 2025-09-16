def mystery():
    result = []
    i = 1
    while i <= 10:
        if i % 2 == 0:
            result.append(i * 2)
        i += 1
    return result

if __name__ == "__main__":
    print(mystery())