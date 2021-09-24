
namespace Gestion_PDA
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tab_Control = new System.Windows.Forms.TabControl();
            this.tab_PDA = new System.Windows.Forms.TabPage();
            this.bt_edit_pda = new System.Windows.Forms.Button();
            this.bt_edit_br = new System.Windows.Forms.Button();
            this.bt_export_pdf = new System.Windows.Forms.Button();
            this.bt_export_excel = new System.Windows.Forms.Button();
            this.tb_problem = new System.Windows.Forms.TextBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.cm_company = new System.Windows.Forms.ComboBox();
            this.cm_no_sim = new System.Windows.Forms.ComboBox();
            this.lb_pda = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_imei = new System.Windows.Forms.TextBox();
            this.tb_no_pda = new System.Windows.Forms.TextBox();
            this.tb_no_serial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_societe = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.dtgPDA = new System.Windows.Forms.DataGridView();
            this.p_societe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_no_pda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_imei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_no_serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_no_telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_no_sim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_problem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_SIM_Societe = new System.Windows.Forms.TabPage();
            this.Bt_Tab_Secret = new System.Windows.Forms.Button();
            this.bt_MAJ_COMPANY = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_c_company = new System.Windows.Forms.TextBox();
            this.tb_c_id = new System.Windows.Forms.TextBox();
            this.bt_ADD_COMPANY = new System.Windows.Forms.Button();
            this.bt_MAJ_SIM = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_s_no_sim = new System.Windows.Forms.TextBox();
            this.tb_s_id = new System.Windows.Forms.TextBox();
            this.bt_ADD_SIM = new System.Windows.Forms.Button();
            this.tb_s_no_phone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgCOMPANY = new System.Windows.Forms.DataGridView();
            this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_societe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgSIM = new System.Windows.Forms.DataGridView();
            this.s_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_no_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_no_sim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_BR = new System.Windows.Forms.TabPage();
            this.dtgBR = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.br_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.br_path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webBR = new System.Windows.Forms.WebBrowser();
            this.tab_BL = new System.Windows.Forms.TabPage();
            this.dtgBL = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webBL = new System.Windows.Forms.WebBrowser();
            this.tab_Settings = new System.Windows.Forms.TabPage();
            this.tab_Secret = new System.Windows.Forms.TabPage();
            this.tab_Control.SuspendLayout();
            this.tab_PDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPDA)).BeginInit();
            this.tab_SIM_Societe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCOMPANY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSIM)).BeginInit();
            this.tab_BR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBR)).BeginInit();
            this.tab_BL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBL)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Control
            // 
            this.tab_Control.Controls.Add(this.tab_PDA);
            this.tab_Control.Controls.Add(this.tab_SIM_Societe);
            this.tab_Control.Controls.Add(this.tab_BR);
            this.tab_Control.Controls.Add(this.tab_BL);
            this.tab_Control.Controls.Add(this.tab_Settings);
            this.tab_Control.Controls.Add(this.tab_Secret);
            this.tab_Control.Location = new System.Drawing.Point(12, 12);
            this.tab_Control.Name = "tab_Control";
            this.tab_Control.SelectedIndex = 0;
            this.tab_Control.Size = new System.Drawing.Size(1258, 705);
            this.tab_Control.TabIndex = 0;
            // 
            // tab_PDA
            // 
            this.tab_PDA.Controls.Add(this.bt_edit_pda);
            this.tab_PDA.Controls.Add(this.bt_edit_br);
            this.tab_PDA.Controls.Add(this.bt_export_pdf);
            this.tab_PDA.Controls.Add(this.bt_export_excel);
            this.tab_PDA.Controls.Add(this.tb_problem);
            this.tab_PDA.Controls.Add(this.tb_type);
            this.tab_PDA.Controls.Add(this.tb_lastname);
            this.tab_PDA.Controls.Add(this.tb_firstname);
            this.tab_PDA.Controls.Add(this.cm_company);
            this.tab_PDA.Controls.Add(this.cm_no_sim);
            this.tab_PDA.Controls.Add(this.lb_pda);
            this.tab_PDA.Controls.Add(this.label9);
            this.tab_PDA.Controls.Add(this.label8);
            this.tab_PDA.Controls.Add(this.label7);
            this.tab_PDA.Controls.Add(this.label6);
            this.tab_PDA.Controls.Add(this.label5);
            this.tab_PDA.Controls.Add(this.label4);
            this.tab_PDA.Controls.Add(this.label3);
            this.tab_PDA.Controls.Add(this.tb_imei);
            this.tab_PDA.Controls.Add(this.tb_no_pda);
            this.tab_PDA.Controls.Add(this.tb_no_serial);
            this.tab_PDA.Controls.Add(this.label2);
            this.tab_PDA.Controls.Add(this.lb_societe);
            this.tab_PDA.Controls.Add(this.lb_title);
            this.tab_PDA.Controls.Add(this.dtgPDA);
            this.tab_PDA.Location = new System.Drawing.Point(4, 22);
            this.tab_PDA.Name = "tab_PDA";
            this.tab_PDA.Padding = new System.Windows.Forms.Padding(3);
            this.tab_PDA.Size = new System.Drawing.Size(1250, 679);
            this.tab_PDA.TabIndex = 0;
            this.tab_PDA.Text = "PDA";
            this.tab_PDA.UseVisualStyleBackColor = true;
            // 
            // bt_edit_pda
            // 
            this.bt_edit_pda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit_pda.Location = new System.Drawing.Point(912, 556);
            this.bt_edit_pda.Name = "bt_edit_pda";
            this.bt_edit_pda.Size = new System.Drawing.Size(333, 35);
            this.bt_edit_pda.TabIndex = 24;
            this.bt_edit_pda.Text = "Mettre à jour le PDA";
            this.bt_edit_pda.UseVisualStyleBackColor = true;
            this.bt_edit_pda.Click += new System.EventHandler(this.Bt_Maj_PDA_Click);
            // 
            // bt_edit_br
            // 
            this.bt_edit_br.Enabled = false;
            this.bt_edit_br.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit_br.Location = new System.Drawing.Point(912, 597);
            this.bt_edit_br.Name = "bt_edit_br";
            this.bt_edit_br.Size = new System.Drawing.Size(333, 35);
            this.bt_edit_br.TabIndex = 23;
            this.bt_edit_br.Text = "Editer le Bon de Retour";
            this.bt_edit_br.UseVisualStyleBackColor = true;
            // 
            // bt_export_pdf
            // 
            this.bt_export_pdf.Enabled = false;
            this.bt_export_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_export_pdf.Location = new System.Drawing.Point(1079, 638);
            this.bt_export_pdf.Name = "bt_export_pdf";
            this.bt_export_pdf.Size = new System.Drawing.Size(166, 35);
            this.bt_export_pdf.TabIndex = 22;
            this.bt_export_pdf.Text = "Export PDF";
            this.bt_export_pdf.UseVisualStyleBackColor = true;
            // 
            // bt_export_excel
            // 
            this.bt_export_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_export_excel.Location = new System.Drawing.Point(912, 638);
            this.bt_export_excel.Name = "bt_export_excel";
            this.bt_export_excel.Size = new System.Drawing.Size(166, 35);
            this.bt_export_excel.TabIndex = 21;
            this.bt_export_excel.Text = "Export EXCEL";
            this.bt_export_excel.UseVisualStyleBackColor = true;
            this.bt_export_excel.Click += new System.EventHandler(this.Bt_Export_Excel_Click);
            // 
            // tb_problem
            // 
            this.tb_problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_problem.Location = new System.Drawing.Point(912, 365);
            this.tb_problem.Multiline = true;
            this.tb_problem.Name = "tb_problem";
            this.tb_problem.Size = new System.Drawing.Size(333, 185);
            this.tb_problem.TabIndex = 20;
            // 
            // tb_type
            // 
            this.tb_type.Enabled = false;
            this.tb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_type.Location = new System.Drawing.Point(1025, 299);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(220, 31);
            this.tb_type.TabIndex = 19;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lastname.Location = new System.Drawing.Point(1025, 262);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(220, 31);
            this.tb_lastname.TabIndex = 18;
            // 
            // tb_firstname
            // 
            this.tb_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_firstname.Location = new System.Drawing.Point(1025, 225);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(220, 31);
            this.tb_firstname.TabIndex = 17;
            // 
            // cm_company
            // 
            this.cm_company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cm_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm_company.FormattingEnabled = true;
            this.cm_company.Location = new System.Drawing.Point(1025, 46);
            this.cm_company.Name = "cm_company";
            this.cm_company.Size = new System.Drawing.Size(220, 28);
            this.cm_company.TabIndex = 16;
            // 
            // cm_no_sim
            // 
            this.cm_no_sim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cm_no_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm_no_sim.FormattingEnabled = true;
            this.cm_no_sim.Location = new System.Drawing.Point(1025, 191);
            this.cm_no_sim.Name = "cm_no_sim";
            this.cm_no_sim.Size = new System.Drawing.Size(220, 28);
            this.cm_no_sim.TabIndex = 15;
            // 
            // lb_pda
            // 
            this.lb_pda.AutoSize = true;
            this.lb_pda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pda.Location = new System.Drawing.Point(1113, 337);
            this.lb_pda.Name = "lb_pda";
            this.lb_pda.Size = new System.Drawing.Size(132, 25);
            this.lb_pda.TabIndex = 14;
            this.lb_pda.Text = "NB PDA : 00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(906, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Problème :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(906, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Type :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(907, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(907, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prénom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(907, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "N° SIM :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(907, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "N° Série :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(907, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "IMEI :";
            // 
            // tb_imei
            // 
            this.tb_imei.Enabled = false;
            this.tb_imei.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_imei.Location = new System.Drawing.Point(1025, 117);
            this.tb_imei.Name = "tb_imei";
            this.tb_imei.Size = new System.Drawing.Size(220, 31);
            this.tb_imei.TabIndex = 6;
            // 
            // tb_no_pda
            // 
            this.tb_no_pda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_no_pda.Location = new System.Drawing.Point(1025, 80);
            this.tb_no_pda.Name = "tb_no_pda";
            this.tb_no_pda.Size = new System.Drawing.Size(220, 31);
            this.tb_no_pda.TabIndex = 5;
            // 
            // tb_no_serial
            // 
            this.tb_no_serial.Enabled = false;
            this.tb_no_serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_no_serial.Location = new System.Drawing.Point(1025, 154);
            this.tb_no_serial.Name = "tb_no_serial";
            this.tb_no_serial.Size = new System.Drawing.Size(220, 31);
            this.tb_no_serial.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(907, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "N° PDA :";
            // 
            // lb_societe
            // 
            this.lb_societe.AutoSize = true;
            this.lb_societe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_societe.Location = new System.Drawing.Point(907, 48);
            this.lb_societe.Name = "lb_societe";
            this.lb_societe.Size = new System.Drawing.Size(96, 25);
            this.lb_societe.TabIndex = 2;
            this.lb_societe.Text = "Société :";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(906, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(339, 31);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "IMEI : 000000000000000";
            // 
            // dtgPDA
            // 
            this.dtgPDA.AllowUserToAddRows = false;
            this.dtgPDA.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPDA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_societe,
            this.p_no_pda,
            this.p_imei,
            this.p_no_serie,
            this.p_no_telephone,
            this.p_no_sim,
            this.p_firstname,
            this.p_lastname,
            this.p_type,
            this.p_problem});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPDA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPDA.Location = new System.Drawing.Point(0, 0);
            this.dtgPDA.MultiSelect = false;
            this.dtgPDA.Name = "dtgPDA";
            this.dtgPDA.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPDA.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPDA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPDA.Size = new System.Drawing.Size(900, 676);
            this.dtgPDA.TabIndex = 0;
            this.dtgPDA.SelectionChanged += new System.EventHandler(this.DtgPDA_SelectionChanged);
            // 
            // p_societe
            // 
            this.p_societe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.p_societe.HeaderText = "Société";
            this.p_societe.Name = "p_societe";
            this.p_societe.ReadOnly = true;
            this.p_societe.Width = 68;
            // 
            // p_no_pda
            // 
            this.p_no_pda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.p_no_pda.HeaderText = "N° PDA";
            this.p_no_pda.Name = "p_no_pda";
            this.p_no_pda.ReadOnly = true;
            this.p_no_pda.Width = 69;
            // 
            // p_imei
            // 
            this.p_imei.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.p_imei.HeaderText = "IMEI";
            this.p_imei.Name = "p_imei";
            this.p_imei.ReadOnly = true;
            this.p_imei.Width = 54;
            // 
            // p_no_serie
            // 
            this.p_no_serie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.p_no_serie.HeaderText = "N° Série";
            this.p_no_serie.Name = "p_no_serie";
            this.p_no_serie.ReadOnly = true;
            this.p_no_serie.Width = 71;
            // 
            // p_no_telephone
            // 
            this.p_no_telephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.p_no_telephone.HeaderText = "N° Téléphone";
            this.p_no_telephone.Name = "p_no_telephone";
            this.p_no_telephone.ReadOnly = true;
            this.p_no_telephone.Width = 98;
            // 
            // p_no_sim
            // 
            this.p_no_sim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.p_no_sim.HeaderText = "N° SIM";
            this.p_no_sim.Name = "p_no_sim";
            this.p_no_sim.ReadOnly = true;
            this.p_no_sim.Width = 66;
            // 
            // p_firstname
            // 
            this.p_firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.p_firstname.HeaderText = "Prénom";
            this.p_firstname.Name = "p_firstname";
            this.p_firstname.ReadOnly = true;
            this.p_firstname.Width = 68;
            // 
            // p_lastname
            // 
            this.p_lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.p_lastname.HeaderText = "Nom";
            this.p_lastname.Name = "p_lastname";
            this.p_lastname.ReadOnly = true;
            this.p_lastname.Width = 54;
            // 
            // p_type
            // 
            this.p_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.p_type.HeaderText = "Type";
            this.p_type.Name = "p_type";
            this.p_type.ReadOnly = true;
            this.p_type.Visible = false;
            // 
            // p_problem
            // 
            this.p_problem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.p_problem.HeaderText = "Problème";
            this.p_problem.Name = "p_problem";
            this.p_problem.ReadOnly = true;
            this.p_problem.Visible = false;
            // 
            // tab_SIM_Societe
            // 
            this.tab_SIM_Societe.Controls.Add(this.Bt_Tab_Secret);
            this.tab_SIM_Societe.Controls.Add(this.bt_MAJ_COMPANY);
            this.tab_SIM_Societe.Controls.Add(this.label14);
            this.tab_SIM_Societe.Controls.Add(this.tb_c_company);
            this.tab_SIM_Societe.Controls.Add(this.tb_c_id);
            this.tab_SIM_Societe.Controls.Add(this.bt_ADD_COMPANY);
            this.tab_SIM_Societe.Controls.Add(this.bt_MAJ_SIM);
            this.tab_SIM_Societe.Controls.Add(this.label12);
            this.tab_SIM_Societe.Controls.Add(this.label11);
            this.tab_SIM_Societe.Controls.Add(this.tb_s_no_sim);
            this.tab_SIM_Societe.Controls.Add(this.tb_s_id);
            this.tab_SIM_Societe.Controls.Add(this.bt_ADD_SIM);
            this.tab_SIM_Societe.Controls.Add(this.tb_s_no_phone);
            this.tab_SIM_Societe.Controls.Add(this.label10);
            this.tab_SIM_Societe.Controls.Add(this.label1);
            this.tab_SIM_Societe.Controls.Add(this.pictureBox2);
            this.tab_SIM_Societe.Controls.Add(this.pictureBox1);
            this.tab_SIM_Societe.Controls.Add(this.dtgCOMPANY);
            this.tab_SIM_Societe.Controls.Add(this.dtgSIM);
            this.tab_SIM_Societe.Location = new System.Drawing.Point(4, 22);
            this.tab_SIM_Societe.Name = "tab_SIM_Societe";
            this.tab_SIM_Societe.Padding = new System.Windows.Forms.Padding(3);
            this.tab_SIM_Societe.Size = new System.Drawing.Size(1250, 679);
            this.tab_SIM_Societe.TabIndex = 1;
            this.tab_SIM_Societe.Text = "SIM / SOCIETE";
            this.tab_SIM_Societe.UseVisualStyleBackColor = true;
            // 
            // Bt_Tab_Secret
            // 
            this.Bt_Tab_Secret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Tab_Secret.Location = new System.Drawing.Point(699, 446);
            this.Bt_Tab_Secret.Name = "Bt_Tab_Secret";
            this.Bt_Tab_Secret.Size = new System.Drawing.Size(277, 35);
            this.Bt_Tab_Secret.TabIndex = 39;
            this.Bt_Tab_Secret.Text = "Test  NPT";
            this.Bt_Tab_Secret.UseVisualStyleBackColor = true;
            this.Bt_Tab_Secret.Click += new System.EventHandler(this.Bt_Tab_Secret_Click);
            // 
            // bt_MAJ_COMPANY
            // 
            this.bt_MAJ_COMPANY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_MAJ_COMPANY.Location = new System.Drawing.Point(699, 405);
            this.bt_MAJ_COMPANY.Name = "bt_MAJ_COMPANY";
            this.bt_MAJ_COMPANY.Size = new System.Drawing.Size(277, 35);
            this.bt_MAJ_COMPANY.TabIndex = 38;
            this.bt_MAJ_COMPANY.Text = "Mettre à jour Société";
            this.bt_MAJ_COMPANY.UseVisualStyleBackColor = true;
            this.bt_MAJ_COMPANY.Click += new System.EventHandler(this.Bt_Maj_Company_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(694, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 25);
            this.label14.TabIndex = 36;
            this.label14.Text = "Société :";
            // 
            // tb_c_company
            // 
            this.tb_c_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_c_company.Location = new System.Drawing.Point(699, 282);
            this.tb_c_company.Name = "tb_c_company";
            this.tb_c_company.Size = new System.Drawing.Size(277, 31);
            this.tb_c_company.TabIndex = 35;
            // 
            // tb_c_id
            // 
            this.tb_c_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_c_id.Location = new System.Drawing.Point(703, 6);
            this.tb_c_id.Name = "tb_c_id";
            this.tb_c_id.Size = new System.Drawing.Size(277, 31);
            this.tb_c_id.TabIndex = 34;
            this.tb_c_id.Visible = false;
            // 
            // bt_ADD_COMPANY
            // 
            this.bt_ADD_COMPANY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ADD_COMPANY.Location = new System.Drawing.Point(699, 364);
            this.bt_ADD_COMPANY.Name = "bt_ADD_COMPANY";
            this.bt_ADD_COMPANY.Size = new System.Drawing.Size(277, 35);
            this.bt_ADD_COMPANY.TabIndex = 33;
            this.bt_ADD_COMPANY.Text = "Ajouter Société";
            this.bt_ADD_COMPANY.UseVisualStyleBackColor = true;
            this.bt_ADD_COMPANY.Click += new System.EventHandler(this.Bt_Add_Company_Click);
            // 
            // bt_MAJ_SIM
            // 
            this.bt_MAJ_SIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_MAJ_SIM.Location = new System.Drawing.Point(334, 405);
            this.bt_MAJ_SIM.Name = "bt_MAJ_SIM";
            this.bt_MAJ_SIM.Size = new System.Drawing.Size(277, 35);
            this.bt_MAJ_SIM.TabIndex = 31;
            this.bt_MAJ_SIM.Text = "Mettre à jour Carte SIM";
            this.bt_MAJ_SIM.UseVisualStyleBackColor = true;
            this.bt_MAJ_SIM.Click += new System.EventHandler(this.Bt_Maj_SIM_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(329, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "N° Téléphone :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(329, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "N° SIM :";
            // 
            // tb_s_no_sim
            // 
            this.tb_s_no_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_s_no_sim.Location = new System.Drawing.Point(334, 282);
            this.tb_s_no_sim.Name = "tb_s_no_sim";
            this.tb_s_no_sim.Size = new System.Drawing.Size(277, 31);
            this.tb_s_no_sim.TabIndex = 28;
            // 
            // tb_s_id
            // 
            this.tb_s_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_s_id.Location = new System.Drawing.Point(338, 6);
            this.tb_s_id.Name = "tb_s_id";
            this.tb_s_id.Size = new System.Drawing.Size(277, 31);
            this.tb_s_id.TabIndex = 27;
            this.tb_s_id.Visible = false;
            // 
            // bt_ADD_SIM
            // 
            this.bt_ADD_SIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ADD_SIM.Location = new System.Drawing.Point(334, 364);
            this.bt_ADD_SIM.Name = "bt_ADD_SIM";
            this.bt_ADD_SIM.Size = new System.Drawing.Size(277, 35);
            this.bt_ADD_SIM.TabIndex = 26;
            this.bt_ADD_SIM.Text = "Ajouter Carte SIM";
            this.bt_ADD_SIM.UseVisualStyleBackColor = true;
            this.bt_ADD_SIM.Click += new System.EventHandler(this.Bt_Add_SIM_Click);
            // 
            // tb_s_no_phone
            // 
            this.tb_s_no_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_s_no_phone.Location = new System.Drawing.Point(334, 194);
            this.tb_s_no_phone.Name = "tb_s_no_phone";
            this.tb_s_no_phone.Size = new System.Drawing.Size(277, 31);
            this.tb_s_no_phone.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(770, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 31);
            this.label10.TabIndex = 5;
            this.label10.Text = "Sociétés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "N° Téléphones / SIM";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(648, 394);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(11, 399);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(648, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(11, 399);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dtgCOMPANY
            // 
            this.dtgCOMPANY.AllowUserToAddRows = false;
            this.dtgCOMPANY.AllowUserToDeleteRows = false;
            this.dtgCOMPANY.AllowUserToResizeColumns = false;
            this.dtgCOMPANY.AllowUserToResizeRows = false;
            this.dtgCOMPANY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgCOMPANY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCOMPANY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_id,
            this.c_societe});
            this.dtgCOMPANY.Location = new System.Drawing.Point(1007, 3);
            this.dtgCOMPANY.MultiSelect = false;
            this.dtgCOMPANY.Name = "dtgCOMPANY";
            this.dtgCOMPANY.ReadOnly = true;
            this.dtgCOMPANY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCOMPANY.Size = new System.Drawing.Size(240, 670);
            this.dtgCOMPANY.TabIndex = 1;
            this.dtgCOMPANY.SelectionChanged += new System.EventHandler(this.DtgCOMPANY_SelectionChanged);
            // 
            // c_id
            // 
            this.c_id.HeaderText = "ID";
            this.c_id.Name = "c_id";
            this.c_id.ReadOnly = true;
            this.c_id.Width = 43;
            // 
            // c_societe
            // 
            this.c_societe.HeaderText = "Société";
            this.c_societe.Name = "c_societe";
            this.c_societe.ReadOnly = true;
            this.c_societe.Width = 68;
            // 
            // dtgSIM
            // 
            this.dtgSIM.AllowUserToAddRows = false;
            this.dtgSIM.AllowUserToDeleteRows = false;
            this.dtgSIM.AllowUserToResizeColumns = false;
            this.dtgSIM.AllowUserToResizeRows = false;
            this.dtgSIM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgSIM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSIM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s_id,
            this.s_no_phone,
            this.s_no_sim});
            this.dtgSIM.Location = new System.Drawing.Point(3, 3);
            this.dtgSIM.MultiSelect = false;
            this.dtgSIM.Name = "dtgSIM";
            this.dtgSIM.ReadOnly = true;
            this.dtgSIM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSIM.Size = new System.Drawing.Size(287, 670);
            this.dtgSIM.TabIndex = 0;
            this.dtgSIM.SelectionChanged += new System.EventHandler(this.DtgSIM_SelectionChanged);
            // 
            // s_id
            // 
            this.s_id.HeaderText = "ID";
            this.s_id.Name = "s_id";
            this.s_id.ReadOnly = true;
            this.s_id.Width = 43;
            // 
            // s_no_phone
            // 
            this.s_no_phone.HeaderText = "N° Téléphone";
            this.s_no_phone.Name = "s_no_phone";
            this.s_no_phone.ReadOnly = true;
            this.s_no_phone.Width = 98;
            // 
            // s_no_sim
            // 
            this.s_no_sim.HeaderText = "N° SIM";
            this.s_no_sim.Name = "s_no_sim";
            this.s_no_sim.ReadOnly = true;
            this.s_no_sim.Width = 66;
            // 
            // tab_BR
            // 
            this.tab_BR.Controls.Add(this.dtgBR);
            this.tab_BR.Controls.Add(this.webBR);
            this.tab_BR.Location = new System.Drawing.Point(4, 22);
            this.tab_BR.Name = "tab_BR";
            this.tab_BR.Padding = new System.Windows.Forms.Padding(3);
            this.tab_BR.Size = new System.Drawing.Size(1250, 679);
            this.tab_BR.TabIndex = 2;
            this.tab_BR.Text = "BON DE RETOURS";
            this.tab_BR.UseVisualStyleBackColor = true;
            // 
            // dtgBR
            // 
            this.dtgBR.AllowUserToAddRows = false;
            this.dtgBR.AllowUserToDeleteRows = false;
            this.dtgBR.AllowUserToResizeColumns = false;
            this.dtgBR.AllowUserToResizeRows = false;
            this.dtgBR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgBR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.br_code,
            this.br_path});
            this.dtgBR.Location = new System.Drawing.Point(0, 0);
            this.dtgBR.MultiSelect = false;
            this.dtgBR.Name = "dtgBR";
            this.dtgBR.ReadOnly = true;
            this.dtgBR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBR.Size = new System.Drawing.Size(396, 679);
            this.dtgBR.TabIndex = 2;
            this.dtgBR.SelectionChanged += new System.EventHandler(this.DtgBR_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "PDA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "N° SERIE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 79;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 61;
            // 
            // br_code
            // 
            this.br_code.HeaderText = "CODE";
            this.br_code.Name = "br_code";
            this.br_code.ReadOnly = true;
            this.br_code.Width = 62;
            // 
            // br_path
            // 
            this.br_path.HeaderText = "PATH";
            this.br_path.Name = "br_path";
            this.br_path.ReadOnly = true;
            this.br_path.Visible = false;
            this.br_path.Width = 61;
            // 
            // webBR
            // 
            this.webBR.Location = new System.Drawing.Point(402, 0);
            this.webBR.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBR.Name = "webBR";
            this.webBR.Size = new System.Drawing.Size(848, 679);
            this.webBR.TabIndex = 1;
            // 
            // tab_BL
            // 
            this.tab_BL.Controls.Add(this.dtgBL);
            this.tab_BL.Controls.Add(this.webBL);
            this.tab_BL.Location = new System.Drawing.Point(4, 22);
            this.tab_BL.Name = "tab_BL";
            this.tab_BL.Padding = new System.Windows.Forms.Padding(3);
            this.tab_BL.Size = new System.Drawing.Size(1250, 679);
            this.tab_BL.TabIndex = 3;
            this.tab_BL.Text = "BON DE LIVRAISONS";
            this.tab_BL.UseVisualStyleBackColor = true;
            // 
            // dtgBL
            // 
            this.dtgBL.AllowUserToAddRows = false;
            this.dtgBL.AllowUserToDeleteRows = false;
            this.dtgBL.AllowUserToResizeColumns = false;
            this.dtgBL.AllowUserToResizeRows = false;
            this.dtgBL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dtgBL.Location = new System.Drawing.Point(0, 0);
            this.dtgBL.MultiSelect = false;
            this.dtgBL.Name = "dtgBL";
            this.dtgBL.ReadOnly = true;
            this.dtgBL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBL.Size = new System.Drawing.Size(396, 679);
            this.dtgBL.TabIndex = 4;
            this.dtgBL.SelectionChanged += new System.EventHandler(this.DtgBL_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "PDA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 54;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "N° SERIE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 79;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 61;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "CODE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 62;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "PATH";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 61;
            // 
            // webBL
            // 
            this.webBL.Location = new System.Drawing.Point(402, 0);
            this.webBL.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBL.Name = "webBL";
            this.webBL.Size = new System.Drawing.Size(848, 679);
            this.webBL.TabIndex = 3;
            // 
            // tab_Settings
            // 
            this.tab_Settings.Location = new System.Drawing.Point(4, 22);
            this.tab_Settings.Name = "tab_Settings";
            this.tab_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Settings.Size = new System.Drawing.Size(1250, 679);
            this.tab_Settings.TabIndex = 4;
            this.tab_Settings.Text = "PARAMETRES";
            this.tab_Settings.UseVisualStyleBackColor = true;
            // 
            // tab_Secret
            // 
            this.tab_Secret.Location = new System.Drawing.Point(4, 22);
            this.tab_Secret.Name = "tab_Secret";
            this.tab_Secret.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Secret.Size = new System.Drawing.Size(1250, 679);
            this.tab_Secret.TabIndex = 5;
            this.tab_Secret.Text = "SECRET";
            this.tab_Secret.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 729);
            this.Controls.Add(this.tab_Control);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Gestion_PDA";
            this.tab_Control.ResumeLayout(false);
            this.tab_PDA.ResumeLayout(false);
            this.tab_PDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPDA)).EndInit();
            this.tab_SIM_Societe.ResumeLayout(false);
            this.tab_SIM_Societe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCOMPANY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSIM)).EndInit();
            this.tab_BR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBR)).EndInit();
            this.tab_BL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Control;
        private System.Windows.Forms.TabPage tab_PDA;
        private System.Windows.Forms.DataGridView dtgPDA;
        private System.Windows.Forms.TabPage tab_SIM_Societe;
        private System.Windows.Forms.TabPage tab_BR;
        private System.Windows.Forms.TabPage tab_BL;
        private System.Windows.Forms.TabPage tab_Settings;
        private System.Windows.Forms.TabPage tab_Secret;
        private System.Windows.Forms.Button bt_edit_pda;
        private System.Windows.Forms.Button bt_edit_br;
        private System.Windows.Forms.Button bt_export_pdf;
        private System.Windows.Forms.Button bt_export_excel;
        private System.Windows.Forms.TextBox tb_problem;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.ComboBox cm_company;
        private System.Windows.Forms.ComboBox cm_no_sim;
        private System.Windows.Forms.Label lb_pda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_imei;
        private System.Windows.Forms.TextBox tb_no_pda;
        private System.Windows.Forms.TextBox tb_no_serial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_societe;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.DataGridView dtgCOMPANY;
        private System.Windows.Forms.DataGridView dtgSIM;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_ADD_SIM;
        private System.Windows.Forms.TextBox tb_s_no_phone;
        private System.Windows.Forms.Button bt_MAJ_COMPANY;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_c_company;
        private System.Windows.Forms.TextBox tb_c_id;
        private System.Windows.Forms.Button bt_ADD_COMPANY;
        private System.Windows.Forms.Button bt_MAJ_SIM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_s_no_sim;
        private System.Windows.Forms.TextBox tb_s_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_societe;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_no_pda;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_imei;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_no_serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_no_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_no_sim;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_problem;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_societe;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_no_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_no_sim;
        private System.Windows.Forms.DataGridView dtgBR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn br_code;
        private System.Windows.Forms.WebBrowser webBR;
        private System.Windows.Forms.DataGridViewTextBoxColumn br_path;
        private System.Windows.Forms.DataGridView dtgBL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.WebBrowser webBL;
        private System.Windows.Forms.Button Bt_Tab_Secret;
    }
}

