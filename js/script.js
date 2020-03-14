$(document).ready(function (){
    $(".sideMenuToggler").on("click", function () {
$(".wrapper").toggleClass("active");
    });
});


const ul = document.getElementById("navbarDropdownUserName"); 
const url = 'https://cvsystem.azurewebsites.net/api/adminData/get'; 


fetch(url)
.then(res => res.json())
.then((out) => {
  console.log('Checkout this JSON! ', out);
  ul.innerHTML = out[0].login.loginName;
})
.catch(err => { throw err });

 




// var obj = 
