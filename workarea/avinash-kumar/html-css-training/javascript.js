
const e1 = document.getElementById('btn1');
function func1() {
    e1.nextElementSibling.classList.toggle('show');

}
const e3 = document.querySelector('.nav');
const e2 = document.getElementById('icon');


function funct2() {
    //console.log(e2.nextElementSibling);
    e2.nextElementSibling.classList.toggle('show');
}


let user = document.getElementById('username');
//let pass=document.getElementById('password');
const pass = document.querySelector('input[type="password"]');
let welcomenote = document.getElementById('welcome');

var login = false;
const btnLink = document.querySelector('.btn-link')
const url = 'index.json';
var users = ""


function funclogin() {
    var a = user.value;
    var b = pass.value;
    fetch(url)
        .then(res => res.json())
        .then((data) => {
            console.log(data[0].username);
            if (a === data[0].username && b === data[0].password) {
                login = true
                console.log(login)
                var elem=document.createElement('h2');
                elem.innerText="login confirm";
                console.log(welcomenote);
                console.log(data[0].username);
            }
        })
        .catch (error => console.log(error));
}

// if (login) {
//     welcomenote.innerText = `WELCOME ${users}`;
//     welcomenote.appendChild(`WELCOME ${users}`)

// }



//console.log(users);
