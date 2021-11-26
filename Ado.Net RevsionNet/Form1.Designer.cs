namespace Ado.Net_RevsionNet
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
            this.textid = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnShowInDgv = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnUpadte = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnModifere = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnpervouis = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(44, 43);
            this.textid.Multiline = true;
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(158, 32);
            this.textid.TabIndex = 0;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(226, 43);
            this.textFirstName.Multiline = true;
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(158, 32);
            this.textFirstName.TabIndex = 1;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(423, 43);
            this.textLastName.Multiline = true;
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(158, 32);
            this.textLastName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "firstName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "lastName";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(736, 90);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(137, 41);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "show first one";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(736, 34);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(137, 41);
            this.btnRecherche.TabIndex = 7;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeight = 29;
            this.dgv.Location = new System.Drawing.Point(44, 104);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(537, 271);
            this.dgv.TabIndex = 8;
            // 
            // btnShowInDgv
            // 
            this.btnShowInDgv.Location = new System.Drawing.Point(736, 137);
            this.btnShowInDgv.Name = "btnShowInDgv";
            this.btnShowInDgv.Size = new System.Drawing.Size(137, 41);
            this.btnShowInDgv.TabIndex = 9;
            this.btnShowInDgv.Text = "show in Dgv";
            this.btnShowInDgv.UseVisualStyleBackColor = true;
            this.btnShowInDgv.Click += new System.EventHandler(this.btnShowInDgv_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(736, 184);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(137, 41);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnUpadte
            // 
            this.btnUpadte.Location = new System.Drawing.Point(736, 364);
            this.btnUpadte.Name = "btnUpadte";
            this.btnUpadte.Size = new System.Drawing.Size(137, 74);
            this.btnUpadte.TabIndex = 11;
            this.btnUpadte.Text = "Enrg sur db ";
            this.btnUpadte.UseVisualStyleBackColor = true;
            this.btnUpadte.Click += new System.EventHandler(this.btnUpadte_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(736, 231);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(137, 41);
            this.btnsupprimer.TabIndex = 12;
            this.btnsupprimer.Text = "supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnModifere
            // 
            this.btnModifere.Location = new System.Drawing.Point(736, 278);
            this.btnModifere.Name = "btnModifere";
            this.btnModifere.Size = new System.Drawing.Size(137, 41);
            this.btnModifere.TabIndex = 13;
            this.btnModifere.Text = "Modifiere";
            this.btnModifere.UseVisualStyleBackColor = true;
            this.btnModifere.Click += new System.EventHandler(this.btnModifere_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(466, 397);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(137, 41);
            this.btnFirst.TabIndex = 17;
            this.btnFirst.Text = ">>";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(323, 397);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(137, 41);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnpervouis
            // 
            this.btnpervouis.Location = new System.Drawing.Point(176, 395);
            this.btnpervouis.Name = "btnpervouis";
            this.btnpervouis.Size = new System.Drawing.Size(137, 41);
            this.btnpervouis.TabIndex = 15;
            this.btnpervouis.Text = "<";
            this.btnpervouis.UseVisualStyleBackColor = true;
            this.btnpervouis.Click += new System.EventHandler(this.btnpervouis_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(33, 395);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(137, 41);
            this.btnlast.TabIndex = 14;
            this.btnlast.Text = "<<";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 519);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnpervouis);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnModifere);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnUpadte);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnShowInDgv);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textid);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnShowInDgv;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnUpadte;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnModifere;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnpervouis;
        private System.Windows.Forms.Button btnlast;
    }
}

