

function disableButtonOnClick(oButton, sButtonText, sCssClass) {
    // set button to disabled so you can't click on it.
    oButton.disabled = true;
    // change the text of the button.
    oButton.value = sButtonText;
    // IE uses className for the css property.
    oButton.setAttribute('className', sCssClass);
    // Firefox, Safari use class for the css property.  (doesn't hurt to do both).
    oButton.setAttribute('class', sCssClass);
}

function RefreshIt(selectObj) {
    __doPostBack('<%= Page.ClientID %>', selectObj.name);
}

var config = {
    '.chosen-select': {},
    '.chosen-select-deselect': { allow_single_deselect: true },
    '.chosen-select-no-single': { disable_search_threshold: 10 },
    '.chosen-select-no-results': { no_results_text: 'Oops, nothing found!' },
    '.chosen-select-width': { width: "95%" }
}



for (var selector in config) {
    $(selector).chosen(config[selector]);
}

function isNumberKey(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {

        return false;
    }

    return true;
}

function isNumberOrDecimal(evt, element) {
    var charCode = (evt.which) ? evt.which : event.keyCode

    if (
            (charCode != 45 || $(element).val().indexOf('-') != -1) &&      // “-” CHECK MINUS, AND ONLY ONE.
            (charCode != 46 || $(element).val().indexOf('.') != -1) &&      // “.” CHECK DOT, AND ONLY ONE.
            (charCode < 48 || charCode > 57))
        return false;

    return true;


}

function emailValidate(element) {

    var reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
    //var address = document.getElementById[email].value;
    if (reg.test($(element).val()) == false) {
        alert('Invalid Email Address');
        return false;
    }
}


function blockSpecialChars(e) {
    var keycode;

    if (window.event)
        keycode = window.event.keyCode;
    else if (event)
        keycode = event.keyCode;
    else if (e)
        keycode = e.which;
    else
        return true;

    if ((keycode >= 47 && keycode <= 57) || (keycode >= 65 && keycode <= 90) || window.event.keyCode == 32 || (keycode >= 97 && keycode <= 122)) {
        return true;
    } else {
        return false;
    }

    return true;
}

function AllowOnlyNumwithComma(e, obj) {
    var hasDot = false;
    if (e.value.indexOf(",") > -1) {
        hasDot = true;
    }

    if (window.event.keyCode > 47 && window.event.keyCode < 58 || window.event.keyCode == 8 || (window.event.keyCode == 46 && !hasDot)) {
        window.event.returnValue = true;
    }
    else {
        window.event.returnValue = false;
    }
}

//Added By NNE [To enter decimal value only]
function isDecimalKey(evt, obj) {

    var charCode = (evt.which) ? evt.which : event.keyCode
    var value = obj.value;
    var dotcontains = value.indexOf(".") != -1;
    if (dotcontains)
        if (charCode == 46) return false;
    if (charCode == 46) return true;
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;
    return true;
}

function isPhoneNo(evt, obj) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (charCode == 188 || charCode == 189)
        return true;
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;
    return true;
}



