using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Data.SqlClient;
using NewTikTakToe;

namespace Tik_Tak_Toe.UnitTest
{
    public class TikTakToeTest
    {
        [Test(Description = "Позитивный тест передачи переменной")]
        public void TestWinValue()
        {
            var actual = "";
            var expected = "X";
            var form = new WinForm(expected);
            if (form.winMarker == expected)
            {
                 actual = form.winMarker;
            }
            Assert.AreEqual(expected, actual, "Переменная доходит до пункта назначения");
        }


    }
}
