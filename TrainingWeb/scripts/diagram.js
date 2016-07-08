var diagram = (function () {
    return {
        title: function (t1) {
            this.text = t1;
            x: -20;
        },

        subtitle: function (subt1) {
            this.text = subt1;
            x: -20;
        },

        xAxis: function (cate) {
            this.categories = cate;
        },

        yAxis: function (tit2, plotLines) {
            this.text = tit2;
            this.plotLines = plotLines;
        },

        tooltip: function (x) {
            this.valueSuffix = x;
        },
    }
    
})();