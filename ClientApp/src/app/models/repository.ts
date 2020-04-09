import { Forum } from "./forum.model";

export class Repository {

  constructor() {
    this.forum = JSON.parse(document.getElementById("data").textContent);
  }

  forum: Forum;
}
