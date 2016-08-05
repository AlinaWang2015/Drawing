function Geometry() {
    this.points = [];
    this.polylines = [];
    this.initialization();
}

Geometry.prototype = {
    construction: Geometry,
    initialization: function () {
        if (this.context === undefined) {
            var canvas = document.getElementById("canvas");
            Geometry.prototype.context = canvas.getContext('2d');
        }
    },
    draw: function () {
        var i, ctx = this.context;
        ctx.strokeStyle = this.getColor(style);
        ctx.beginPath();
        ctx.moveTo(this.points[0].x, this.points[0].y);
        for (i = 1; i < this.points.length; i++) {
            ctx.lineTo(this.points[i].x, this.points[i].y);
        }
    },
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

function Point(x, y) {
    this.x = x;
    this.y = y;
}

function PolygonGeometry (points, parts) {
    this.points = points;
    this.parts = parts;
    this.getArea = function () {

    };
}

function PolylineGeometry(p1, p2) {
    this.p1 = p1;
    this.p2 = p2;
    this.length = Math.sqrt(
        Math.pow(p1.x - p2.x, 2) + Math.pow(p1.y - p2.y, 2)
        );
}

(function () {
    var geometry = new Geometry();
    Point.prototype = geometry;
    PolygonGeometry.prototype = geometry;
    PolylineGeometry.prototype = geometry;
})();