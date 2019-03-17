using System;
using Database.Entities;

namespace StudentBusinessRules {
    public static class BusinessRules
    {
        public static bool hasShortEmail(Student student) => 
            student.EmailAddress.Length < shortEmailLength;

        public static int shortEmailLength = 12;

    }
}