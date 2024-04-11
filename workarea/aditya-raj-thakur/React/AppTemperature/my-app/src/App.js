import { useState } from 'react';
import './App.css';

function App() {
  const [temp, setTemp] = useState(10);

  const incrementTemperature =()=>{
    setTemp(prevTemperature => prevTemperature +1);
  }
  const decrementTemperature = () => {
    setTemp(prevTemperature => prevTemperature - 1);
  };

  
  return (
    <div className="App">
      <h1>Temperature </h1>
      <div className="temp-display">
        <h2>Temperature: {temp}°C</h2>
      </div>
      <div className="buttons">
        <button onClick={incrementTemperature}>Increase</button>
        <button onClick={decrementTemperature}>Decrease</button>
      </div>
  </div>
  );
}

export default App;
