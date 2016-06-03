var PointGeometry = {
    vertexBox: [],
    partsBox: []
}

var PolylineGeometry = {
    vertexBox: [],
    partsBox: []
}

var PolygonGeometry = {
    vertex: [],
    parts: []
}

var CircleGeometry = {
    centter: vertex,
    radius: null
}

var Geoemtry = {
    Id:null,
    vertexBox: [],
    partsBox: []
}

var Style = {
    

}

var Canvas = {
    Higth:null,
    Width:null,
    Background:null
}

function Canvas(higth,width,background){
    this.Higth = higth;
    this.Width = width;
    this.Background = background;
}

function painter() {
    function DrawPoint(canvas,vertex) {
        var pointCanvas = document.createElement('canvas');
        var context = pointCanvas.getContext("2d");
        context.beginPath();
        context.lineWidth = 1;
        context.fillStyle = 'yellow';
        context.fillRect(50,50,200,100);
            
        }

    }
}