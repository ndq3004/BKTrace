import Vue from "vue";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import VueI18n from "vue-i18n";
import vnMessage from "@/i18n/data/vn/food.js";
import plugin from "./plugin.js";
import vuetify from "./plugins/vuetify";

const messages = {
  vn: vnMessage
};

Vue.config.productionTip = false;
Vue.use(VueI18n);
const i18n = new VueI18n({
  locale: "vn",
  messages,
  fallbackLocale: "vn"
});

Vue.use(plugin);
new Vue({
  router,
  store,
  i18n,
  plugin,
  vuetify,
  render: h => h(App)
}).$mount("#app");
