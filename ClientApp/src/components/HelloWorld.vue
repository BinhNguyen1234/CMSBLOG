<script setup lang="ts">
import { ref,reactive,onUpdated, nextTick } from 'vue'

defineProps<{ msg: string }>()
let a = 'color:red;'
let count = ref(0)
const count2 = reactive ({
  value: 0
})
let { value } = count2
function CountC(){
  
  count2.value +=1;
  nextTick()
}
onUpdated(()=>{
  console.log(3123213)
})

</script>

<template>
  <h1>{{ msg }}</h1>

  <div class="card">
    <button :disabled="count >= 10" type="button" @click="CountC">count is {{ value }}</button>
    <p>
      Edit
      <code>components/HelloWorld.vue</code> to test HMR
    </p>
  </div>

  <p>
    Check out
    <a href="https://vuejs.org/guide/quick-start.html#local" target="_blank"
      >create-vue</a
    >, the official Vue + Vite starter
  </p>
  <p>o
    Install
    <a href="https://github.com/vuejs/language-tools" target="_blank">Volar</a>
    in your IDE for a better DX
  </p>
  <p v-if="count % 2 == 0" v-bind:style="a" class="read-the-docs">Click on the Vite and Vue logos to learn more</p>
</template>

<style scoped> 
.read-the-docs {
  color: #888;
}
</style>
