
function OnButtonClick() {
  
    
    var text = document.getElementById("text").textContent;
    var result = ReplaceWhitespace(text);

    //jsConsole.writeLine(result);
    //jsConsole.writeLine(text);
    document.write("With nbsp  <br/>");
    document.write();
    document.write(result);
    document.write("<br/><br/>");
    document.write("Without nbsp <br/>");
      
    document.write(text);
}
function ReplaceWhitespace(text) {
    var array = text.split(' ');
    var result = new String();
    for (var i = 0; i < array.length; i++) {
        result += array[i] + "&nbsp";
    }
    return result;
}