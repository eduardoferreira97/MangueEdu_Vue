<template>
    <div>
        <div id="xAxisTickValues"></div>
    </div>
</template>

<script>
import bb, { line } from "billboard.js";

export default {
    name: "chartT2.vue",

    mounted() {
        bb.generate({
            title: {
          text: "inverted indexed x & y Aaxis"
             },
            data: {
                x: "x",
                columns: [
                    ["x", "2013-01-01", "2013-01-02", "2013-01-03", "2013-01-04", "2013-01-05", "2013-01-06", "2013-01-07", "2013-01-08", "2013-01-09", "2013-01-10", "2013-01-11", "2013-01-12"],
                    ["sample", 30, 200, 100, 400, 150, 250, 30, 200, 100, 400, 150, 250]
                ],
                
                type: line(), // for ESM specify as: line()
            },
            axis: {
                x: {
                    type: "timeseries",
                    tick: {
                        values: [
                            "2013-01-05",
                            "2013-01-10"
                        ]
                    }
                }
            },
            bindto: "#xAxisTickValues"
        });
    }
}

</script>