namespace Ex3
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.picWarrior = new System.Windows.Forms.PictureBox();
            this.picMagician = new System.Windows.Forms.PictureBox();
            this.lblWarriorOriginalLife = new System.Windows.Forms.Label();
            this.lblWarriorCurrentLife = new System.Windows.Forms.Label();
            this.lblMagicianCurrentLife = new System.Windows.Forms.Label();
            this.lblMagicianOriginalLife = new System.Windows.Forms.Label();
            this.lblMinotaurCurrentLife = new System.Windows.Forms.Label();
            this.lblMinotaurOriginalLife = new System.Windows.Forms.Label();
            this.lblNecromancerCurrentLife = new System.Windows.Forms.Label();
            this.lblNecromancerOriginalLife = new System.Windows.Forms.Label();
            this.picNecromancer = new System.Windows.Forms.PictureBox();
            this.picMinotaur = new System.Windows.Forms.PictureBox();
            this.buttonHeroAttack = new System.Windows.Forms.Button();
            this.buttonMonsterAttack = new System.Windows.Forms.Button();
            this.labelWarriorLife = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelWarriorName = new System.Windows.Forms.Label();
            this.labelMagicianName = new System.Windows.Forms.Label();
            this.labelNecromancerName = new System.Windows.Forms.Label();
            this.labelMinotaurName = new System.Windows.Forms.Label();
            this.labelMagicianLife = new System.Windows.Forms.Label();
            this.labelNecromancerLife = new System.Windows.Forms.Label();
            this.labelMinotaurLife = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.picTechAbility = new System.Windows.Forms.PictureBox();
            this.timerability = new System.Windows.Forms.Timer(this.components);
            this.timerAbilityNer = new System.Windows.Forms.Timer(this.components);
            this.picTechAbilityNer = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWarrior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMagician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNecromancer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinotaur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTechAbility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTechAbilityNer)).BeginInit();
            this.SuspendLayout();
            // 
            // picWarrior
            // 
            this.picWarrior.BackColor = System.Drawing.Color.Transparent;
            this.picWarrior.BackgroundImage = global::Ex3.Properties.Resources.wir;
            this.picWarrior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWarrior.Location = new System.Drawing.Point(134, 97);
            this.picWarrior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picWarrior.Name = "picWarrior";
            this.picWarrior.Size = new System.Drawing.Size(149, 191);
            this.picWarrior.TabIndex = 1;
            this.picWarrior.TabStop = false;
            this.picWarrior.Click += new System.EventHandler(this.picWarrior_Click);
            // 
            // picMagician
            // 
            this.picMagician.BackColor = System.Drawing.Color.Transparent;
            this.picMagician.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMagician.BackgroundImage")));
            this.picMagician.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMagician.Location = new System.Drawing.Point(134, 320);
            this.picMagician.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMagician.Name = "picMagician";
            this.picMagician.Size = new System.Drawing.Size(149, 232);
            this.picMagician.TabIndex = 2;
            this.picMagician.TabStop = false;
            this.picMagician.Click += new System.EventHandler(this.picMagician_Click);
            // 
            // lblWarriorOriginalLife
            // 
            this.lblWarriorOriginalLife.BackColor = System.Drawing.Color.Red;
            this.lblWarriorOriginalLife.Location = new System.Drawing.Point(73, 56);
            this.lblWarriorOriginalLife.Name = "lblWarriorOriginalLife";
            this.lblWarriorOriginalLife.Size = new System.Drawing.Size(196, 24);
            this.lblWarriorOriginalLife.TabIndex = 3;
            // 
            // lblWarriorCurrentLife
            // 
            this.lblWarriorCurrentLife.BackColor = System.Drawing.Color.Yellow;
            this.lblWarriorCurrentLife.Location = new System.Drawing.Point(73, 56);
            this.lblWarriorCurrentLife.Name = "lblWarriorCurrentLife";
            this.lblWarriorCurrentLife.Size = new System.Drawing.Size(152, 24);
            this.lblWarriorCurrentLife.TabIndex = 4;
            // 
            // lblMagicianCurrentLife
            // 
            this.lblMagicianCurrentLife.BackColor = System.Drawing.Color.Yellow;
            this.lblMagicianCurrentLife.Location = new System.Drawing.Point(73, 294);
            this.lblMagicianCurrentLife.Name = "lblMagicianCurrentLife";
            this.lblMagicianCurrentLife.Size = new System.Drawing.Size(152, 24);
            this.lblMagicianCurrentLife.TabIndex = 6;
            // 
            // lblMagicianOriginalLife
            // 
            this.lblMagicianOriginalLife.BackColor = System.Drawing.Color.Red;
            this.lblMagicianOriginalLife.Location = new System.Drawing.Point(73, 294);
            this.lblMagicianOriginalLife.Name = "lblMagicianOriginalLife";
            this.lblMagicianOriginalLife.Size = new System.Drawing.Size(196, 24);
            this.lblMagicianOriginalLife.TabIndex = 5;
            // 
            // lblMinotaurCurrentLife
            // 
            this.lblMinotaurCurrentLife.BackColor = System.Drawing.Color.Yellow;
            this.lblMinotaurCurrentLife.Location = new System.Drawing.Point(732, 294);
            this.lblMinotaurCurrentLife.Name = "lblMinotaurCurrentLife";
            this.lblMinotaurCurrentLife.Size = new System.Drawing.Size(153, 24);
            this.lblMinotaurCurrentLife.TabIndex = 10;
            // 
            // lblMinotaurOriginalLife
            // 
            this.lblMinotaurOriginalLife.BackColor = System.Drawing.Color.Red;
            this.lblMinotaurOriginalLife.Location = new System.Drawing.Point(732, 294);
            this.lblMinotaurOriginalLife.Name = "lblMinotaurOriginalLife";
            this.lblMinotaurOriginalLife.Size = new System.Drawing.Size(196, 24);
            this.lblMinotaurOriginalLife.TabIndex = 9;
            // 
            // lblNecromancerCurrentLife
            // 
            this.lblNecromancerCurrentLife.BackColor = System.Drawing.Color.Yellow;
            this.lblNecromancerCurrentLife.Location = new System.Drawing.Point(732, 56);
            this.lblNecromancerCurrentLife.Name = "lblNecromancerCurrentLife";
            this.lblNecromancerCurrentLife.Size = new System.Drawing.Size(153, 24);
            this.lblNecromancerCurrentLife.TabIndex = 8;
            // 
            // lblNecromancerOriginalLife
            // 
            this.lblNecromancerOriginalLife.BackColor = System.Drawing.Color.Red;
            this.lblNecromancerOriginalLife.Location = new System.Drawing.Point(732, 56);
            this.lblNecromancerOriginalLife.Name = "lblNecromancerOriginalLife";
            this.lblNecromancerOriginalLife.Size = new System.Drawing.Size(196, 24);
            this.lblNecromancerOriginalLife.TabIndex = 7;
            // 
            // picNecromancer
            // 
            this.picNecromancer.BackColor = System.Drawing.Color.Transparent;
            this.picNecromancer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picNecromancer.BackgroundImage")));
            this.picNecromancer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picNecromancer.Location = new System.Drawing.Point(708, 82);
            this.picNecromancer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picNecromancer.Name = "picNecromancer";
            this.picNecromancer.Size = new System.Drawing.Size(149, 168);
            this.picNecromancer.TabIndex = 11;
            this.picNecromancer.TabStop = false;
            this.picNecromancer.Click += new System.EventHandler(this.picNecromancer_Click);
            // 
            // picMinotaur
            // 
            this.picMinotaur.BackColor = System.Drawing.Color.Transparent;
            this.picMinotaur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMinotaur.BackgroundImage")));
            this.picMinotaur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMinotaur.Location = new System.Drawing.Point(700, 341);
            this.picMinotaur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMinotaur.Name = "picMinotaur";
            this.picMinotaur.Size = new System.Drawing.Size(163, 175);
            this.picMinotaur.TabIndex = 12;
            this.picMinotaur.TabStop = false;
            this.picMinotaur.Click += new System.EventHandler(this.picMinotaur_Click);
            // 
            // buttonHeroAttack
            // 
            this.buttonHeroAttack.Font = new System.Drawing.Font("幼圆", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonHeroAttack.Location = new System.Drawing.Point(269, 489);
            this.buttonHeroAttack.Name = "buttonHeroAttack";
            this.buttonHeroAttack.Size = new System.Drawing.Size(100, 47);
            this.buttonHeroAttack.TabIndex = 13;
            this.buttonHeroAttack.Text = "英雄攻击";
            this.buttonHeroAttack.UseVisualStyleBackColor = true;
            this.buttonHeroAttack.Click += new System.EventHandler(this.buttonHeroAttack_Click);
            // 
            // buttonMonsterAttack
            // 
            this.buttonMonsterAttack.Font = new System.Drawing.Font("幼圆", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonMonsterAttack.Location = new System.Drawing.Point(522, 485);
            this.buttonMonsterAttack.Name = "buttonMonsterAttack";
            this.buttonMonsterAttack.Size = new System.Drawing.Size(100, 47);
            this.buttonMonsterAttack.TabIndex = 14;
            this.buttonMonsterAttack.Text = "怪物攻击";
            this.buttonMonsterAttack.UseVisualStyleBackColor = true;
            this.buttonMonsterAttack.Click += new System.EventHandler(this.buttonMonsterAttack_Click);
            // 
            // labelWarriorLife
            // 
            this.labelWarriorLife.AutoSize = true;
            this.labelWarriorLife.BackColor = System.Drawing.Color.Transparent;
            this.labelWarriorLife.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWarriorLife.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelWarriorLife.Location = new System.Drawing.Point(72, 18);
            this.labelWarriorLife.Name = "labelWarriorLife";
            this.labelWarriorLife.Size = new System.Drawing.Size(73, 21);
            this.labelWarriorLife.TabIndex = 15;
            this.labelWarriorLife.Text = "血量：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(732, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 18;
            // 
            // labelWarriorName
            // 
            this.labelWarriorName.BackColor = System.Drawing.Color.Transparent;
            this.labelWarriorName.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarriorName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelWarriorName.Location = new System.Drawing.Point(5, 97);
            this.labelWarriorName.Name = "labelWarriorName";
            this.labelWarriorName.Size = new System.Drawing.Size(123, 48);
            this.labelWarriorName.TabIndex = 19;
            this.labelWarriorName.Text = "Warrior";
            // 
            // labelMagicianName
            // 
            this.labelMagicianName.BackColor = System.Drawing.Color.Transparent;
            this.labelMagicianName.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMagicianName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMagicianName.Location = new System.Drawing.Point(-4, 341);
            this.labelMagicianName.Name = "labelMagicianName";
            this.labelMagicianName.Size = new System.Drawing.Size(132, 48);
            this.labelMagicianName.TabIndex = 20;
            this.labelMagicianName.Text = "Magician";
            // 
            // labelNecromancerName
            // 
            this.labelNecromancerName.BackColor = System.Drawing.Color.Transparent;
            this.labelNecromancerName.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNecromancerName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNecromancerName.Location = new System.Drawing.Point(849, 109);
            this.labelNecromancerName.Name = "labelNecromancerName";
            this.labelNecromancerName.Size = new System.Drawing.Size(196, 48);
            this.labelNecromancerName.TabIndex = 21;
            this.labelNecromancerName.Text = "Necromancer";
            // 
            // labelMinotaurName
            // 
            this.labelMinotaurName.BackColor = System.Drawing.Color.Transparent;
            this.labelMinotaurName.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinotaurName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMinotaurName.Location = new System.Drawing.Point(869, 355);
            this.labelMinotaurName.Name = "labelMinotaurName";
            this.labelMinotaurName.Size = new System.Drawing.Size(151, 48);
            this.labelMinotaurName.TabIndex = 22;
            this.labelMinotaurName.Text = "Minotaur";
            // 
            // labelMagicianLife
            // 
            this.labelMagicianLife.AutoSize = true;
            this.labelMagicianLife.BackColor = System.Drawing.Color.Transparent;
            this.labelMagicianLife.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMagicianLife.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelMagicianLife.Location = new System.Drawing.Point(72, 261);
            this.labelMagicianLife.Name = "labelMagicianLife";
            this.labelMagicianLife.Size = new System.Drawing.Size(73, 21);
            this.labelMagicianLife.TabIndex = 23;
            this.labelMagicianLife.Text = "血量：";
            // 
            // labelNecromancerLife
            // 
            this.labelNecromancerLife.AutoSize = true;
            this.labelNecromancerLife.BackColor = System.Drawing.Color.Transparent;
            this.labelNecromancerLife.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNecromancerLife.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelNecromancerLife.Location = new System.Drawing.Point(731, 18);
            this.labelNecromancerLife.Name = "labelNecromancerLife";
            this.labelNecromancerLife.Size = new System.Drawing.Size(73, 21);
            this.labelNecromancerLife.TabIndex = 24;
            this.labelNecromancerLife.Text = "血量：";
            // 
            // labelMinotaurLife
            // 
            this.labelMinotaurLife.AutoSize = true;
            this.labelMinotaurLife.BackColor = System.Drawing.Color.Transparent;
            this.labelMinotaurLife.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMinotaurLife.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelMinotaurLife.Location = new System.Drawing.Point(731, 262);
            this.labelMinotaurLife.Name = "labelMinotaurLife";
            this.labelMinotaurLife.Size = new System.Drawing.Size(73, 21);
            this.labelMinotaurLife.TabIndex = 25;
            this.labelMinotaurLife.Text = "血量：";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Font = new System.Drawing.Font("幼圆", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRestart.Location = new System.Drawing.Point(397, 485);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(96, 51);
            this.buttonRestart.TabIndex = 26;
            this.buttonRestart.Text = "重新开始";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // picTechAbility
            // 
            this.picTechAbility.BackColor = System.Drawing.Color.Transparent;
            this.picTechAbility.Image = ((System.Drawing.Image)(resources.GetObject("picTechAbility.Image")));
            this.picTechAbility.Location = new System.Drawing.Point(301, 369);
            this.picTechAbility.Name = "picTechAbility";
            this.picTechAbility.Size = new System.Drawing.Size(68, 62);
            this.picTechAbility.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTechAbility.TabIndex = 27;
            this.picTechAbility.TabStop = false;
            this.picTechAbility.Visible = false;
            // 
            // timerability
            // 
            this.timerability.Tick += new System.EventHandler(this.timerability_Tick);
            // 
            // timerAbilityNer
            // 
            this.timerAbilityNer.Tick += new System.EventHandler(this.timerAbilityNer_Tick);
            // 
            // picTechAbilityNer
            // 
            this.picTechAbilityNer.BackColor = System.Drawing.Color.Transparent;
            this.picTechAbilityNer.Image = ((System.Drawing.Image)(resources.GetObject("picTechAbilityNer.Image")));
            this.picTechAbilityNer.Location = new System.Drawing.Point(596, 142);
            this.picTechAbilityNer.Name = "picTechAbilityNer";
            this.picTechAbilityNer.Size = new System.Drawing.Size(71, 59);
            this.picTechAbilityNer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTechAbilityNer.TabIndex = 28;
            this.picTechAbilityNer.TabStop = false;
            this.picTechAbilityNer.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 47);
            this.button1.TabIndex = 29;
            this.button1.Text = "自动对打";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(397, 38);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(59, 28);
            this.buttonSave.TabIndex = 30;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(488, 38);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(59, 28);
            this.buttonLoad.TabIndex = 31;
            this.buttonLoad.Text = "加载";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 548);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picTechAbilityNer);
            this.Controls.Add(this.picTechAbility);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelMinotaurLife);
            this.Controls.Add(this.labelNecromancerLife);
            this.Controls.Add(this.labelMagicianLife);
            this.Controls.Add(this.labelMinotaurName);
            this.Controls.Add(this.labelNecromancerName);
            this.Controls.Add(this.labelMagicianName);
            this.Controls.Add(this.labelWarriorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelWarriorLife);
            this.Controls.Add(this.buttonMonsterAttack);
            this.Controls.Add(this.buttonHeroAttack);
            this.Controls.Add(this.picMinotaur);
            this.Controls.Add(this.picNecromancer);
            this.Controls.Add(this.lblMinotaurCurrentLife);
            this.Controls.Add(this.lblMinotaurOriginalLife);
            this.Controls.Add(this.lblNecromancerCurrentLife);
            this.Controls.Add(this.lblNecromancerOriginalLife);
            this.Controls.Add(this.lblMagicianCurrentLife);
            this.Controls.Add(this.lblMagicianOriginalLife);
            this.Controls.Add(this.lblWarriorCurrentLife);
            this.Controls.Add(this.lblWarriorOriginalLife);
            this.Controls.Add(this.picMagician);
            this.Controls.Add(this.picWarrior);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWarrior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMagician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNecromancer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinotaur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTechAbility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTechAbilityNer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWarrior;
        private System.Windows.Forms.PictureBox picMagician;
        private System.Windows.Forms.Label lblWarriorOriginalLife;
        private System.Windows.Forms.Label lblWarriorCurrentLife;
        private System.Windows.Forms.Label lblMagicianCurrentLife;
        private System.Windows.Forms.Label lblMagicianOriginalLife;
        private System.Windows.Forms.Label lblMinotaurCurrentLife;
        private System.Windows.Forms.Label lblMinotaurOriginalLife;
        private System.Windows.Forms.Label lblNecromancerCurrentLife;
        private System.Windows.Forms.Label lblNecromancerOriginalLife;
        private System.Windows.Forms.PictureBox picNecromancer;
        private System.Windows.Forms.PictureBox picMinotaur;
        private System.Windows.Forms.Button buttonHeroAttack;
        private System.Windows.Forms.Button buttonMonsterAttack;
        private System.Windows.Forms.Label labelWarriorLife;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelWarriorName;
        private System.Windows.Forms.Label labelMagicianName;
        private System.Windows.Forms.Label labelNecromancerName;
        private System.Windows.Forms.Label labelMinotaurName;
        private System.Windows.Forms.Label labelMagicianLife;
        private System.Windows.Forms.Label labelNecromancerLife;
        private System.Windows.Forms.Label labelMinotaurLife;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.PictureBox picTechAbility;
        private System.Windows.Forms.Timer timerability;
        private System.Windows.Forms.Timer timerAbilityNer;
        private System.Windows.Forms.PictureBox picTechAbilityNer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
    }
}

