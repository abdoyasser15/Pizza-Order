namespace PizzaOrder
{
    partial class Form1
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
            this.gpSize = new System.Windows.Forms.GroupBox();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.lbPizza = new System.Windows.Forms.Label();
            this.gpType = new System.Windows.Forms.GroupBox();
            this.rdThickType = new System.Windows.Forms.RadioButton();
            this.rdThinType = new System.Windows.Forms.RadioButton();
            this.gpToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushroms = new System.Windows.Forms.CheckBox();
            this.chkcheese = new System.Windows.Forms.CheckBox();
            this.gpWhereToEat = new System.Windows.Forms.GroupBox();
            this.rdEatOut = new System.Windows.Forms.RadioButton();
            this.rdEatIn = new System.Windows.Forms.RadioButton();
            this.gpOrderSummary = new System.Windows.Forms.GroupBox();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.lbTakeinOrOut = new System.Windows.Forms.Label();
            this.lbTextSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPriceSummary = new System.Windows.Forms.Label();
            this.lbWhereToEatSummary = new System.Windows.Forms.Label();
            this.lbCrustTyperSummary = new System.Windows.Forms.Label();
            this.lbToppingsSummary = new System.Windows.Forms.Label();
            this.lbSizesummary = new System.Windows.Forms.Label();
            this.btOrderPizza = new System.Windows.Forms.Button();
            this.btResetOrder = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbCount = new System.Windows.Forms.Label();
            this.gpSize.SuspendLayout();
            this.gpType.SuspendLayout();
            this.gpToppings.SuspendLayout();
            this.gpWhereToEat.SuspendLayout();
            this.gpOrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpSize
            // 
            this.gpSize.Controls.Add(this.rdLarge);
            this.gpSize.Controls.Add(this.rdMedium);
            this.gpSize.Controls.Add(this.rdSmall);
            this.gpSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSize.Location = new System.Drawing.Point(30, 67);
            this.gpSize.Name = "gpSize";
            this.gpSize.Size = new System.Drawing.Size(159, 150);
            this.gpSize.TabIndex = 0;
            this.gpSize.TabStop = false;
            this.gpSize.Text = "Size";
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLarge.Location = new System.Drawing.Point(42, 104);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(73, 24);
            this.rdLarge.TabIndex = 4;
            this.rdLarge.TabStop = true;
            this.rdLarge.Text = "Large";
            this.rdLarge.UseVisualStyleBackColor = true;
            this.rdLarge.CheckedChanged += new System.EventHandler(this.rdLarge_CheckedChanged);
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMedium.Location = new System.Drawing.Point(42, 67);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(89, 24);
            this.rdMedium.TabIndex = 3;
            this.rdMedium.TabStop = true;
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = true;
            this.rdMedium.CheckedChanged += new System.EventHandler(this.rdMedium_CheckedChanged);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSmall.Location = new System.Drawing.Point(42, 28);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(72, 24);
            this.rdSmall.TabIndex = 2;
            this.rdSmall.TabStop = true;
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged);
            // 
            // lbPizza
            // 
            this.lbPizza.AutoSize = true;
            this.lbPizza.BackColor = System.Drawing.SystemColors.Control;
            this.lbPizza.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPizza.ForeColor = System.Drawing.Color.Red;
            this.lbPizza.Location = new System.Drawing.Point(317, 9);
            this.lbPizza.Name = "lbPizza";
            this.lbPizza.Size = new System.Drawing.Size(291, 52);
            this.lbPizza.TabIndex = 1;
            this.lbPizza.Text = "Make Your Pizza";
            // 
            // gpType
            // 
            this.gpType.Controls.Add(this.rdThickType);
            this.gpType.Controls.Add(this.rdThinType);
            this.gpType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpType.Location = new System.Drawing.Point(30, 263);
            this.gpType.Name = "gpType";
            this.gpType.Size = new System.Drawing.Size(159, 109);
            this.gpType.TabIndex = 2;
            this.gpType.TabStop = false;
            this.gpType.Text = "Crust Type";
            // 
            // rdThickType
            // 
            this.rdThickType.AutoSize = true;
            this.rdThickType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThickType.Location = new System.Drawing.Point(42, 67);
            this.rdThickType.Name = "rdThickType";
            this.rdThickType.Size = new System.Drawing.Size(70, 24);
            this.rdThickType.TabIndex = 3;
            this.rdThickType.TabStop = true;
            this.rdThickType.Text = "Thick";
            this.rdThickType.UseVisualStyleBackColor = true;
            this.rdThickType.CheckedChanged += new System.EventHandler(this.rdThickType_CheckedChanged);
            // 
            // rdThinType
            // 
            this.rdThinType.AutoSize = true;
            this.rdThinType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThinType.Location = new System.Drawing.Point(42, 28);
            this.rdThinType.Name = "rdThinType";
            this.rdThinType.Size = new System.Drawing.Size(62, 24);
            this.rdThinType.TabIndex = 2;
            this.rdThinType.TabStop = true;
            this.rdThinType.Text = "Thin";
            this.rdThinType.UseVisualStyleBackColor = true;
            this.rdThinType.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // gpToppings
            // 
            this.gpToppings.Controls.Add(this.chkGreenPeppers);
            this.gpToppings.Controls.Add(this.chkOlives);
            this.gpToppings.Controls.Add(this.chkOnions);
            this.gpToppings.Controls.Add(this.chkTomatoes);
            this.gpToppings.Controls.Add(this.chkMushroms);
            this.gpToppings.Controls.Add(this.chkcheese);
            this.gpToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpToppings.Location = new System.Drawing.Point(326, 67);
            this.gpToppings.Name = "gpToppings";
            this.gpToppings.Size = new System.Drawing.Size(268, 150);
            this.gpToppings.TabIndex = 3;
            this.gpToppings.TabStop = false;
            this.gpToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(142, 104);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(126, 22);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Text = "GreenPeppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(142, 67);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(71, 22);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Location = new System.Drawing.Point(142, 31);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(70, 22);
            this.chkOnions.TabIndex = 3;
            this.chkOnions.Text = "Onion";
            this.chkOnions.UseVisualStyleBackColor = true;
            this.chkOnions.CheckedChanged += new System.EventHandler(this.chkOnions_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(27, 106);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(98, 22);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushroms
            // 
            this.chkMushroms.AutoSize = true;
            this.chkMushroms.Location = new System.Drawing.Point(27, 69);
            this.chkMushroms.Name = "chkMushroms";
            this.chkMushroms.Size = new System.Drawing.Size(102, 22);
            this.chkMushroms.TabIndex = 1;
            this.chkMushroms.Text = "Mushroms";
            this.chkMushroms.UseVisualStyleBackColor = true;
            this.chkMushroms.CheckedChanged += new System.EventHandler(this.chkMushroms_CheckedChanged);
            // 
            // chkcheese
            // 
            this.chkcheese.AutoSize = true;
            this.chkcheese.Location = new System.Drawing.Point(27, 31);
            this.chkcheese.Name = "chkcheese";
            this.chkcheese.Size = new System.Drawing.Size(119, 22);
            this.chkcheese.TabIndex = 0;
            this.chkcheese.Text = "Extra Cheese";
            this.chkcheese.UseVisualStyleBackColor = true;
            this.chkcheese.CheckedChanged += new System.EventHandler(this.chkcheese_CheckedChanged);
            // 
            // gpWhereToEat
            // 
            this.gpWhereToEat.Controls.Add(this.rdEatOut);
            this.gpWhereToEat.Controls.Add(this.rdEatIn);
            this.gpWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpWhereToEat.Location = new System.Drawing.Point(326, 281);
            this.gpWhereToEat.Name = "gpWhereToEat";
            this.gpWhereToEat.Size = new System.Drawing.Size(188, 91);
            this.gpWhereToEat.TabIndex = 4;
            this.gpWhereToEat.TabStop = false;
            this.gpWhereToEat.Text = "Where To Eat";
            // 
            // rdEatOut
            // 
            this.rdEatOut.AutoSize = true;
            this.rdEatOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEatOut.Location = new System.Drawing.Point(94, 40);
            this.rdEatOut.Name = "rdEatOut";
            this.rdEatOut.Size = new System.Drawing.Size(82, 24);
            this.rdEatOut.TabIndex = 3;
            this.rdEatOut.TabStop = true;
            this.rdEatOut.Text = "EatOut";
            this.rdEatOut.UseVisualStyleBackColor = true;
            this.rdEatOut.CheckedChanged += new System.EventHandler(this.rdEatOut_CheckedChanged);
            // 
            // rdEatIn
            // 
            this.rdEatIn.AutoSize = true;
            this.rdEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEatIn.Location = new System.Drawing.Point(15, 40);
            this.rdEatIn.Name = "rdEatIn";
            this.rdEatIn.Size = new System.Drawing.Size(73, 24);
            this.rdEatIn.TabIndex = 2;
            this.rdEatIn.TabStop = true;
            this.rdEatIn.Text = "Eat In";
            this.rdEatIn.UseVisualStyleBackColor = true;
            this.rdEatIn.CheckedChanged += new System.EventHandler(this.rdEatIn_CheckedChanged);
            // 
            // gpOrderSummary
            // 
            this.gpOrderSummary.Controls.Add(this.lbTo);
            this.gpOrderSummary.Controls.Add(this.lbPrice);
            this.gpOrderSummary.Controls.Add(this.lbCrustType);
            this.gpOrderSummary.Controls.Add(this.lbTakeinOrOut);
            this.gpOrderSummary.Controls.Add(this.lbTextSize);
            this.gpOrderSummary.Controls.Add(this.label1);
            this.gpOrderSummary.Controls.Add(this.lbPriceSummary);
            this.gpOrderSummary.Controls.Add(this.lbWhereToEatSummary);
            this.gpOrderSummary.Controls.Add(this.lbCrustTyperSummary);
            this.gpOrderSummary.Controls.Add(this.lbToppingsSummary);
            this.gpOrderSummary.Controls.Add(this.lbSizesummary);
            this.gpOrderSummary.Location = new System.Drawing.Point(658, 67);
            this.gpOrderSummary.Name = "gpOrderSummary";
            this.gpOrderSummary.Size = new System.Drawing.Size(320, 367);
            this.gpOrderSummary.TabIndex = 5;
            this.gpOrderSummary.TabStop = false;
            this.gpOrderSummary.Text = "Order Summary";
            this.gpOrderSummary.Enter += new System.EventHandler(this.gpOrderSummary_Enter);
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.Location = new System.Drawing.Point(105, 105);
            this.lbTo.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(93, 18);
            this.lbTo.TabIndex = 10;
            this.lbTo.Text = "No Toppings";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbPrice.Location = new System.Drawing.Point(95, 305);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(53, 38);
            this.lbPrice.TabIndex = 9;
            this.lbPrice.Text = "$0";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustType.Location = new System.Drawing.Point(114, 185);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(0, 20);
            this.lbCrustType.TabIndex = 8;
            // 
            // lbTakeinOrOut
            // 
            this.lbTakeinOrOut.AutoSize = true;
            this.lbTakeinOrOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTakeinOrOut.Location = new System.Drawing.Point(138, 260);
            this.lbTakeinOrOut.Name = "lbTakeinOrOut";
            this.lbTakeinOrOut.Size = new System.Drawing.Size(0, 18);
            this.lbTakeinOrOut.TabIndex = 7;
            // 
            // lbTextSize
            // 
            this.lbTextSize.AutoSize = true;
            this.lbTextSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextSize.Location = new System.Drawing.Point(88, 33);
            this.lbTextSize.Name = "lbTextSize";
            this.lbTextSize.Size = new System.Drawing.Size(0, 20);
            this.lbTextSize.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            this.label1.Visible = false;
            // 
            // lbPriceSummary
            // 
            this.lbPriceSummary.AutoSize = true;
            this.lbPriceSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceSummary.Location = new System.Drawing.Point(17, 289);
            this.lbPriceSummary.Name = "lbPriceSummary";
            this.lbPriceSummary.Size = new System.Drawing.Size(58, 20);
            this.lbPriceSummary.TabIndex = 4;
            this.lbPriceSummary.Text = "Price :";
            // 
            // lbWhereToEatSummary
            // 
            this.lbWhereToEatSummary.AutoSize = true;
            this.lbWhereToEatSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEatSummary.Location = new System.Drawing.Point(17, 228);
            this.lbWhereToEatSummary.Name = "lbWhereToEatSummary";
            this.lbWhereToEatSummary.Size = new System.Drawing.Size(127, 20);
            this.lbWhereToEatSummary.TabIndex = 3;
            this.lbWhereToEatSummary.Text = "Where To Eat  :";
            // 
            // lbCrustTyperSummary
            // 
            this.lbCrustTyperSummary.AutoSize = true;
            this.lbCrustTyperSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustTyperSummary.Location = new System.Drawing.Point(17, 185);
            this.lbCrustTyperSummary.Name = "lbCrustTyperSummary";
            this.lbCrustTyperSummary.Size = new System.Drawing.Size(91, 20);
            this.lbCrustTyperSummary.TabIndex = 2;
            this.lbCrustTyperSummary.Text = "CrustType:";
            // 
            // lbToppingsSummary
            // 
            this.lbToppingsSummary.AutoSize = true;
            this.lbToppingsSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppingsSummary.Location = new System.Drawing.Point(17, 104);
            this.lbToppingsSummary.Name = "lbToppingsSummary";
            this.lbToppingsSummary.Size = new System.Drawing.Size(82, 20);
            this.lbToppingsSummary.TabIndex = 1;
            this.lbToppingsSummary.Text = "Toppings:";
            // 
            // lbSizesummary
            // 
            this.lbSizesummary.AutoSize = true;
            this.lbSizesummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSizesummary.Location = new System.Drawing.Point(17, 33);
            this.lbSizesummary.Name = "lbSizesummary";
            this.lbSizesummary.Size = new System.Drawing.Size(47, 20);
            this.lbSizesummary.TabIndex = 0;
            this.lbSizesummary.Text = "Size:";
            // 
            // btOrderPizza
            // 
            this.btOrderPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrderPizza.Location = new System.Drawing.Point(304, 442);
            this.btOrderPizza.Name = "btOrderPizza";
            this.btOrderPizza.Size = new System.Drawing.Size(114, 43);
            this.btOrderPizza.TabIndex = 6;
            this.btOrderPizza.Text = "OrderPizza";
            this.btOrderPizza.UseVisualStyleBackColor = true;
            this.btOrderPizza.Click += new System.EventHandler(this.btOrderPizza_Click);
            // 
            // btResetOrder
            // 
            this.btResetOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetOrder.Location = new System.Drawing.Point(451, 442);
            this.btResetOrder.Name = "btResetOrder";
            this.btResetOrder.Size = new System.Drawing.Size(114, 43);
            this.btResetOrder.TabIndex = 7;
            this.btResetOrder.Text = "Reset Order";
            this.btResetOrder.UseVisualStyleBackColor = true;
            this.btResetOrder.Click += new System.EventHandler(this.btResetOrder_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(101, 462);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 30);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.Location = new System.Drawing.Point(12, 466);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(71, 25);
            this.lbCount.TabIndex = 9;
            this.lbCount.Text = "Count:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1223, 626);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btResetOrder);
            this.Controls.Add(this.btOrderPizza);
            this.Controls.Add(this.gpOrderSummary);
            this.Controls.Add(this.gpWhereToEat);
            this.Controls.Add(this.gpToppings);
            this.Controls.Add(this.gpType);
            this.Controls.Add(this.lbPizza);
            this.Controls.Add(this.gpSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpSize.ResumeLayout(false);
            this.gpSize.PerformLayout();
            this.gpType.ResumeLayout(false);
            this.gpType.PerformLayout();
            this.gpToppings.ResumeLayout(false);
            this.gpToppings.PerformLayout();
            this.gpWhereToEat.ResumeLayout(false);
            this.gpWhereToEat.PerformLayout();
            this.gpOrderSummary.ResumeLayout(false);
            this.gpOrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpSize;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.Label lbPizza;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.GroupBox gpType;
        private System.Windows.Forms.RadioButton rdThickType;
        private System.Windows.Forms.RadioButton rdThinType;
        private System.Windows.Forms.GroupBox gpToppings;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushroms;
        private System.Windows.Forms.CheckBox chkcheese;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.GroupBox gpWhereToEat;
        private System.Windows.Forms.RadioButton rdEatOut;
        private System.Windows.Forms.RadioButton rdEatIn;
        private System.Windows.Forms.GroupBox gpOrderSummary;
        private System.Windows.Forms.Label lbWhereToEatSummary;
        private System.Windows.Forms.Label lbCrustTyperSummary;
        private System.Windows.Forms.Label lbToppingsSummary;
        private System.Windows.Forms.Label lbSizesummary;
        private System.Windows.Forms.Label lbPriceSummary;
        private System.Windows.Forms.Button btOrderPizza;
        private System.Windows.Forms.Button btResetOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTextSize;
        private System.Windows.Forms.Label lbTakeinOrOut;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbCount;
    }
}

