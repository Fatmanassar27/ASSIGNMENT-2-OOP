using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace ASSIGNMENT_2_OOP
{
    internal class Type_C : Type_A
    {
        public void print()
        {
            #region with inheritance
            //Type_C TypeC = new Type_C();
            //TypeC.x = 1; //invalid private protected int x => private[not inherited]
            //TypeC.y = 1;  //valid  protected int y; => private
            //TypeC.z = 1; //valid internal protected int z; => private
            //TypeC.m = 1; //invalid private int m; => private[not inherited]
            #endregion
        }
    }
}
