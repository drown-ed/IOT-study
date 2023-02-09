import sys
from PyQt5.QtWidgets import *

class YourApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initUI()

    def initUI(self):
        Label1 = QLabel('Label1', self)
        Label1.move(20, 20)
        Label2 = QLabel('Label2', self)
        Label2.move(20, 60)
        
        btn1 = QPushButton('Button1', self)
        btn1.move(80, 13)

        self.setWindowTitle('Absoulte layout')
        self.setGeometry(300, 300, 300, 300)
        self.show()

if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = YourApp()
    sys.exit(app.exec_())