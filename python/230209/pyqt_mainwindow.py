import sys
from PyQt5.QtWidgets import QApplication, QMainWindow, QAction, qApp
from PyQt5.QtGui import QIcon

class MyApp(QMainWindow):                               # status bar의 경우 QMainWindow 상속
    def __init__(self):
        super().__init__()
        self.initUI()

    def initUI(self):

        # exit
        exit = QAction(QIcon('./python/230209/exit.png'), 'Exit', self)
        exit.setShortcut('Ctrl+Q')
        exit.setStatusTip('Exit App')
        exit.triggered.connect(qApp.quit)

        menu = self.menuBar()
        menu.setNativeMenuBar(False)
        filemenu = menu.addMenu('&File')
        filemenu.addAction(exit)

        # menubar 
        self.statusBar().showMessage('Ready')

        self.setWindowTitle('statusbar')
        self.setGeometry(300, 300, 300, 200)
        self.show()

if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())