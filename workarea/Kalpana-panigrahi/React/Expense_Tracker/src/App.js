import React, { useState } from 'react';

function ExpenseTracker() {
  const [expenses, setExpenses] = useState([]);
  const [newExpense, setNewExpense] = useState('');
  const [amount, setAmount] = useState('');

  const handleExpenseChange = event => {
    setNewExpense(event.target.value);
  };

  const handleAmountChange = event => {
    setAmount(event.target.value);
  };

  const addExpense = () => {
    if (newExpense.trim() !== '' && amount.trim() !== '') {
      const newExpenseItem = {
        id: Date.now(),
        description: newExpense,
        amount: parseFloat(amount)
      };
      setExpenses([...expenses, newExpenseItem]);
      setNewExpense('');
      setAmount('');
    }
  };

  const deleteExpense = id => {
    setExpenses(expenses.filter(expense => expense.id !== id));
  };

  const totalExpenses = expenses.reduce((total, expense) => total + expense.amount, 0);

  return (
    <div style={{ maxWidth: '400px', margin: '0 auto', padding: '20px', border: '1px solid #ccc', borderRadius: '8px', backgroundColor: '#f9f9f9' }}>
      <h1>Expense Tracker</h1>
      <div style={{ marginBottom: '20px' }}>
        <label htmlFor="expenseInput" style={{ marginRight: '10px' }}>Expense:</label>
        <input
          id="expenseInput"
          type="text"
          value={newExpense}
          onChange={handleExpenseChange}
          style={{ padding: '8px', marginRight: '10px' }}
        />
      </div>
      <div style={{ marginBottom: '20px' }}>
        <label htmlFor="amountInput" style={{ marginRight: '10px' }}>Amount:</label>
        <input
          id="amountInput"
          type="number"
          value={amount}
          onChange={handleAmountChange}
          style={{ padding: '8px', marginRight: '10px' }}
        />
        <button onClick={addExpense} style={{ padding: '8px 16px', backgroundColor: '#007bff', color: '#fff', border: 'none', borderRadius: '4px', cursor: 'pointer' }}>Add Expense</button>
      </div>
      <ul style={{ listStyle: 'none', padding: '0' }}>
        {expenses.map(expense => (
          <li key={expense.id} style={{ marginBottom: '10px' }}>
            <span>{expense.description}: {expense.amount}</span>
            <button onClick={() => deleteExpense(expense.id)} style={{ padding: '4px 8px', backgroundColor: '#dc3545', color: '#fff', border: 'none', borderRadius: '4px', cursor: 'pointer', marginLeft: '10px' }}>Delete</button>
          </li>
        ))}
      </ul>
      <p style={{ fontWeight: 'bold', marginTop: '20px' }}>Total Expenses: {totalExpenses.toFixed(2)}</p>
    </div>
  );
}

export default ExpenseTracker;

