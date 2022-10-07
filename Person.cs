using System;
using System.Collections.Generic;
using System.Text;
namespace LambdaExpressionDemo
{
    class Person
    {
        public string? SSN;
        public string? Name;
        public string? Address;
        public int? Age;
        internal bool name;
        private string v1;
        private string v2;
        private string v3;
        private int v4;
        public Person(string ssn, string name, string addr, int age)
        {
            SSN = ssn;
            Name = name;
            Address = addr;
            Age = age;

        }
        public Person(string? sSN, string? name, string? address, int? age, string v1, string v2, string v3, int v4)
        {
            SSN = sSN;
            Name = name;
            Address = address;
            Age = age;
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }
    }
}
