
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Database;
using Database.Entities;
using System;

public class StudentRepository : IStudentRepository
{ 
    private readonly SchoolContext _dbContext;
    private readonly ILogger _logger;
    public StudentRepository(SchoolContext dbContext, ILoggerFactory loggerFactory)
    {
        _dbContext = dbContext;
        _logger = loggerFactory.CreateLogger("Controllers.StudentRepository");
    }
    public List<Student> GetAllStudents()
    {
        try
        {
            return _dbContext.Student.ToList();
        } 
        catch(Exception ex)
        {
            _logger.LogError("Failed to get students.", ex);
            
            return new List<Student>();
        }
    }
}