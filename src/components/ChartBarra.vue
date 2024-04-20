<template>
    <div>
        <div id="barFront_1"></div>
    </div>
</template>

<script>
import "billboard.js/dist/billboard.css";
import bb, { bar } from 'billboard.js'

export default {
    name: "chartBarra",

    mounted() {
        bb.generate({
            title: {
                text: "Gráfico de barra"
            },
            data: {
                columns: [
                    ["data1", 230, 180, 250, 270, 220, 120, 300, 40, 147],
                    
                ],
                types: {
                    data1: bar(), // for ESM specify as: bar()
                }
            },
            bar: {
                front: true
            },
            bindto: "#barFront_1"
        })
    }  
        
}

</script>