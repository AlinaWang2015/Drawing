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
        context.lineTo(35, 20);
        context.closePath();
        context.stroke();
    }

}

function Canvas(height, width, background) {
  
        var mycanvas = document.createElement("canvas");
        mycanvas.id = "mycanvas";
        mycanvas.width = width;
        mycanvas.height = height;
        mycanvas.style.background = background;
        document.body.appendChild(mycanvas)
        
        

}