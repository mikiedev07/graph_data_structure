
namespace graph_lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.show_graph = new System.Windows.Forms.Button();
            this.bfs = new System.Windows.Forms.Button();
            this.dfs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vertex_2 = new System.Windows.Forms.TextBox();
            this.vertex_1 = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox2.Location = new System.Drawing.Point(228, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(621, 504);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // show_graph
            // 
            this.show_graph.Location = new System.Drawing.Point(74, 41);
            this.show_graph.Name = "show_graph";
            this.show_graph.Size = new System.Drawing.Size(75, 23);
            this.show_graph.TabIndex = 1;
            this.show_graph.Text = "Show Graph";
            this.show_graph.UseVisualStyleBackColor = true;
            this.show_graph.Click += new System.EventHandler(this.show_graph_Click);
            // 
            // bfs
            // 
            this.bfs.Location = new System.Drawing.Point(25, 188);
            this.bfs.Name = "bfs";
            this.bfs.Size = new System.Drawing.Size(75, 23);
            this.bfs.TabIndex = 2;
            this.bfs.Text = "BFS";
            this.bfs.UseVisualStyleBackColor = true;
            this.bfs.Click += new System.EventHandler(this.button2_Click);
            // 
            // dfs
            // 
            this.dfs.Location = new System.Drawing.Point(126, 188);
            this.dfs.Name = "dfs";
            this.dfs.Size = new System.Drawing.Size(75, 23);
            this.dfs.TabIndex = 3;
            this.dfs.Text = "DFS";
            this.dfs.UseVisualStyleBackColor = true;
            this.dfs.Click += new System.EventHandler(this.dfs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 90);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the first vertex (number)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter the second vertex (number)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Path:";
            // 
            // vertex_2
            // 
            this.vertex_2.Location = new System.Drawing.Point(183, 126);
            this.vertex_2.Name = "vertex_2";
            this.vertex_2.Size = new System.Drawing.Size(39, 20);
            this.vertex_2.TabIndex = 7;
            // 
            // vertex_1
            // 
            this.vertex_1.Location = new System.Drawing.Point(183, 87);
            this.vertex_1.Name = "vertex_1";
            this.vertex_1.Size = new System.Drawing.Size(39, 20);
            this.vertex_1.TabIndex = 8;
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(51, 328);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(162, 20);
            this.path.TabIndex = 9;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(849, 503);
            this.Controls.Add(this.path);
            this.Controls.Add(this.vertex_1);
            this.Controls.Add(this.vertex_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dfs);
            this.Controls.Add(this.bfs);
            this.Controls.Add(this.show_graph);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button show_graph;
        private System.Windows.Forms.Button bfs;
        private System.Windows.Forms.Button dfs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vertex_2;
        private System.Windows.Forms.TextBox vertex_1;
        private System.Windows.Forms.TextBox path;
    }
}

