var tasks = document.querySelector("#toDoList");

function onAddTask() {
    if (event.preventDefault) {
        event.preventDefault();
    }
    else {
        event.returnValue = false;
    }

    var currentTask = document.getElementById("taskInput").value;

    var li = document.createElement("li");


    if (currentTask !== "") {
        li.innerHTML = currentTask;
        tasks.appendChild(li);
    }
}

function onRemoveTask() {
    if (event.preventDefault) {
        event.preventDefault();
    }
    else {
        event.returnValue = false;
    }

    var ol = document.querySelector("#toDoList");
    var elementToRemove = document.querySelectorAll("ol li");
    ol.removeChild(elementToRemove[0]);
    
    
}

function onShowHide() {
    if (event.preventDefault) {
        event.preventDefault();
    }
    else {
        event.returnValue = false;
    }
    var ol = document.querySelector("#toDoList");
     
    if (ol.style.display !== "none") {
        ol.style.display = "none";
    }
    else {
        ol.style.display = "block";
    }
}
