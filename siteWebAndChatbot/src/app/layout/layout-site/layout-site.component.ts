import { Component } from '@angular/core';
import { SiteWebComponent } from '../../view/site-web/site-web.component';

@Component({
  selector: 'app-layout-site',
  standalone: true,
  imports: [SiteWebComponent],
  templateUrl: './layout-site.component.html',
  styleUrl: './layout-site.component.scss'
})
export class LayoutSiteComponent {

}
