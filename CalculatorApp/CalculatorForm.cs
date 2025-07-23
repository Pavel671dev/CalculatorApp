using System.Diagnostics.Eventing.Reader;

namespace CalculatorApp;

public class CalculatorForm : Form
{
    private System.ComponentModel.IContainer components = null;
    
    private string operation = "";
    private double resultValue;
    private bool isPerformed;

    private Label labelCurrentOperation;

    private TextBox textBoxResult;

    private Button buttonOne;
    private Button buttonTwo;
    private Button buttonThree;
    private Button buttonFour;
    private Button buttonFive;
    private Button buttonSix;
    private Button buttonSeven;
    private Button buttonEight;
    private Button buttonNine;
    private Button buttonZero;
    private Button buttonPlus;
    private Button buttonMinus;
    private Button buttonSlash;
    private Button buttonAstherics;
    private Button buttonDot;
    private Button buttonEqual;
    private Button buttonC;
    private Button buttonCE;
    
    public CalculatorForm()
    {
        InitializeComponent();
    }
    
    public void UnuniqueNumberProperties(Button button)
    {
        
        button.Font = new Font("Segoe UI", 12F);
        button.Size = new Size(72, 76);
        button.UseVisualStyleBackColor = true;
        button.Click += ButtonClick;
        Controls.Add(button);
    }

    public void UnuniqueOperationProperties(Button button)
    {
        button.Font = new Font("Segoe UI", 12F);
        button.Size = new Size(72, 76);
        button.UseVisualStyleBackColor = true;
        button.Click += OperatorClick;
        Controls.Add(button);
    }
    public void InitializeButtonOne()
    {
        buttonOne = new Button();
        UnuniqueNumberProperties(buttonOne);
        buttonOne.Location = new Point(12, 281);
        buttonOne.Name = "buttonOne";
        buttonOne.TabIndex = 9;
        buttonOne.Text = "1";
    }

    public void InitializeButtonTwo()
    {
        buttonTwo = new Button();
        UnuniqueNumberProperties(buttonTwo);
        buttonTwo.Location = new Point(90, 281);
        buttonTwo.Name = "buttonTwo";
        buttonTwo.TabIndex = 10;
        buttonTwo.Text = "2";
    }
    
    public void InitializeButtonThree()
    {
        buttonThree = new Button();
        UnuniqueNumberProperties(buttonThree);
        buttonThree.Location = new Point(168, 281);
        buttonThree.Name = "buttonThree";
        buttonThree.TabIndex = 11;
        buttonThree.Text = "3";
    }

    public void InitializeButtonFour()
    {
        buttonFour = new Button();
        UnuniqueNumberProperties(buttonFour);
        buttonFour.Location = new Point(12, 199);
        buttonFour.Name = "buttonFour";
        buttonFour.TabIndex = 5;
        buttonFour.Text = "4";
    }
    public void InitializeButtonFive()
    {
        buttonFive = new Button();
        UnuniqueNumberProperties(buttonFive);
        buttonFive.Location = new Point(90, 199);
        buttonFive.Name = "buttonFive";
        buttonFive.TabIndex = 6;
        buttonFive.Text = "5";
    }

    public void InitializeButtonSix()
    {
        buttonSix = new Button();
        UnuniqueNumberProperties(buttonSix);
        buttonSix.Location = new Point(168, 199);
        buttonSix.Name = "buttonSix";
        buttonSix.TabIndex = 6;
        buttonSix.Text = "6";
    }

    public void InitializeButtonSeven()
    {
        buttonSeven = new Button();
        UnuniqueNumberProperties(buttonSeven);
        buttonSeven.Location = new Point(12, 117);
        buttonSeven.Name = "buttonSeven";
        buttonSeven.TabIndex = 0;
        buttonSeven.Text = "7";
    }

    public void InitializeButtonEight()
    {
        buttonEight = new Button();
        UnuniqueNumberProperties(buttonEight);
        buttonEight.Location = new Point(90, 117);
        buttonEight.Name = "buttonEight";
        buttonEight.TabIndex = 2;
        buttonEight.Text = "8";
    }

