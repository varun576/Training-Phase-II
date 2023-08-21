import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  Username: string= '';

  ResetUsername()
  {
    this.Username='';
  }
  buttonDisable(){
    let flag: boolean=false;
    if(this.Username == ''){flag=true;}
    return flag;
  }
  getButtonStyle() {
    if (this.buttonDisable()) {
      return { 'cursor': 'not-allowed' };
    } else {
      return { 'cursor': 'pointer' };
    }
  }
}
