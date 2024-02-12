<!DOCTYPE html>
<head>
  <title>
    javascript</title>
    <style>
      #myHeading {
        color: red;
        text-align: center;
      }


      .myParagraph {
        color: blue;
        font-size: 24px;
        font-style: italic;
        text-align: justify;
    }
    </style>
</head>
<body>
  <h1 id="myHeading">Hello, World!</h1>
  <p class="myParagraph">This is a paragraph.</p>
  <button onclick="changeText()">Change Text</button>
  <button onclick="changeHeading()">Change Heading</button>
  <button onclick="createElement()">Create Element</button>

  <script type="text/javascript">
  function changeText() {
    var para = document.getElementsByClassName("myParagraph");
    para.innerText = "This is a new text.";
  }
  
  function changeHeading() {
    var heading = document.getElementById("myHeading");
    heading.innerHTML = "Hello, JavaScript!";
  }
  
  function createElement() {
    var newElement = document.createElement("p");
    var textNode = document.createTextNode("This is a new paragraph.");
    newElement.appendChild(textNode);
    document.body.appendChild(newElement);
  }
</script>
</body>
</html>
