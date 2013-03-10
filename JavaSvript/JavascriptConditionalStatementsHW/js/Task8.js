function OnCalculate() {

    var N = jsConsole.readInteger("#num");
    
    oneToNine = N % 10;
    tens = ((N - oneToNine) / 10) % 10;
    hundreds = ((N-oneToNine)- (tens*10))/100;


    var hundred = "";
    var teen = "";
    var ten = "";
    var digits = "";

    switch (hundreds) {
        case 1:
            {
                hundred = "One hundred";
                break;
            }
        case 2:
            {
                hundred = "Two hundred";
                break;
            }
        case 3:
            {
                hundred = "Tree hundred";
                break;
            }
        case 4:
            {
                hundred = "Four hundred";
                break;
            }
        case 5:
            {
                hundred = "Five hundred";
                break;
            }
        case 6:
            {
                hundred = "Six hundred";
                break;
            }
        case 7:
            {
                hundred = "Seven hundred";
                break;
            }
        case 8:
            {
                hundred = "Eight hundred";
                break;
            }
        case 9:
            {
                hundred = "Nine hundred";
                break;
            }
        case 0:
            {

                break;
            }
        default:

            break;
    }
    switch (tens) {
        case 1:
            {
                switch (oneToNine) {
                    case 1:
                        {
                            teen = "eleven";
                            break;
                        }
                    case 2:
                        {
                            teen = "twelve";
                            break;
                        }
                    case 3:
                        {
                            teen = "thirteen";
                            break;
                        }
                    case 4:
                        {
                            teen = "fourteen";
                            break;
                        }
                    case 5:
                        {
                            teen = "fifteen";
                            break;
                        }
                    case 6:
                        {
                            teen = "sixteen";
                            break;
                        }
                    case 7:
                        {
                            teen = "seventeen";
                            break;
                        }
                    case 8:
                        {
                            teen = "eighteen";
                            break;
                        }
                    case 9:
                        {
                            teen = "nineteen";
                            break;
                        }
                    default:
                        break;
                }
                break;

            }
        case 2:
            {
                ten = "twenty";
                break;
            }
        case 3:
            {
                ten = "thirty";
                break;
            }
        case 4:
            {
                ten = "fourty";
                break;
            }
        case 5:
            {
                ten = "fifty";
                break;
            }
        case 6:
            {
                ten = "sixty";
                break;
            }
        case 7:
            {
                ten = "seventy";
                break;

            }
        case 8:
            {
                ten = "eighty";
                break;
            }
        case 9:
            {
                ten = "ninety";
                break;
            }


        default:
            break;
    }
    switch (oneToNine) {
        case 1:
            {
                digits = "one";
                break;
            }
        case 2:
            {
                digits = "two";
                break;
            }
        case 3:
            {
                digits = "three";
                break;
            }
        case 4:
            {
                digits = "four";
                break;
            }
        case 5:
            {
                digits = "five";
                break;
            }
        case 6:
            {
                digits = "six";
                break;
            }
        case 7:
            {
                digits = "seven";
                break;
            }
        case 8:
            {
                digits = "eight";
                break;
            }
        case 9:
            {
                digits = "nine";
                break;
            }
    }
     

    if (tens === 1) {
        if (hundreds != 0) {
            jsConsole.writeLine(hundred + ' ' + "and" + ' ' + teen);
        }
        else {
            jsConsole.writeLine(teen);
        }
    }
    else if (tens != 0 || oneToNine != 0) {
        jsConsole.writeLine(hundred + " " + ten + " " + digits);
    }
    else if (tens === 0 && hundreds === 0 && oneToNine === 0) {
        jsConsole.writeLine("zero");
    }
    else {
        jsConsole.writeLine(hundred);
    }

}