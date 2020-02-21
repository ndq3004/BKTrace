<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/logo.png" />
    <HelloWorld msg="Welcome to Your Vue.js App" />
  </div>
</template>

<script>
// @ is an alias to /src
import HelloWorld from "@/components/HelloWorld.vue";
// import "axios";
// import Axios from "axios";
export default {
  name: "home",
  components: {
    HelloWorld
  },
  data() {
    return {
      value1: 0,
      value2: 0
    };
  },
  mounted() {
    debugger;
  }
};
</script>
