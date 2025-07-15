namespace WindowsFormsApp1
{
    partial class Form2
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
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.chkChees = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.gbEat = new System.Windows.Forms.GroupBox();
            this.rbTakeout = new System.Windows.Forms.RadioButton();
            this.rbEatIN = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbClcTotal = new System.Windows.Forms.Label();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbEat.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(33, 44);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(95, 33);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = false;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMeduim.Location = new System.Drawing.Point(33, 105);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(121, 33);
            this.rbMeduim.TabIndex = 2;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(33, 166);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(96, 33);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(37, 107);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(234, 226);
            this.gbSize.TabIndex = 4;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThin.Location = new System.Drawing.Point(48, 45);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(72, 29);
            this.rbThin.TabIndex = 5;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThick.Location = new System.Drawing.Point(48, 99);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(113, 40);
            this.rbThick.TabIndex = 6;
            this.rbThick.TabStop = true;
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbCrust.Controls.Add(this.rbThick);
            this.gbCrust.Controls.Add(this.rbThin);
            this.gbCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrust.Location = new System.Drawing.Point(37, 376);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(234, 158);
            this.gbCrust.TabIndex = 7;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust Type";
            // 
            // chkChees
            // 
            this.chkChees.AutoSize = true;
            this.chkChees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChees.Location = new System.Drawing.Point(40, 44);
            this.chkChees.Name = "chkChees";
            this.chkChees.Size = new System.Drawing.Size(165, 33);
            this.chkChees.TabIndex = 8;
            this.chkChees.Text = "Extra Chees";
            this.chkChees.UseVisualStyleBackColor = true;
            this.chkChees.CheckedChanged += new System.EventHandler(this.chkChees_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(40, 106);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(161, 33);
            this.chkMushrooms.TabIndex = 9;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.Location = new System.Drawing.Point(40, 166);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(144, 33);
            this.chkTomatoes.TabIndex = 10;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(245, 44);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(100, 33);
            this.chkOnion.TabIndex = 11;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(245, 106);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(103, 33);
            this.chkOlives.TabIndex = 12;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPeppers.Location = new System.Drawing.Point(245, 166);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(200, 33);
            this.chkPeppers.TabIndex = 13;
            this.chkPeppers.Text = "Green Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
            this.chkPeppers.CheckedChanged += new System.EventHandler(this.chkPeppers_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbToppings.Controls.Add(this.chkPeppers);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkChees);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(310, 107);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(454, 226);
            this.gbToppings.TabIndex = 14;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // gbEat
            // 
            this.gbEat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbEat.Controls.Add(this.rbTakeout);
            this.gbEat.Controls.Add(this.rbEatIN);
            this.gbEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEat.Location = new System.Drawing.Point(310, 376);
            this.gbEat.Name = "gbEat";
            this.gbEat.Size = new System.Drawing.Size(234, 158);
            this.gbEat.TabIndex = 8;
            this.gbEat.TabStop = false;
            this.gbEat.Text = "Where to eat";
            // 
            // rbTakeout
            // 
            this.rbTakeout.AutoSize = true;
            this.rbTakeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeout.Location = new System.Drawing.Point(48, 99);
            this.rbTakeout.Name = "rbTakeout";
            this.rbTakeout.Size = new System.Drawing.Size(128, 33);
            this.rbTakeout.TabIndex = 6;
            this.rbTakeout.TabStop = true;
            this.rbTakeout.Text = "Take out";
            this.rbTakeout.UseVisualStyleBackColor = true;
            this.rbTakeout.CheckedChanged += new System.EventHandler(this.rbTakeout_CheckedChanged);
            // 
            // rbEatIN
            // 
            this.rbEatIN.AutoSize = true;
            this.rbEatIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIN.Location = new System.Drawing.Point(48, 45);
            this.rbEatIN.Name = "rbEatIN";
            this.rbEatIN.Size = new System.Drawing.Size(94, 33);
            this.rbEatIN.TabIndex = 5;
            this.rbEatIN.TabStop = true;
            this.rbEatIN.Text = "Eat in";
            this.rbEatIN.UseVisualStyleBackColor = true;
            this.rbEatIN.CheckedChanged += new System.EventHandler(this.rbEatIN_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(651, 508);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(229, 66);
            this.btnOrder.TabIndex = 15;
            this.btnOrder.Text = "ORDER PIZZA";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(669, 590);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(191, 66);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "RESET DATA";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Size : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 77);
            this.label3.TabIndex = 18;
            this.label3.Text = "Topping : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Crust Type : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Where to eat : ";
            // 
            // lbClcTotal
            // 
            this.lbClcTotal.AutoSize = true;
            this.lbClcTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbClcTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClcTotal.Location = new System.Drawing.Point(17, 280);
            this.lbClcTotal.Name = "lbClcTotal";
            this.lbClcTotal.Size = new System.Drawing.Size(161, 29);
            this.lbClcTotal.TabIndex = 21;
            this.lbClcTotal.Text = "Total Price : $";
            // 
            // gbSummary
            // 
            this.gbSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbSummary.Controls.Add(this.lbClcTotal);
            this.gbSummary.Controls.Add(this.label5);
            this.gbSummary.Controls.Add(this.label4);
            this.gbSummary.Controls.Add(this.label3);
            this.gbSummary.Controls.Add(this.label2);
            this.gbSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSummary.Location = new System.Drawing.Point(793, 114);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(308, 336);
            this.gbSummary.TabIndex = 22;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Order Summary";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.download1;
            this.ClientSize = new System.Drawing.Size(1146, 693);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORDER PIZZA";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbEat.ResumeLayout(false);
            this.gbEat.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.CheckBox chkChees;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkPeppers;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbEat;
        private System.Windows.Forms.RadioButton rbTakeout;
        private System.Windows.Forms.RadioButton rbEatIN;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbClcTotal;
        private System.Windows.Forms.GroupBox gbSummary;
    }
}