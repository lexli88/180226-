using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProOperation
{
  public abstract   class Operation
    {//父类用抽象类
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }
        public Operation(int n1,int n2)
        {
            this.NumberOne = n1;
            this.NumberTwo = n2;
        }
        //记录子类的计算类型  + - * /
        public abstract string Type
        { get; set; }
        //返回一个结果
        public abstract int GetResult();
    }
}
