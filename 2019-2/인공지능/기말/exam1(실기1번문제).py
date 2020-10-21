import tensorflow as tf
import numpy as np
import matplotlib.pyplot as plt

#data creation by numpy
x=np.array([[2]])
x=x.astype(np.float32)

y=x**2+2*x+1
y=y.astype(np.float32)

#solution by TensorFlow
X=tf.placeholder(tf.float32)
Y=tf.placeholder(tf.float32)
#Y=X**2+2*X+1


sess = tf.Session()
sess.run(tf.global_variables_initializer())
print("Y=",sess.run(Y,feed_dict= {X:x,Y:y}))
##Y=sess.run(Y,feed_dict= {X:x,Y:y})
##print("Y=",Y)
sess.close() 
 
