var a = 6.343;
var b = 8.234;
var c = 6.899;

if (a >= b) {
    if (a >= c) {
        if (b <= c) {
            //swap( b,  c);
            var temp = b;
            b = c;
            c = temp;
        }
    }
    else {
        //swap( a,  c);
        var temp = a;
        a = c;
        c = temp;
        //swap( b,  c); 
        var temp = b;
        b = c;
        c = temp;
    }
}
else if (b >= c) {
    //swap( a,  b);
    var temp = a;
    a = b;
    b = temp;

    if (b <= c) {
        //swap(b, c);
        var temp = b;
        b = c;
        c = temp;
    }
}
else {
    //swap(a, c);
    var temp = a;
    a = c;
    c = temp;
}

document.writeln("a=" + a);
document.writeln("b=" + b);
document.writeln("c=" + c);