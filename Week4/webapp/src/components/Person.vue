<template>
  
<div>
    <table>
        <tr>
            <th class="tablehead">First Name</th>
            <th class="tablehead">Middle Initial</th>
            <th class="tablehead">Last Name</th>
        </tr>

        <tr>
            <td>Person</td>
            <td>Q</td>
            <td>Being</td>
        </tr>
        <tr>
            <td>Human</td>
            <td>X</td>
            <td>Being</td>
        </tr>
        <tr>
            <td>Person</td>
            <td>S</td>
            <td>Being</td>
        </tr>
        <tr>
            <td>Person</td>
            <td>T</td>
            <td>Being</td>
        </tr>
        <tr>
            <td>Person</td>
            <td>U</td>
            <td>Being</td>
        </tr>
    </table>
</div>
  
</template>

<script>
export default {
  name: 'Person',
  data () {
    return {
      
    }
  }
}
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