    public void InitializeButtonNine()
    {
        buttonNine = new Button();
        UnuniqueNumberProperties(buttonNine);
        buttonNine.Location = new Point(168, 117);
        buttonNine.Name = "buttonNine";
        buttonNine.TabIndex = 3;
        buttonNine.Text = "9";
    }

    public void InitializeButtonZero()
    {
        buttonZero = new Button();
        UnuniqueNumberProperties(buttonZero);
        buttonZero.Size = new Size(150, 76);
        buttonZero.Location = new Point(12, 363);
        buttonZero.Name = "buttonZero";
        buttonZero.TabIndex = 16;
        buttonZero.Text = "0";
    }

    public void InitializeButtonDot()
    {
        buttonDot = new Button();
        UnuniqueNumberProperties(buttonDot);
        buttonDot.Location = new Point(168, 363);
        buttonDot.Name = "buttonDot";
        buttonDot.TabIndex = 17;
        buttonDot.Text = ",";
    }

    public void InitializeButtonPlus()
    {
        buttonPlus = new Button();
        UnuniqueOperationProperties(buttonPlus);
        buttonPlus.Location = new Point(246, 361);
        buttonPlus.Name = "buttonPlus";
        buttonPlus.TabIndex = 18;
        buttonPlus.Text = "+";
    }

    public void InitializeButtonMinus()
    {
        buttonMinus = new Button();
        UnuniqueOperationProperties(buttonMinus);
        buttonMinus.Location = new Point(246, 281);
        buttonMinus.Name = "buttonMinus";
        buttonMinus.TabIndex = 12;
        buttonMinus.Text = "-";
    }

    public void InitializeButtonAstherics()
    {
        buttonAstherics = new Button();
        UnuniqueOperationProperties(buttonAstherics);
        buttonAstherics.Location = new Point(246, 117);
        buttonAstherics.Name = "buttonAstherics";
        buttonAstherics.TabIndex = 4;
        buttonAstherics.Text = "*";
    }

    public void InitializeButtonSlash()
    {
        buttonSlash = new Button();
        UnuniqueOperationProperties(buttonSlash);
        buttonSlash.Location = new Point(246, 199);
        buttonSlash.Name = "buttonSlash";
        buttonSlash.TabIndex = 8;
        buttonSlash.Text = "/";
    }

    public void InitializeButtonEqual()
    {
        buttonEqual = new Button();
        buttonEqual.Font = new Font("Segoe UI", 12F);
        buttonEqual.Location = new Point(325, 281);
        buttonEqual.Name = "buttonEqual";
        buttonEqual.Size = new Size(72, 156);
        buttonEqual.TabIndex = 19;
        buttonEqual.Text = "=";
        buttonEqual.UseVisualStyleBackColor = true;
        buttonEqual.Click += EqualClick;
        Controls.Add(buttonEqual);
    }

    public void InitializeButtonC()
    {
        buttonC = new Button();
        buttonC.Font = new Font("Segoe UI", 12F);
        buttonC.Location = new Point(324, 117);
        buttonC.Name = "buttonC";
        buttonC.Size = new Size(72, 76);
        buttonC.TabIndex = 13;
        buttonC.Text = "C";
        buttonC.UseVisualStyleBackColor = true;
        buttonC.Click += ClearClick;
        Controls.Add(buttonC);
    }

    public void InitializeButtonCE()
    {
        buttonCE = new Button();
        buttonCE.Font = new Font("Segoe UI", 12F);
        buttonCE.Location = new Point(324, 199);
        buttonCE.Name = "buttonCE";
        buttonCE.Size = new Size(72, 76);
        buttonCE.TabIndex = 14;
        buttonCE.Text = "CE";
        buttonCE.UseVisualStyleBackColor = true;
        buttonCE.Click += CEClick;
        Controls.Add(buttonCE);
    }

