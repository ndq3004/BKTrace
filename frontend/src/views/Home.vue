<template>
  <div class="home">
    
    <v-card-title>
      <h1 class="display-1">Login</h1>
    </v-card-title>
  </div>
</template>

<script>
// @ is an alias to /src
// import "axios";
// import Axios from "axios";
export default {
  name: "home",
  components: {},
  data() {
    return {
      value1: 0,
      value2: 0
    };
  },
  mounted() {
    if(this.$qn.cache){
      debugger
      console.log(this.$qn.cache.exportJson())

    }
  }
};
</script>
