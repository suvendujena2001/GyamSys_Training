let xhr=new XMLHttpRequest();
let url="https://jsonplaceholder.typicode.com/users";
xhr.onreadystatechange=function(){
  if(this.readyState==4 && this.status==200){
   var data=xhr.response;
   let con=document.getElementById("a1");
   for(var i=0;i<data.length;i++){
    con.innerHTML += "<div>"+data[i].name+"</div>";
   }
  }
}
xhr.open("GET",url);
xhr.responseType="json";
xhr.send();