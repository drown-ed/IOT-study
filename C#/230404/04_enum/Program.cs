using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_enum
{
    internal class Program
    {
        // enum : 같은 형태를 가지고 있는 상수를 열거할 때 사용
        enum DialogResult
        {
            Yes,        // 0
            No,         // 1
            Cancel,     // 2
            Confirm,    // 3
            Ok          // 4
        }

        enum HomeTown
        {
            SEOUL,      // Ctrl + U : lower
            DAEJEON,    // Ctrl + Shift + U : Upper
            DAEGU,
            BUSAN,
            JEJU
        }
        static void Main(string[] args)
        {
            DialogResult result = DialogResult.Yes;
            Console.WriteLine(result);          // output >> Yes

            HomeTown myHomeTown;
            myHomeTown = HomeTown.BUSAN;
            if (myHomeTown == HomeTown.SEOUL)
            {
                Console.WriteLine("서울 출신이시군요!");
            } else if (myHomeTown == HomeTown.BUSAN)
            {
                Console.WriteLine("부산 출신이시군요!");
            }

        }
    }
}
