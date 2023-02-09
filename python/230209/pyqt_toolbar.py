import sys
from PyQt5.QtWidgets import QApplication, QMainWindow, QAction, qApp, QDesktopWidget
from PyQt5.QtGui import QIcon

class MyApp(QMainWindow):
    def __init__(self):
        super().__init__()
        self.initUI()

    def initUI(self):
        exit = QAction(QIcon('./python/230209/exit.png'), 'Exit', self)
        exit.setShortcut('Ctrl+Q')
        exit.setStatusTip('Exit App')
        exit.triggered.connect(qApp.quit)

        self.statusBar()

        self.toolbar = self.addToolBar('Exit')
        self.toolbar.addAction(exit)

        self.setWindowTitle('Toolbar')
        self.setGeometry(300, 300, 300, 200)
        self.center()
        self.show()

    def center(self):
        qr = self.frameGeometry()
        cp = QDesktopWidget().availableGeometry().center()
        qr.moveCenter(cp)
        self.move(qr.topLeft())

if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())