import { useState } from "react";
import classes from "./App.module.css";
import Todo from "./components";
import CreateTodo from "./components/CreateTodo";

const App = () => {
  const [todos, setTodos] = useState([]);

  const [showCreateTodoForm, setShowCreateTodoForm] = useState(false);

  const updatedTodo = (id, updatedTitle) => {
    const updatedTodos = [...todos];  //copying todos to updatesTodos
    const index = updatedTodos.findIndex((e) => e.id === id);
    updatedTodos[index] = {
      ...updatedTodos[index],
      title: updatedTitle,
    };
    setTodos(updatedTodos);
  };

  return (
    <div className={classes.root}>
      {!showCreateTodoForm && (
        <button
          type="button"
          className={classes.createTodoButton}
          onClick={() => {
            setShowCreateTodoForm(true);
          }}
        >
          Create Todo
        </button>
      )}
      {showCreateTodoForm && (
        <CreateTodo
          hideCreateTodoForm={() => setShowCreateTodoForm(false)}
          addNewTodo={(todoTitle) => {
            setTodos([
              ...todos,
              { id: `${Date.now()}-${Math.random()}`, title: todoTitle },
            ]);
          }}
        />
      )}
      {todos.map((todo) => (
        <Todo
          key={todo.id}
          id={todo.id}
          title={todo.title}
          deleteTodo={(id) => {
            setTodos(todos.filter((e) => e.id !== id));
          }}
          updateTodo={updatedTodo}
        />
      ))}
    </div>
  );
};

export default App;
