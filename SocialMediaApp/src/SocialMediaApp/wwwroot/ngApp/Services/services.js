var SocialMediaApp;
(function (SocialMediaApp) {
    var Services;
    (function (Services) {
        var ModalService = (function () {
            function ModalService($uibModal) {
                this.$uibModal = $uibModal;
            }
            ModalService.prototype.openModal = function (html, movieId) {
                this.$uibModal.open({
                    templateUrl: "/ngApp/views/modalViews/" + html,
                    controller: SocialMediaApp.Controllers.ModalController,
                    controllerAs: 'modal',
                    size: 'md',
                    resolve: {
                        movieId: function () { return movieId; }
                    }
                });
            };
            return ModalService;
        }());
        Services.ModalService = ModalService;
        angular.module("SocialMediaApp").service("ModalService", ModalService);
    })(Services = SocialMediaApp.Services || (SocialMediaApp.Services = {}));
})(SocialMediaApp || (SocialMediaApp = {}));
//# sourceMappingURL=services.js.map