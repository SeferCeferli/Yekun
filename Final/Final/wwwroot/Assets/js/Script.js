function likebtn() {
    var x = document.getElementById("fb-like");
    var y = document.getElementById("facebook-plus")
    var z = parseInt(y.innerHTML);
    if (x.className === "fa fa-plus") {
        x.className = "fas fa-minus";
        x.style.float = "right";
        x.style.paddingTop = "13px";
        y.innerHTML = (z + 1).toString();
    } else {
        x.className = "fa fa-plus";
        y.innerHTML = (z - 1).toString();
    }
}
function likebtn1() {
    var x = document.getElementById("tw-like");
    var y = document.getElementById("twitter-plus")
    var z = parseInt(y.innerHTML);
    if (x.className === "fa fa-plus") {
        x.className = "fas fa-minus";
        x.style.float = "right";
        x.style.paddingTop = "13px";
        y.innerHTML = (z + 1).toString();
    } else {
        x.className = "fa fa-plus";
        y.innerHTML = (z - 1).toString();
    }
}
function likebtn2() {
    var x = document.getElementById("yu-like");
    var y = document.getElementById("youtube-plus")
    var z = parseInt(y.innerHTML);
    if (x.className === "fa fa-plus") {
        x.className = "fas fa-minus";
        x.style.float = "right";
        x.style.paddingTop = "13px";
        y.innerHTML = (z + 1).toString();
    } else {
        x.className = "fa fa-plus";
        y.innerHTML = (z - 1).toString();
    }
}
function likebtn3() {
    var x = document.getElementById("in-like");
    var y = document.getElementById("instagram-plus")
    var z = parseInt(y.innerHTML);
    if (x.className === "fa fa-plus") {
        x.className = "fas fa-minus";
        x.style.float = "right";
        x.style.paddingTop = "13px";
        y.innerHTML = (z + 1).toString();
    } else {
        x.className = "fa fa-plus";
        y.innerHTML = (z - 1).toString();
    }
}
function likebtn4() {
    var x = document.getElementById("go-like");
    var y = document.getElementById("google-plus")
    var z = parseInt(y.innerHTML);
    if (x.className === "fa fa-plus") {
        x.className = "fas fa-minus";
        x.style.float = "right";
        x.style.paddingTop = "13px";
        y.innerHTML = (z + 1).toString();
    } else {
        x.className = "fa fa-plus";
        y.innerHTML = (z - 1).toString();
    }
}
var url_segment = window.location.href.split('/');
var script_name = url_segment[url_segment.length - 1];
if (localStorage[script_name]) {
    localStorage[script_name] = parseInt(localStorage[script_name]) + 1;
}
else {
    localStorage[script_name] = 1;
}

document.write("You've had " + localStorage[script_name] + " hits.");