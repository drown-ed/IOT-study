import sys
from PyQt5.QtWidgets import QApplication, QWidget, QPushButton
from PyQt5.QtCore import QCoreApplication

class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initUI()

    # sender (btn) // receiver (app)
    def initUI(self):
        btn = QPushButton('Quit', self)                         # QPushBotton(표시 텍스트, 버튼 위치 위젯)
        self.setToolTip('This is a QWidget widget.')

        btn.move(50, 50)
        btn.resize(btn.sizeHint())
        btn.setToolTip('if you click, it will be gone.')        # Tooltip
        btn.clicked.connect(QCoreApplication.instance().quit)   # btn clicked -> signal 'clicked' -> return instance() -> connect quit()

        self.show()

if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())