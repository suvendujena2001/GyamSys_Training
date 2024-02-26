
const e1=document.getElementById('btn1');
function func1(){
    e1.nextElementSibling.classList.toggle('show');
    
}
const e3=document.querySelector('.nav');
const e2=document.getElementById('icon');


function funct2(){
        //console.log(e2.nextElementSibling);
        e2.nextElementSibling.classList.toggle('show');
}


let user=document.getElementById('username');
//let pass=document.getElementById('password');
const pass = document.querySelector('input[type="password"]');
let welcomenote=document.getElementById('welcome');

var login=false;
const btnLink = document.querySelector('.btn-link')
const url='index.json';
var users=""


function funclogin(){
    let a=user.value;
    let b=pass.value;
    // console.log(a,b);
    users = fetch(url)
    .then(res=> res.json())
    .then((data)=>{
       // console.log(a,b);
        //console.log(data);
        //console.log(data[0].username,data[0].password)
        if(a===data[0].username && b === data[0].password){
          //  console.log("loging in");
             //welcomenote.textContent=`WELCOME ${data[0].username}`;
           // btnLink.attributes.href=`indes.html`;
           login=true 
           console.log(login)
          window.location.href = 'indes.html';
           console.log(welcomenote);
            return data[0].username;
        }
        else{
            alert("wrong input");
        }
        //console.log(data[0].username===a) 

    });

    //console.log(users);

    if(login){
        welcomenote.innerText=`WELCOME ${users}`;
        welcomenote.appendChild(`WELCOME ${users}`)
        
    }

}




//console.log(users);
