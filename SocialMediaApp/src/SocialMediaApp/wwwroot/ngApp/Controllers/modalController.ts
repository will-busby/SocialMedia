namespace SocialMediaApp.Controllers {
    export class ModalController {
        public movie;
        constructor(public $http: ng.IHttpService, public movieId) {
            this.getById(movieId);
        }

        public getById(movieId) {
            this.$http.get(`api/guidebox/${movieId}`).then((res) => {
                this.movie = res.data;
                console.log(this.movie);
            });
        }
    }
}