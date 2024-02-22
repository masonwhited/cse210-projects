using System;

class Program
{
    static void Main(string[] args)
    {

        //Console.WriteLine("Hello Learning04 World!");
        string student = "James MacHine";
        string subject = "Math";
        Assignment assignment = new Assignment(student, subject);
        Console.WriteLine(assignment.GetSummary());

        /*         Student s1 = new Student("id1", "Bob", "CSE");
                Faculty f1 = new Faculty("id2", "Sue", "BioAg");

                List<Person> people = new List<Person>();
                people.Add(s1);
                people.Add(f1);

                foreach (var person in people)
                {
                    //System.Console.WriteLine($"{person.DisplayInfo()}");
                    if (person is Student)
                    {
                        Student student = (Student)person;
                        student.Display();
                    }
                    else
                    {
                        Faculty faculty = (Faculty)person;
                        faculty.Display();
                    }
                }
            }
        }

        class Person
        {
            private string id;
            private string name;

            public Person(string id, string name)
            {
                this.id = id;
                this.name = name;
            }
            public string DisplayInfo()
            {
                return $"{name}: {id}";
            }
        }

        class Student : Person
        {
            private string major;

            public Student(string id, string name, string major) : base(id, name)
            {
                this.major = major;
            }

            public void Display()
            {
                System.Console.WriteLine($"{DisplayInfo()} - {major}");
            }
        }

        class Faculty : Person
        {
            private string department;

            public Faculty(string id, string name, string department) : base(id, name)
            {
                this.department = department;
            }

            public void Display()
            {
                System.Console.WriteLine($"{DisplayInfo()} - {department}");
            }*/
    }
}