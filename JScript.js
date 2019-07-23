function signupvalidation()
{

    var signnumber = document.getElementById("txtsignnumber").value;
    var signemail = document.getElementById("txtsignemail").value;
    var signpswd = document.getElementById("txtsignpassword").value;
    var numberpatten = /^[0-9]+$/;
    var emailpatten = /^(\".*\"|[A-Za-z]\w*)@(\[\d{1,3}(\.\d{1,3}){3}]|[A-Za-z]\w*(\.[A-Za-z]\w*)+)$/ 
    
    
    if (signnumber == "") {
       alert("Please Enter Mobile Number");
       return false;}

    if (!signnumber.match(numberpatten)) {
          alert("should be Number");
          return false;
      }
     if ((signnumber.length != 10)) {

          alert("only 10 digit allowed");
          return false;
      }
    if (signemail == "") {

        alert("Please Enter Email");
        return false;
    }
    if (!signemail.match(emailpatten)) {
        alert("Invalid Email Format");
        return false;

    }


    if (signpswd== "") {

        alert("Please Enter Password");
        return false;
    }
     if ((signpswd.length < 6)) {

        alert("Please manimum 6 character");
        return false;
    }

    return true;
}

function uservalidation() {

    var loginemail = document.getElementById("txtusername").value;
    var loginpswd = document.getElementById("txtuserpassword").value;
    var emailpatten = /^(\".*\"|[A-Za-z]\w*)@(\[\d{1,3}(\.\d{1,3}){3}]|[A-Za-z]\w*(\.[A-Za-z]\w*)+)$/ 

    if (loginemail == "") {

        alert("Please Enter Email");
        return false;
    }
    if (!loginemail.match(emailpatten)) {
        alert("Invalid Email Format");
        return false;

    }
    if (loginpswd == "") {

        alert("Please Enter Password");
        return false;
    }
    if ((loginpswd.length< 6)) {

        alert("Please manimum 6 character");
        return false;
    }

    return true;
}

function customervalidation() {

    var cpincode = document.getElementById("txtpincode").value;
    var cmobnumber = document.getElementById("txtmobnumber").value;
    var ccolony = document.getElementById("txtcolony").value;
    var caddtype = document.getElementById("rbhome").checked;
    var cname = document.getElementById("txtname").value;
    var chouse = document.getElementById("txthouse").value;
    var ccity  = document.getElementById("txtcity").value;
    var cstate = document.getElementById("txtstate").value;
    var caddtype = document.getElementById("rboffice").checked;
    var numberpatten = /^[0-9]+$/;

    if (cpincode == "") {

        alert("Please Enter PinCode");
        return false;

    }
    if (cmobnumber == "") {

        alert("Please Enter PinCode");
        return false;

    }
}