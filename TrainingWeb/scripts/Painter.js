Vertex = function(x,y) {
    this.x = x;
    this.y = y;
}

PointGeometry = function(vertexBox){
    this.vertexBox = vertexBox;
}

PolylineGeometry = function(vertexBox,partsBox){
    this.vertexBox = vertexBox;
    this.partsBox = partsBox;
}

PolygonGeometry = function(vertexBox,partsBox){
    this.vertexBox = vertexBox;
    this.partsBox = partsBox;
}

CircleGeometry = function(center,radius){
    this.centter = center;
    this.radius = radius;
}

var Geoemtry = {
    Id:null,
    vertexBox: [],
    partsBox: []
}

Style = function(penColor,penWidth){
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

function Painter(canvas) {


    this.drawPolylines = function (canvas) {
        //canvas
        var canvasss = document.getElementById('mycanvas');
        var context = canvasss.getContext('2d');

        //paint lines
        context.beginPath();
        context.lineWidth = 10;
        context.storkeStylw = "black";
        context.moveTo(20, 20);
        context.lineTo(100, 20);
        context.closePath();
        context.stroke();
    }

    this.drawPoints = function (x, y) {
        var point = document.createElement('div');
        point.style.height = '2px';
        point.style.width = '2px';
        point.style.backgroundColor = 'red';
        point.style.left = x + 'px';
        point.style.top = y + 'px';
        document.body.appendChild(point);
        return point;

    }
}