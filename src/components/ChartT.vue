<template>
  <div>
    <div id="axisLabelPosition"></div>
  </div>
</template>

<script>
// Importar o CSS do billboard.js
import "billboard.js/dist/billboard.css";
import bb, {line} from "billboard.js";

export default {
  name: 'ChartT',
  mounted() {
    bb.generate({
      title: {
          text: "inverted indexed x & y Aaxis"
        },
      data: {
        columns: [
          ["sample1", 30, 200, 100, 400, 150, 250],
          ["sample2", 430, 300, 500, 400, 650, 250]
        ],
        type: line(),
        axes: {
          sample1: "y",
        }
      },
      point:{
        show: true
      },
      axis: {
        x: {
          label: {
            text: "X Label",
            position: "outer-center"
          }
        },
        y: {
          label: {
            text: "Y Label",
            position: "outer-middle"
          }
        },
      },
      bindto: "#axisLabelPosition"
    });
  }
};
</script>
