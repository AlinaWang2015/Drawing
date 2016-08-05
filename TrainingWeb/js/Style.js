var Style = function  (color, penWieth, lineStyle) {
    //var arguments;
    switch (arguments.length) {
        case 0:
            this.color = "#fffffb";
            this.penWidth = 10;
            this.lineStyle = 0;
            this.isFill = false;
            break;
        case 1:
            this.color = arguments[0];
            this.penWidth = 5;
            this.lineStyle = 0;
            this.isFill = false;
            break;
        case 2:
            this.color = arguments[0];
            this.penWidth = arguments[1];
            this.lineStyle = 0;
            this.isFill = false;
            break;
        case 3:
            this.brushColor = arguments[0];
            this.lineStyle = arguments[1];
            this.isFill = arguments[2];
            break;
        default:
            alert("Input style's format is error, please re-enter！");
            break;
    }

}