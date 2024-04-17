import { useState } from "react";
import classes from "./Cardapp.module.scss";
import 'bootstrap/dist/css/bootstrap.css';
const Card=()=>{
    const [name,setState]=useState({firstName:"",lastName:""});
    return(
        <div>
           <div className={classes.inputs}>
             <label htmlFor="fname" className="namelabel">Enter your first name :</label>
             <div className="input-group flex-nowrap">
               <span className="input-group-text" id="addon-wrapping">@</span>
               <input type="text" id="fname" className="form-control" style={name.firstName.length>10?{background:'lightcoral',}:{}} placeholder="Firstname" aria-label="Username" aria-describedby="addon-wrapping" onChange={(e)=>setState({...name,firstName:e.target.value})}></input>
             </div>
             <label htmlFor="lname" className="namelabel">Enter your last name :</label>
             <div className="input-group flex-nowrap">
               <span className="input-group-text" id="addon-wrapping">@</span>
               <input type="text" id="lname" className="form-control" style={name.lastName.length>10?{background:'lightcoral',}:{}} placeholder="Lastname" aria-label="Username" aria-describedby="addon-wrapping" onChange={(e)=>setState({...name,lastName:e.target.value})}></input>
             </div>
             <div>
               <p>Entered first name is :{name.firstName.length>10?"First Name should not exceed 10 letters":name.firstName} </p>
               <p>Entered last name is :{name.lastName.length>10?"Last Name should not exceed 10 letters":name.lastName}</p>
             </div>
          </div>
       </div>
       )
}
export default Card;