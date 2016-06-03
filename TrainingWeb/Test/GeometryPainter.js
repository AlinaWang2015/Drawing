var Drawing = {

    Vertex: null,
    Point: null,
    Line: null,
    Polygon: null,
    Circle: null,
    Style: null,
    Painter: null,
    PainterCanvas:null
};

(function () {
    var id = 0;

    function inheritFromConstructor(parent, child) {
        child.prototype = new parent();
        child.prototype.constructor = child;
    };


    Drawing.Vertex = function (x, y) {
        this.x = x;
        this.y = y;
    };


    function Shape() {
        this.vertexes = null;
    }

    Shape.prototype.getPerimeter = function () {
        return "false Shape.prototype.getPerimeter";
    };

    Shape.prototype.getArea = function () {
        return "false Shape.prototype.GetArea";
    };

    Shape.prototype.resize = function (vertexIndex, multiple) {
        if (vertexIndex > this.vertexes.length - 1) {
            return "false";
        }
        var standardVertex = this.vertexes[vertexIndex];
        for (var i = 0; i < this.vertexes.length; i++) {
            this.vertexes[i].x = standardVertex.x - (standardVertex.x - this.vertexes[i].x) * multiple;
            this.vertexes[i].y = standardVertex.y - (standardVertex.y - this.vertexes[i].y) * multiple;
        }
    };

    Shape.prototype.move = function (veticalOffset, horizontalOffset) {
        for (var i = 0; i < this.vertexes.length; i++) {
            this.vertexes[i].x += veticalOffset;
            this.vertexes[i].y += horizontalOffset;
        }
    };


    Drawing.Point = function (vertex) {
        vertex = vertex || new Vertex(0, 0);
        this.vertexes = [vertex];
        this.id = id++;
    };

    inheritFromConstructor(Shape, Drawing.Point);

    Drawing.Point.prototype.getPerimeter = function () {
        return 0;
    };

    Drawing.Point.prototype.getArea = function () {
        return 0;
    };

    Drawing.Point.prototype.resize = function (multiple) { };


    Drawing.Line = function (vertex1, vertex2) {
        this.vertexes = [vertex1, vertex2];
        this.id = id++;
    };

    inheritFromConstructor(Shape, Drawing.Line);

    Drawing.Line.prototype.getPerimeter = function () {
        return Math.sqrt(Math.pow(this.vertexes[1].x - this.vertexes[0].x, 2) + Math.pow(this.vertexes[1].y - this.vertexes[0].y, 2));
    }

    Drawing.Line.prototype.getArea = function () {
        return 0;
    };


    Drawing.Polygon = function (vertexes) {
        this.vertexes = vertexes;
        this.id = id++;
    };

    inheritFromConstructor(Shape, Drawing.Polygon);

    Drawing.Polygon.prototype.getPerimeter = function () {
        var perimeter = 0;
        for (var i = 0; i < this.vertexes.length - 1; i++) {
            perimeter += Math.sqrt(Math.pow(this.vertexes[i + 1].x - this.vertexes[i].x, 2) + Math.pow(this.vertexes[i + 1].y - this.vertexes[i].y, 2));
        }
        perimeter += Math.sqrt(Math.pow(this.vertexes[0].x - this.vertexes[this.vertexes.length - 1].x, 2) + Math.pow(this.vertexes[0].y - this.vertexes[this.vertexes.length - 1].y, 2));
        return perimeter;
    }

    Drawing.Polygon.prototype.getArea = function () {
        return "true Polygon.prototype.GetArea";
    };


    Drawing.Circle = function (center, radius) {
        this.vertexes = [center];
        this.radius = radius;
        this.id = id++;
    };

    inheritFromConstructor(Shape, Drawing.Circle);

    Drawing.Circle.prototype.getPerimeter = function () {
        return 2 * Math.PI * this.radius;
    };

    Drawing.Circle.prototype.getArea = function () {
        return Math.PI * Math.pow(this.radius, 2);
    };

    Drawing.Circle.prototype.resize = function (multiple) {
        this.radius *= multiple;
    };


    Drawing.Style = function (borderColor, fillColor, borderWidth) {
        this.borderColor = borderColor;
        this.fillColor = fillColor || "rgba(0,0,0,0)";
        this.borderWidth = borderWidth || 1;
    };


    Drawing.PainterCanvas = function (width, height, backgroundColor) {
        this.width = width;
        this.height = height;
        this.backgroundColor = backgroundColor;
    }
    Drawing.PainterCanvas.prototype.clear = function () {
        c.getContext('2d').clearRect(0, 0, this.width, this.height);
    }

    var c = document.createElement('canvas');
    Drawing.Painter = function (painterCanvas, style) {
        c.width = painterCanvas.width;
        c.height = painterCanvas.height;
        c.style.background = painterCanvas.backgroundColor;
        document.body.appendChild(c);
        this.canvas = c;
        this.cxt = c.getContext('2d');
        this.style = style || new Style("Black");
        this.shapes = [];
    };

    Drawing.Painter.prototype.draw = function (shape) {
        this.setCxtStyle();
        switch (shape.constructor) {
            case Drawing.Point:
                this.drawPoint(shape.vertexes[0]);
                break;
            case Drawing.Line:
            case Drawing.Polygon:
                this.drawLines(shape);
                break;
            case Drawing.Circle:
                this.drawCircle(shape);
                break;
            default:
                return "wrong shape";
                break;
        }
    };

    Drawing.Painter.prototype.drawPoint = function (vertex) {
        return "drawing Point";
    };

    Drawing.Painter.prototype.drawLines = function (lines) {
        this.cxt.beginPath();
        this.cxt.moveTo(lines.vertexes[0].x, lines.vertexes[0].y);
        for (var i = 1; i < lines.vertexes.length; i++) {
            this.cxt.lineTo(lines.vertexes[i].x, lines.vertexes[i].y);
        }
        this.cxt.lineTo(lines.vertexes[0].x, lines.vertexes[0].y);
        this.cxt.closePath();
        this.cxt.stroke();
        this.cxt.fill();
    };

    Drawing.Painter.prototype.drawCircle = function (circle) {
        this.cxt.beginPath();
        this.cxt.arc(circle.vertexes[0].x, circle.vertexes[0].y, circle.radius, 0, 2 * Math.PI);
        this.cxt.closePath();
        this.cxt.stroke();
        this.cxt.fill();
    };

    Drawing.Painter.prototype.setCanvas = function (canvas) {
        this.canvas = canvas;
        this.cxt = canvas.getContext('2d');
    };

    Drawing.Painter.prototype.setCxtStyle = function () {
        this.cxt.strokeStyle = this.style.borderColor;
        this.cxt.lineWidth = this.style.borderWidth;
        this.cxt.fillStyle = this.style.fillColor;
    };
})();
