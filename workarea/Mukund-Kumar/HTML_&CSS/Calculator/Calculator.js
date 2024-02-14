const input = document.getElementById('inputtext');
const buttons = document.querySelectorAll('button');
function calculate(expression) {
    console.log(expression);
    return  eval(expression);
}
// need to learn try catch concept
    // try {
    //     return new Function('return ' + expression)();
    // } catch (error) {
    //     return 'Malformed Operation';
    // }   

function operation(buttonValue) {
    if (buttonValue === 'C') {
        input.value = '';
    } else if (buttonValue === 'DEL') {
        input.value = input.value.slice(0, -1);
    } else if (buttonValue === '=') {
        input.value = calculate(input.value);
    } else {
        input.value += buttonValue;
    }
}
buttons.forEach(button => {
    let buttonValue = button.innerText;
    button.addEventListener('click', function () {
        operation(buttonValue); // here we created a new variable because in JS arrays are passed as call by reference 
        rather than call by value.
    });
});
