import { Forum } from './forum.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

const forumsUrl = "/api/forums";

@Injectable()
export class Repository {
  forum: Forum;
  forums: Forum[];
  constructor(private http: HttpClient) {
    this.getForums();
  }

  getForum(id: number) {
    this.http.get<Forum>('${forumsUrl}/${id}')
      .subscribe(p => this.forum = p);
  }
  getForums() {
    this.http.get<Forum[]>('${forumsUrl}')
      .subscribe(prod => this.forums = prod);
  }
}
