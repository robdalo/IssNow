import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-iss-now',
  templateUrl: './iss-now.component.html'
})
export class IssNowComponent {
  public location: Location;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Location>(baseUrl + 'location').subscribe(result => {
      this.location = result;
    }, error => console.error(error));
  }
}

interface Location {
  timestamp: number;
  longitude: number;
  latitude: number;
}
