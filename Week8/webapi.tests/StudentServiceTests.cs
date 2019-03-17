using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;
using Database.Entities;
using StudentBusinessRules;

public class StudentServiceTests
{
    private StudentService _studentService; // System Under Test (SUT)
    private IStudentRepository _studentRepository; // Mock

    [SetUp]
    public void Setup()
    {
        var loggerFactory = A.Fake<LoggerFactory>();
        _studentRepository = A.Fake<IStudentRepository>();

        _studentService = new StudentService(_studentRepository, loggerFactory);
    }
    [Test]
    public void GetAllReturnsSomeSpecialStudents()
    {
        // Arrange
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId=1,
                    EmailAddress="aaa.bbbccc@oit.edu"
                },
                new Student {
                    StudentId=2,
                    EmailAddress="q@oit.edu"
                }
            }
        );

        // Act
        var studentDtos = _studentService.GetAllStudents();

        // Assert (FluentAssertions)
        studentDtos.Any(pdto => pdto.Special).Should().BeTrue();
    }

    [Test]
    public void GetAllReturnsNoSpecialStudents()
    {
        // Arrange
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId=1,
                    EmailAddress="aaa.bbbccc@oit.edu"
                },
                new Student {
                    StudentId=2,
                    EmailAddress="aeiouaeiou.aeiou@oit.edu"
                }

            }
            
        );

        // Act
        var studentDtos = _studentService.GetAllStudents();

        // Assert (FluentAssertions)
        studentDtos.Any(pdto => pdto.Special).Should().BeFalse();
    }
}