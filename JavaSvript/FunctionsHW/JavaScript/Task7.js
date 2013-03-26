function OnButtonClick() {
    var nums = jsConsole.read("#array");
    var arr = nums.split(' ');
    var index =-1;

    for (var i = 1; i < arr.length-1; i++) {
        if (Count(i, arr) == true) {
            index = i;
            break;
        }
    }

    jsConsole.writeLine("index ="+index)
}
function Count(pos, array) {
    if (array[pos - 1] < array[pos] && array[pos + 1] < array[pos]) {
        return true;
    }
    else {
        return false;
    }
    
}