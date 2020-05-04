import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AvailableStaffListComponent } from './available-staff-list.component';

describe('AvailableStaffListComponent', () => {
  let component: AvailableStaffListComponent;
  let fixture: ComponentFixture<AvailableStaffListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AvailableStaffListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AvailableStaffListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
