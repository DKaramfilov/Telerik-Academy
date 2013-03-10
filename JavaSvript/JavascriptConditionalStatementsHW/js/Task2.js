var a = -5;
var b = 10;
var c = -5;

var countMinus = 0;
if (a < 0) countMinus++;
if (b < 0) countMinus++;
if (c < 0) countMinus++;

if (countMinus % 2 === 0) {
    document.writeln("The product sing is +");
}
else {
    document.writeln("The product sing is -");
}