    public void InitializeBoxResult()
    {
        textBoxResult = new TextBox();
        textBoxResult.Font = new Font("Segoe UI", 14F);
        textBoxResult.Location = new Point(13, 67);
        textBoxResult.Name = "textBoxResult";
        textBoxResult.Size = new Size(384, 39);
        textBoxResult.TabIndex = 20;
        textBoxResult.Text = "0";
        textBoxResult.TextAlign = HorizontalAlignment.Right;
        Controls.Add(textBoxResult);
    }

    public void InitializeLabelCurrent()
    {
        labelCurrentOperation = new Label();
        labelCurrentOperation.Font = new Font("Segoe UI", 12F);
        labelCurrentOperation.Location = new Point(13, 32);
        labelCurrentOperation.Name = "labelCurrentOperation";
        labelCurrentOperation.Size = new Size(295, 32);
        labelCurrentOperation.TabIndex = 21;
        Controls.Add(labelCurrentOperation);
    }
    public void InitializeComponent()
    {
        InitializeButtonOne();
        InitializeButtonTwo();
        InitializeButtonThree();
        InitializeButtonFour();
        InitializeButtonFive();
        InitializeButtonSix();
        InitializeButtonSeven();
        InitializeButtonEight();
        InitializeButtonNine();
        InitializeButtonZero();
        InitializeButtonDot();
        InitializeButtonPlus();
        InitializeButtonMinus();
        InitializeButtonAstherics();
        InitializeButtonSlash();
        InitializeButtonEqual();
        InitializeButtonC();
        InitializeButtonCE();
        InitializeBoxResult();
        InitializeLabelCurrent();

        SuspendLayout();

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(409, 449);
        
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Calculator";
        ResumeLayout(false);
        PerformLayout();
    }
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }
    private void ButtonClick(object sender, EventArgs e)
    {
        // Method is used for 0123456789 and , buttons
        isPerformed = false;
        Button button = (Button)sender;
        if (textBoxResult.Text == "Error") textBoxResult.Text = "0";
        if ((textBoxResult.Text == "0") && (button.Text != ","))
            textBoxResult.Clear();
        // Separator is not added if it already exists in number
        if (button.Text != "," || !textBoxResult.Text.Contains(","))
            textBoxResult.Text = textBoxResult.Text + button.Text;

    }

    private void OperatorClick(object sender, EventArgs e)
    {
        // Method is used for +-/* buttons
        if (textBoxResult.Text == "Error")
            textBoxResult.Text = "0";
        if (isPerformed)
            return;
        Button button = (Button)sender;
        operation = button.Text;
        resultValue = double.Parse(textBoxResult.Text);
        // First typed number and operation will be displayed under the line with result
        labelCurrentOperation.Text = (textBoxResult.Text + operation);
        isPerformed = true;
        textBoxResult.Text = "0";
    }

    private void ClearClick(object sender, EventArgs e)
    {
        // Method removes all numbers and operation
        textBoxResult.Text = "0";
        resultValue = 0;
        labelCurrentOperation.Text = "";
    }

    private void CEClick(object sender, EventArgs e)
    {
        textBoxResult.Text = "0";
    }

    private string HandleClickPlus()
    {
        return (resultValue + double.Parse(textBoxResult.Text)).ToString();
    }
    
    private string HandleClickMinus()
    {
        return (resultValue - double.Parse(textBoxResult.Text)).ToString();
    }
    private string HandleClickAstherics()
    {
        return (resultValue * double.Parse(textBoxResult.Text)).ToString();
    }
    private string HandleClickDivide()
    {
        return (double.Parse(textBoxResult.Text) == 0) ? "Error" : (resultValue / double.Parse(textBoxResult.Text)).ToString();
    }
    
    private void EqualClick(object sender, EventArgs e)
    {
        switch (operation)
        {
            case "+":
                textBoxResult.Text = HandleClickPlus();
                break;
            case "-":
                textBoxResult.Text = HandleClickMinus();
                break;
            case "*":
                textBoxResult.Text = HandleClickAstherics();
                break;
            case "/":
                textBoxResult.Text = HandleClickDivide();
                break;
            default:
                return;
        }
    }
}