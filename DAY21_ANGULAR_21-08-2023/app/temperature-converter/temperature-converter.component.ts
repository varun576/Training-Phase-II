import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-temperature-converter',
  templateUrl: './temperature-converter.component.html',
  styleUrls: ['./temperature-converter.component.css']
})
export class TemperatureConverterComponent implements OnInit {
  temperatureForm!: FormGroup;
  convertedTemperature!: string;
  convertedUnit!: string;

  constructor(private fb: FormBuilder) {}

  ngOnInit(): void {
    this.temperatureForm = this.fb.group({
      temperature: [''],
      unit: ['celsius'] // Default unit, you can change this to Fahrenheit
    });
  }

  convertTemperature() {
    const temperature = parseFloat(this.temperatureForm.value.temperature);
    const unit = this.temperatureForm.value.unit;

    if (unit === 'celsius') {
      this.convertedTemperature = ((temperature * 9 / 5) + 32).toFixed(2);
      this.convertedUnit = 'Fahrenheit';
    } else {
      this.convertedTemperature = ((temperature - 32) * 5 / 9).toFixed(2);
      this.convertedUnit = 'Celsius';
    }
  }
}
