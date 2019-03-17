using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Person> persons = new List<Person> {
            new Person {
                firstName="API",
                middleInitial='Q',
                lastName="Person"
            },
            new Person {
                firstName="API",
                middleInitial='R',
                lastName="Persontwo"
            },
            new Person {
                firstName="API",
                middleInitial='S',
                lastName="Personthree"
            },
        };
        public static List<Student> students = new List<Student> {
            new Student {
                id=100,
                email="person@a.com"
            }
        };
    }
}