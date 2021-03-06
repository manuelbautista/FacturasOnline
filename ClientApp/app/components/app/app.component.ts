import { AuthService } from './../../auth.service.service';
import { Component } from '@angular/core';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {
    constructor(private auth: AuthService) {
        auth.handleAuthentication();
    }
}
