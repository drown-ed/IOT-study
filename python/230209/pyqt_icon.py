import sys
from PyQt5.QtWidgets import QApplication, QWidget 
from PyQt5.QtGui import QIcon                                    # favicon setting lib

class MyApp(QWidget):                                            # QWidget 상속받은 MyApp class
    def __init__(self):
        super().__init__()
        self.initUI()

    # GUI 화면 설정
    def initUI(self):
        self.setWindowTitle('icon')                             # 화면 창 제목

        self.setWindowIcon(QIcon('./python/230209/icon.png'))   # python 경우 상대경로를 이용해 입력
        self.setGeometry(300, 300, 300, 200)

        self.show()                                             # 화면 띄우기


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())