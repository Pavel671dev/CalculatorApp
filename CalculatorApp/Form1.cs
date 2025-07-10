using System.Diagnostics.Eventing.Reader;

namespace CalculatorApp;

public partial class Form1 : Form
{
    private string _operation = "";
    private double _resultValue;
    private bool _isPerformed;
    public Form1()
    {
        InitializeComponent();
    }
    
    

    private void ButtonClick(object sender, EventArgs e)
    {
        // Method is used for 0123456789 and , buttons
        _isPerformed = false;
        Button button = (Button)sender;
        if ((textBoxResult.Text == "0") && (button.Text != ","))
            textBoxResult.Clear();
        // Separator is not added if it already exists in number
        if ((button.Text != ",") || !(textBoxResult.Text.Contains(",")))
            textBoxResult.Text = textBoxResult.Text + button.Text;

    }

    private void OperatorClick(object sender, EventArgs e)
    {
        // Method is used for +-/* buttons
        if (_isPerformed)
            return;
        Button  button = (Button)sender;
        _operation = button.Text;
        _resultValue = double.Parse(textBoxResult.Text);
        // First typed number and operation will be displayed under the line with result
        labelCurrentOperation.Text = (textBoxResult.Text + _operation);
        _isPerformed = true;
        textBoxResult.Text = "0";
    }

    private void ClearClick(object sender, EventArgs e)
    {
        // Method removes all numbers and operation
        textBoxResult.Text = "0";
        _resultValue = 0;
        labelCurrentOperation.Text = "";
    }

    private void CEClick(object sender, EventArgs e)
    {
        // Method removes only current number
        textBoxResult.Text = "0";
    }

    private void EqualClick(object sender, EventArgs e)
    {
        switch (_operation)
        {
            case "+":
                textBoxResult.Text = (_resultValue + double.Parse(textBoxResult.Text)).ToString();
                break;
            case "-":
                textBoxResult.Text = (_resultValue - double.Parse(textBoxResult.Text)).ToString();
                break;
            case "*":
                textBoxResult.Text = (_resultValue * double.Parse(textBoxResult.Text)).ToString();
                break;
            case "/":
                    // When divided by zero returns infinity
                    textBoxResult.Text = (_resultValue / double.Parse(textBoxResult.Text)).ToString();
                break;
            default:
                break;
        }
    }
}