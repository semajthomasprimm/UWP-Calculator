using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MainViewModel ViewModel;
        public MainPage()
        {
            InitializeComponent();
            // init ModelView with currentValueTxt and calculationTxt; does view update??
            ViewModel = new MainViewModel(currentValueTxt, calculationTxt);
        }

        // Number buttons

        private void SevenBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleNumberButtonClick(sevenBtn.Content.ToString());   
        }

        private void EightBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleNumberButtonClick(eightBtn.Content.ToString());
        }

        private void NineBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleNumberButtonClick(nineBtn.Content.ToString());
        }

        private void FourBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleNumberButtonClick(fourBtn.Content.ToString());
        }

        private void FiveBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleNumberButtonClick(fiveBtn.Content.ToString());
        }

        private void SixBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleNumberButtonClick(sixBtn.Content.ToString());
        }

        private void OneBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleNumberButtonClick(oneBtn.Content.ToString());
        }

        private void TwoBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleNumberButtonClick(twoBtn.Content.ToString());
        }

        private void ThreeBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleNumberButtonClick(threeBtn.Content.ToString());
        }

        private void ZeroBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleNumberButtonClick(zeroBtn.Content.ToString());
        }

        // Operations
        private void DivisionBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleOperationButtonClick(divisionBtn.Content.ToString());
        }

        private void MultiplyBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleOperationButtonClick(multiplyBtn.Content.ToString());
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleOperationButtonClick(minusBtn.Content.ToString());
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleOperationButtonClick(plusBtn.Content.ToString());
        }

        private void DecimalBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleDecimalButtonClick();
        }

        private void AcBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleACButtonClick(); // set textboxes to default
        }

        private void PosNegateBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleOperationButtonClick(posNegateBtn.Content.ToString());
        }

        private void ModulusBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleOperationButtonClick(modulusBtn.Content.ToString());
        }

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.HandleEqualsButtonClick();
        }

        // Handle resizing of currentValueTxtBlock, make text smaller if length is 12 letters
        private void CurrentValueTxt_SelectionChanged(object sender, RoutedEventArgs e)
        {
            // TODO: implement ViewModel.ResizeTxtBlock();
        }
    }
}
