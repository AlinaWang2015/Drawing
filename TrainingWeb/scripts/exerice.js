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


