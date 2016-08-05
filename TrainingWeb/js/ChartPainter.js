
// reference the painter library
document.write("<script language=javascript src='/js/Painter.js'></script>");

var ChartPainter = {};

ChartPainter.Charts = function (title, legend, series) {
    this.title = title;
    this.legend = legend;
    this.series = series;
};



ChartPainter.Charts.PieChart = function (datas, colors, center, radius) {
    this.datas = datas;
    this.colors = colors;
    this.center = center;
    this.radius = radius;
    this.draw = function (canvas) {
        var endAngle, i, pieStyle,
            startAngle = 0,
            showData = this.getShowData();

        // draw the sector
        for (i = 0; i < datas.length; i++) {
            endAngle = showData[i] * 360 + startAngle; // change data to angle
            pieStyle = new Painter.Style(colors[i], 3, true, colors[i]);

            Painter.Drawing.drawSector(canvas, pieStyle, center, radius, startAngle, endAngle, false);
            startAngle = endAngle;
        }
    };
    this.drawLegend = function (canvas) {
        var i, legendStyle, point, textStyle;

        // draw the rectangle
        for (i = 0; i < datas.length; i++) {
            legendStyle = new Painter.Style(colors[i], 2, true, colors[i]);
            point = new Painter.Vertice(center.x + radius + 20, 50 + 18 * i);
            textStyle = new Painter.Style("#000", 2, true, "#000");

            Painter.Drawing.drawRectangle(canvas, legendStyle, point, 16, 16);
            Painter.Drawing.drawText(canvas, textStyle, datas[i][1], point.x + 20, 62 + 18 * i);
        }
    };
    this.getShowData = function () {
        var i,
    	    sumData = 0,
    	    showData = [];

        for (i = 0; i < datas.length; i++) {
            sumData += datas[i][0];
        }

        // chage the data to percentage
        for (i = 0; i < datas.length; i++) {
            showData[i] = datas[i][0] / sumData
        }
        return showData;
    };
}

ChartPainter.Charts.RadarChart = function (center, maxRadius, maxData, minData, numCircle, series, data) {
    this.center = center;
    this.maxRadius = maxRadius;
    this.numCircle = numCircle;
    this.series = series;
    this.data = data;
    this.maxDate = maxData;
    this.minData = minData;
    this.draw = function (canvas) {
        this.drawConcentricCircles(canvas);
        this.drawSeries(canvas);
        this.drawDataLine(canvas);
    }

    this.drawConcentricCircles = function (canvas) {
        var i,
    	    PERRADIUS = maxRadius / numCircle,
            tempRadius = maxRadius,
            circleStyle = new Painter.Style("#A0A0A0", 0.5, false);

        // draw the concertric circles form outside to inside by decrease the radiu 
        for (i = 0; i < numCircle; i++) {
            Painter.Drawing.drawCircle(canvas, circleStyle, center, tempRadius);
            tempRadius -= PERRADIUS;
        }
    }

    this.drawSeries = function (canvas) {
        var i, endPoint,
    	    seriesStyle = new Painter.Style("rgba(255,227,188,99)", 2, false),
            tempAngle = 0,
            PER_ANGLE = 360 / series.length;

        for (var i = 0; i < series.length ; i++) {

            // draw the sector. 
            if (tempAngle === 0 || tempAngle === 360 || tempAngle == 180) {
                endPoint = new Painter.Vertice(center.x + maxRadius * Math.cos(Math.PI *
                	       tempAngle / 180), center.y);
                Painter.Drawing.drawPolyline(canvas, seriesStyle, center, endPoint);
                textStyle = new Painter.Style("#000", 2, true, "#000");
                Painter.Drawing.drawText(canvas, textStyle, series[i], endPoint.x, endPoint.y);
            } else if (tempAngle === 90 || tempAngle === 270) {
                endPoint = new Painter.Vertice(center.x, center.y + maxRadius *
                	       Math.sin(Math.PI * tempAngle / 180));
                Painter.Drawing.drawPolyline(canvas, seriesStyle, center, endPoint, 14);
                textStyle = new Painter.Style("#000", 2, true, "#000");
                Painter.Drawing.drawText(canvas, textStyle, series[i], endPoint.x, endPoint.y + 10);
            } else {
                endPoint = new Painter.Vertice(center.x + maxRadius * Math.cos(Math.PI * tempAngle / 180),
                         center.y + maxRadius * Math.sin(Math.PI * tempAngle / 180));
                Painter.Drawing.drawPolyline(canvas, seriesStyle, center, endPoint);

                if (tempAngle > 0 && tempAngle < 180) {
                    textStyle = new Painter.Style("#000", 2, true, "#000");
                    Painter.Drawing.drawText(canvas, textStyle, series[i], endPoint.x, endPoint.y + 14);
                } else if (tempAngle > 180 && tempAngle < 360) {
                    textStyle = new Painter.Style("#000", 2, true, "#000");
                    Painter.Drawing.drawText(canvas, textStyle, series[i], endPoint.x, endPoint.y - 14);
                }
            }
            tempAngle += PER_ANGLE;
        }
    }

    this.drawDataLine = function (canvas) {
        var i, r, temX, temY, pointsLength, polygon,
            points = [],
            parts = [],
            angle = 0,
            PER_ANGLE = 360 / series.length,
    	    dataStyle = new Painter.Style("#8E4733", 2, true, "rgba(157,116,71,0.4)");

        for (i = 0; i < data.length; i++) {
            r = maxRadius * (data[i] - minData) / (maxData - minData);

            if (angle === 0 || angle === 360) {
                temX = (data[i] * maxRadius / (maxData - minData) + center.x);
                temY = center.y;
                points[i] = new Painter.Vertice(temX, temY);
            } else if (angle === 90) {
                temX = center.y;
                temY = data[i] * maxRadius / (maxData - minData) - center.y;
                points[i] = new Painter.Vertice(temX, temY);
            } else if (angle === 180) {
                temX = (center.x - data[i] * maxRadius / (maxData - minData));
                temY = center.y;
                points[i] = new Painter.Vertice(temX, temY);
            } else if (angle === 270) {
                temX = center.y;
                temY = data[i] * maxRadius / (maxData - minData) + center.y;
                points[i] = new Painter.Vertice(temX, temY);
            } else {
                temX = ((data[i] * maxRadius / (maxData - minData)) * Math.cos(angle * Math.PI / 180) + center.x);
                temY = ((data[i] * maxRadius / (maxData - minData)) * Math.sin(angle * Math.PI / 180) + center.y);
                points[i] = new Painter.Vertice(temX, temY);
            }
            angle += PER_ANGLE;
        }

        pointsLength = points.length
        points[pointsLength] = points[0];
        parts = [series.length + 1];
        polygon = new Painter.Geometry.PolygonGeometry(points, parts);
        Painter.Drawing.drawPolygon(canvas, dataStyle, polygon);
    }


}

