function drawPoints(x, y) {
    var point = document.createElement('div');
    point.style.position = 'absolute';
    point.style.height = '2px';
    point.style.width = '2px';
    point.style.backgroundColor = 'red';
    point.style.left = x + 'px';
    point.style.top = y + 'px';

    document.body.appendChild(point);

    return point;
}

function Canvas(height, width, background) {

    var mycanvas = document.createElement("canvas");
    mycanvas.id = "mycanvas";
    mycanvas.width = width;
    mycanvas.height = height;
    mycanvas.style.background = background;
    document.body.appendChild(mycanvas)

}


this.drawCircle = function (x,y, r) {
  
        var canvasss = document.getElementById('mycanvas');
        var context = canvasss.getContext('2d');

        //paint circle
        context.beginPath();
        context.lineWidth = 10;
        context.storkeStylw = "black";
        context.arc(x, y, r, 0, Math.PI*2,false);
        
        context.fill();

}



function drawCircle1() {//画个圆  
    var r = 200;
    var x1 = 300;
    var y1 = 300;
    var frag = document.createDocumentFragment();
    for (var degree = 0; degree < 360; degree += 1) {
        var y2 = r * Math.sin(degree * Math.PI / 180);
        var x2 = r * Math.cos(degree * Math.PI / 180);
        frag.appendChild(drawPoints(x1 + x2, y1 + y2));
        
    }
    document.body.appendChild(frag);
}



var a = (function () {
    function someSetup() {
        var setup = 'done';
    }

    function actualWork() {
        alert('worky-worky!!!!');
    }

    someSetup();
    return actualWork;
}())

















function PointGeometry(vertexBox) {
    this.vertexBox = vertexBox;
}

var PolylineGeometry = function (vertexBox, partsBox) {
    this.vertexBox = vertexBox;
    this.partsBox = partsBox;
}

function PolygonGeometry(vertexBox, partsBox) {
    this.vertexBox = vertexBox;
    this.partsBox = partsBox;
}

function CircleGeometry(center, radius) {
    this.centter = center;
    this.radius = radius;
}


Style = function (penColor, penWidth) {
    this.penColor = penColor;
    this.penWidth = penWidth;

}

function Canvas(height, width, background) {

    var mycanvas = document.createElement("canvas");
    mycanvas.id = "mycanvas";
    mycanvas.width = width;
    mycanvas.height = height;
    mycanvas.style.background = background;
    document.body.appendChild(mycanvas)

}

function Painter() {

    this.drawPolylines = function (polyline, style) {
        //canvas
        var canvasss = document.getElementById('mycanvas');
        var context = canvasss.getContext('2d');

        //paint lines
        context.beginPath();
        context.lineWidth = style.penWidth;
        context.storkeStylw = style.penColor;

        context.moveTo(polyline.vertexBox[0].x, polyline.vertexBox[0].y);
        context.lineTo(polyline.vertexBox[1].x, polyline.vertexBox[1].y);
        context.closePath();
        context.stroke();

    }

    this.drawPolygon = function (polygon, style) {
        //canvas
        var canvasss = document.getElementById('mycanvas');
        var context = canvasss.getContext('2d');
        //paint lines
        context.beginPath();
        context.lineWidth = style.penWidth;
        context.storkeStylw = style.penColor;
        context.moveTo(polyline.vertexBox[0].x, polyline.vertexBox[0].y);
        for (var i = 1; i < polygon.vertexBox.length; i++) {
            context.lineTo(polyline.vertexBox[i].x, polyline.vertexBox[i].y);
        }

        context.closePath();
        context.stroke();

    }

    this.drawPoints = function (points, style) {
        var canvasss = document.getElementById('mycanvas');
        var context = canvasss.getContext('2d');
        //paint points
        context.beginPath();
        context.lineWidth = style.penWidth;
        context.storkeStylw = style.penColor;
        for (var i = 0; i < points.length; i++) {
            context.arc(points[i].x, points[i].y, 2, 0, Math.PI * 2, false);
        }


        context.fill();
    }

    this.drawCircle = function (vertex, r, style) {

        var canvasss = document.getElementById('mycanvas');
        var context = canvasss.getContext('2d');
        //paint circle
        context.beginPath();
        context.lineWidth = style.penWidth;
        context.storkeStylw = style.penColor;
        context.arc(vertex.x, vertex.y, r, 0, Math.PI * 2, false);
        context.stroke();
        context.fill();

    }
}

