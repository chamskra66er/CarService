import { Component } from '@angular/core';
import { Repository } from './models/repository';
import { Forum } from './models/forum.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor(private repo: Repository) { }

  get forum(): Forum {
    return this.repo.forum;
  }
}
