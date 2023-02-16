# 그래프 표현 개선
class Graph:
    def __init__(self, size) -> None:
        self.SIZE = size 
        self.graph = [[0 for _ in range(size)] for _ in range(size)]

G1 = None 
nameAry = ['Yoda', 'Quigon', 'Obiwan', 'Anakin', 'Ahsoka', 'Padme']
Yoda, Quigon, Obiwan, Anakin, Ahsoka, Padme = 0, 1, 2, 3, 4, 5

def printGraph(graph):
    print(' ', end = ' ')
    for v in range(graph.SIZE):
        print(f'\t{nameAry[v]}', end = ' ')
    print()

    for row in range(graph.SIZE):
        print(f'\t{nameAry[row]}', end = ' ')
        for col in range(graph.SIZE):
            print(f'\t{graph.graph[row][col]}', end = ' ')
        print()
    print()

if __name__ == '__main__':
    gSize = 6
    G1 = Graph(gSize)
    G1.graph[Yoda][Quigon] = 1; G1.graph[Yoda][Obiwan] = 1
    G1.graph[Quigon][Obiwan] = 1; G1.graph[Quigon][Anakin] = 1
    G1.graph[Obiwan][Anakin] = 1; G1.graph[Obiwan][Ahsoka] = 1
    G1.graph[Anakin][Padme] = 1; G1.graph[Anakin][Ahsoka] = 1
    G1.graph[Ahsoka][Padme] = 1;

    printGraph(G1)
    