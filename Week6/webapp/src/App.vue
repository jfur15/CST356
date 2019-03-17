<template>
  <div id="app">
    <img src="./assets/logo.png">
    <span v-on:click='goToHome'>Index</span>

    <span v-on:click='goToStudents'>Students</span>

    <span v-on:click='goToPerson'>Persons</span>

    <router-view/>
  </div>
</template>

<script>
export default {
  name: 'App',
  methods: {
    goToHome: function(){
      this.$router.push({ path: 'home' })
    },
    goToStudents: function(){
      this.$router.push({ path: 'students' })
    },
    goToPerson: function(){
      this.$router.push({ path: 'person' })
    }
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
