using System;
using System.Collections.Generic;
using System.Text;

namespace 极夜30
{
    class Person
    {
        //姓名
        private string _name;
        public string Name 
        {
            get {  return _name; }
            set {  _name = value; }
        }

        //性别
        private char _gender;
        public char Gender 
        {
            get { return _gender; }
            set { _gender = value; } 
        }
        
        //年龄
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        //

    }
}
