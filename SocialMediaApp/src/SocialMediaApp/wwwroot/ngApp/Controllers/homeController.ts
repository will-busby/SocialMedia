namespace SocialMediaApp.Controllers {
    export class HomeController {
        public movies;
        constructor(public $http: ng.IHttpService, public ModalService: SocialMediaApp.Services.ModalService) {
            $http.get('api/guidebox').then((res) => {
                this.movies = res.data;
                //console.log(this.movies);
            });
        }
    }
}