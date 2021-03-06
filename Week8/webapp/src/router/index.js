import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/components/Home'
import Students from '@/components/Students'
import Person from '@/components/Person'
Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/home',
      name: 'Home',
      component: Home
    },
    {
      path: '/students',
      name: 'Students',
      component: Students
    },
    {
      path: '/person',
      name: 'Person',
      component: Person
    }
  ]
})
