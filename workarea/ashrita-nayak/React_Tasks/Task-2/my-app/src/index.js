import React, {useState} from 'react';
import ReactDOM from 'react-dom/client';
import classes from './app.module.css';

const Square = (props) => {
 return (
    <button className={classes.square}
   onClick= {props.onClickEvent}
    >
    {props.value}
  </button>
);
};

const Board = () => {
const initialSquares = Array(9).fill(null);
         const [squares, setSquares] = useState(initialSquares);
         const [xIsNext, setXIsNext] =  useState(true);
  const handleClickEvent = (i) => {
const newSquares = [...squares];

const winnerDeclared = Boolean(calculateWinner(newSquares));

const squareFilled = Boolean(newSquares[i]);

if (winnerDeclared || squareFilled) {
  return;
}
newSquares[i] = xIsNext ? 'X' : 'O';
setSquares(newSquares);
setXIsNext(!xIsNext);
  }
const renderSquare = (i) => {
  return (
    <Square value = {squares[i]}
    onClickEvent = {() => handleClickEvent(i)}
    />
  );
};

const Winner = calculateWinner(squares);
const status =  Winner ?
`WINNER: ${Winner}`: `NEXT PLAYER: ${xIsNext ? 'X' : 'O'}`;
return (
    <div >
    <div className={classes.status}>{status}</div>
    <div className= {classes.board_row}>
    {renderSquare(0)}{renderSquare(1)}{renderSquare(2)}
    </div>
    <div className= {classes.board_row}>
    {renderSquare(3)}{renderSquare(4)}{renderSquare(5)}
    </div>
    <div className= {classes.board_row}>
    {renderSquare(6)}{renderSquare(7)}{renderSquare(8)}
    </div>
 </div>
);
};
 
const Game = () => {
  return (
    <div className = {classes.game}>  
      <p>A FUN GAME CALLED NOUGHTS & CROSSES</p>
      <Board/>
    </div>
  );
};

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(<Game />,);
function calculateWinner(squares) {
  const lines = [
    [0,1,2], [3,4,5], [6,7,8],
    [0,3,6], [1,4,7], [2,5,8],
    [0,4,8],[2,4,6]
  ];
 for (let line of lines) {
  const [p,q,r] = line;
  if (squares[p] && squares[p] === squares[q] && squares[p] === squares[r] ){
    return squares[p];

  }
 }
 return null;
 }

