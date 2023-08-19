import { Component } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})
export class ServersComponent {
serverId:number=122;
serverStatus:string='offline';

getServerId(){
  return this.serverId;
}

getserverstatus(){
  return this.serverStatus;
}

addNewServer:Boolean= false;
serverCreated:string='not Yet';

ServerName : string = '';

serverList= ['SQL','Oracle'];
serverNumbers= ['101','444'];
onServerCreation(){
  this.serverCreated="Created";
  this.serverList.push(this.ServerName);
}
constructor(){
  setTimeout(()=>{
    this.addNewServer= true;
  },5000);

  this.serverStatus = Math.random()>0.5?'online':'offline';
  this.serverStatus =='online'?'green':'red';
}
getcolor(){
  return this.serverStatus =='online'?'green':'red';
}



// onserverNameEntry(event:Event){
//   console.log(event);
//   this.ServerName=(<HTMLInputElement>event.target).value;
// }
}
