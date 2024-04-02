function displaycontent() {
    let request = new XMLHttpRequest();
    request.onreadystatechange = function() {
        if(this.readyState === 4 && this.status === 200) {
            document.getElementById("content").innerHTML = this.responseText;
        }
    };
    request.open("GET", "index.txt", true);
  request.send();
}