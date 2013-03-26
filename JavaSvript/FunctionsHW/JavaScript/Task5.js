
function OnButtonClick() {
    var first = jsConsole.readInteger("#first");
    var nums = jsConsole.read("#array");
    var arr = nums.split(' ');

    var result = Count(first,arr);

    jsConsole.writeLine("The count of number '" + first + "' is: " + result)
}
function Count(number, array) {
    var count = 0;
    for (var i = 0; i < array.length; i++) {
        if (number == array[i])
            count++;
    }
    return count;
}