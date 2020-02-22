/**
 *Define một plugin
 * theo đó, ta có thể gọi trong các màn hình bằng cách this.$qn
 */
// import axios from "axios";

import cache from "memory-cache";
// function plugin(){

// }
var qPlugin = {
  install(Vue) {
    Vue.prototype.$qn = {
      session: "one",
      cache: cache
    };
  }
};
export default qPlugin;
