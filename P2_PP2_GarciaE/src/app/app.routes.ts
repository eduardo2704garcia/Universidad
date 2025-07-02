import { Routes } from '@angular/router';
import { WelcomePage } from './home/welcome-page/welcome-page';
import { List } from './products/list/list';
import { Contact } from './user/contact/contact';
import { Info } from './user/info/info';
import { Donations } from './pages/donations/donations';
import { Volunteering } from './pages/volunteering/volunteering';

export const routes: Routes = [
    { path: 'home', component: WelcomePage },
    { path: 'products', component: List },
    { path: 'user/contact', component: Contact },
    { path: 'user/info', component: Info },
    { path: 'pages/donations', component: Donations},
    { path: 'pages/volunteering', component: Volunteering}
];
