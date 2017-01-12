var SocialMediaApp;
(function (SocialMediaApp) {
    var Controllers;
    (function (Controllers) {
        var ModalController = (function () {
            function ModalController($http, movieId) {
                this.$http = $http;
                this.movieId = movieId;
                this.getById(movieId);
            }
            ModalController.prototype.getById = function (movieId) {
                var _this = this;
                this.$http.get("api/guidebox/" + movieId).then(function (res) {
                    _this.movie = res.data;
                    console.log(_this.movie);
                });
            };
            return ModalController;
        }());
        Controllers.ModalController = ModalController;
    })(Controllers = SocialMediaApp.Controllers || (SocialMediaApp.Controllers = {}));
})(SocialMediaApp || (SocialMediaApp = {}));
//# sourceMappingURL=modalController.js.map