import { Component } from '@angular/core';
import { SearchService } from './search-results.service';
import { Observable } from 'rxjs';
import { FormControl } from '@angular/forms';
import { debounceTime , distinctUntilChanged, switchMap, tap  } from 'rxjs/operators';


@Component({
  selector: 'app-search-results',
  templateUrl: './search-results.component.html',
})

export class SearchResultsComponent {
  private persons: Observable<Person[]>;
  private peopleService:SearchService;
  public isLoading: boolean;
  public isNotEmptySearch: boolean;
  private searchField: FormControl;
  public term: string;

  constructor(peopleService:SearchService) {
    this.peopleService=peopleService;
    this.isNotEmptySearch=false;
  }

  ngOnInit(){
    this.searchField = new FormControl();
      console.log(this.isNotEmptySearch);
      this.persons = this.searchField.valueChanges.pipe(
      debounceTime(300), 
      distinctUntilChanged(),
      tap( () => this.isLoading = true),
      switchMap(obj => this.peopleService.getPeople(this.searchField.value)),
      tap( () => this.isLoading = false));
      this.isNotEmptySearch=true;
    }
}

export class Person{
  name: string;
  age: number;
  interests: string;
  line: string;
  city: string;
  state: string;
  zip: number;
  imgPath: string;

}

