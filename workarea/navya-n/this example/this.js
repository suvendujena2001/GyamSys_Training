const sample={
    name:'navya',
    sayname:function() {
        console.log(this.name);
    }
}
sample.sayname();
//output:navya

console.log(this);
//output: [object Window]

function obj() {
    console.log(this);
}
obj();
//output: [object Window]

function obj1(){
    "use strict"
    console.log(this);
}
obj1();
//output: undefined
