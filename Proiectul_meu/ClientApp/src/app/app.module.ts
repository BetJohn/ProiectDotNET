import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { BluzaComponent } from './bluza/bluza.component';
import { MatListModule } from '@angular/material';
import { CounterComponent } from './counter/counter.component';
import { SoseteComponent } from './sosete/sosete.component';
import { TricouComponent } from './tricou/tricou.component';
import { TreningComponent } from './trening/trening.component';
import { PantaloniComponent } from './pantaloni/pantaloni.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    BluzaComponent,
    SoseteComponent,
    TricouComponent,
    TreningComponent,
    PantaloniComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    MatListModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'bluza', component: BluzaComponent },
      { path: 'sosete', component: SoseteComponent },
      { path: 'tricouri', component: TricouComponent },
      { path: 'treninguri', component: TreningComponent },
      { path: 'pantaloni', component: PantaloniComponent }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
