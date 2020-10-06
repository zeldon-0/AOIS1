import { Genre } from "../../genres/models/genre";
import { Instrument } from "../../instruments/models/instrument";
import { Tempo } from "../../tempos/models/tempo";
import { Novelty } from "../../novelties/models/novelty";

export class  RecommendationQuery{
    genres : Genre[];
    instruments : Instrument[];
    tempos : Tempo[];
    novelties : Novelty[];
    constructor(){
        this.genres = [];
        this.instruments = [];
        this.tempos = [];
        this.novelties = [];
    }
}