using System;

namespace FileWriterUITest {
    partial class TestForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXml = new System.Windows.Forms.RadioButton();
            this.btnJson = new System.Windows.Forms.RadioButton();
            this.btnCsv = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(776, 426);
            this.dgv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXml);
            this.groupBox1.Controls.Add(this.btnJson);
            this.groupBox1.Controls.Add(this.btnCsv);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(665, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(9, 126);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "izvoz podataka";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "pohrana podataka";
            // 
            // btnXml
            // 
            this.btnXml.AutoSize = true;
            this.btnXml.Location = new System.Drawing.Point(7, 102);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(47, 17);
            this.btnXml.TabIndex = 3;
            this.btnXml.Text = "XML";
            this.btnXml.UseVisualStyleBackColor = true;
            // 
            // btnJson
            // 
            this.btnJson.AutoSize = true;
            this.btnJson.Location = new System.Drawing.Point(7, 78);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(53, 17);
            this.btnJson.TabIndex = 2;
            this.btnJson.Text = "JSON";
            this.btnJson.UseVisualStyleBackColor = true;
            // 
            // btnCsv
            // 
            this.btnCsv.AutoSize = true;
            this.btnCsv.Checked = true;
            this.btnCsv.Location = new System.Drawing.Point(7, 54);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(46, 17);
            this.btnCsv.TabIndex = 1;
            this.btnCsv.TabStop = true;
            this.btnCsv.Text = "CSV";
            this.btnCsv.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Name = "TestForm";
            this.Text = "TextForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btnXml;
        private System.Windows.Forms.RadioButton btnJson;
        private System.Windows.Forms.RadioButton btnCsv;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnExport;
        private EventHandler groupBox1_Enter;
    }
}

