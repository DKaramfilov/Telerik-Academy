var a = 3;
var b = 5;
var c = 8;
var max;
var min;

if (a >= b) {
    if (a >= c) {
        max = a;
        if (b >= c)
            min = c;
        else
            min = b;
    }
    else {
        max = c;
        min = b;
    }
}
else if (b >= c) {
    max = b;
    if (a >= c)
        min = c;
    else
        min = a;
}
else {
    max = c;
    if (a >= b)
        min = b;
    else
        min = a;
}
document.writeln("max =" + max);
document.writeln("min =" + min);