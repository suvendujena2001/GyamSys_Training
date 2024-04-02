//Hoisting
//Function
var a=3;
function set(){
    let b=3;
    const c=5;
    console.log("B="+b);
    console.log("C="+c);
}
set();
console.log("A="+a);

//If-else condition

if(a==5)
{
    console.log("Five");
}
else{
    console.log("A not equals to five");
}

//for loops
for(i=0;i<5;i++)
{
    console.log(i);
}

//DOM APIs

document.getElementById("h1").innerHTML = "Welcome to JS!";
let html = document.getElementById("h1");
console.log(html);

// document.getElementsByClassName('createelement')[0].innerText='<p>Hello Everyone</p>';
document.getElementsByClassName('createelement')[0].innerHTML+='<p>Hello Everyone</p>';

btn=document.querySelector(".btn");
btn.addEventListener('click', function() {
    let text = document.getElementById('random').textContent;
    let count = text.split(' ').length;
    let cnt = document.getElementById('ccc');
    cnt.innerText = 'Number of words: ' + count;
});


btn2=document.querySelector('.btn2');
btn2.addEventListener('click',reverse);
function reverse()
{
    const org=document.querySelector('#random').textContent;
    const rev=org.split(' ').reverse().join(' ');
    const revv=document.getElementById('rever');
    revv.innerText=rev;
}



