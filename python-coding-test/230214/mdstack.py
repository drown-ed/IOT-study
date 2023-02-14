SIZE = 0
stack = []
top = -1

def isStackFull():
    global SIZE, stack, top

    if (top >= SIZE - 1):
        return True
    else: return False

def isStackEmpty():
    global SIZE, stack, top

    if (top == -1):
        return True
    else: False 

def push(data):
    global SIZE, stack, top
    if (isStackFull()):
        print('Stack is Full')
        return
    else:
        top += 1
        stack[top] = data

def pop():
    global SIZE, stack, top
    if (isStackEmpty()):
        print('Stack is empty!')
    else:
        data = stack[top]
        stack[top] = None
        top -= 1
        return data

def peek():
    global SIZE, stack, top
    if isStackEmpty():
        print('Stack is empty')
        return None
    else:
        return stack[top]

if __name__ == '__main__':
    top = -1
    SIZE = int(input('input stack size >> '))
    stack = [None for _ in range(SIZE)]

    while True:
        select = input('삽입 I / 추출 E / 확인 V / 종료 X')
        if select.lower() == 'x':
            break
        elif select.lower() == 'i':
            data = input('추가할 데이터 >> ')
            push(data)
            print(f'스택 상태 : {stack}')
        elif select.lower() == 'e':
            data = pop()
            print(f'추출 데이터 : {data}')
            print(f'스택 상태 : {stack}')
        elif select.lower() == 'v':
            data = peek()
            print(f'확인 데이터 : {data}')
            print(f'스택 상태 : {stack}')
        else:
            continue

    print('stack program')