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

  public releaseSlotForParking() {
    let request = {
      "SlotId": 1,
      "releaseDate":"2019-08-08"
    }
    this.http.post<boolean>(this.baseUrl + 'api/SampleData/ReleaseSlot', request).subscribe(result => {
      this.status = result;
    }, error => console.error(error));
  }
} 
