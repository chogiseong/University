# From calculation, we expect that the local minimum occurs at x=9/4

x_old = 0
x_new = 6

y_old = 0
y_new = 6


eps = 0.01 # step size
precision = 0.00001
##
##def f_prime(x):
##    return 4 * x**3 - 9 * x**2
##def f(x):
##    return x**4 - 3*x**3 +2

def f(x, y):
    return x**2 + y**2

def fx_prime(x, y):
    h = 0.00001
    return (f(x+h, y)-f(x, y))/h

def fy_prime(x, y):
    h = 0.00001
    return (f(x, y+h)-f(x, y))/h


while abs(x_new - x_old) > precision and abs(y_new - y_old) > precision:
    x_old = x_new
    y_old = y_new
    
    x_new = x_old - eps * fx_prime(x_old, y_old)
    y_new = y_old - eps * fy_prime(x_old, y_old)
    
    print(x_new, y_new)
    
