
function initStudents()
{
    var data = parseStudents();
    displayStudents(data.students);
}

function parseStudents()
{
    return JSON.parse(studentDatabase);
}

function displayStudents(students)
{
    for (i = 0; i < students.length; i++)
    {
        console.log(students[i].id);
        $("table tbody").append("<tr><td>" + students[i].id + "</td><td>" + students[i].email + "</td><td>");
    }
    
    
}

var studentDatabase = '{"students": [{"id": "101", "email": "oneohone@oit.edu"}, {"id": "202", "email": "twoohtwo@oit.edu"}]}'

