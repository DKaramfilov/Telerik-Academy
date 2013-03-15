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
    for (var i = 0; i < arr.length; i++) {
        jsConsole.write(arr[i]+" ");
    }

}