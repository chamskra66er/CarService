import { Image } from "./image.model";

export class Forum {
  constructor(
    public id?: number,
    public title?: string,
    public description?:string,
    public videoUrl?: string,
    public fileUrl?: string,
    public imageUrl?: string,
    public path?: string,
    public value?: string,
    public comment?: string,
    public dateCreate?: Date,
    public dateFinish?: Date, 
    public images?: Image ) {}
}
