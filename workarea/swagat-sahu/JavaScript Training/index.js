        var firstname = 'hello';//In case of var we can declare the varible with the same name and reassign values as well.
        let degree = 'MBA';//In case of let we can reassign values but we cannot declare new ones. 
        const loc = 'Bhubaneswar';//Block Scope, We can neither declare nor reassign values to a variable.
    document.getElementById('null').innerHTML="<h1>Javascript</h1>";
    // document.getElementById('null').innerText='Javascript';
    document.getElementById('fruit').innerHTML='<ul><li>Javascript</li><li>HTML</li></ul>';
    // document.querySelectorAll("div.vegetable , div.swagat").style.backgroundColor = "red";
    

    

    const m = document.getElementsByClassName("comma");
     m[0].innerHTML="Hello Everyone!";
     const collection = document.getElementsByClassName("example");
    collection[0].innerHTML = "Hello World!";
    const Nexy = document.getElementsByClassName("exampleee");
    Nexy[0].innerHTML = "Hello all!";

    console.log('Hello World');
    let a = 3;
    var b = 2;
    const c = 4;
    function js1(){
        var x = 5
        if(a==x){
            console.log('True');
        }
        else{
            console.log('False');
        }
    }
    js1()
    function js3(){
        const a = 5
        if(a!=c){
            console.log('False');
        }
    }
    js3()
    // function js2(){
    //     const y = 2;
    //         if(y==b){
    //             console.log('True')
    //             y = 10;// Throws error as const cannot be reassigned.
    //             console.log('a',+a);
    //         }

    //     }
    // js2()
    
    // function js4(){
    //     const z = 7;
    //     if(z>x){
    //         console.log('Greater')
    //     }


    // }
    // js4()// Throws error as let can't be accessed outside the function.
    
    