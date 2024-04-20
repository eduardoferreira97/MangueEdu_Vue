<template>

  <ChartT/>
  <ChartT2/>
  <Suave/>
  <Barra/>
  <Donut/>
  
</template>

<script>

import ChartT from './components/ChartT.vue'
import ChartT2 from './components/ChartT2.vue'
import Suave from './components/ChartSuave.vue'
import Barra from './components/ChartBarra.vue'
import Donut from './components/ChartDonuts.vue'

export default {
  name: 'App',
  components: {
    ChartT,
    ChartT2,
    Suave,
    Barra,
    Donut
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
