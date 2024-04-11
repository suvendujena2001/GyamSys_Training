import React, { useState } from "react";
import classes from "./todo.module.css";
import { MdEdit as EditIcon } from "react-icons/md";
import { AiFillDelete as DeleteIcon } from "react-icons/ai";

const Todo = ({ id, title, deleteTodo, updateTodo }) => {
  const [editFlag, setEditFlag] = useState(false);
  const [todoTitle, setTodoTitle] = useState("");

  return (
    <div className={classes.root}>
      {!editFlag ? (
        <span>{title}</span>
      ) : (
        <input
          className={classes.input}
          type="text"
          value={todoTitle}
          onChange={(e) => setTodoTitle(e.target.value)}
        />
      )}

      <div style={{ flex: 1 }} />

      <button
        className={classes.todoButton}
        style={editFlag ? { background: "grey" } : {}}
        onClick={() => {
          if (editFlag) {
            // we want to update todo title and set flag to false
            updateTodo(id, todoTitle);
            setEditFlag(false);
          } else {
            // we set flag to true and set setTodoTitle to the initial value to our todo
            setEditFlag(true);
            setTodoTitle(title);
          }
        }}
      >
        <EditIcon />
      </button>
      <button
        className={classes.todoButton}
        onClick={() => {
          deleteTodo(id);
        }}
      >
        <DeleteIcon />
      </button>
    </div>
  );
};

export default Todo;
