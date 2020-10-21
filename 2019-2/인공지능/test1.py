import tensorflow as tf
import numpy as np
import matplotlib.pyplot as plt

NUM_ITER = 10000
learning_rate = 0.001

x_data = np.array([[0, 0], [0, 1],
                   [1, 0], [1, 1]])
y_data = np.array([[1], [0], [0], [1]])

X = tf.placeholder(tf.float32, [None, 2])
Y = tf.placeholder(tf.float32, [None, 1])

W1 = tf.Variable(tf.random_normal([2, 2]), name='weight1')
B1 = tf.Variable(tf.random_normal([2]), name='bias1')
layer1 = tf.sigmoid(tf.matmul(X, W1) + B1)

W2 = tf.Variable(tf.random_normal([2, 2]), name='weight2')
B2 = tf.Variable(tf.random_normal([2]), name='bias2')
layer2 = tf.sigmoid(tf.matmul(layer1, W2) + B2)

W3 = tf.Variable(tf.random_normal([2, 2]), name='weight3')
B3 = tf.Variable(tf.random_normal([2]), name='bias3')
hypothesis = tf.nn.softmax(tf.matmul(X, W3) + B3)


cost = -tf.reduce_mean(Y * tf.log(hypothesis) + (1 - Y) * tf.log(1 - hypothesis))

optimizer = tf.train.GradientDescentOptimizer(learning_rate).minimize(cost)

predicted = tf.cast(hypothesis > 0.5, dtype=tf.float32)
accuracy = tf.reduce_mean(tf.cast(tf.equal(predicted, Y), dtype=tf.float32))

sess = tf.Session()
sess.run(tf.global_variables_initializer())
error_list = []
for k in range(NUM_ITER):
        e, _ = sess.run([cost, optimizer], feed_dict={X:x_data, Y:y_data})
        error_list.append(e)

w1 = sess.run(W1)
b1 = sess.run(B1)
w2 = sess.run(W2)
b2 = sess.run(B2)
w3 = sess.run(W3)
b3 = sess.run(B3)

a = sess.run(accuracy, feed_dict={X:x_data,Y:y_data})
print("accuracy = ", a)

#학습 현황
plt.plot(range(NUM_ITER), error_list)
plt.show()
