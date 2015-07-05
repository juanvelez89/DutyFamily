function ValidateFields() {
    this.validateFieldsFamily = function (familyDto) {
        var error = false;
        familyDto.FamilyName = $('#txtFamily').val();
        familyDto.Password = $('#txtPassword').val();
        if (familyDto.FamilyName == null || familyDto.FamilyName == "") {
            $('#errFamlily').show();
            error = true;
        }
        else {
            $('#errFamlily').hide();
            error = false;
        }

        if (familyDto.Password == null || familyDto.Password == "") {
            $('#errPassword').show();
            error = true;
        }
        else {
            $('#errPassword').hide();
            error = false;
        }

        return error;
    }
}