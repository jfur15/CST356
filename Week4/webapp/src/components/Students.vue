<template>
  
<div>

    <table>
    <thead>
        <tr>
            <th class="tablehead">Student ID</th>
            <th class="tablehead">Email Address</th>
        </tr>
        </thead>
<tbody>
                <tr v-for="student in students">
                    <td>{{ student.id }}</td>
                    <td>{{ student.email }}</td>
                </tr>
            </tbody>


    </table>

</div>
  
</template>

<script>
export default {
  name: 'Students',
  mounted() {
      this.students=parseStudents();
  },
  data () {
    return {
      students: []
    }
  }
}


function parseStudents()
{
    return JSON.parse(studentDatabase).students;  
}


var studentDatabase = '{"students": [{"id": "101", "email": "oneohone@oit.edu"}, {"id": "202", "email": "twoohtwo@oit.edu"}]}'

</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.tablehead
{
    font-size: 18px;
    background-color: beige;
    font-style: italic;
}

.homehead
{
    background-color: mediumspringgreen;
    color: red;
    font-family: Verdana, Geneva, Tahoma, sans-serif;
    font-style: italic;
    font-size: 4em;
}

img
{
    width: 6em;
}
</style>
