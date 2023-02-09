import sys
from PyQt5.QtWidgets import QApplication, QWidget 

class MyApp(QWidget):                               # QWidget 상속받은 MyApp class
    def __init__(self):
        super().__init__()
        self.initUI()

    # GUI 화면 설정
    def initUI(self):
        self.setWindowTitle('Application Title')    # 화면 창 제목
        self.move(300, 300)                         # 화면 초기 위치
        self.resize(400, 200)                       # 화면 사이즈 
        self.show()                                 # 화면 띄우기


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())