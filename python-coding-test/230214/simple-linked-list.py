class Node:
    def __init__(self) -> None:
        self.data = None
        self.link = None

memory = [] 
head, current, pre = None, None, None 
dataArray = ['다현', '정연', '쯔위', '사나', '지효']

def printNodes(start):
    current = start
    if current == None:
        return
    print(current.data, end = ' -> ')
    
    while current.link != None:
        current = current.link
        if current.link == None: 
            print(current.data)
        else:
            print(current.data, end = ' -> ')

def insertNode(findData, insertData):
    global memory, head, current, pre

    if head.data == findData:
        node = Node()
        node.data = insertData
        node.link = head
        head = node
        return
    
    current = head 
    while current.link != None:
        pre = current 
        current = current.link 

        if current.data == findData:
            node = Node()
            node.data = insertData 
            node.link = current 
            pre.link = node 
            return 

    node = Node()
    node.data = insertData
    current.link = node
    return 0 

def deleteNode(deleteData):
    global memory, head, current, pre
    
    if head.data == deleteData:
        current = head
        head = head.link 
        del(current)
    
    current = head
    while current.link != None:
        pre = current # 모두 첫번째 노드 가리킴
        current = current.link 
        if current.data == deleteData:
            pre.link = current.link 
            del(current)
            return 

def findNode(findnode):
    global memory, pre, current, head 

    current = head 
    if current.data == findnode:
        return current 
    
    while current.link != None:
        current = current.link 
        if current.data == findnode:
            return current 
    
    return Node() 

if __name__ == '__main__':
    node = Node()
    node.data = dataArray[0]
    head = node
    memory.append(node)

    for data in dataArray[1:]: 
        pre = node
        node = Node()
        node.data = data
        pre.link = node 
        memory.append(node)

    printNodes(head)
    insertNode('다현', '미나')
    printNodes(head)

    deleteNode('사나')
    printNodes(head)

    result = findNode('쯔위')
    print(result.data)