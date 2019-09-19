import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Person } from './search-results.component';
import { Observable } from 'rxjs';
import { of } from "rxjs";

@Injectable({
    providedIn: 'root'
  })
  
export class SearchService {
  public persons: Person[] = [];
  public searchString: string;
  public urlPath: string;

  constructor(private http: HttpClient) {
  }
  
  public getPeople(searchString: string = ""): Observable<Person[]>
  {
    const url = 'http://localhost:60550/api/people';
    if (searchString=="")
    {
        return of([]);
    }
    else
    {
        this.urlPath=url + "?searchString=" + searchString;
    }
    return this.http.get<Person[]>(this.urlPath);
  }
}

