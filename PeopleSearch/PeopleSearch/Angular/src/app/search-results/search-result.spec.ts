import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { TestBed, getTestBed } from '@angular/core/testing';
import * as myGlobals from '../globals';
import { SearchService } from './search-results.service';
  /*
  *  Unit test for Search-Result service.
  *  The test creates a mock back end with test data.
  *  Runs the result through the service and verified the returned data matches the mock data.
  *  Test also checks that the api url is correct. 
  *  To run from Angular CLI, in the project's Angular folder run ng test
  */

describe('SearchService', () => {
  let injector: TestBed;
  let service: SearchService;
  let httpMock: HttpTestingController;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [SearchService]
    });

    injector = getTestBed();
    service = injector.get(SearchService);
    httpMock = injector.get(HttpTestingController);
  });

  afterEach(() => {
    httpMock.verify();
  });

  describe('getPeopleSearch', () => {
    it('should return an Observable<Person[]>', () => {
      const tesatData = [
        { id: 0, name: 'Test0', age: '20', interests: 'testing', line: '123 Test Way', city: 'Testing', state: 'Tx', zip: '55555', imgPath: '/test.png' },
        { id: 1, name: 'Test1', age: '25', interests: 'testing', line: '345 Test Way', city: 'Testing', state: 'Tx', zip: '55555', imgPath: '/test.png' }
      ];

      service.getPeople("test").subscribe(people => {
        expect(people.length).toBe(2);
        console.log(people)
      });

      const req = httpMock.expectOne(myGlobals.backEndUrl + '?searchString=test');
      expect(req.request.method).toBe("GET");
      req.flush(tesatData);
    });
  });
});
