function OnButtonClick() {
    var keyword = jsConsole.read("#first");
   
    var text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days ";

    var quote = text.toLowerCase();
    keyword = keyword.toLowerCase();
    var count = 0;
    
    
    var index = quote.indexOf(keyword);
    while (index > -1)
    {

        index = quote.indexOf(keyword, index + 1);
        count++;

    }
    
    jsConsole.writeLine("String '" + keyword + "' found " + count + " times." );
}