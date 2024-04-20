<template>
    <div>
        <div id="startingAngle"></div>
    </div>
</template>

<script>
import "billboard.js/dist/billboard.css";
import bb, { donut } from 'billboard.js'

export default {
    name: "chartDonuts",

    mounted() {
        bb.generate({
            title: {
                text: "Donut chart"
            },
            data: {
                columns: [
                    ["data1", 30],
                    ["data2", 45],
                    ["data3", 25]
                ],
                type: donut(), // for ESM specify as: donut()
            },
            donut: {
                startingAngle: 0.7
            },
            bindto: "#startingAngle"

        })
    }

}

</script>