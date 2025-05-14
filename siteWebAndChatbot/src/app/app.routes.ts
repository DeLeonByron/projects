import { Routes } from '@angular/router';
import { LayoutSiteComponent } from './layout/layout-site/layout-site.component';
import { SiteWebComponent } from './view/site-web/site-web.component';

export const routes: Routes = [
    {
      path: '',
      component: LayoutSiteComponent,
      children: [
        { path: '', component: SiteWebComponent }
      ]
    }
  ];
