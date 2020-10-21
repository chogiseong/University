Python 3.6.4 (v3.6.4:d48eceb, Dec 19 2017, 06:04:45) [MSC v.1900 32 bit (Intel)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> import numpy as np
>>> A = np.array([[4, -2, 2], [-2, 2, -2], [2, -4, 11]])
>>> Q, R = np.linalg.qr(A)
>>> Q
array([[-0.81649658, -0.49236596,  0.30151134],
       [ 0.40824829, -0.12309149,  0.90453403],
       [-0.40824829,  0.86164044,  0.30151134]])
>>> R
array([[-4.89897949,  4.0824829 , -6.94022094],
       [ 0.        , -2.7080128 ,  8.73949586],
       [ 0.        ,  0.        ,  2.11057941]])

>>> np.allclose(np.dot(Q.T, Q), np.eye(3))
True
>>> np.allclose(A, np.dot(Q,R))
True
>>> b = [0, 4, -13]
>>> y = np.dot(Q.T, b)
>>> def backward_sub(U, y):
    n = len(y)
    x = np.zeros(n)
    for k in range(n-1, -1, -1):
        x[k] = (y[k] - np.dot(U[k, k+1:n], x[k+1:n]))/U[k, k]
    return x

>>> x = backward_sub(R, y)
>>> x
array([ 2.        ,  3.85714286, -0.14285714])
>>> 
