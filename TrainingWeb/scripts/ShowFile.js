function showFile() {
    var shapefile = {};
    shapefile.FileLength = 
    document.writeln("输出文件头：");
    document.writeln("文件长度：{0}", shapefile.FileLength);
    document.writeln("版本：{0}", shapefile.Version);
    document.writeln("shape类型：{0}", shapefile.ShapeType);
    document.writeln("头文件的边界盒(Xmin,Ymin,Xmax,Ymax)：({0},{1},{2},{3})", shapefile.Box[0], shapefile.Box[1], shapefile.Box[2], shapefile.Box[3]);
   
}