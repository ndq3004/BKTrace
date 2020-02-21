export const mi = {
  data() {
    return {
      new: "day"
    };
  },
  methods: {
    show() {
      this.new = "month";
      console.log(this.new);
    }
  }
};
