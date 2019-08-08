import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})

export class CounterComponent {
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }
  public status:boolean;

    this.http.post(url, "").subscribe(error => console.error(error));
  }
} 
