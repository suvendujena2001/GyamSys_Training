const generateButton = document.getElementById('generate-word-button');
const randomWordParagraph = document.getElementById('random-word');

generateButton.addEventListener('click', () => {
  fetch('https://random-word-api.herokuapp.com/word')
    .then(response => {
      if (response.ok) {
        return response.json();
      }
      throw new Error('Error in API request');
    })
    .then(data => {
      const randomWord = data[0];
      randomWordParagraph.textContent = randomWord;
      return fetch(`https://api.dictionaryapi.dev/api/v2/entries/en/${randomWord}`);
    })
    .then(response => {
      if (response.ok) {
        return response.json();
      }
      throw new Error('Error in API request');
    })
    .then(data => {
      const table = document.getElementById('myTable');
      const tableBody = table.getElementsByTagName('tbody')[0];
      const tr = document.createElement('tr'); 
      const td1 = document.createElement('td');
      td1.textContent = data[0].meanings[0].partOfSpeech;
      const td2 = document.createElement('td');
      td2.textContent = data[0].meanings[0].definitions[0].definition;
      tr.appendChild(td1);
      tr.appendChild(td2);
      tableBody.appendChild(tr);
    })
    .catch(error => {
      console.error(error);
    });
});