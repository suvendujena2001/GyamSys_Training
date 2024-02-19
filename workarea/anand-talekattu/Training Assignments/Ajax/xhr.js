let xhr=new XMLHttpRequest();
let url="https://jsonplaceholder.typicode.com/users";
xhr.onreadystatechange=function(){
  if(this.readyState==4 && this.status==200){
   
console.log(xhr.response);
  }
}
xhr.open("GET",url);
xhr.responseType="json";
xhr.send();