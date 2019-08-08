import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  public requestSpot() {
    let url = this.baseUrl + 'api/ParkingSpot/RequestSpot' + '?employeeId=1234'

    this.http.post(url, "").subscribe(error => console.error(error));
  }

  public acceptSpot() {
    let url = this.baseUrl + 'api/ParkingSpot/AcceptSpot' + '?employeeId=1234'

    this.http.post(url, "").subscribe(error => console.error(error));
  }

  public declineSpot() {
    let url = this.baseUrl + 'api/ParkingSpot/DeclineSpot' + '?employeeId=1234'

    this.http.post(url, "").subscribe(error => console.error(error));
  }

}
