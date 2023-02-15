# queue

SIZE = 0
queue = []
front = rear = -1

def isQueueFull():
    global SIZE, queue, front, rear
    
    if (rear != SIZE-1):
        return False  
    elif (rear == SIZE - 1) and (front == -1) :
        return True
    else: 
        for i in range(front + 1, SIZE):
            queue[i-1] = queue[i]
            queue[i] = None 
        front -= 1
        rear -= 1 
        return False  

def isQueueEmpty():
    global SIZE, queue, front, rear

    if (rear == front):
        return True 
    else : return False 

def enQueue(data):
    global SIZE, queue, front, rear 

    if (isQueueFull()):
        print('Queue is Full')
    else:
        rear += 1
        queue[rear] = data

def deQueue():
    global SIZE, queue, front, rear 

    if (isQueueEmpty()):
        print('Queue is Empty')
        return None 
    front += 1
    data = queue[front]
    queue[front] = None
    for i in range(front+1, SIZE):
        queue[i-1] = queue[i]
        queue[i] = None
    front = -1  
    rear = -1

    return data 

def peek():
    global SIZE, queue, front, rear 
    if isQueueEmpty():
        print('Queue is Empty')
        return None
    else:
        return queue[front + 1]

if __name__ == '__main__':
    SIZE = int(input('Queue size --> '))
    queue = [None for _ in range(SIZE)]

    while True:
        select = input('input (I) / extract (E) / verfiy (V) / exit (X) --> ')
        if select.lower() == 'x':
            break 
        elif select.lower() == 'i':
            data = input('input Data >> ')
            enQueue(data)
            print(f'Queue status : {queue}')
        elif select.lower() == 'e':
            data = deQueue()
            print(f'Extract Data : {data}')
            print(f'Queue status : {queue}')
        elif select.lower() == 'v':
            data = peek()
            print(f'Verify Data : {data}')
            print(f'Queue status : {queue}')
        else:
            continue 
    
    print('Queue program')