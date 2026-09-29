namespace PizzaProject
{
    partial class frmPizzaOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.lbOR = new System.Windows.Forms.Label();
            this.gbWhereEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblWhereEat = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbTopping.SuspendLayout();
            this.gbWhereEat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(105, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Ehsan";
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Swis721 Blk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbSize.Location = new System.Drawing.Point(12, 141);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 159);
            this.gbSize.TabIndex = 4;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.ForeColor = System.Drawing.Color.White;
            this.rbMedium.Location = new System.Drawing.Point(6, 81);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(135, 33);
            this.rbMedium.TabIndex = 6;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "20";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbLarge.Location = new System.Drawing.Point(6, 127);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(106, 33);
            this.rbLarge.TabIndex = 5;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "25";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbSmall.Location = new System.Drawing.Point(6, 35);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(106, 33);
            this.rbSmall.TabIndex = 4;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Font = new System.Drawing.Font("Swis721 Blk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbCrustType.Location = new System.Drawing.Point(12, 307);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(200, 159);
            this.gbCrustType.TabIndex = 7;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.ForeColor = System.Drawing.Color.White;
            this.rbThickCrust.Location = new System.Drawing.Point(6, 81);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(182, 33);
            this.rbThickCrust.TabIndex = 6;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Tag = "10";
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbThinCrust.Location = new System.Drawing.Point(6, 35);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(166, 33);
            this.rbThinCrust.TabIndex = 4;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbTopping
            // 
            this.gbTopping.BackColor = System.Drawing.Color.Transparent;
            this.gbTopping.Controls.Add(this.lbOR);
            this.gbTopping.Controls.Add(this.chkGreenPeppers);
            this.gbTopping.Controls.Add(this.chkOlives);
            this.gbTopping.Controls.Add(this.chkOnion);
            this.gbTopping.Controls.Add(this.chkTomatoes);
            this.gbTopping.Controls.Add(this.chkMushrooms);
            this.gbTopping.Controls.Add(this.chkExtraCheese);
            this.gbTopping.Font = new System.Drawing.Font("Swis721 Blk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTopping.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbTopping.Location = new System.Drawing.Point(250, 141);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Size = new System.Drawing.Size(219, 370);
            this.gbTopping.TabIndex = 8;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Toppings";
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkExtraCheese.Location = new System.Drawing.Point(0, 42);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(207, 33);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkMushrooms.Location = new System.Drawing.Point(0, 88);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(185, 33);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkTomatoes.Location = new System.Drawing.Point(0, 127);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(163, 33);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkGreenPeppers.Location = new System.Drawing.Point(0, 331);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(227, 33);
            this.chkGreenPeppers.TabIndex = 8;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkOlives.Location = new System.Drawing.Point(0, 291);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(113, 33);
            this.chkOlives.TabIndex = 7;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkOnion.Location = new System.Drawing.Point(0, 247);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(108, 33);
            this.chkOnion.TabIndex = 6;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // lbOR
            // 
            this.lbOR.AutoSize = true;
            this.lbOR.Font = new System.Drawing.Font("Swis721 Blk BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOR.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbOR.Location = new System.Drawing.Point(28, 166);
            this.lbOR.Name = "lbOR";
            this.lbOR.Size = new System.Drawing.Size(135, 77);
            this.lbOR.TabIndex = 9;
            this.lbOR.Text = "OR";
            // 
            // gbWhereEat
            // 
            this.gbWhereEat.BackColor = System.Drawing.Color.Transparent;
            this.gbWhereEat.Controls.Add(this.rbTakeOut);
            this.gbWhereEat.Controls.Add(this.rbEatIn);
            this.gbWhereEat.Font = new System.Drawing.Font("Swis721 Blk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereEat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbWhereEat.Location = new System.Drawing.Point(475, 384);
            this.gbWhereEat.Name = "gbWhereEat";
            this.gbWhereEat.Size = new System.Drawing.Size(200, 121);
            this.gbWhereEat.TabIndex = 7;
            this.gbWhereEat.TabStop = false;
            this.gbWhereEat.Text = "Where to Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.ForeColor = System.Drawing.Color.White;
            this.rbTakeOut.Location = new System.Drawing.Point(6, 81);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(146, 33);
            this.rbTakeOut.TabIndex = 6;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbEatIn.Location = new System.Drawing.Point(6, 35);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(107, 33);
            this.rbEatIn.TabIndex = 4;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat in";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderSummary.Font = new System.Drawing.Font("Swis721 Blk BT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummary.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOrderSummary.Location = new System.Drawing.Point(638, 130);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(284, 39);
            this.lblOrderSummary.TabIndex = 10;
            this.lblOrderSummary.Text = "Order Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Swis721 Blk BT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(714, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Size";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Font = new System.Drawing.Font("Swis721 Blk BT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSize.Location = new System.Drawing.Point(839, 190);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(68, 29);
            this.lblSize.TabIndex = 12;
            this.lblSize.Text = "Size";
            this.lblSize.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(701, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 58);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Swis721 Blk BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblPrice.Location = new System.Drawing.Point(819, 512);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(117, 77);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "0$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Swis721 Blk BT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(672, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "Crust Type";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.BackColor = System.Drawing.Color.Transparent;
            this.lblCrustType.Font = new System.Drawing.Font("Swis721 Blk BT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCrustType.Location = new System.Drawing.Point(853, 239);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(83, 29);
            this.lblCrustType.TabIndex = 15;
            this.lblCrustType.Text = "Think";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.BackColor = System.Drawing.Color.Transparent;
            this.lblE.Font = new System.Drawing.Font("Swis721 Blk BT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblE.Location = new System.Drawing.Point(672, 414);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(195, 33);
            this.lblE.TabIndex = 18;
            this.lblE.Text = "Where to eat";
            // 
            // lblWhereEat
            // 
            this.lblWhereEat.AutoSize = true;
            this.lblWhereEat.BackColor = System.Drawing.Color.Transparent;
            this.lblWhereEat.Font = new System.Drawing.Font("Swis721 Blk BT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereEat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWhereEat.Location = new System.Drawing.Point(873, 418);
            this.lblWhereEat.Name = "lblWhereEat";
            this.lblWhereEat.Size = new System.Drawing.Size(86, 29);
            this.lblWhereEat.TabIndex = 19;
            this.lblWhereEat.Text = "Eat in";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.Location = new System.Drawing.Point(303, 542);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(154, 52);
            this.btnOrderPizza.TabIndex = 20;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.Transparent;
            this.btnResetForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.Black;
            this.btnResetForm.Location = new System.Drawing.Point(586, 542);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(154, 52);
            this.btnResetForm.TabIndex = 21;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblToppings);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(687, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 146);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Swis721 Blk BT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 33);
            this.label4.TabIndex = 17;
            this.label4.Text = "Toppings";
            // 
            // lblToppings
            // 
            this.lblToppings.BackColor = System.Drawing.Color.Transparent;
            this.lblToppings.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblToppings.Location = new System.Drawing.Point(6, 32);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(273, 114);
            this.lblToppings.TabIndex = 18;
            this.lblToppings.Text = "No Toppings";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaProject.Properties.Resources.Gemini_Generated_Image_72039j72039j7203;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.lblWhereEat);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblCrustType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.gbWhereEat);
            this.Controls.Add(this.gbTopping);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbTopping.ResumeLayout(false);
            this.gbTopping.PerformLayout();
            this.gbWhereEat.ResumeLayout(false);
            this.gbWhereEat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbTopping;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.Label lbOR;
        private System.Windows.Forms.GroupBox gbWhereEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblWhereEat;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label label4;
    }
}

