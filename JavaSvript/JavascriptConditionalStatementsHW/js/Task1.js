var a = 63;
var b = 53;
document.writeln("before exchange \n");
document.writeln("a=" + a);
document.writeln("b=" + b);

if (a > b) {
    var temp = a;
    a = b;
    b = temp;
}
document.writeln("after exchange \n");
document.writeln("a=" + a);
document.writeln("b=" + b);