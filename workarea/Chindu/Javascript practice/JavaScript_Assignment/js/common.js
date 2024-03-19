const generateButton = document.getElementById('generate-word-button');
const randomWordParagraph = document.getElementById('random-word');

generateButton.addEventListener('click', async () => {
  try {
    const tableBody = document.querySelector('#myTable tbody');
    tableBody.innerHTML = '';

    const response1 = await fetch('https://random-word-api.herokuapp.com/word');
    if (!response1.ok) {
      throw new Error('Error in API request');
    }
    const data1 = await response1.json();
    const randomWord = data1[0];
    randomWordParagraph.textContent = randomWord;

    const response2 = await fetch(`https://api.dictionaryapi.dev/api/v2/entries/en/${randomWord}`);
    if (!response2.ok) {
      throw new Error('Error in API request');
    }
    const data2 = await response2.json();

    const tr = document.createElement('tr'); 
    const td1 = document.createElement('td');
    td1.textContent = data2[0].meanings[0].partOfSpeech;
    const td2 = document.createElement('td');
    td2.textContent = data2[0].meanings[0].definitions[0].definition;
    tr.appendChild(td1);
    tr.appendChild(td2);
    tableBody.appendChild(tr);
  } catch (error) {
    console.error(error);
  }
});