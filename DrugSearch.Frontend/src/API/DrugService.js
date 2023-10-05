import Config from "./Config.js";
import axios from "axios";

export default class DrugService {
  static url = Config.BaseUrl

  static async GetById(id) {
    const response = await axios.get(
        this.url + `/api/drug/${id}`, {
        headers: {
          "ngrok-skip-browser-warning": "6024"}
      })
    return response;
  }

  static async SearchByQuery(query) {
    const response = await axios.get(
        this.url + `/api/drug/search?query=${query}`, {
          headers: {
            "ngrok-skip-browser-warning": "6024"}
        })
    return response;
  }
}