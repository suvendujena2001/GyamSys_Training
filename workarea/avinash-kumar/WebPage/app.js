const sign_in_btn = document.querySelector("#sign-in-btn");
const sign_up_btn = document.querySelector("#sign-up-btn");
const container = document.querySelector(".container");

const url='index.json';

function funclogin(){
    fetch(url).then(res=> res.json())
    .then((data)=>{
        //let data1=new data;
       // if (data1[0]==)
       console.log(data[0]);
    }
    );

}

sign_up_btn.addEventListener('click', () =>{
    container.classList.add("sign-up-mode");
});

sign_in_btn.addEventListener('click', () =>{
    container.classList.remove("sign-up-mode");
});






