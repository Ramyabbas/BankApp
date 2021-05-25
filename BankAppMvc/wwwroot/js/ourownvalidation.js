


jQuery.validator.addMethod("notcurrenthour",
    function (value, element, param) {
        console.log('notcurrenthour' + value);
        var d = new Date();
        var n = d.getHours();
        if (parseInt(value) == parseInt(n)) {
            return false;
        }
        else {
            return true;
        }
});
jQuery.validator.unobtrusive.adapters.addBool("notcurrenthour");