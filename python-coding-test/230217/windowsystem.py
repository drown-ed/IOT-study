import os

def makeFileList(folder):
    fnameAry = []
    for dirName, surDirList, fnames in os.walk(folder):
        for fname in fnames:
            fnameAry.append(fname)
    return fnameAry 

def insertionSort(ary):
    n = len(ary)
    for end in range(1, n):
        for cur in range(end, 0, -1):
            if ary[cur -1] < ary[cur]:
                ary[cur-1], ary[cur] = ary[cur], ary[cur-1]
            
    return ary 

fileAry = makeFileList('C:\Program Files\Common Files')
fileAry = insertionSort(fileAry)
print('파일명 ', fileAry)