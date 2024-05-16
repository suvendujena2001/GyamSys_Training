import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TaskWatchComponent } from './task-watch.component';

describe('TaskWatchComponent', () => {
  let component: TaskWatchComponent;
  let fixture: ComponentFixture<TaskWatchComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TaskWatchComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TaskWatchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
