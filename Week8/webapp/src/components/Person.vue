<template>
  
<div>
    <table>
        <tr>
            <th class="tablehead">First Name</th>
            <th class="tablehead">Middle Initial</th>
            <th class="tablehead">Last Name</th>
        </tr>

        <tbody>
                <tr v-for="person in persons">
                    <td>{{ person.firstName }}</td>
                    <td>{{ person.middleInitial }}</td>
                    <td>{{ person.lastName }}</td>
                </tr>
        </tbody>
    </table>
</div>
  
</template>

<script>
    import Vue from 'vue';
    export default {
        name: 'Persons',
        
        data () {
            return {
                persons: []
            }
        },
        methods: {
            getPersons: function() {
                Vue.axios.get('http://localhost:8081/api/persons').then(
                    (response) => {
                        console.log(response)
                        this.persons = response.data;
                    }
                );  
            }
        },
        mounted() {
            this.getPersons();
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
