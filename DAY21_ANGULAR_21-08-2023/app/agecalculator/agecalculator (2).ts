import { Component } from '@angular/core';

@Component({
  selector: 'app-mortgagecalculator',
  templateUrl: './mortgagecalculator.component.html',
  styleUrls: ['./mortgagecalculator.component.css']
})
export class MortgagecalculatorComponent {


  purchasePrice: number = 0;
  downPayment: number = 0;
  repaymentTime: number = 1; 
  interestRate: number = 0;
  loanAmount: number = 0;
  monthlyPayment: number = 0;

  calculateMortgage(): void {
    this.loanAmount = this.purchasePrice - this.downPayment;
    const monthlyInterestRate = (this.interestRate / 100) / 12;
    const totalPayments = this.repaymentTime * 12;
    this.monthlyPayment = (this.loanAmount * monthlyInterestRate) / (1 - Math.pow(1 + monthlyInterestRate, -totalPayments));
  }
}
