import { environment } from './../../../environments/environment';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PlanService {

  baseUrl = environment.api;
  messageSource = new BehaviorSubject<number>(0);
  currentMessage = this.messageSource.asObservable();
  // method này để change source message
  changeMessage(message) {
    this.messageSource.next(message);
  }
  constructor(private http: HttpClient) { }


  getAll() {
    return this.http.get(this.baseUrl + `Plan/GetAll`, {})
  }
  getAllCount() {
    return this.http.get(this.baseUrl + `Plan/GetAllPlanCount`, {})
  }
  created(model) {
    return this.http.post(this.baseUrl + `Plan/Create`, model)
  }
  start(id) {
    return this.http.get(this.baseUrl + `Plan/Start/${id}`, {})
  }
  stop(id) {
    return this.http.get(this.baseUrl + `Plan/Stop/${id}`, {})
  }
  getAllLine() {
    return this.http.get(this.baseUrl + `Line/GetAll`, {})
  }
  getAllCar() {
    return this.http.get(this.baseUrl + `Car/GetAll`, {})
  }
  delete(id,file_name) {
    return this.http.delete(`${this.baseUrl}ToDoList/Delete/${id}/${file_name}`)
  }
  downloadExcel(url: string){
    return this.http.get(url,{responseType: 'blob'})
  }
  approve(ToDoListID,userID) {
    return this.http.get(this.baseUrl + `ToDoList/Approval/${ToDoListID}/${userID}`, {})
  }
  LoadTimeLine(ToDoListID) {
    return this.http.get(this.baseUrl + `ToDoList/LoadTimeLine/${ToDoListID}`, {})
  }
  reject(model) {
    return this.http.post(this.baseUrl + 'ToDoList/reject', model)
  }
}
