﻿namespace GestLaboMach
{
    partial class ResultatForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultatForm));
            this.dataGridViewDossiers = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bindingNavigatorDossiers = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingSourceDossiers = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxListDossiers = new System.Windows.Forms.GroupBox();
            this.groupBoxDosDetail = new System.Windows.Forms.GroupBox();
            this.dataGridViewDosDT = new System.Windows.Forms.DataGridView();
            this.bindingSourceDossiersDt = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDossiers)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDossiers)).BeginInit();
            this.bindingNavigatorDossiers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDossiers)).BeginInit();
            this.groupBoxListDossiers.SuspendLayout();
            this.groupBoxDosDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDosDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDossiersDt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDossiers
            // 
            this.dataGridViewDossiers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDossiers.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewDossiers.Name = "dataGridViewDossiers";
            this.dataGridViewDossiers.Size = new System.Drawing.Size(403, 253);
            this.dataGridViewDossiers.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageResult);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 350);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.groupBoxDosDetail);
            this.tabPageResult.Controls.Add(this.groupBoxListDossiers);
            this.tabPageResult.Controls.Add(this.bindingNavigatorDossiers);
            this.tabPageResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(740, 324);
            this.tabPageResult.TabIndex = 0;
            this.tabPageResult.Text = "Résultats";
            this.tabPageResult.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bindingNavigatorDossiers
            // 
            this.bindingNavigatorDossiers.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorDossiers.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorDossiers.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorDossiers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorDossiers.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigatorDossiers.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorDossiers.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorDossiers.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorDossiers.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorDossiers.Name = "bindingNavigatorDossiers";
            this.bindingNavigatorDossiers.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorDossiers.Size = new System.Drawing.Size(734, 25);
            this.bindingNavigatorDossiers.TabIndex = 1;
            this.bindingNavigatorDossiers.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // groupBoxListDossiers
            // 
            this.groupBoxListDossiers.Controls.Add(this.dataGridViewDossiers);
            this.groupBoxListDossiers.Location = new System.Drawing.Point(6, 40);
            this.groupBoxListDossiers.Name = "groupBoxListDossiers";
            this.groupBoxListDossiers.Size = new System.Drawing.Size(415, 278);
            this.groupBoxListDossiers.TabIndex = 2;
            this.groupBoxListDossiers.TabStop = false;
            this.groupBoxListDossiers.Text = "Dossiers";
            // 
            // groupBoxDosDetail
            // 
            this.groupBoxDosDetail.Controls.Add(this.dataGridViewDosDT);
            this.groupBoxDosDetail.Location = new System.Drawing.Point(438, 40);
            this.groupBoxDosDetail.Name = "groupBoxDosDetail";
            this.groupBoxDosDetail.Size = new System.Drawing.Size(296, 278);
            this.groupBoxDosDetail.TabIndex = 3;
            this.groupBoxDosDetail.TabStop = false;
            this.groupBoxDosDetail.Text = "Examens";
            // 
            // dataGridViewDosDT
            // 
            this.dataGridViewDosDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDosDT.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewDosDT.Name = "dataGridViewDosDT";
            this.dataGridViewDosDT.Size = new System.Drawing.Size(284, 247);
            this.dataGridViewDosDT.TabIndex = 0;
            // 
            // ResultatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 439);
            this.Controls.Add(this.tabControl1);
            this.Name = "ResultatForm";
            this.Text = "ResultatForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDossiers)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageResult.ResumeLayout(false);
            this.tabPageResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDossiers)).EndInit();
            this.bindingNavigatorDossiers.ResumeLayout(false);
            this.bindingNavigatorDossiers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDossiers)).EndInit();
            this.groupBoxListDossiers.ResumeLayout(false);
            this.groupBoxDosDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDosDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDossiersDt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDossiers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageResult;
        private System.Windows.Forms.BindingNavigator bindingNavigatorDossiers;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource bindingSourceDossiers;
        private System.Windows.Forms.GroupBox groupBoxListDossiers;
        private System.Windows.Forms.GroupBox groupBoxDosDetail;
        private System.Windows.Forms.DataGridView dataGridViewDosDT;
        private System.Windows.Forms.BindingSource bindingSourceDossiersDt;
    }
}