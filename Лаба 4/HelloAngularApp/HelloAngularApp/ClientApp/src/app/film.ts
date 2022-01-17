export class Film {
    constructor(
        public id?: number,
        public name?: string,
        public producer?: string,
        public genre?: string,
        public year?: number,
        public rating?: number,
        public picture?: string,
        public description?: string
    ) { }
}