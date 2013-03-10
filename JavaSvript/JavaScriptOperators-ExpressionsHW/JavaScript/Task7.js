function OnCalculate() {
    var N = jsConsole.readInteger("#tb-first");
    var isPrime = true;

    for (var i = 2; i <= Math.sqrt(N); i++) {
        if (N % i === 0) {
            isPrime = false;
            break;
        }
    }

    if (isPrime == true) {
        jsConsole.writeLine(N+ " is Prime" );
    }

    if (isPrime == false) jsConsole.writeLine(N + " is NOT Prime");

    
}