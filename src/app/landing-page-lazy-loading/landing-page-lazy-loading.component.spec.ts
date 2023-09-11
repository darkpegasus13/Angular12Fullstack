import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LandingPageLazyLoadingComponent } from './landing-page-lazy-loading.component';

describe('LandingPageLazyLoadingComponent', () => {
  let component: LandingPageLazyLoadingComponent;
  let fixture: ComponentFixture<LandingPageLazyLoadingComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [LandingPageLazyLoadingComponent]
    });
    fixture = TestBed.createComponent(LandingPageLazyLoadingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
