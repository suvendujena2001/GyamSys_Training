
const e1=document.getElementById('btn1');
function func1(){
    e1.nextElementSibling.classList.toggle('show');
    
}
const e3=document.getElementsByClassName('nav');
const e2=document.getElementById('icon');


function funct2(){
        console.log(e2.nextElementSibling);
        e2.nextElementSibling.classList.toggle('show');
}


