using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class Type_B : Type_A
    {
        //public void print ()
        //{
        //  Type_A TypeA = new Type_A ();

        //    #region without inheritance
        //    //TypeA.x = 1; //invalid private protected int x => private
        //    //TypeA.y = 1;  //invalid  protected int y; => private
        //    //TypeA.z = 1; //valid internal protected int z; => internal
        //    //TypeA.m = 1; private int m; => private
        //    #endregion


        //    #region with inheritance
        //    //Type_B TypeB = new Type_B ();
        //    //TypeB.x = 1; //valid private protected int x => private
        //    //TypeB.y = 1;  //valid  protected int y; => private
        //    //TypeB.z = 1; //valid internal protected int z; => internal
        //    ////TypeB.m = 1; //invalid private int m; => private
        //    #endregion

        }


    }
}
