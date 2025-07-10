namespace CalculatorApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        buttonSeven = new System.Windows.Forms.Button();
        buttonEight = new System.Windows.Forms.Button();
        buttonNine = new System.Windows.Forms.Button();
        buttonAstherics = new System.Windows.Forms.Button();
        buttonFour = new System.Windows.Forms.Button();
        buttonFive = new System.Windows.Forms.Button();
        buttonSix = new System.Windows.Forms.Button();
        buttonSlash = new System.Windows.Forms.Button();
        buttonOne = new System.Windows.Forms.Button();
        buttonTwo = new System.Windows.Forms.Button();
        buttonThree = new System.Windows.Forms.Button();
        buttonMinus = new System.Windows.Forms.Button();
        buttonC = new System.Windows.Forms.Button();
        buttonCE = new System.Windows.Forms.Button();
        buttonZero = new System.Windows.Forms.Button();
        buttonDot = new System.Windows.Forms.Button();
        buttonPlus = new System.Windows.Forms.Button();
        buttonEqual = new System.Windows.Forms.Button();
        textBoxResult = new System.Windows.Forms.TextBox();
        labelCurrentOperation = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // buttonSeven
        // 
        buttonSeven.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonSeven.Location = new System.Drawing.Point(12, 117);
        buttonSeven.Name = "buttonSeven";
        buttonSeven.Size = new System.Drawing.Size(72, 76);
        buttonSeven.TabIndex = 0;
        buttonSeven.Text = "7";
        buttonSeven.UseVisualStyleBackColor = true;
        buttonSeven.Click += ButtonClick;
        // 
        // buttonEight
        // 
        buttonEight.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonEight.Location = new System.Drawing.Point(90, 117);
        buttonEight.Name = "buttonEight";
        buttonEight.Size = new System.Drawing.Size(72, 76);
        buttonEight.TabIndex = 2;
        buttonEight.Text = "8";
        buttonEight.UseVisualStyleBackColor = true;
        buttonEight.Click += ButtonClick;
        // 
        // buttonNine
        // 
        buttonNine.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonNine.Location = new System.Drawing.Point(168, 117);
        buttonNine.Name = "buttonNine";
        buttonNine.Size = new System.Drawing.Size(72, 76);
        buttonNine.TabIndex = 3;
        buttonNine.Text = "9";
        buttonNine.UseVisualStyleBackColor = true;
        buttonNine.Click += ButtonClick;
        // 
        // buttonAstherics
        // 
        buttonAstherics.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonAstherics.Location = new System.Drawing.Point(246, 117);
        buttonAstherics.Name = "buttonAstherics";
        buttonAstherics.Size = new System.Drawing.Size(72, 76);
        buttonAstherics.TabIndex = 4;
        buttonAstherics.Text = "*";
        buttonAstherics.UseVisualStyleBackColor = true;
        buttonAstherics.Click += OperatorClick;
        // 
        // buttonFour
        // 
        buttonFour.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonFour.Location = new System.Drawing.Point(12, 199);
        buttonFour.Name = "buttonFour";
        buttonFour.Size = new System.Drawing.Size(72, 76);
        buttonFour.TabIndex = 5;
        buttonFour.Text = "4";
        buttonFour.UseVisualStyleBackColor = true;
        buttonFour.Click += ButtonClick;
        // 
        // buttonFive
        // 
        buttonFive.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonFive.Location = new System.Drawing.Point(90, 199);
        buttonFive.Name = "buttonFive";
        buttonFive.Size = new System.Drawing.Size(72, 76);
        buttonFive.TabIndex = 6;
        buttonFive.Text = "5";
        buttonFive.UseVisualStyleBackColor = true;
        buttonFive.Click += ButtonClick;
        // 
        // buttonSix
        // 
        buttonSix.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonSix.Location = new System.Drawing.Point(168, 199);
        buttonSix.Name = "buttonSix";
        buttonSix.Size = new System.Drawing.Size(72, 76);
        buttonSix.TabIndex = 6;
        buttonSix.Text = "6";
        buttonSix.UseVisualStyleBackColor = true;
        buttonSix.Click += ButtonClick;
        // 
        // buttonSlash
        // 
        buttonSlash.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonSlash.Location = new System.Drawing.Point(246, 199);
        buttonSlash.Name = "buttonSlash";
        buttonSlash.Size = new System.Drawing.Size(72, 76);
        buttonSlash.TabIndex = 8;
        buttonSlash.Text = "/";
        buttonSlash.UseVisualStyleBackColor = true;
        buttonSlash.Click += OperatorClick;
        // 
        // buttonOne
        // 
        buttonOne.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonOne.Location = new System.Drawing.Point(12, 281);
        buttonOne.Name = "buttonOne";
        buttonOne.Size = new System.Drawing.Size(72, 76);
        buttonOne.TabIndex = 9;
        buttonOne.Text = "1";
        buttonOne.UseVisualStyleBackColor = true;
        buttonOne.Click += ButtonClick;
        // 
        // buttonTwo
        // 
        buttonTwo.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonTwo.Location = new System.Drawing.Point(90, 281);
        buttonTwo.Name = "buttonTwo";
        buttonTwo.Size = new System.Drawing.Size(72, 76);
        buttonTwo.TabIndex = 10;
        buttonTwo.Text = "2";
        buttonTwo.UseVisualStyleBackColor = true;
        buttonTwo.Click += ButtonClick;
        // 
        // buttonThree
        // 
        buttonThree.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonThree.Location = new System.Drawing.Point(168, 281);
        buttonThree.Name = "buttonThree";
        buttonThree.Size = new System.Drawing.Size(72, 76);
        buttonThree.TabIndex = 11;
        buttonThree.Text = "3";
        buttonThree.UseVisualStyleBackColor = true;
        buttonThree.Click += ButtonClick;
        // 
        // buttonMinus
        // 
        buttonMinus.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonMinus.Location = new System.Drawing.Point(246, 281);
        buttonMinus.Name = "buttonMinus";
        buttonMinus.Size = new System.Drawing.Size(72, 76);
        buttonMinus.TabIndex = 12;
        buttonMinus.Text = "-";
        buttonMinus.UseVisualStyleBackColor = true;
        buttonMinus.Click += OperatorClick;
        // 
        // buttonC
        // 
        buttonC.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonC.Location = new System.Drawing.Point(324, 117);
        buttonC.Name = "buttonC";
        buttonC.Size = new System.Drawing.Size(72, 76);
        buttonC.TabIndex = 13;
        buttonC.Text = "C";
        buttonC.UseVisualStyleBackColor = true;
        buttonC.Click += ClearClick;
        // 
        // buttonCE
        // 
        buttonCE.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonCE.Location = new System.Drawing.Point(324, 199);
        buttonCE.Name = "buttonCE";
        buttonCE.Size = new System.Drawing.Size(72, 76);
        buttonCE.TabIndex = 14;
        buttonCE.Text = "CE";
        buttonCE.UseVisualStyleBackColor = true;
        buttonCE.Click += CEClick;
        // 
        // buttonZero
        // 
        buttonZero.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonZero.Location = new System.Drawing.Point(12, 363);
        buttonZero.Name = "buttonZero";
        buttonZero.Size = new System.Drawing.Size(150, 76);
        buttonZero.TabIndex = 16;
        buttonZero.Text = "0";
        buttonZero.UseVisualStyleBackColor = true;
        buttonZero.Click += ButtonClick;
        // 
        // buttonDot
        // 
        buttonDot.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonDot.Location = new System.Drawing.Point(168, 363);
        buttonDot.Name = "buttonDot";
        buttonDot.Size = new System.Drawing.Size(72, 76);
        buttonDot.TabIndex = 17;
        buttonDot.Text = ",";
        buttonDot.UseVisualStyleBackColor = true;
        buttonDot.Click += ButtonClick;
        // 
        // buttonPlus
        // 
        buttonPlus.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonPlus.Location = new System.Drawing.Point(246, 361);
        buttonPlus.Name = "buttonPlus";
        buttonPlus.Size = new System.Drawing.Size(72, 76);
        buttonPlus.TabIndex = 18;
        buttonPlus.Text = "+";
        buttonPlus.UseVisualStyleBackColor = true;
        buttonPlus.Click += OperatorClick;
        // 
        // buttonEqual
        // 
        buttonEqual.Font = new System.Drawing.Font("Segoe UI", 12F);
        buttonEqual.Location = new System.Drawing.Point(325, 281);
        buttonEqual.Name = "buttonEqual";
        buttonEqual.Size = new System.Drawing.Size(72, 156);
        buttonEqual.TabIndex = 19;
        buttonEqual.Text = "=";
        buttonEqual.UseVisualStyleBackColor = true;
        buttonEqual.Click += EqualClick;
        // 
        // textBoxResult
        // 
        textBoxResult.Font = new System.Drawing.Font("Segoe UI", 14F);
        textBoxResult.Location = new System.Drawing.Point(13, 67);
        textBoxResult.Name = "textBoxResult";
        textBoxResult.Size = new System.Drawing.Size(384, 39);
        textBoxResult.TabIndex = 20;
        textBoxResult.Text = "0";
        textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // labelCurrentOperation
        // 
        labelCurrentOperation.Font = new System.Drawing.Font("Segoe UI", 12F);
        labelCurrentOperation.Location = new System.Drawing.Point(13, 32);
        labelCurrentOperation.Name = "labelCurrentOperation";
        labelCurrentOperation.Size = new System.Drawing.Size(295, 32);
        labelCurrentOperation.TabIndex = 21;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(409, 449);
        Controls.Add(labelCurrentOperation);
        Controls.Add(textBoxResult);
        Controls.Add(buttonEqual);
        Controls.Add(buttonPlus);
        Controls.Add(buttonDot);
        Controls.Add(buttonZero);
        Controls.Add(buttonCE);
        Controls.Add(buttonC);
        Controls.Add(buttonMinus);
        Controls.Add(buttonThree);
        Controls.Add(buttonTwo);
        Controls.Add(buttonOne);
        Controls.Add(buttonSlash);
        Controls.Add(buttonSix);
        Controls.Add(buttonFive);
        Controls.Add(buttonFour);
        Controls.Add(buttonAstherics);
        Controls.Add(buttonNine);
        Controls.Add(buttonEight);
        Controls.Add(buttonSeven);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        MaximizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Calculator";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label labelCurrentOperation;

    private System.Windows.Forms.TextBox textBoxResult;

    private System.Windows.Forms.Button buttonNine;
    private System.Windows.Forms.Button buttonEight;
    private System.Windows.Forms.Button buttonAstherics;
    private System.Windows.Forms.Button buttonFour;
    private System.Windows.Forms.Button buttonFive;
    private System.Windows.Forms.Button buttonSix;
    private System.Windows.Forms.Button buttonSlash;
    private System.Windows.Forms.Button buttonOne;
    private System.Windows.Forms.Button buttonTwo;
    private System.Windows.Forms.Button buttonThree;
    private System.Windows.Forms.Button buttonMinus;
    private System.Windows.Forms.Button buttonC;
    private System.Windows.Forms.Button buttonCE;
    private System.Windows.Forms.Button buttonZero;
    private System.Windows.Forms.Button buttonDot;
    private System.Windows.Forms.Button buttonPlus;
    private System.Windows.Forms.Button buttonEqual;

    private System.Windows.Forms.Button buttonSeven;

    #endregion
}