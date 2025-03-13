namespace Calculadora
{
    partial class frmPrincipal
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPrimeiroNumero = new Label();
            txbPrimeiroNumero = new TextBox();
            lblSegundoNumero = new Label();
            txbSegundoNumero = new TextBox();
            btnSomar = new Button();
            lblResultado = new Label();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            SuspendLayout();
            // 
            // lblPrimeiroNumero
            // 
            lblPrimeiroNumero.AutoSize = true;
            lblPrimeiroNumero.Location = new Point(31, 37);
            lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            lblPrimeiroNumero.Size = new Size(141, 15);
            lblPrimeiroNumero.TabIndex = 0;
            lblPrimeiroNumero.Text = "Digite o primeiro número";
            // 
            // txbPrimeiroNumero
            // 
            txbPrimeiroNumero.Location = new Point(31, 55);
            txbPrimeiroNumero.Name = "txbPrimeiroNumero";
            txbPrimeiroNumero.Size = new Size(216, 23);
            txbPrimeiroNumero.TabIndex = 1;
            // 
            // lblSegundoNumero
            // 
            lblSegundoNumero.AutoSize = true;
            lblSegundoNumero.Location = new Point(31, 106);
            lblSegundoNumero.Name = "lblSegundoNumero";
            lblSegundoNumero.Size = new Size(142, 15);
            lblSegundoNumero.TabIndex = 2;
            lblSegundoNumero.Text = "Digite o segundo número";
            // 
            // txbSegundoNumero
            // 
            txbSegundoNumero.Location = new Point(31, 124);
            txbSegundoNumero.Name = "txbSegundoNumero";
            txbSegundoNumero.Size = new Size(216, 23);
            txbSegundoNumero.TabIndex = 3;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(31, 170);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(87, 23);
            btnSomar.TabIndex = 4;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(31, 245);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado";
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(158, 170);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(89, 23);
            btnSubtrair.TabIndex = 6;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(31, 199);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(87, 23);
            btnMultiplicar.TabIndex = 7;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(158, 199);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(89, 23);
            btnDividir.TabIndex = 8;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(285, 323);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(lblResultado);
            Controls.Add(btnSomar);
            Controls.Add(txbSegundoNumero);
            Controls.Add(lblSegundoNumero);
            Controls.Add(txbPrimeiroNumero);
            Controls.Add(lblPrimeiroNumero);
            Name = "frmPrincipal";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrimeiroNumero;
        private TextBox txbPrimeiroNumero;
        private Label lblSegundoNumero;
        private TextBox txbSegundoNumero;
        private Button btnSomar;
        private Label lblResultado;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
    }
}
