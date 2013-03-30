function OnButtonClick() {
    var people = [{ name: "Peter", age: 84 },
                { name: "Gosho", age: 44 },
                { name: "Thosho", age: 54 },
                { name: "Misho", age: 11 },
                { name: "Bai Mangal", age: 13 }];

    var template = "<strong> {0} </strong> <span> {1} </span>"
    var peopleList = generateList(people,template);
    document.getElementById("list-item").innerHtml = peopleList;
}
function generateList(array, template) {
    var result = "<ul>";
    
    

    for (var i = 0; i < array.length; i++) {

    
        var listItem = stringFormat(template, array[i].name, array[i].age);        
        result += "<li>" + listItem + "</li>";
    }
    result += "</ul>"
    return result;
}
function stringFormat(format) {
    var index = format.indexOf("{");
    var sb = String();
    var start = 0;

    while (index != -1) {

        var count = parseInt(format.substr(index + 1, 1));
        sb += format.substring(start, index - 1) + ' ';
        sb += (arguments[count + 1]);

        start = index + 3;
        index = format.indexOf("{", index + 1);
    }
    sb += format.substring(start, index - 1) ;
    return sb;
}