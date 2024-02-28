console.log("test")

let user=document.getElementById('username');
//let pass=document.getElementById('password');
const pass = document.querySelector('input[type="password"]');
const url='index.json';
var users="";
function funclogin(){
    let a=user.value;
    let b=pass.value;
    // console.log(a,b);
   fetch(url)
    .then(res=> res.json())
    
    .then((data)=>{
        console.log(data);
       // console.log(a,b);
        //console.log(data);
        //console.log(data[0].username,data[0].password)
        if(a===data[0].username && b === data[0].password){
            console.log("loging in");
            users=data[0].username;
            window.location.href='login.html';
            
           
        }
        else{
            alert("wrong input");
        }
        
        console.log(data[0].username===a) 

    })

}
console.log(users)

