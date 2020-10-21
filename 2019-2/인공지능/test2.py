import tensorflow as tf
import numpy as np
import matplotlib.pyplot as plt

#training data
train_x = np.array([[0,0], [0,1],
                   [1,0], [1,1]])
train_y = np.array([[1],[0],[0],[1]])

#epoch, node
NUM_ITER = 1000
learning_rate = 0.001

X = tf.placeholder(tf.float32, [None, 2])
Y = tf.placeholder(tf.float32, [None, 1])

#MLP
W = tf.Variable(tf.random_uniform([2, 2], -0.5, 0.5))
B = tf.Variable(tf.random_uniform([2], -0.5, 0.5))
hiddenLayer = tf.matmul(X,W)+B
hiddenLayer = tf.sigmoid(hiddenLayer)

W2 = tf.Variable(tf.random_uniform([2, 2], -0.5, 0.5))
B2 = tf.Variable(tf.random_uniform([2], 0.5, 0.5))
H1 = tf.matmul(hiddenLayer, W2)+B2
H1 = tf.sigmoid(H1)

W3 = tf.Variable(tf.random_uniform([2, 2], -0.5, 0.5))
B3 = tf.Variable(tf.random_uniform([2], -0.5, 0.5))
outLayer = tf.matmul(H1,W)+B
yHat = tf.nn.softmax(outLayer)

#cost
cost = tf.reduce_mean(tf.square(Y - yHat))
#optimizer
optimizer = tf.train.GradientDescentOptimizer(learning_rate).minimize(cost)

predicted = tf.cast(yHat > 0.5, dtype=tf.float32)
accuracy = tf.reduce_mean(tf.cast(tf.equal(predicted, Y), dtype=tf.float32))

sess = tf.Session()
sess.run(tf.global_variables_initializer())

cost_list = []
for step in range(NUM_ITER):
    e, _ = sess.run([cost, optimizer], feed_dict={X:train_x, Y:train_y})
    cost_list.append(e)

w1 = sess.run(W)
b1 = sess.run(B)
w2 = sess.run(W2)
b2 = sess.run(B2)
w3 = sess.run(W3)
b3 = sess.run(B3)

#accuracy
a = sess.run(accuracy, feed_dict={X:train_x, Y:train_y})
print("accuracy = ", a)

#graph
plt.plot(range(NUM_ITER), cost_list)
plt.show()
