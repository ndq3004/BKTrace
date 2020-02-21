/**
 *Define một plugin
 * theo đó, ta có thể gọi trong các màn hình bằng cách this.$qn
 */
const qPlugin = {
  install(Vue) {
    Vue.prototype.$qn = {
      session: "one",
      cache: 4
    };
  }
};
export default qPlugin;
