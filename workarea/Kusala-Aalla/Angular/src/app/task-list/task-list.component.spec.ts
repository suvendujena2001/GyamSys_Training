import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TaslListComponent } from './task-list.component';

describe('TaslListComponent', () => {
  let component: TaslListComponent;
  let fixture: ComponentFixture<TaslListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TaslListComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TaslListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
