/// <reference path="../../jquery-1.11.3.js" />
/// <reference path="../Dto/FamilyDto.js" />
/// <reference path="../Model/FamilyModel.js" />
/// <reference path="../../ValidateFields.js" />


$(function () {
    //login
    $('#btnLogin').click(function (event) {
        event.preventDefault();
        var familyModel = new FamilyModel();
        var familyDto = new FamilyDto();
        var validateFields = new ValidateFields();
        var error = validateFields.validateFieldsFamily(familyDto);
        if (error == false && familyDto.FamilyName != null
            && familyDto.FamilyName != "" && familyDto.Password != null && familyDto.Password)
        {
            $('.popup-modal').click();
            familyModel.LoginFamily(familyDto, function (data) {
                if(data.header.Code==200)
                {
                    localStorage.idFamily = data.Data.IdFamily;
                    localStorage.familyName = data.Data.FamilyName;
                    localStorage.familyImage = data.Data.Image;
                    window.location.replace("/Inicio");
                }
                else {
                    alert(data.header.Message);
                    $.magnificPopup.close();
                }
            }, function () {
                alert('Ha ocurrido un error con su petición. Intente mas tarde');
                $.magnificPopup.close();
            })
        }
    });


    //Registro redireccion
    $('#btnRegister').click(function (event) {
        event.preventDefault();
        $('.popup-modal').click();
        window.location.replace("/Register");
    });


    //registro 
    $('#btnRegisterSubmit').click(function (event) {
        event.preventDefault();
        var familyModel = new FamilyModel();
        var familyDto = new FamilyDto();
        var validateFields = new ValidateFields();
        var error = validateFields.validateFieldsFamily(familyDto);
        if (error == false && familyDto.FamilyName != null
          && familyDto.FamilyName != "" && familyDto.Password != null && familyDto.Password) {
            $('.popup-modal').click();
            familyModel.RegisterFamily(familyDto, function (data) {
                if (data.header.Code == 200) {
                    alert("Registro exitoso");
                    $('#btnRegisterSubmit').hide();
                    $('#btnCancelar').text("Regresar");
                    $.magnificPopup.close();
                }
                else {
                    alert(data.header.Message);
                    $.magnificPopup.close();
                }
            },function () {
                alert('Ha ocurrido un error con su petición. Intente mas tarde');
                $.magnificPopup.close();
            });
        }

    });

});