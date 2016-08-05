var Painter = {}

///*the parent object geometry */
Painter.Vertice = function (x, y) {
    this.x = x;
    this.y = y;
}

Painter.Geometry = function () {
    this.points = [];
    this.parts = [];
}

Painter.Geometry.prototype = {
    construction: Painter.Geometry,
    getColor: function (style) {
        return style.color;
    },
    getArea: function () { },
    getPerimeter: function () {
        var i, sum = 0;
        for (i = 0; i < this.lines.length; i++) {
            sum += this.polylines[i].length;
        }
        return sum;
    }
}

///*the child object */
Painter.Geometry.PointGeometry = function (x, y) {
    this.x = x;
    this.y = y;
}

Painter.Geometry.PolylineGeometry = function(points) {
    this.points = points;
    this.length = function () {
    }
}

Painter.Geometry.PolygonGeometry = function(points, parts) {
    this.points = points;
    this.parts = parts;
    this.getArea = function () {
    };
}

function CircleGeometry(center, radius) {
    this.centter = center;
    this.radius = radius;
}

(function () {
    var geometry = new Painter.Geometry();
    Painter.Geometry.PointGeometry.prototype = geometry;
    Painter.Geometry.PolygonGeometry.prototype = geometry;
    Painter.Geometry.PolylineGeometry.prototype = geometry;
})();

Painter.Style = function(penColor, penWidth, isFill, fillColor) {
    this.penColor = penColor;
    this.penWidth = penWidth;
    this.isFill = isFill;
    this.fillColor = fillColor;
}

Painter.Canvas = function (id, height, width, background) {
    this.id = id;
    this.height = height;
    this.width = width;
    this.background = background;
}

