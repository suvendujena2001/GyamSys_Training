import React, { useState } from "react";
import classes from "./todo.module.css";

const CreateTodo = ({ hideCreateTodoForm, addNewTodo }) => {
  const [todoTitle, setTodoTitle] = useState("");
  return (
    <div className={classes.createTodoForm}>
      <h2 className={classes.header}>Create Todo Form</h2>
      <input
        className={classes.input}
        type="text"
        value={todoTitle}
        onChange={(e) => setTodoTitle(e.target.value)}
      />
      <div className={classes.buttonCont}>
        <button
          onClick={() => {
            addNewTodo(todoTitle);
            hideCreateTodoForm();
          }}
        >
          Create Todo
        </button>
        <button
          //   onClick={() => {
          //     hideCreateTodoForm();
          //   }}
          onClick={hideCreateTodoForm}
        >
          Cancel
        </button>
      </div>
    </div>
  );
};

export default CreateTodo;