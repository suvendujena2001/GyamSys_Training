const generateButton = document.getElementById('generate-word-button');
const randomWordParagraph = document.getElementById('random-word');

generateButton.addEventListener('click', () => {
  fetchRandomWord()
    .then(randomWord => {
      randomWordParagraph.textContent = randomWord;
      return fetchWordMeaning(randomWord);
    })
    .then(meaning => {
      const tableBody = document.querySelector('#myTable tbody');
      tableBody.innerHTML = ''; // Clear the existing rows

      meaning.map(a => {
        const tr = document.createElement('tr');
        const td1 = document.createElement('td');
        td1.textContent = a.partOfSpeech;
        const td2 = document.createElement('td');
        td2.textContent = a.definitions;
        tr.appendChild(td1);
        tr.appendChild(td2);
        tableBody.appendChild(tr);
      });
    })
    .catch(error => {
      console.error(error);
    });
});

function fetchRandomWord() {
  return new Promise((resolve, reject) => {
    fetch('https://random-word-api.herokuapp.com/word')
      .then(response => {
        if (!response.ok) {
          reject(new Error('Error in API request'));
        } else {
          response.json().then(data => {
            resolve(data[0]);
          });
        }
      })
      .catch(error => {
        reject(error);
      });
  });
}

function fetchWordMeaning(word) {
  return new Promise((resolve, reject) => {
    fetch(`https://api.dictionaryapi.dev/api/v2/entries/en/${word}`)
      .then(response => {
        if (!response.ok) {
          reject(new Error('Error in API request'));
        } else {
          response.json().then(data => {
            const meaning = data[0].meanings.map(abc => {
              return {
                partOfSpeech: abc.partOfSpeech,
                definitions: abc.definitions.map(def => def.definition).join(', ')
              };
            });
            resolve(meaning);
          });
        }
      })
      .catch(error => {
        reject(error);
      });
  });
}