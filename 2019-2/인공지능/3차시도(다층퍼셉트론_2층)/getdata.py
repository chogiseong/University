import numpy as np
def get_traindata():
    x=np.zeros((808,9))
    y=np.zeros(808)
    cnt=0
    cnty=0
    f=open("train.txt",'r')
    while True:
        line=f.readline()
        if not line:break
        c=np.array(line.split(' '))
        for i in range(0,c.size-1):
            if i==9:
                if c[i]=='true':
                    y[cnty]=1
                    cnty+=1
                else:
                    y[cnty]=0
                    cnty+=1
            else:
                if c[i]=='x':
                    x[cnt][i]=1
                elif c[i]=='b':
                    x[cnt][i]=0
                else:
                    x[cnt][i]=-1
        cnt +=1
    f.close()
    return x,y
    
def get_testdata():
    x=np.zeros((150,9))
    y=np.zeros(150)
    cnt=0
    cnty=0
    f=open("test.txt","r")
    while True:
        line=f.readline()
        if not line:break
        c=np.array(line.split(' '))
        for i in range(0,c.size-1):
            if i==9:
                if c[i]=='true':
                    y[cnty]=1
                    cnty+=1
                else:
                    y[cnty]=0
                    cnty+=1
            else:
                if c[i]=='x':
                    x[cnt][i]=1
                elif c[i]=='b':
                    x[cnt][i]=0
                else:
                    x[cnt][i]=-1
        cnt +=1
    f.close()
    return x,y

def sigmoid(x):
    return 1 / (1 + np.exp(-x))   
