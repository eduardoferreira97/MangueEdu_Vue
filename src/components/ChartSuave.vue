<template>
    <div>
        <div id="dataLabelPosition_2"></div>
    </div>
</template>
<script>



import bb, { spline } from "billboard.js"

export default {
    name: "ChartSuave",
    mounted() {
        bb.generate({
            title:{
                text: "Grafico suave"
            },
            data: {
                columns: [
                    ["data1", 150, 240, 400, 300, 200],
                    ["data2", 80, 120, 300, 240, 115]
                ],
                type: spline(), // for ESM specify as: spline()
                labels: {
                    show: true, //Não mostra os valores no grafico como False
                    position: {
                        data1: {
                            x: 3,
                            y: -10
                        },
                        data2: {
                            x: 3,
                            y: 30
                        }
                    }
                }
            },
            axis: {
                x: {
                    padding: {
                        left: 0.5,
                        right: 0.5
                    }
                }
            },
            bindto: "#dataLabelPosition_2"

        })
    }
}
</script>