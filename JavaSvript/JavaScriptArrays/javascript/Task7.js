function OnButtonClick() {
    var first = jsConsole.read("#first");
    var second = jsConsole.readInteger("#second");
    var arr = first.split(' ');
    var min = 0;


    for (var i = 0; i < arr.length - 1; i++) {
        min = i;
        for (var q = i + 1; q < arr.length; q++) {
            if (arr[min] > arr[q]) min = q;
        }
        if (min != i) {
            var k = arr[i];
            arr[i] = arr[min];
            arr[min] = k;
        }

    }
    var result = BinarySearch(second, arr);

    if (result >= 0) {
        jsConsole.writeLine("Element " + second + " found at index " + result);
    }
    else {
        jsConsole.writeLine('Not found.');
    }

}
function BinarySearch(key, a) {
    var lo = 0;
    var hi = a.length - 1;
    while (lo <= hi) {
        var mid = parseInt(lo + (hi - lo) / 2);
        if (key < a[mid]) hi = mid - 1;
        else if (key > a[mid]) lo = mid + 1;
        else return mid;
    }
    return -1;

}