// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




function validateForm() {

    if (document.forms["Form"]["aProductName"].value == "") {
        alert("Name must be filled out");
        return false;
    }


    if (document.forms["Form"]["aQuantityPerUnit"].value == "") {
        alert("QuantityPerUnit must be filled out");
        return false;
    }
    if (document.forms["Form"]["aUnitPrice"].value == "") {
        alert("UnitPrice must be filled out");
        return false;
    }
    if (document.forms["Form"]["aUnitsInStock"].value == "") {
        alert("UnitsInStock must be filled out");
        return false;
    }
    if (document.forms["Form"]["aUnitsOnOrder"].value == "") {
        alert("UnitsOnOrder must be filled out");
        return false;
    }
    if (document.forms["Form"]["aReorderLevel"].value == "") {
        alert("ReorderLevel must be filled out");
        return false;
    }
    if (document.forms["Form"]["aDiscontinued"].value == "") {
        alert("Discontinued must be filled out");
        return false;
    }

}
