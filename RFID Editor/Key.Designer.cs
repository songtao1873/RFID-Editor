using System.Windows.Forms;

namespace Editor
{
    partial class Key
    {
        /// <summary>
        /// 必需的设计器变量
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有已用的资源
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
        /// 设计器支持的必需方法-请勿修改
        /// 使用代码编辑器可以看到此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Key));
            this.lv_KeyList = new System.Windows.Forms.ListView();
            this.col_Key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_DelAll = new System.Windows.Forms.Button();
            this.btn_ImportData = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_KeyList
            // 
            this.lv_KeyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Key});
            this.lv_KeyList.FullRowSelect = true;
            this.lv_KeyList.HideSelection = false;
            this.lv_KeyList.Location = new System.Drawing.Point(13, 14);
            this.lv_KeyList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lv_KeyList.Name = "lv_KeyList";
            this.lv_KeyList.Size = new System.Drawing.Size(280, 345);
            this.lv_KeyList.TabIndex = 0;
            this.lv_KeyList.UseCompatibleStateImageBehavior = false;
            this.lv_KeyList.View = System.Windows.Forms.View.Details;
            // 
            // col_Key
            // 
            this.col_Key.Text = "Key";
            this.col_Key.Width = 184;
            // 
            // txt_Key
            // 
            this.txt_Key.Location = new System.Drawing.Point(13, 369);
            this.txt_Key.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(280, 27);
            this.txt_Key.TabIndex = 1;
            this.txt_Key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Key_KeyPress);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(301, 368);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(108, 28);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "添加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_DelAll
            // 
            this.btn_DelAll.Location = new System.Drawing.Point(301, 52);
            this.btn_DelAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_DelAll.Name = "btn_DelAll";
            this.btn_DelAll.Size = new System.Drawing.Size(108, 28);
            this.btn_DelAll.TabIndex = 3;
            this.btn_DelAll.Text = "删除全部";
            this.btn_DelAll.UseVisualStyleBackColor = true;
            this.btn_DelAll.Click += new System.EventHandler(this.btn_DelAll_Click);
            // 
            // btn_ImportData
            // 
            this.btn_ImportData.Location = new System.Drawing.Point(300, 161);
            this.btn_ImportData.Name = "btn_ImportData";
            this.btn_ImportData.Size = new System.Drawing.Size(106, 50);
            this.btn_ImportData.TabIndex = 4;
            this.btn_ImportData.Text = "从数据文件中导入密钥";
            this.btn_ImportData.UseVisualStyleBackColor = true;
            this.btn_ImportData.Click += new System.EventHandler(this.btn_ImportData_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(301, 14);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(108, 28);
            this.btn_Del.TabIndex = 6;
            this.btn_Del.Text = "删除";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // Key
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 409);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_DelAll);
            this.Controls.Add(this.btn_ImportData);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.lv_KeyList);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Key";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "自定义密钥列表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Key_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_KeyList;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_DelAll;
        private System.Windows.Forms.Button btn_ImportData;
        private System.Windows.Forms.ColumnHeader col_Key;
        private System.Windows.Forms.Button btn_Del;
    }
}