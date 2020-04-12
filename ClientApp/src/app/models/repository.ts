import { Forum } from './forum.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Filter } from './configClasses.repository';
import { Image } from './image.model';

const forumsUrl = "/api/forums";
const imagesUrl = "/api/images"

@Injectable()
export class Repository {
  forum: Forum;
  forums: Forum[];
  images: Image[] = [];
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

  createForum(f: Forum) {
    let data = {
      title: f.title, description: f.description, videoUrl: f.videoUrl, fileUrl: f.fileUrl,
      imageUrl: f.imageUrl, path: f.path, value: f.value, comment: f.comment, dateCreate: f.dateCreate,
      dateFinish: f.dateFinish, images: f.images ? f.images.id : 0
    };
    this.http.post<number>(forumsUrl, data)
      .subscribe(id => {
        f.id = id;
        this.forums.push(f);
      });
  }
  createImage(f: Forum, i: Image) {
    let data = {
      forumId: f.id, imgUrl1: i.imgUrl1, imgUrl2: i.imgUrl2, imgUrl3: i.imgUrl3, imgUrl4: i.imgUrl4
    };
    this.http.post<number>(imagesUrl, data)
      .subscribe(id => {
        i.id = id;
        f.images = i;
        this.images.push(i);
        if (f != null) {
          this.createForum(f);
        }
      });
  }
}
