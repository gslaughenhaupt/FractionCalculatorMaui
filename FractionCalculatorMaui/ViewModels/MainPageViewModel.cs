using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FractionCalculatorMaui.Models;
using FractionCalculatorMaui.Service;

namespace FractionCalculatorMaui.ViewModels
{

    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        int leftWhole;
        [ObservableProperty]
        int leftTop;
        [ObservableProperty]
        int leftBottom;
        [ObservableProperty]
        int rightWhole;
        [ObservableProperty]
        int rightTop;
        [ObservableProperty]
        int rightBottom;
        [ObservableProperty]
        int resultWhole;
        [ObservableProperty]
        int resultTop;
        [ObservableProperty]
        int resultBottom;
        [ObservableProperty]
        string leftAsDecimal;
        [ObservableProperty]
        string rightAsDecimal;
        [ObservableProperty]
        string resultAsDecimal;
        [ObservableProperty]
        string _operator;

        public MainPageViewModel()
        {
            LeftWhole = 0;
            LeftTop = 1;
            LeftBottom = 6;
            RightWhole = 1;
            RightTop = 8;
            RightBottom = 9;
            Operator = "-";
            Calculate();
        }
        [RelayCommand]
        void Add() => Operator = "+";
        [RelayCommand]
        public void Subtract() => Operator = "-";
        [RelayCommand]
        public void Multiply() => Operator = "x";
        [RelayCommand]
        public void Divide() => Operator = "/";
        [RelayCommand]
        public void Calculate()
        {
            Fraction l = new Fraction();
            l.whole = LeftWhole;
            l.top = LeftTop;
            l.bottom = LeftBottom;
            //get right fraction
            Fraction r = new Fraction();
            r.whole = RightWhole;
            r.top = RightTop;
            r.bottom = RightBottom;
            Fraction s = new Fraction();
            bool isResultPositive = true;
            switch (Operator)
            {
                case "+":
                    {
                        s = FractionOperations.Add(l, r);
                        break;
                    }
                case "-":
                    {
                        s = FractionOperations.Subtract(l, r);
                        break;
                    }
                case "x":
                    {
                        s = FractionOperations.Multiply(l, r);
                        break;
                    }
                case "/":
                    {
                        s = FractionOperations.Divide(l, r);
                        break;
                    }
            }
            ResultWhole = s.whole;
            ResultTop = s.top;
            ResultBottom = s.bottom;
            var leftDecimal = l.GetAsDecimal();
            var rightDecimal = r.GetAsDecimal();
            LeftAsDecimal = leftDecimal.ToString("#.##");
            RightAsDecimal = rightDecimal.ToString("#.##");
            if (Operator.Equals("-"))
            {
                
                ResultAsDecimal = (leftDecimal > rightDecimal) ? s.GetAsDecimal().ToString("#.##") : s.GetAsDecimal().ToString("-#.##");
            }
            else
            {
                ResultAsDecimal = s.GetAsDecimal().ToString("#.##");
            }            
        }

    }
}
