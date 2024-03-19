const rev1 = document.getElementById('btn1');
const rev2 = document.getElementById('btn2');
rev1.addEventListener('mousein', function() {
    const historyText = document.getElementById('history').textContent;
    const reversedText = historyText.split(' ').reverse().join(' ');
    document.getElementById('revhistory').textContent = reversedText;
    const count = document.querySelector('.count');
    count.innerText = 'Number of Words: '+historyText.split('').length;
});
rev2.addEventListener('click',function(){
    const historyText = document.getElementById('history').textContent;
    const uppercaseText = historyText.toUpperCase();
    document.getElementById('revhistory').textContent = uppercaseText;
    const count = document.querySelector('.count');
    count.innerText = 'Number of Words: '+historyText.split('').length;

});
