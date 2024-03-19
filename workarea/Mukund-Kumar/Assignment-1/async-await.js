document.addEventListener('DOMContentLoaded', function() {
  const searchbtn = document.querySelector('.btn');

async function getRandomWord(){
    const wordApiURL = getWordApi();
    const response=await fetch(wordApiURL);
    if(response.status==404)
    {
        document.querySelector('wordis').style.display='none';
        document.querySelector('.error').innerText='Error';
    }
    else{
        var data=await response.json();
        var gword=data.word;
        document.querySelector('#word').innerText=gword;
    }

    const dictionaryApi= getDictionaryApiUrl() + '/' + gword;
    const dictresponse=await fetch(dictionaryApi);


    if(dictresponse.status==404)
    {
        document.querySelector('.ok').style.display="none";
        document.querySelector('.dicterror').innerText="The meaning not found";
    }
    else{
        var gdata=await dictresponse.json();
        document.querySelector('.partofspeech').innerText = 'Part of Speech: '+gdata[0].meanings[0].partOfSpeech;
        document.querySelector('.definition').innerHTML = 'Definintion: '+gdata[0].meanings[0].definitions[0].definition;
    }
}

  searchbtn.addEventListener('click', () => {
    getRandomWord();
  });
});
