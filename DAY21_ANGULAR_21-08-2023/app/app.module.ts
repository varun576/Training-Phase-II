import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { WarningAlertComponent } from './warning-alert/warning-alert.component';
import { SuccessAlertComponent } from './success-alert/success-alert.component';
import { TwowaybindComponent } from './twowaybind/twowaybind.component';
import { CalculatorComponent } from './calculator/calculator.component';
import { TemperatureConverterComponent } from './temperature-converter/temperature-converter.component';
import { ReactiveFormsModule } from '@angular/forms';
import { MortgagecalculatorComponent } from './mortgagecalculator/mortgagecalculator.component';

@NgModule({
  declarations: [
    AppComponent,
    WarningAlertComponent,
    SuccessAlertComponent,
    TwowaybindComponent,
    CalculatorComponent,
    TemperatureConverterComponent,
    MortgagecalculatorComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
