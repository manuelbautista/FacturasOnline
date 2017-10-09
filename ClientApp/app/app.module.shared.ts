import { ErrorHandler } from '@angular/core';
import { AppErrorHandler } from './app.error-handler';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { ClientesComponent } from './components/clientes/clientes.component';
import { FacturasComponent } from './components/facturas/facturas.component';
import { ToastyModule } from 'ng2-toasty';
import * as Raven from 'raven-js';

Raven
.config('https://de26a9be61604d0d93dfe0dc272f2d02@sentry.io/227746')
.install();

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        ClientesComponent,
        FacturasComponent
    ],
    providers: [
        { provide: ErrorHandler, useClass: AppErrorHandler},
    ],
    imports: [
        CommonModule,
        HttpModule,
        ToastyModule.forRoot(),
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'login', component: CounterComponent },
            { path: 'clientes', component: ClientesComponent },
            { path: 'facturas', component: FacturasComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}
