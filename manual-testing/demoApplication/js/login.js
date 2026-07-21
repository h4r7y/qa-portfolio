
const loginButton = document.getElementById("login");

loginButton.addEventListener("click", function () {

    const email = document.getElementById("email").value;
    const password = document.getElementById("password").value;


    if(email === "test@test.com" && password === "1234") {

        window.location.href = "dashboard.html";

    } else {

        document.getElementById("message").innerHTML =
        "❌ Ungültige Zugangsdaten";

    }

});