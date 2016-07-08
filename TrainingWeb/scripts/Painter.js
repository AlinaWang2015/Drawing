




var painter = (function () {
    return {
        style: function (penColor, penWidth) {
            var canvasss = document.getElementById('mycanvas');
            var context = canvasss.getContext('2d');
            context.lineWidth = penWidth;
            context.stroke.style = penColor;
            return context;
        },

        canvas: function (height, width, background) {
            var mycanvas = document.createElement("canvas");
            mycanvas.id = "mycanvas";
            mycanvas.width = width;
            mycanvas.height = height;
            mycanvas.style.background = background;
            document.body.appendChild(mycanvas);
        },

        Vertex: function (x, y) {
            this.x = x;
            this.y = y;
        },

        Line : function(v1,v2){
            this.v1 = v1;
            this.v2 = v2;
            this.length = Math.sqrt(
                Math.pow(v1.x - v2.x),
                Math.pow(v1.y - v2.y)
                );
        },

        Geometry:function ()  {
            this.points = [];
            this.lines = [];
            this.initialization();
        },

        PointGeometry: function (vertexBox) {
            this.vertexBox = vertexBox;
        },

        PolylineGeometry: function (vertexBox, partsBox) {
            this.vertexBox = vertexBox;
            this.partsBox = partsBox;
        },

        PolygonGeometry: function (vertexBox, partsBox) {
            this.vertexBox = vertexBox;
            this.partsBox = partsBox;
        },

        CircleGeometry: function (center, radius) {
            this.centter = center;
            this.radius = radius;
        },

        verify: function (input) {

            if (!isNaN(input)) {
                if (!isFinite(input)) {
                    alert("输入参数为一个即非infinity又非NaN的数字！");
                } else {
                    return input;
                }

            } else {
                var output = parseFloat(input);
                return output;
            }
        },

        drawPolylines: function (polyline, style) {
            //canvas
            var context = style;

            context.beginPath();
            for (var j = 0; j < polyline.partsBox; j++) {
                for (var i = 0; i < polyline.partsBox[j]; i++) {
                    context.moveTo(polyline.vertexBox[i].x, polyline.vertexBox[i].y);
                    context.lineTo(polyline.vertexBox[i + 1].x, polyline.vertexBox[i + 1].y);
                    context.closePath();
                    context.stroke();
                }
            }

        },

        drawPolygon: function (polygon, style) {
            //canvas
            var context = style;

            context.beginPath();
            for (var j = 0; j < polygon.partsBox; j++) {
                var temp = polygon.partsBox[j];
                for (var i = 0; i < temp; i++) {
                    context.moveTo(polygon.vertexBox[i].x, polygon.vertexBox[i].y);
                    context.lineTo(polygon.vertexBox[i + 1].x, polygon.vertexBox[i + 1].y);

                    context.closePath();
                    context.stroke();
                }
            }
        },

        drawPoint: function (x,y,style) {
            
           
                var oDiv = document.createElement('div');
                oDiv.style.position = 'absolute';
                oDiv.style.height = '5px';
                oDiv.style.width = '5px';
                oDiv.style.backgroundColor = 'black';
                oDiv.style.left = x + 'px';
                oDiv.style.top = y + 'px';
                document.body.appendChild(oDiv);
           
           
        },

        drawCircle: function (vertex, r, style) {
            var canvasss = document.getElementById('mycanvas');
            var context = canvasss.getContext('2d');
            //paint circle
            context.beginPath();
            context.lineWidth = style.penWidth;
            context.storkeStylw = style.penColor;
            context.arc(vertex.x, vertex.y, r, 0, Math.PI * 2, false);
            context.stroke();
            context.fill();
        },


    }
})();

painter.Geometry.prototype = {
    // reset pointer to constructor
    constructor: Geometry,
    initialization: function () {
        if (this.context === undefined) {
            var canvas = document.getElementById('canvas');
            Geometry.prototype.context = canvas.getContext('2d');
        }
    },

    getLines: function () {
        if (this.lines > 0) {
            return this.lines;
        }
        var i, lines = [];
        for (i = 0; i < lines.length; i++) {
            lines[i] = new painter.Line(this.points[i], this.points[i + 1] || this.points[0]);
        }
        this.lines = lines;
        return lines;
    },

    getArea: function () { },

    getPerimeter: function () {
        var i, perimeter = 0, lines = this.getLines();
        for (i = 0; i < lines.length; i++) {
            perimeter += lines[i].length;
        }
        return perimeter;
    }
};


(function () {
    var geome = new painter.Geometry();
    painter.PointGeometry.prototype = geome;
    painter.PolygonGeometry.prototype = geome;
    painter.PolygonGeometry.prototype = geome;
}
)();
