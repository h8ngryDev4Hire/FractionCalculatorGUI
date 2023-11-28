using System.Drawing.Text;
using System.Collections.Generic;
using System;

namespace FractionCalculatorGUI
{



    public partial class FracCalcGUI : Form
    {
        /// ENUMS for which mode calculator is in
        private enum FRACTION_MODE { NUMERATOR, DENOMINATOR, OPERATIONS, EQUALS};
        private enum DISPLAY_MODE {CURRENT_VALUE, ACCUMULATOR, ERROR};
        private enum OPERATION {ADD, SUBTRACT, MULTIPLY, DIVIDE, NULL};


        /// static bool values
        private bool validSelection = true;
        private bool buttonEnabledBool = false;
        private bool equalButtonEnabled = false;
        private bool operationSelected = false;

        /// static int values
        private int currentValue = 0;
        private int FirstFractionEquationDetector = 0;                                  ///This will keep track of how many fractions since last AC
        private int fracModeIncrementor = 0;                            ///Cycles thru FRACTION_MODE Enum array
        private int numeratorPlaceholder;
        private int denominatorPlaceholder;

        /// static string values
        private string errorMessage = "";

        /// static ENUM values
        private OPERATION currentOperation;
        private DISPLAY_MODE displayMode = DISPLAY_MODE.CURRENT_VALUE;
        private FRACTION_MODE fractionMode = FRACTION_MODE.NUMERATOR;
        

        
        /// static Fraction values.
        static List<Fraction> fractionList = new List<Fraction>();
        private Fraction accumulator = new Fraction(0, 1);                                   ///stores all fractional changes until user hits AC
        private Fraction testValue = new Fraction(0, 1);                           ///Calc calculates this value against accumulator



        public FracCalcGUI()
        {
            InitializeComponent();
        }


        private void UpdateDisplay()
        {
            switch (displayMode)
            {
                case DISPLAY_MODE.CURRENT_VALUE:
                    TextBoxDisplay.Text = currentValue.ToString();
                    break;

                case DISPLAY_MODE.ACCUMULATOR:
                    TextBoxDisplay.Text = accumulator.ToString();
                    break;

                case DISPLAY_MODE.ERROR:
                    TextBoxDisplay.Text = errorMessage.ToString();
                    break;
            }

        }


        /// Methods for which function a button performs when clicked
        private void NumberKeyHit(int number)
        {
            displayMode = DISPLAY_MODE.CURRENT_VALUE;
            currentValue = currentValue * 10 + number;
            UpdateDisplay();
        }

        private void OperationKeyHit(OPERATION op)
        {
            OperationProcess();
            currentOperation = op;

            if (validSelection == true)
            {
                currentValue = 0;
                UpdateDisplay();
            }

            else
            {
                errorMessage = "Cannot Divide by 0";
                displayMode = DISPLAY_MODE.ERROR;
                UpdateDisplay();
            }

        }

        private void OperationProcess()
        {

            validSelection = true;

            switch (currentOperation)
            {
                case OPERATION.ADD:

                    accumulator += testValue;
                    testValue.Set(0, 1);
                    currentValue = 0;
                    labelFractionDisplay.Text = accumulator.ToString(); 
                    UpdateDisplay();
                    buttonFractionMode.Enabled = true;
                    DisableOperationButtons();

                    break;

                case OPERATION.SUBTRACT:
                    
                    accumulator -= testValue;
                    testValue.Set(0, 1);
                    currentValue = 0;
                    labelFractionDisplay.Text = accumulator.ToString(); 
                    UpdateDisplay();
                    buttonFractionMode.Enabled = true;
                    DisableOperationButtons();
                    break;

                case OPERATION.MULTIPLY:

                    accumulator *= testValue;
                    testValue.Set(0, 1);
                    currentValue = 0;
                    labelFractionDisplay.Text = accumulator.ToString(); 
                    UpdateDisplay();
                    buttonFractionMode.Enabled = true;
                    DisableOperationButtons();
                    break;

                case OPERATION.DIVIDE:
                    try
                    {
                        accumulator /= testValue;
                    }
                    catch(DivideByZeroException)
                    {

                        validSelection = false;

                    }

                    testValue.Set(0, 1);
                    currentValue = 0;
                    labelFractionDisplay.Text = accumulator.ToString(); 
                    UpdateDisplay();
                    buttonFractionMode.Enabled = true;
                    DisableOperationButtons();
                    break;
            }
        }










