/// <reference path="../../jquery-1.11.3.js" />
/// <reference path="../../Knockout.js" />
/// <reference path="../Dto/UserDto.js" />
/// <reference path="../Model/UserModel.js" />
/// <reference path="../Model/RolModel.js" />


$(function () {

    function HomeViewModel() {

        var self = this;
        self.familyName = localStorage.familyName;
        self.rolList = ko.observableArray();
        self.userList = ko.observableArray();
        self.selectedRol = ko.observable();

        //Models

        self.rolModel = new RolModel();

        $('#lblFamilyName').text(self.familyName);

        //RegionUsuarios
        $('#btnAddNewUser').click(function () {
            if ($('#newUser').is('visible') == false) {
                $('#newUser').show();
                $('#addNewUser').hide();
                self.rolModel.Roles(function (data) {
                    self.rolList(data.Data);
                }, function () {

                });
            }
            else {

            }
        });

        $('#btnUsers').click(function () {
            $('.popup-modal').click();
            $('#userForm').show();
            $('#newUser').hide();
            $('#addNewUser').show();
            $('#rolForm').hide();
            $('#IntroHome').hide();
            $.magnificPopup.close();
        });

        //EndUsuarios

        $('#btnRoles').click(function () {
            $('.popup-modal').click();
            $('#userForm').hide();
            $('#rolForm').show();
            $('#IntroHome').hide();
            $.magnificPopup.close();
        });

    }

    ko.applyBindings(new HomeViewModel());

   

});