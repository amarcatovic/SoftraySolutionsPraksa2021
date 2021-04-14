import { Observable } from 'rxjs';

export interface CanComponentDeactivate{
    canDeactivate: () => Observable<boolean> | boolean;
}