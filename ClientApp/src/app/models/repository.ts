import { Forum } from './forum.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Filter } from './configClasses.repository';

const forumsUrl = "/api/forums";

@Injectable()
export class Repository {
  forum: Forum;
  forums: Forum[];
  filter: Filter = new Filter();
  constructor(private http: HttpClient) {
    this.filter.category = "";
    this.getForums();
  }

  getForum(id: number) {
    this.http.get<Forum>("/api/forums/" + id)
      .subscribe(p => this.forum = p);
  }

  getForums() {
    let url = "/api/forums";
    if (this.filter.category)
    {
      url += `?category=${this.filter.category}`; 
    }
    this.http.get<Forum[]>(url)
      .subscribe(pr => this.forums = pr);
  }
}
