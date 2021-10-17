
namespace Gestion_PDA
{
    partial class F_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_MainForm));
            this.tb = new System.Windows.Forms.TabControl();
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
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_SIM_Societe = new System.Windows.Forms.TabPage();
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
            this.tb_FACTURES = new System.Windows.Forms.TabPage();
            this.dtgFACT = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webFACT = new System.Windows.Forms.WebBrowser();
            this.tb_SUIVI_COLIS = new System.Windows.Forms.TabPage();
            this.dtgCOLIS = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webCOLIS = new System.Windows.Forms.WebBrowser();
            this.tb_UTILISATEURS = new System.Windows.Forms.TabPage();
            this.bt_user_password = new System.Windows.Forms.Button();
            this.bt_user_edit = new System.Windows.Forms.Button();
            this.cm_actif = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bt_user_add = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtgUSERS = new System.Windows.Forms.DataGridView();
            this.u_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_isActived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_SETTINGS_BR = new System.Windows.Forms.TabPage();
            this.tb_address_mail = new System.Windows.Forms.TextBox();
            this.tb_no_fax = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_no_phone = new System.Windows.Forms.TextBox();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.tb_zip_code = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_interlocuteur = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.bt_maj_settings = new System.Windows.Forms.Button();
            this.tb_company = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.tb.SuspendLayout();
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
            this.tb_FACTURES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFACT)).BeginInit();
            this.tb_SUIVI_COLIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCOLIS)).BeginInit();
            this.tb_UTILISATEURS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUSERS)).BeginInit();
            this.tb_SETTINGS_BR.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Controls.Add(this.tab_PDA);
            this.tb.Controls.Add(this.tab_SIM_Societe);
            this.tb.Controls.Add(this.tab_BR);
            this.tb.Controls.Add(this.tab_BL);
            this.tb.Controls.Add(this.tb_FACTURES);
            this.tb.Controls.Add(this.tb_SUIVI_COLIS);
            this.tb.Controls.Add(this.tb_UTILISATEURS);
            this.tb.Controls.Add(this.tb_SETTINGS_BR);
            this.tb.Location = new System.Drawing.Point(12, 12);
            this.tb.Name = "tb";
            this.tb.SelectedIndex = 0;
            this.tb.Size = new System.Drawing.Size(1258, 705);
            this.tb.TabIndex = 0;
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
            this.tab_PDA.Text = "LISTE PDA";
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
            this.bt_edit_br.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit_br.Location = new System.Drawing.Point(912, 597);
            this.bt_edit_br.Name = "bt_edit_br";
            this.bt_edit_br.Size = new System.Drawing.Size(333, 35);
            this.bt_edit_br.TabIndex = 23;
            this.bt_edit_br.Text = "Editer le Bon de Retour";
            this.bt_edit_br.UseVisualStyleBackColor = true;
            this.bt_edit_br.Click += new System.EventHandler(this.Bt_edit_br_Click);
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
            this.p_problem,
            this.p_id});
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
            // p_id
            // 
            this.p_id.HeaderText = "ID";
            this.p_id.Name = "p_id";
            this.p_id.ReadOnly = true;
            this.p_id.Visible = false;
            // 
            // tab_SIM_Societe
            // 
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
            this.webBR.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebBR_Navigated);
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
            // tb_FACTURES
            // 
            this.tb_FACTURES.Controls.Add(this.dtgFACT);
            this.tb_FACTURES.Controls.Add(this.webFACT);
            this.tb_FACTURES.Location = new System.Drawing.Point(4, 22);
            this.tb_FACTURES.Name = "tb_FACTURES";
            this.tb_FACTURES.Size = new System.Drawing.Size(1250, 679);
            this.tb_FACTURES.TabIndex = 8;
            this.tb_FACTURES.Text = "FACTURES";
            this.tb_FACTURES.UseVisualStyleBackColor = true;
            // 
            // dtgFACT
            // 
            this.dtgFACT.AllowUserToAddRows = false;
            this.dtgFACT.AllowUserToDeleteRows = false;
            this.dtgFACT.AllowUserToResizeColumns = false;
            this.dtgFACT.AllowUserToResizeRows = false;
            this.dtgFACT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgFACT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFACT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dtgFACT.Location = new System.Drawing.Point(0, 0);
            this.dtgFACT.MultiSelect = false;
            this.dtgFACT.Name = "dtgFACT";
            this.dtgFACT.ReadOnly = true;
            this.dtgFACT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFACT.Size = new System.Drawing.Size(396, 679);
            this.dtgFACT.TabIndex = 6;
            this.dtgFACT.SelectionChanged += new System.EventHandler(this.DtgFACT_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "N° SUIVI";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 75;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "MONTANT";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 86;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 61;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "CODE";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 62;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "PATH";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            this.dataGridViewTextBoxColumn13.Width = 61;
            // 
            // webFACT
            // 
            this.webFACT.Location = new System.Drawing.Point(402, 0);
            this.webFACT.MinimumSize = new System.Drawing.Size(20, 20);
            this.webFACT.Name = "webFACT";
            this.webFACT.Size = new System.Drawing.Size(848, 679);
            this.webFACT.TabIndex = 5;
            // 
            // tb_SUIVI_COLIS
            // 
            this.tb_SUIVI_COLIS.Controls.Add(this.dtgCOLIS);
            this.tb_SUIVI_COLIS.Controls.Add(this.webCOLIS);
            this.tb_SUIVI_COLIS.Location = new System.Drawing.Point(4, 22);
            this.tb_SUIVI_COLIS.Name = "tb_SUIVI_COLIS";
            this.tb_SUIVI_COLIS.Size = new System.Drawing.Size(1250, 679);
            this.tb_SUIVI_COLIS.TabIndex = 9;
            this.tb_SUIVI_COLIS.Text = "SUIVI COLIS";
            this.tb_SUIVI_COLIS.UseVisualStyleBackColor = true;
            // 
            // dtgCOLIS
            // 
            this.dtgCOLIS.AllowUserToAddRows = false;
            this.dtgCOLIS.AllowUserToDeleteRows = false;
            this.dtgCOLIS.AllowUserToResizeColumns = false;
            this.dtgCOLIS.AllowUserToResizeRows = false;
            this.dtgCOLIS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgCOLIS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCOLIS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.dtgCOLIS.Location = new System.Drawing.Point(0, 0);
            this.dtgCOLIS.MultiSelect = false;
            this.dtgCOLIS.Name = "dtgCOLIS";
            this.dtgCOLIS.ReadOnly = true;
            this.dtgCOLIS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCOLIS.Size = new System.Drawing.Size(396, 679);
            this.dtgCOLIS.TabIndex = 8;
            this.dtgCOLIS.SelectionChanged += new System.EventHandler(this.DtgCOLIS_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "N° SUIVI";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 75;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "MONTANT";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 86;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 61;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "CODE";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 62;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "PATH";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            this.dataGridViewTextBoxColumn18.Width = 61;
            // 
            // webCOLIS
            // 
            this.webCOLIS.Location = new System.Drawing.Point(402, 0);
            this.webCOLIS.MinimumSize = new System.Drawing.Size(20, 20);
            this.webCOLIS.Name = "webCOLIS";
            this.webCOLIS.Size = new System.Drawing.Size(848, 679);
            this.webCOLIS.TabIndex = 7;
            // 
            // tb_UTILISATEURS
            // 
            this.tb_UTILISATEURS.Controls.Add(this.bt_user_password);
            this.tb_UTILISATEURS.Controls.Add(this.bt_user_edit);
            this.tb_UTILISATEURS.Controls.Add(this.cm_actif);
            this.tb_UTILISATEURS.Controls.Add(this.label18);
            this.tb_UTILISATEURS.Controls.Add(this.label17);
            this.tb_UTILISATEURS.Controls.Add(this.label16);
            this.tb_UTILISATEURS.Controls.Add(this.tb_mail);
            this.tb_UTILISATEURS.Controls.Add(this.tb_name);
            this.tb_UTILISATEURS.Controls.Add(this.label13);
            this.tb_UTILISATEURS.Controls.Add(this.bt_user_add);
            this.tb_UTILISATEURS.Controls.Add(this.tb_username);
            this.tb_UTILISATEURS.Controls.Add(this.label15);
            this.tb_UTILISATEURS.Controls.Add(this.dtgUSERS);
            this.tb_UTILISATEURS.Location = new System.Drawing.Point(4, 22);
            this.tb_UTILISATEURS.Name = "tb_UTILISATEURS";
            this.tb_UTILISATEURS.Size = new System.Drawing.Size(1250, 679);
            this.tb_UTILISATEURS.TabIndex = 6;
            this.tb_UTILISATEURS.Text = "UTILISATEURS";
            this.tb_UTILISATEURS.UseVisualStyleBackColor = true;
            // 
            // bt_user_password
            // 
            this.bt_user_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_user_password.Location = new System.Drawing.Point(867, 354);
            this.bt_user_password.Name = "bt_user_password";
            this.bt_user_password.Size = new System.Drawing.Size(376, 35);
            this.bt_user_password.TabIndex = 43;
            this.bt_user_password.Text = "Changer le mot de passe";
            this.bt_user_password.UseVisualStyleBackColor = true;
            this.bt_user_password.Click += new System.EventHandler(this.bt_user_password_Click);
            // 
            // bt_user_edit
            // 
            this.bt_user_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_user_edit.Location = new System.Drawing.Point(867, 313);
            this.bt_user_edit.Name = "bt_user_edit";
            this.bt_user_edit.Size = new System.Drawing.Size(376, 35);
            this.bt_user_edit.TabIndex = 42;
            this.bt_user_edit.Text = "Appliquer les modifications";
            this.bt_user_edit.UseVisualStyleBackColor = true;
            this.bt_user_edit.Click += new System.EventHandler(this.bt_user_edit_Click);
            // 
            // cm_actif
            // 
            this.cm_actif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cm_actif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm_actif.FormattingEnabled = true;
            this.cm_actif.Location = new System.Drawing.Point(867, 221);
            this.cm_actif.Name = "cm_actif";
            this.cm_actif.Size = new System.Drawing.Size(376, 28);
            this.cm_actif.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(777, 220);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 25);
            this.label18.TabIndex = 40;
            this.label18.Text = "ACTIF :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(712, 187);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 25);
            this.label17.TabIndex = 39;
            this.label17.Text = "Adresse Mail :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(793, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 25);
            this.label16.TabIndex = 38;
            this.label16.Text = "Nom :";
            // 
            // tb_mail
            // 
            this.tb_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mail.Location = new System.Drawing.Point(867, 184);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(376, 31);
            this.tb_mail.TabIndex = 36;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(867, 147);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(376, 31);
            this.tb_name.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(744, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 25);
            this.label13.TabIndex = 34;
            this.label13.Text = "Identifiant :";
            // 
            // bt_user_add
            // 
            this.bt_user_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_user_add.Location = new System.Drawing.Point(867, 272);
            this.bt_user_add.Name = "bt_user_add";
            this.bt_user_add.Size = new System.Drawing.Size(376, 35);
            this.bt_user_add.TabIndex = 33;
            this.bt_user_add.Text = "Ajouter un Utilisateur";
            this.bt_user_add.UseVisualStyleBackColor = true;
            this.bt_user_add.Click += new System.EventHandler(this.bt_user_add_Click);
            // 
            // tb_username
            // 
            this.tb_username.Enabled = false;
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(867, 110);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(376, 31);
            this.tb_username.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(926, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 31);
            this.label15.TabIndex = 31;
            this.label15.Text = "Utilisateur";
            // 
            // dtgUSERS
            // 
            this.dtgUSERS.AllowUserToAddRows = false;
            this.dtgUSERS.AllowUserToDeleteRows = false;
            this.dtgUSERS.AllowUserToResizeColumns = false;
            this.dtgUSERS.AllowUserToResizeRows = false;
            this.dtgUSERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgUSERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUSERS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.u_username,
            this.u_name,
            this.u_mail,
            this.u_isActived});
            this.dtgUSERS.Location = new System.Drawing.Point(0, 0);
            this.dtgUSERS.MultiSelect = false;
            this.dtgUSERS.Name = "dtgUSERS";
            this.dtgUSERS.ReadOnly = true;
            this.dtgUSERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUSERS.Size = new System.Drawing.Size(706, 670);
            this.dtgUSERS.TabIndex = 1;
            this.dtgUSERS.SelectionChanged += new System.EventHandler(this.DtgUSERS_SelectionChanged);
            // 
            // u_username
            // 
            this.u_username.HeaderText = "UTILISATEUR";
            this.u_username.Name = "u_username";
            this.u_username.ReadOnly = true;
            this.u_username.Width = 103;
            // 
            // u_name
            // 
            this.u_name.HeaderText = "NOM";
            this.u_name.Name = "u_name";
            this.u_name.ReadOnly = true;
            this.u_name.Width = 57;
            // 
            // u_mail
            // 
            this.u_mail.HeaderText = "ADRESSE MAIL";
            this.u_mail.Name = "u_mail";
            this.u_mail.ReadOnly = true;
            this.u_mail.Width = 102;
            // 
            // u_isActived
            // 
            this.u_isActived.HeaderText = "ACTIF";
            this.u_isActived.Name = "u_isActived";
            this.u_isActived.ReadOnly = true;
            this.u_isActived.Width = 62;
            // 
            // tb_SETTINGS_BR
            // 
            this.tb_SETTINGS_BR.Controls.Add(this.tb_address_mail);
            this.tb_SETTINGS_BR.Controls.Add(this.tb_no_fax);
            this.tb_SETTINGS_BR.Controls.Add(this.label27);
            this.tb_SETTINGS_BR.Controls.Add(this.label26);
            this.tb_SETTINGS_BR.Controls.Add(this.label25);
            this.tb_SETTINGS_BR.Controls.Add(this.label24);
            this.tb_SETTINGS_BR.Controls.Add(this.tb_no_phone);
            this.tb_SETTINGS_BR.Controls.Add(this.tb_city);
            this.tb_SETTINGS_BR.Controls.Add(this.tb_zip_code);
            this.tb_SETTINGS_BR.Controls.Add(this.label19);
            this.tb_SETTINGS_BR.Controls.Add(this.label20);
            this.tb_SETTINGS_BR.Controls.Add(this.label21);
            this.tb_SETTINGS_BR.Controls.Add(this.tb_address);
            this.tb_SETTINGS_BR.Controls.Add(this.tb_interlocuteur);
            this.tb_SETTINGS_BR.Controls.Add(this.label22);
            this.tb_SETTINGS_BR.Controls.Add(this.bt_maj_settings);
            this.tb_SETTINGS_BR.Controls.Add(this.tb_company);
            this.tb_SETTINGS_BR.Controls.Add(this.label23);
            this.tb_SETTINGS_BR.Location = new System.Drawing.Point(4, 22);
            this.tb_SETTINGS_BR.Name = "tb_SETTINGS_BR";
            this.tb_SETTINGS_BR.Size = new System.Drawing.Size(1250, 679);
            this.tb_SETTINGS_BR.TabIndex = 7;
            this.tb_SETTINGS_BR.Text = "PARAMETRES BR";
            this.tb_SETTINGS_BR.UseVisualStyleBackColor = true;
            // 
            // tb_address_mail
            // 
            this.tb_address_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address_mail.Location = new System.Drawing.Point(164, 351);
            this.tb_address_mail.Name = "tb_address_mail";
            this.tb_address_mail.Size = new System.Drawing.Size(376, 31);
            this.tb_address_mail.TabIndex = 59;
            // 
            // tb_no_fax
            // 
            this.tb_no_fax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_no_fax.Location = new System.Drawing.Point(164, 314);
            this.tb_no_fax.Name = "tb_no_fax";
            this.tb_no_fax.Size = new System.Drawing.Size(376, 31);
            this.tb_no_fax.TabIndex = 58;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(9, 354);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(149, 25);
            this.label27.TabIndex = 57;
            this.label27.Text = "Adresse Mail :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(93, 317);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 25);
            this.label26.TabIndex = 56;
            this.label26.Text = "FAX :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(32, 280);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(126, 25);
            this.label25.TabIndex = 55;
            this.label25.Text = "Téléphone :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(93, 243);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 25);
            this.label24.TabIndex = 54;
            this.label24.Text = "Ville :";
            // 
            // tb_no_phone
            // 
            this.tb_no_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_no_phone.Location = new System.Drawing.Point(164, 277);
            this.tb_no_phone.Name = "tb_no_phone";
            this.tb_no_phone.Size = new System.Drawing.Size(376, 31);
            this.tb_no_phone.TabIndex = 53;
            // 
            // tb_city
            // 
            this.tb_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_city.Location = new System.Drawing.Point(164, 240);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(376, 31);
            this.tb_city.TabIndex = 52;
            // 
            // tb_zip_code
            // 
            this.tb_zip_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_zip_code.Location = new System.Drawing.Point(164, 203);
            this.tb_zip_code.Name = "tb_zip_code";
            this.tb_zip_code.Size = new System.Drawing.Size(376, 31);
            this.tb_zip_code.TabIndex = 51;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(17, 206);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(141, 25);
            this.label19.TabIndex = 50;
            this.label19.Text = "Code Postal :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(55, 169);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 25);
            this.label20.TabIndex = 49;
            this.label20.Text = "Adresse :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(15, 132);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(143, 25);
            this.label21.TabIndex = 48;
            this.label21.Text = "Interlocuteur :";
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.Location = new System.Drawing.Point(164, 166);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(376, 31);
            this.tb_address.TabIndex = 47;
            // 
            // tb_interlocuteur
            // 
            this.tb_interlocuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_interlocuteur.Location = new System.Drawing.Point(164, 129);
            this.tb_interlocuteur.Name = "tb_interlocuteur";
            this.tb_interlocuteur.Size = new System.Drawing.Size(376, 31);
            this.tb_interlocuteur.TabIndex = 46;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(62, 95);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 25);
            this.label22.TabIndex = 45;
            this.label22.Text = "Société :";
            // 
            // bt_maj_settings
            // 
            this.bt_maj_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_maj_settings.Location = new System.Drawing.Point(164, 408);
            this.bt_maj_settings.Name = "bt_maj_settings";
            this.bt_maj_settings.Size = new System.Drawing.Size(376, 35);
            this.bt_maj_settings.TabIndex = 44;
            this.bt_maj_settings.Text = "Mettre à Jour";
            this.bt_maj_settings.UseVisualStyleBackColor = true;
            this.bt_maj_settings.Click += new System.EventHandler(this.Bt_maj_settings_Click);
            // 
            // tb_company
            // 
            this.tb_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_company.Location = new System.Drawing.Point(164, 92);
            this.tb_company.Name = "tb_company";
            this.tb_company.Size = new System.Drawing.Size(376, 31);
            this.tb_company.TabIndex = 43;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(166, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(374, 31);
            this.label23.TabIndex = 42;
            this.label23.Text = "Paramètres Bon de Retours";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.Location = new System.Drawing.Point(12, 725);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(176, 20);
            this.lb_user.TabIndex = 1;
            this.lb_user.Text = "USER : PRENOM NOM";
            // 
            // F_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 754);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.tb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion PDA > Programme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close_app);
            this.tb.ResumeLayout(false);
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
            this.tb_FACTURES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFACT)).EndInit();
            this.tb_SUIVI_COLIS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCOLIS)).EndInit();
            this.tb_UTILISATEURS.ResumeLayout(false);
            this.tb_UTILISATEURS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUSERS)).EndInit();
            this.tb_SETTINGS_BR.ResumeLayout(false);
            this.tb_SETTINGS_BR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tb;
        private System.Windows.Forms.TabPage tab_PDA;
        private System.Windows.Forms.DataGridView dtgPDA;
        private System.Windows.Forms.TabPage tab_SIM_Societe;
        private System.Windows.Forms.TabPage tab_BR;
        private System.Windows.Forms.TabPage tab_BL;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.TabPage tb_UTILISATEURS;
        private System.Windows.Forms.DataGridView dtgUSERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_isActived;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bt_user_add;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bt_user_password;
        private System.Windows.Forms.Button bt_user_edit;
        private System.Windows.Forms.ComboBox cm_actif;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.TabPage tb_SETTINGS_BR;
        private System.Windows.Forms.TabPage tb_FACTURES;
        private System.Windows.Forms.DataGridView dtgFACT;
        private System.Windows.Forms.WebBrowser webFACT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.TextBox tb_address_mail;
        private System.Windows.Forms.TextBox tb_no_fax;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tb_no_phone;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.TextBox tb_zip_code;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_interlocuteur;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button bt_maj_settings;
        private System.Windows.Forms.TextBox tb_company;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage tb_SUIVI_COLIS;
        private System.Windows.Forms.DataGridView dtgCOLIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.WebBrowser webCOLIS;
    }
}

