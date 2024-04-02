let xhr=new XMLHttpRequest();
let url="https://jsonplaceholder.typicode.com/users";
xhr.onreadystatechange=function(){
  if(this.readyState==4 && this.status==200){
   var data=xhr.response;
   const newName=data.map((num)=>{return num.name});   //using map to display employee name
   for(i=0;i<newName.length;i++){
    console.log(newName[i]);
   }
   console.log("");
   console.log("Employee above id number 4 are:");
   const newId=data.filter((num)=>{return num.id>4});   //using filter to display employee with id>4
   newId.forEach((num)=>{console.log(num.name)});

   var sal=10000;
   data.forEach((num)=>{num.salary=sal;           //adding salary property to each object
                        console.log(num.salary);
                        sal+=10000;})
   console.log(data[1].salary);
   }
}
xhr.open("GET",url);
xhr.responseType="json";
xhr.send();