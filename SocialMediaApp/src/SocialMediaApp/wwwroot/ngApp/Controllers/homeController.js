var SocialMediaApp;
(function (SocialMediaApp) {
    var Controllers;
    (function (Controllers) {
        var HomeController = (function () {
            function HomeController($http, ModalService) {
                var _this = this;
                this.$http = $http;
                this.ModalService = ModalService;
                $http.get('api/guidebox').then(function (res) {
                    _this.movies = res.data;
                    //console.log(this.movies);
                });
            }
            return HomeController;
        }());
        Controllers.HomeController = HomeController;
    })(Controllers = SocialMediaApp.Controllers || (SocialMediaApp.Controllers = {}));
})(SocialMediaApp || (SocialMediaApp = {}));
//# sourceMappingURL=homeController.js.map