        /// Number Buttons
        private void FracCalcGUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NumberKeyHit(1);
            UpdateDisplay();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            NumberKeyHit(2);
            UpdateDisplay();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            NumberKeyHit(3);
            UpdateDisplay();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            NumberKeyHit(4);
            UpdateDisplay();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberKeyHit(5);
            UpdateDisplay();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            NumberKeyHit(6);
            UpdateDisplay();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            NumberKeyHit(7);
            UpdateDisplay();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            NumberKeyHit(8);
            UpdateDisplay();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            NumberKeyHit(9);
            UpdateDisplay();
        }

        private void button0_Click_1(object sender, EventArgs e)
        {
            NumberKeyHit(0);
            UpdateDisplay();
        }



        /// Operation Buttons
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            currentOperation = OPERATION.ADD;
            buttonFractionMode.Enabled = true;
            operationSelected = true;
            DisableOperationButtons();


        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            currentOperation = OPERATION.SUBTRACT;
            buttonFractionMode.Enabled = true;
            operationSelected = true;
            DisableOperationButtons();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            currentOperation = OPERATION.MULTIPLY;
            buttonFractionMode.Enabled = true;
            operationSelected = true;
            DisableOperationButtons();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            currentOperation = OPERATION.DIVIDE;
            buttonFractionMode.Enabled = true;
            operationSelected = true;
            DisableOperationButtons();
        }




        /// Miscellaneous Buttons
        private void ButtonClearScreen_Click(object sender, EventArgs e)
        {
            currentValue = 0;
            displayMode = DISPLAY_MODE.CURRENT_VALUE;
            UpdateDisplay();
        }

        private void buttonClearAll_Click_1(object sender, EventArgs e)
        {
            currentValue = 0;
            accumulator.Set(0, 1);
            displayMode = DISPLAY_MODE.CURRENT_VALUE;
            currentOperation = OPERATION.NULL;
            UpdateDisplay();
        }



        private void FracCalcGUI_Load_1(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void TextBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            do
            {
                if (fractionMode == FRACTION_MODE.EQUALS)
                {
 
                    FractionModeHandler();
                    labelFractionDisplay.Text = accumulator.ToString();
                    fracModeIncrementor = 2;
                    fractionMode = FRACTION_MODE.OPERATIONS;
                    operationSelected = false;

                    FirstFractionEquationDetector++;

                }
                else
                {
                    switch (fracModeIncrementor)
                    {
                        case 0:
                            fractionMode = FRACTION_MODE.NUMERATOR;
                            FractionModeHandler();
                            fracModeIncrementor++;
                            break;

                        case 1:
                            fractionMode = FRACTION_MODE.DENOMINATOR;
                            FractionModeHandler();
                            fracModeIncrementor++;
                            break;

                        case 2:
                            fractionMode = FRACTION_MODE.OPERATIONS;





                            FractionModeHandler();
                            fracModeIncrementor = 0;
                            
                            break;
                    }
                }

                

            } while (fracModeIncrementor > 2);

            
        }


        private void FractionProcess()
        {
            switch (fractionMode)
            {
                ///This is where the process begins
                ///The Denominator mode updates the numPlaceholder
                ///and the text that displays the current fraction
                case FRACTION_MODE.DENOMINATOR:

                    numeratorPlaceholder = currentValue;
                    labelFractionDisplay.Text = numeratorPlaceholder.ToString();
                    currentValue = 0;
                    
                    break;

                ///This is where the calc is prepping for the operation
                ///that the user is going to enter
                case FRACTION_MODE.OPERATIONS:
                    denominatorPlaceholder = currentValue;
                    labelFractionDisplay.Text = (numeratorPlaceholder + "/" + denominatorPlaceholder).ToString();
                    testValue.Set(numeratorPlaceholder, denominatorPlaceholder);
                    currentValue = 0;
                    break;

                ///This is where the loop is completed and we arrive back
                ///to the calc asking for a numerator
                ///The accumulator has
                case FRACTION_MODE.NUMERATOR:
                    //Fraction f = new Fraction(numeratorPlaceholder, denominatorPlaceholder);



                    currentValue = 0;
                    break;

                case FRACTION_MODE.EQUALS:
                    denominatorPlaceholder = currentValue;
                    testValue.Set(numeratorPlaceholder, denominatorPlaceholder);

                    OperationKeyHit(currentOperation);

                    currentValue = 0;
                    break;


            }
        }



        private void FractionModeHandler()
        {
            switch (fractionMode)
            {
                case FRACTION_MODE.NUMERATOR:

                    FractionProcess();
                    labelFractionMode.Text = "Numerator Mode";
                    buttonFractionMode.Text = "DEN";
                    buttonEnabledBool = false;
                    ButtonEnabled();
                    break;

                case FRACTION_MODE.DENOMINATOR:

                    switch(operationSelected)
                    {
                        case true:

                            FractionProcess();
                            labelFractionMode.Text = "Denominator Mode";
                            buttonFractionMode.Text = "=";
                            buttonEnabledBool = false;

                           
                            fractionMode = FRACTION_MODE.EQUALS;
                            break;

                        case false:
                            FractionProcess();
                            labelFractionMode.Text = "Denominator Mode";
                            buttonFractionMode.Text = "OP";
                            buttonEnabledBool = false;
                            ButtonEnabled();
                            break;
                    }

                    break;

                case FRACTION_MODE.OPERATIONS:
                    FractionProcess();
                    labelFractionMode.Text = "Choose Your Operation";
                    buttonFractionMode.Text = "NUM";
                    buttonEnabledBool = true;
                    ButtonEnabled();
                    break;

                case FRACTION_MODE.EQUALS:
                    FractionProcess();
                    labelFractionMode.Text = "Your Results";
                    buttonFractionMode.Text = "NUM";
                    ButtonEnabled();
                    break;
            }
        }


        private void ButtonEnabled()
        {
            switch (fractionMode)
            {
                case FRACTION_MODE.NUMERATOR:
                    //buttonFractionMode.Enabled = false;
                    button0.Enabled = true;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;
                    button8.Enabled = true;
                    button9.Enabled = true;
                    buttonClearScreen.Enabled = true;

                    buttonDivide.Enabled = false;
                    buttonMinus.Enabled = false;
                    buttonPlus.Enabled = false;
                    buttonMultiply.Enabled = false;
                    break;

                case FRACTION_MODE.DENOMINATOR:
                    //buttonFractionMode.Enabled = false;
                    button0.Enabled = true;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;
                    button8.Enabled = true;
                    button9.Enabled = true;
                    buttonClearScreen.Enabled = true;

                    buttonDivide.Enabled = false;
                    buttonMinus.Enabled = false;
                    buttonPlus.Enabled = false;
                    buttonMultiply.Enabled = false;
                    break;

                case FRACTION_MODE.OPERATIONS:
                    //buttonFractionMode.Enabled = true;
                    button0.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    buttonClearScreen.Enabled = false;
                    buttonFractionMode.Enabled = false;

                    buttonDivide.Enabled = true;
                    buttonMinus.Enabled = true;
                    buttonPlus.Enabled = true;
                    buttonMultiply.Enabled = true;
                    //buttonEqual.Enabled = true;
                    break;

                case FRACTION_MODE.EQUALS:
                    button0.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;

                    buttonDivide.Enabled = false;
                    buttonMinus.Enabled = false;
                    buttonPlus.Enabled = false;
                    buttonMultiply.Enabled = false;
                    break;

            }

        }

        private void DisableOperationButtons()
        {
            buttonDivide.Enabled = false;
            buttonMinus.Enabled = false;
            buttonPlus.Enabled = false;
            buttonMultiply.Enabled = false;

        }


    }
}