function OnButtonClick() {
    var pos = jsConsole.readInteger("#first");
    var nums = jsConsole.read("#array");
    var arr = nums.split(' ');

    var result = Count(pos, arr);

    jsConsole.writeLine("The element at postion '" + pos + "' is bigger: " + result)
}
function Count(pos, array) {
    if (pos < 1 || pos >= array.length - 1) {
        return "Wrong position";
    }
    else {
        if (array[pos - 1] < array[pos] && array[pos + 1] < array[pos]) {
            return true;
        }
        else {
            return false;
        }
    }
}