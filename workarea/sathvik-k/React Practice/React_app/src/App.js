import React, { useState } from 'react';
import Box from './Box';
import Button from './Button';

function App() {
  const [color, setColor] = useState('#007bff');

  const changeColor = () => {
    const randomColor = '#' + Math.floor(Math.random()*16777215).toString(16);
    setColor(randomColor);
  };

  return (
    <div className="App">
      <Box color={color} />
      <Button onClick={changeColor} />
    </div>
  );
}

export default App;
