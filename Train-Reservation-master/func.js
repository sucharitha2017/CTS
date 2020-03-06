function check(loginform) { /*function to check userid & password*/
    /*the following code checkes whether the entered userid and password are matching*/
    if (loginform.userid.value == "vishnu" && loginform.pswrd.value == "pass123") {
        window.open('dashboard.html')/*opens the target page while Id & password matches*/
    }
    else {
        alert("Error Password or Username")/*displays error message*/
    }
}