import { Forum } from './forum.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class Repository {
  forum: Forum;
  constructor(private http: HttpClient) {
    this.getForum(1);
  }

  getForum(id: number) {
    this.http.get<Forum>("api/forums/" + id)
      .subscribe(p => this.forum = p);
  }
}
