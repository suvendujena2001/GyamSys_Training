let accounts = [];

        function showLogin() {
            document.getElementById("loginForm").style.display = "block";
            document.getElementById("createAccountForm").style.display = "none";
        }

        function showCreateAccount() {
            document.getElementById("loginForm").style.display = "none";
            document.getElementById("createAccountForm").style.display = "block";
        }

        document.getElementById("loginForm").addEventListener("submit", function(event) {
            event.preventDefault(); // Prevent the form from submitting

            // Your login logic here (e.g., check username and password)
            const username = document.getElementById("username").value;
            const password = document.getElementById("password").value;

            // Example login check (replace with your actual login logic)
            const account = accounts.find(acc => acc.username === username && acc.password === password);
            if (account) {
                // Redirect to the second page after successful login
                window.location.href = "month.html";
            } else {
                alert("Invalid username or password. Please try again.");
            }
        });

        document.getElementById("createAccountForm").addEventListener("submit", function(event) {
            event.preventDefault(); // Prevent the form from submitting

            // Your account creation logic here
            const newUsername = document.getElementById("newUsername").value;
            const newPassword = document.getElementById("newPassword").value;

            // Example account creation (replace with your actual account creation logic)
            accounts.push({ username: newUsername, password: newPassword });
            alert("Account created successfully. Please login.");
            showLogin(); // Switch back to the login form
        });