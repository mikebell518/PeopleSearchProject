import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Person } from './search-results.component';
import { Observable } from 'rxjs';
import { of } from "rxjs";
import * as myGlobals from '../globals';

@Injectable({
    providedIn: 'root'
  })
  
export class SearchService {
  public persons: Person[] = [];
  public searchString: string;
  public urlPath: string;

  constructor(private http: HttpClient) {
  }

  /*
   * Method to make API call to back end.
   * Paramater searchString - Optional
   * If search string is null, an emtry responce is returned and not call is made to the api.
   * This is used to clear the search results when the text box is blank. 
   * 
   */
  public getPeople(searchString: string = ""): Observable<Person[]>
  {
    if (searchString=="")
    {
        return of([]);
    }
    else
    {
      this.urlPath = myGlobals.backEndUrl + "?searchString=" + searchString;
    }
    return this.http.get<Person[]>(this.urlPath);
  }
}

