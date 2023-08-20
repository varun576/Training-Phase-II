import { Component } from '@angular/core';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent {
  currentInput: string = '0';
  firstOperand: string | null = null;
  operator: string | null = null;
  waitingForSecondOperand: boolean = false;

  handleNumber(number: number) {
    if (this.waitingForSecondOperand) {
      this.currentInput = String(number);
      this.waitingForSecondOperand = false;
    } else {
      this.currentInput === '0'
        ? (this.currentInput = String(number))
        : (this.currentInput += number);
    }
  }

  handleDecimal() {
    if (!this.currentInput.includes('.')) {
      this.currentInput += '.';
    }
  }

  handleOperator(newOperator: string) {
    if (this.operator && !this.waitingForSecondOperand) {
      this.calculate();
    }
    this.firstOperand = this.currentInput;
    this.operator = newOperator;
    this.waitingForSecondOperand = true;
  }

  calculate() {
    if (this.firstOperand === null || this.operator === null) {
      return;
    }
    const secondOperand = this.currentInput;
    switch (this.operator) {
      case '+':
        this.currentInput = String(
          parseFloat(this.firstOperand) + parseFloat(secondOperand)
        );
        break;
      case '-':
        this.currentInput = String(
          parseFloat(this.firstOperand) - parseFloat(secondOperand)
        );
        break;
      case '*':
        this.currentInput = String(
          parseFloat(this.firstOperand) * parseFloat(secondOperand)
        );
        break;
      case '/':
        this.currentInput = String(
          parseFloat(this.firstOperand) / parseFloat(secondOperand)
        );
        break;
    }
    this.operator = null;
    this.firstOperand = null;
  }

  clear() {
    this.currentInput = '0';
    this.firstOperand = null;
    this.operator = null;
    this.waitingForSecondOperand = false;
  }
}
