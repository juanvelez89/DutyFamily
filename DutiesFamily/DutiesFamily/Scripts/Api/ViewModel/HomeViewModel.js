﻿$(function () {

    var familyName = localStorage.familyName;
    $('#lblFamilyName').text(familyName);

    $('#btnAddNewUser').click(function () {
        if ($('#newUser').is('visible') == false) {
            $('#newUser').show();
            $('#addNewUser').hide();
        }
    else{

}
    });

    $('#btnUsers').click(function () {
        $('.popup-modal').click();
        $('#userForm').show();
        $('#IntroHome').hide();
        $.magnificPopup.close();
    });

});