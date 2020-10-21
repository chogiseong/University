import tensorflow as tf
import numpy as np
import matplotlib.pyplot as plt
from getdata import *

NUM_ITER = 10000
learning_rate = 0.01
NUM_HIDDEN = 2

# train data
tx,ty=get_traindata()
tx=tx.astype(np.float32)
ty=np.reshape(ty,[808,1]).astype(np.float32)

#tensorflow
X=tf.placeholder(tf.float32,shape=[808,9])
Y=tf.placeholder(tf.float32,shape=[808,1])

W = tf.Variable(tf.random_uniform([9, NUM_HIDDEN],  -0.5,0.5))
B = tf.Variable(tf.random_uniform([NUM_HIDDEN], -0.5,0.5))

##hiddenLayer  = tf.nn.relu(tf.matmul(X,W) + B)
hiddenLayer = tf.sigmoid( tf.add(tf.matmul(X, W), B) )

W2  = tf.Variable(tf.random_uniform([NUM_HIDDEN,1],-0.5,0.5))
B2  = tf.Variable(tf.random_uniform([1],-0.5,0.5))
outLayer =tf.add(tf.matmul(hiddenLayer, W2), B2)
yHat =tf.sigmoid(outLayer)

cost = tf.reduce_sum(tf.square(Y - yHat))
#cost = -tf.reduce_mean(Y * tf.log(yHat) + (1 - Y) * tf.log(1 - yHat))

optimizer = tf.train.GradientDescentOptimizer(learning_rate).minimize(cost)
##optimizer = tf.train.AdamOptimizer(learning_rate).minimize(cost)

predicted = tf.cast(yHat> 0.5, dtype = tf.float32)
accuracy = tf.reduce_mean(tf.cast(tf.equal(predicted, Y), dtype=tf.float32))

sess = tf.Session()
sess.run(tf.global_variables_initializer())

error_list = []
for k in range(NUM_ITER):
        e, _ = sess.run([cost, optimizer], feed_dict={X:tx, Y:ty})
        error_list.append(e)

w1 = sess.run(W)
b1 = sess.run(B)
w2 = sess.run(W2)
b2 = sess.run(B2)
print('w1=', w1)
print('b1=', b1)
print('w2=', w2)
print('b2=', b2)

##yhat, p, a = sess.run([yHat, predicted, accuracy], feed_dict={X:tx,Y:ty})
a = sess.run(accuracy, feed_dict={X:tx,Y:ty})
##print("yhat = ", yhat)
##print("predicted = ", p)
print("accuracy = ", a)

#학습 현황
plt.plot(range(NUM_ITER), error_list)
plt.show()


#test data
testx,testy=get_testdata()
testx=testx.astype(np.float32)
testy=testy.astype(np.float32)
hiddenLayerResult=sigmoid(np.add(np.dot(testx,w1),b1)).astype(np.float32)
outLayerResult=sigmoid(np.add(np.dot(hiddenLayerResult,w2),b2)).astype(np.float32)
test_prediction=np.zeros(150).astype(np.float32)
for i in range(outLayerResult.shape[0]):#예측한 값이 0.5보다 크다면 1(x가 win),작다면 0을 test_prediction에 저장
    if outLayerResult[i]>0.5:
        test_prediction[i]=1
    else:
        test_prediction[i]=0
test_accuracy=np.sum(np.equal(test_prediction,testy))/testy.shape[0]#예측이 제대로 이루어졌는지 정확도 계산
print('-------------------------예측 정확도-------------------------')
print(test_accuracy)
print('----------------------테스트데이터 예측결과----------------------')
print(outLayerResult)        