Painter.Drawing = (function () {
    return {
        drawPoint: function (canvas, style, x, y) {
            var canvasss = document.getElementById(canvas.id),
                context = canvasss.getContext('2d');

            context.lineWidth = style.penWidth;
            context.strokeStyle = style.penColor;
            context.fillStyle = style.penColor;
            context.beginPath();
            context.arc(x, y, 5, 0, Math.PI * 2, true);
            context.closePath();
            context.stroke();
            context.fill();
        },

        drawPoints: function (canvas, style, points) {
            var canvasss = document.getElementById(canvas.id),
                context = canvasss.getContext('2d');

            for (var i = 0; i < points.length; i++) {
                context.lineWidth = style.penWidth;
                context.strokeStyle = style.penColor;
                context.fillStyle = style.penColor;
                context.beginPath();
                context.arc(points[i].x, points[i].y, 5, 0, Math.PI * 2, true);
                context.closePath();
                context.stroke();
                context.fill();
            }
        },

        drawPolyline: function (canvas, style, startVertice, endVertice) {
            var canvasss = document.getElementById(canvas.id),
                context = canvasss.getContext('2d');

            context.beginPath();
            context.lineWidth = style.penWidth;
            context.strokeStyle = style.penColor;
            context.moveTo(startVertice.x, startVertice.y);
            context.lineTo(endVertice.x, endVertice.y);
            context.closePath();
            context.stroke();
        },

        drawPolylines: function (canvas, style, polyline) {
            var canvasss = document.getElementById(canvas.id),
                context = canvasss.getContext('2d');

            context.beginPath();
            context.lineWidth = style.penWidth;
            context.strokeStyle = style.penColor;

            // draw each part's polyline 
            for (var i = 0; i < polyline.points.length - 1; i++) {
                context.moveTo(polyline.points[i].x, points[i].y);
                context.lineTo(polyline.points[i + 1].x, polyline.points[i + 1].y);
                context.closePath();
                context.stroke();
            }

        },

        drawRectangle: function (canvas, style, vertex, width, heigth) {
            var p1, p2, p3, points, parts, polygon,
                canvasss = document.getElementById(canvas.id),
                context = canvasss.getContext('2d');

            context.lineWidth = style.penWidth;
            context.strokeStyle = style.penColor;

            if (style.isFill) {
                context.fillStyle = style.fillColor;
                context.fillRect(vertex.x, vertex.y, width, heigth);
            } else {
                p1 = new PointGeometry(vertex.x + width, vertex.y);
                p2 = new PointGeometry(vertex.x + width, vertex.y + heigth);
                p3 = new PointGeometry(vertex.x, vertex.y + heigth);
                points = [vertex, p1, p2, p3, vertex];
                parts = [5];
                polygon = new PolygonGeometry(points, parts);
                this.drawPolygon(canvas, style, polygon);
            }
        },

        drawPolygon: function (canvas, style, polygon) {
            var i, j, temp,
                tempSign = 0,
                canvasss = document.getElementById(canvas.id),
                context = canvasss.getContext('2d');

            context.lineWidth = style.penWidth;
            context.strokeStyle = style.penColor;
            context.beginPath();

            if (style.isFill) {

                for (j = 0; j < polygon.parts.length; j++) {
                    temp = polygon.parts[j];
                    context.moveTo(polygon.points[tempSign].x, polygon.points[tempSign].y);
                    for (i = 0; i < temp - 1; i++) {
                        context.lineTo(polygon.points[tempSign + i + 1].x, polygon.points[tempSign +
                        	    i + 1].y);
                    }
                    tempSign += temp;
                }
                context.closePath();
                context.fillStyle = style.fillColor;
                context.stroke();
                context.fill();
            } else {

                for (j = 0; j < polygon.parts.length; j++) {
                    temp = polygon.parts[j];
                    for (i = 0; i < temp - 1; i++) {
                        context.moveTo(polygon.points[tempSign + i].x, polygon.points[tempSign + i].y);
                        context.lineTo(polygon.points[tempSign + i + 1].x, polygon.points[tempSign +
                        	    i + 1].y);
                        context.closePath();
                        context.stroke();
                    }
                    tempSign += temp;
                }
            }

        },

        drawCircle: function (canvas, style, center, r) {
            var canvasss = document.getElementById(canvas.id),
                context = canvasss.getContext('2d');

            context.lineWidth = style.penWidth;
            context.strokeStyle = style.penColor;

            if (style.isFill) {
                context.fillStyle = style.fillColor;
                context.beginPath();
                context.arc(center.x, center.y, r, 0, Math.PI * 2, false);
                //context.stroke();
                context.fill();
            } else {
                context.beginPath();
                context.arc(center.x, center.y, r, 0, Math.PI * 2, false);
                context.stroke();
            }
        },

        drawArc: function (canvas, style, center, radius, startAngle, endAngle, anticlockwise) {
            var canvasss = document.getElementById(canvas.id),
                context = canvasss.getContext('2d');

            if (style.isFill) {
                context.lineWidth = style.penWidth;
                context.strokeStyle = style.penColor;
                context.fillStyle = style.fillColor;
                context.beginPath();
                context.arc(center.x, center.y, radius, startAngle * Math.PI / 180, endAngle *
                	    Math.PI / 180, anticlockwise);
                context.stroke();
            } else {
                context.beginPath();
                context.lineWidth = style.penWidth;
                context.strokeStyle = style.penColor;
                context.beginPath();
                context.arc(center.x, center.y, radius, startAngle * Math.PI / 180, endAngle *
                	    Math.PI / 180, anticlockwise);
                context.stroke();
            }

        },

        drawSector: function (canvas, style, center, radius, startAngle, endAngle) {
            var canvasss = document.getElementById(canvas.id),
                context = canvasss.getContext('2d');

            context.lineWidth = style.penWidth;
            context.strokeStyle = style.penColor;
            context.beginPath();
            context.arc(center.x, center.y, radius, startAngle * Math.PI / 180, endAngle *
            	    Math.PI / 180, false);
            context.lineTo(center.x, center.y);

            if (style.isFill) {
                context.fillStyle = style.fillColor;
                context.closePath();
                context.stroke();
                context.fill();
            } else {
                context.closePath();
                context.stroke();
            }
        },

        drawText: function (canvas, style, text, x, y) {
            var canvasss = document.getElementById(canvas.id),
                context = canvasss.getContext('2d');

            context.fillStyle = style.penColor;
            context.fillText(text, x, y);
        }
    }
}());



