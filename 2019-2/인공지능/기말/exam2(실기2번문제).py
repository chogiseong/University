import tensorflow as tf
import numpy as np
import matplotlib.pyplot as plt

#data creation by numpy
N=50
x_data=np.array([[0],[1],[2]])
x_data=x_data.astype(np.float32)
a=-1
b=4
y_data=a*x_data+b
y_data=y_data.astype(np.float32)

#solution by TensorFlow
X=tf.placeholder(tf.float32,shape=[None,1])
Y=tf.placeholder(tf.float32,[None,1])

A=tf.Variable(tf.zeros([1]))
B=tf.Variable(tf.zeros([1]))
Y_=A*X**2+B*X#yHat

cost=tf.reduce_sum(tf.square(Y - Y_))
train_step=tf.train.GradientDescentOptimizer(0.01).minimize(cost)

sess = tf.Session()
sess.run(tf.global_variables_initializer())


error_list = []
for step in range(10000):
   e,_= sess.run([cost,train_step],feed_dict= {X:x_data,Y:y_data})
   error_list.append(e)
   a_pred = sess.run(A).tolist()[0]
   b_pred = sess.run(B).tolist()[0]
    
a=sess.run(A)
b=sess.run(B)
c=sess.run(Y_,feed_dict= {X:x_data,Y:y_data})
print('a=',a)
print('b=',b)
print('yHat=',c)
print('평균제곱오차=',e)
sess.close() 
 


