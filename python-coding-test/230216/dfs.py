# DFS
class Graph:
    def __init__(self, size) -> None:
        self.SIZE = size 
        self.graph = [[0 for _ in range(size)] for _ in range(size)]

G1 = None
stack = []
visitedAry = []
A, B, C, D = 0, 1, 2, 3

if __name__ == '__main__':
    G1 = Graph(4)
    G1.graph[A][C] = 1; G1.graph[A][D] = 1
    G1.graph[B][C] = 1
    G1.graph[C][A] = 1; G1.graph[C][B] = 1; G1.graph[C][D] = 1
    G1.graph[D][A] = 1; G1.graph[D][C] = 1

    for item in G1.graph:
        print(item)

    current = A     # 시작점
    stack.append(current)
    visitedAry.append(current)

    while (len(stack) != 0):
        next = None 
        for vertex in range(G1.SIZE):
            if G1.graph[current][vertex] == 1:
                if vertex in visitedAry: 
                    pass 
                else: 
                    next = vertex 
                    break 
        
        if next != None:
            current = next 
            stack.append(current)
            visitedAry.append(current)
        else: 
            current = stack.pop()
    
    print('visit --> ', end = ' ')

    for i in visitedAry:
        print(chr(ord('A') + i), end = ' -> ')