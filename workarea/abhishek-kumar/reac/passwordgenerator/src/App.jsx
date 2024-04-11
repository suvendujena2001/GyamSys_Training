import { useState , useCallback , useEffect  , useRef} from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {
  const [length,  setLength] = useState(8)
  const[numberAllowed ,setNumberAllowed] = useState(false)
  const[charAllowed , seTcharAllowed] = useState(false)
  const[password , seTpassword] = useState("")

  const passwordRef = useRef(null)
   const generatePassword = useCallback(() =>{
    let pass=""
    let str ="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"

    if(numberAllowed)  str +="1234567890"
    if(charAllowed) str +="!@#$%^&*()_+"

    for(let i = 0; i< length ; i++){
      const char = Math.floor(Math.random() *str.length + 1)
      pass += str.charAt(char)
    }
    seTpassword(pass)
   } , [numberAllowed , length , charAllowed])

   
   const copyPasswordToClipboard = () =>{
    window.navigator.clipboard.writeText(password)
    passwordRef.current?.select()
   }


   useEffect(() =>{
generatePassword()
   } , [length , numberAllowed , charAllowed])

  return (
    <>
    <div className='container'>
      <h1 id='title'>Password Generator</h1>
      <input type="text" id='dis' 
      value={password}
      placeholder='Password'
      ref={passwordRef}
      readOnly></input>
      <button id='btn' onClick={copyPasswordToClipboard}>Copy</button>
      
      
        <input type="range"
        min={6}
        max={14}
        value={length}
        onChange={(e) => setLength(e.target.value)}
        name=''
        id=''></input>
        <label htmlFor="lentgh">Length : {length}</label>
      
      
        <input type="checkbox"
        defaultChecked={numberAllowed}
        onChange={() => {
          setNumberAllowed((prev) => !prev)
        }} />
        <label htmlFor='number'>Numberss</label>
      
        <input type="checkbox"
        defaultChecked={charAllowed}
        onChange={() => {
        seTcharAllowed((prev) => !prev)
        }} />
        <label htmlFor='charInput'>Charachters</label>
      </div>
    </>
  )
}

export default App
