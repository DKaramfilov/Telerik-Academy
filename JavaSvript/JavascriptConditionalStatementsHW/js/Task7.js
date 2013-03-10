function OnCalculate() {
    var nums = [];
    nums[0] = jsConsole.readInteger("#num1");
    nums[1] = jsConsole.readInteger("#num2");
    nums[2] = jsConsole.readInteger("#num3");
    nums[3] = jsConsole.readInteger("#num4");
    nums[4] = jsConsole.readInteger("#num5");

    var max = nums[0];

    for (var i = 1; i < nums.length; i++) {
        if (max < nums[i])
            max = nums[i];
    }
    jsConsole.writeLine("max =" + max);
}