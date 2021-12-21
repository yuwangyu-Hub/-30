using System;
using System.Collections.Generic;
using System.Text;

namespace 极夜30
{
    class Person
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param 名字="name"></param>
        /// <param 性别="gender"></param>
        /// <param 年龄="age"></param>
        public Person(string name,char gender,int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;

        }

        //姓名
        string _name;
        public string Name 
        {
            get {  return _name; }
            set {  _name = value; }
        }

        //性别
        char _gender;
        public char Gender 
        {
            get { return _gender; }
            set { _gender = value; } 
        }
        
        //年龄
        int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        //身高
        float _high;
        public float High
        {
            get { return _high; }
            set { _high = value; }
        }

        //长相（一到十分）
        int _looks;
        public int Looks
        {
            get { return _looks; }
            set {
                if (value < 0 || value > 10)
                    _looks = 5;//如果长相小于0或者大于10，那么长相就给5，表示中等
                else
                    _looks = value;
            }
        }

        //健康状况（1-10）
        //知识（1-10）
        //力气（1-10）
        //职业
        //情绪（1-10）
        //
        //--------------战斗相关
        //武器熟练度（1-10）
        //


    }
}
