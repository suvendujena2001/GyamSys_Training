
function modifythecontent(){
    var xhr=new XMLHttpRequest();
    
    xhr.onreadystatechange=function(response){
        if(this.readyState==4 && this.status==200){
            document.getElementById('demo').innerHTML=this.response;
        }
    };
    xhr.open('GET',"index.txt",true);
    xhr.send();
}