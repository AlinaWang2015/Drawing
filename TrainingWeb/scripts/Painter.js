function Vertex(x,y) {
    this.x = x;
    this.y = y;
}

function PointGeometry(vertexBox){
    this.vertexBox = vertexBox;
}

function PolylineGeometry(v1, v2) {

}

function PolylineGeometry(vertexBox,partsBox){
    this.vertexBox = vertexBox;
    this.partsBox = partsBox;
}

function PolygonGeometry(vertexBox,partsBox){
    this.vertexBox = vertexBox;
    this.partsBox = partsBox;
}

function CircleGeometry(center,radius){
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

function Painter() {

    this.drawPolylines = function (polyline,style) {
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

    this.drawPoints = function (points,style) {
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

    this.drawCircle = function (vertex, r,style) {

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