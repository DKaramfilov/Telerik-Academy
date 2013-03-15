function OnButtonClick() {
    var first = jsConsole.read("#first");
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
    var maxCount = 0;
    var count = 0;
    var num = 0;
    for (var i = 1; i < arr.length; i++) {
        count = 1;
        while (i < arr.length && arr[i] == arr[i - 1]) {
            count++;
            i++;

        }
        if (maxCount < count) {
            maxCount = count;
            num = arr[i - 1];
        }
    }
    jsConsole.writeLine("Element " + num + " is repeated " + maxCount + " times.");
    

}