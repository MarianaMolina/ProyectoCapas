
namespace CapaPresentacion
{
    partial class Menu_Principal
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
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_MantenimientoLibro = new System.Windows.Forms.Button();
            this.btn_PrestamoLibro = new System.Windows.Forms.Button();
            this.btn_MantenimientoVideo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_PrestamoVideo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(24, 28);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(187, 87);
            this.btn_consulta.TabIndex = 0;
            this.btn_consulta.Text = "CONSULTA";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_MantenimientoLibro
            // 
            this.btn_MantenimientoLibro.Location = new System.Drawing.Point(273, 162);
            this.btn_MantenimientoLibro.Name = "btn_MantenimientoLibro";
            this.btn_MantenimientoLibro.Size = new System.Drawing.Size(187, 87);
            this.btn_MantenimientoLibro.TabIndex = 1;
            this.btn_MantenimientoLibro.Text = "LIBRO";
            this.btn_MantenimientoLibro.UseVisualStyleBackColor = true;
            this.btn_MantenimientoLibro.Click += new System.EventHandler(this.btn_MantenimientoLibro_Click);
            // 
            // btn_PrestamoLibro
            // 
            this.btn_PrestamoLibro.Location = new System.Drawing.Point(273, 298);
            this.btn_PrestamoLibro.Name = "btn_PrestamoLibro";
            this.btn_PrestamoLibro.Size = new System.Drawing.Size(187, 87);
            this.btn_PrestamoLibro.TabIndex = 2;
            this.btn_PrestamoLibro.Text = "LIBRO";
            this.btn_PrestamoLibro.UseVisualStyleBackColor = true;
            this.btn_PrestamoLibro.Click += new System.EventHandler(this.btn_PrestamoLibro_Click);
            // 
            // btn_MantenimientoVideo
            // 
            this.btn_MantenimientoVideo.Location = new System.Drawing.Point(530, 162);
            this.btn_MantenimientoVideo.Name = "btn_MantenimientoVideo";
            this.btn_MantenimientoVideo.Size = new System.Drawing.Size(187, 87);
            this.btn_MantenimientoVideo.TabIndex = 3;
            this.btn_MantenimientoVideo.Text = "VIDEO";
            this.btn_MantenimientoVideo.UseVisualStyleBackColor = true;
            this.btn_MantenimientoVideo.Click += new System.EventHandler(this.btn_MantenimientoVideo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MANTENIMIENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PRESTAMO";
            // 
            // btn_PrestamoVideo
            // 
            this.btn_PrestamoVideo.Location = new System.Drawing.Point(530, 298);
            this.btn_PrestamoVideo.Name = "btn_PrestamoVideo";
            this.btn_PrestamoVideo.Size = new System.Drawing.Size(187, 87);
            this.btn_PrestamoVideo.TabIndex = 6;
            this.btn_PrestamoVideo.Text = "VIDEO";
            this.btn_PrestamoVideo.UseVisualStyleBackColor = true;
            this.btn_PrestamoVideo.Click += new System.EventHandler(this.btn_PrestamoVideo_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_PrestamoVideo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MantenimientoVideo);
            this.Controls.Add(this.btn_PrestamoLibro);
            this.Controls.Add(this.btn_MantenimientoLibro);
            this.Controls.Add(this.btn_consulta);
            this.Name = "Menu_Principal";
            this.Text = "Menu_Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_MantenimientoLibro;
        private System.Windows.Forms.Button btn_PrestamoLibro;
        private System.Windows.Forms.Button btn_MantenimientoVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_PrestamoVideo;
    }
}