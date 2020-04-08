import { Image } from "./image.model";

export class Forum {
  constructor(
    public Id?: number,
    public Title?: string,
    public Description?:string,
    public VideoUrl?: string,
    public FileUrl?: string,
    public ImageUrl?:string,
    public Path?:string,
    public Value?:string,
    public Comment?:string,
    public DateCreate?:Date,
    public DateFinish?:Date, 
    public Images?:Image ) {}
}
