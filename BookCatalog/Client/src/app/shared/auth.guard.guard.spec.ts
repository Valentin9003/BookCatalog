import { TestBed } from '@angular/core/testing';

import { AuthGuardGuard } from './auth.guard.guard';

describe('Auth.GuardGuard', () => {
  let guard: AuthGuardGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(AuthGuardGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
