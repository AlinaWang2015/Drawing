function drawPoints(x, y) {
    var point = document.createElement('div');
    //point.style.position = 'absolute';
    point.style.height = '2px';
    point.style.width = '2px';
    point.style.backgroundColor = 'red';
    point.style.left = x + 'px';
    point.style.top = y + 'px';
    document.body.appendChild(point);
    return point;
    
}



