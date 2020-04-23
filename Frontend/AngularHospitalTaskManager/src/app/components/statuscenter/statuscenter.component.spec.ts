import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { StatuscenterComponent } from './statuscenter.component';

describe('StatuscenterComponent', () => {
  let component: StatuscenterComponent;
  let fixture: ComponentFixture<StatuscenterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StatuscenterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StatuscenterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
