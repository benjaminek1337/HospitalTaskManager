import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ScheduleLoaderComponent } from './schedule-loader.component';

describe('ScheduleLoaderComponent', () => {
  let component: ScheduleLoaderComponent;
  let fixture: ComponentFixture<ScheduleLoaderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ScheduleLoaderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ScheduleLoaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
