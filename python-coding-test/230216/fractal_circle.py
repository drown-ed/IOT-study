# fractal circle 

import turtle 
import tkinter as TK

turtle.setup(width=600, height=600)
t = turtle.Turtle()
t.shape('turtle')

c = t.clone()
c.color('red')
c.circle(30)

for i in range(4, 10):
    c.circle(i*10)

turtle.mainloop()
