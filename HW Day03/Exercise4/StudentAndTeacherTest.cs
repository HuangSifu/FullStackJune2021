using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class StudentAndTeacherTest
    {
        public static void Main()
        {
            Person person = new Person();
            Student student = new Student();
            Teacher teacher = new Teacher();
            person.SayHello();
            student.SetAge(21);
            student.SayHello();
            student.ShowAge();
            teacher.SetAge(30);
            teacher.SayHello();
            teacher.Explain();
        }
    }
}
