using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Database.Entities;
using StudentBusinessRules;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    private readonly ILogger _logger;

    public StudentService(IStudentRepository studentRepository, ILoggerFactory loggerFactory)
    {
        _studentRepository = studentRepository;
        _logger = loggerFactory.CreateLogger("Controllers.ProductService");
    }

    public List<StudentDto> GetAllStudents()
    {
        var studentDtos = new List<StudentDto>();

        foreach(var student in _studentRepository.GetAllStudents())
        {
            studentDtos.Add(new StudentDto {
                StudentId = student.StudentId,
                EmailAddress = student.EmailAddress,
                Special = BusinessRules.hasShortEmail(student)
            });
            if (BusinessRules.hasShortEmail(student))
            {
                _logger.LogInformation("Found person with short email address: " + student.StudentId);
            }
        }

        return studentDtos;
    }
}