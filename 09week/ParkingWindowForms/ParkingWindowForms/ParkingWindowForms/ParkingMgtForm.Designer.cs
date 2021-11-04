
namespace ParkingWindowForms
{
    partial class ParkingMgtForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_CarCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCarOut = new System.Windows.Forms.Button();
            this.btnCarIn = new System.Windows.Forms.Button();
            this.cdoCarList = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxState = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_CarCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 35);
            this.panel1.TabIndex = 0;
            // 
            // lb_CarCount
            // 
            this.lb_CarCount.AutoSize = true;
            this.lb_CarCount.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CarCount.Location = new System.Drawing.Point(189, 6);
            this.lb_CarCount.Name = "lb_CarCount";
            this.lb_CarCount.Size = new System.Drawing.Size(23, 24);
            this.lb_CarCount.TabIndex = 1;
            this.lb_CarCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "현재 차량 대수 : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCarOut);
            this.panel2.Controls.Add(this.btnCarIn);
            this.panel2.Controls.Add(this.cdoCarList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 86);
            this.panel2.TabIndex = 1;
            // 
            // btnCarOut
            // 
            this.btnCarOut.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCarOut.Location = new System.Drawing.Point(456, 27);
            this.btnCarOut.Name = "btnCarOut";
            this.btnCarOut.Size = new System.Drawing.Size(111, 35);
            this.btnCarOut.TabIndex = 2;
            this.btnCarOut.Text = "출 차";
            this.btnCarOut.UseVisualStyleBackColor = true;
            // 
            // btnCarIn
            // 
            this.btnCarIn.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCarIn.Location = new System.Drawing.Point(339, 27);
            this.btnCarIn.Name = "btnCarIn";
            this.btnCarIn.Size = new System.Drawing.Size(111, 35);
            this.btnCarIn.TabIndex = 1;
            this.btnCarIn.Text = "입 차";
            this.btnCarIn.UseVisualStyleBackColor = true;
            // 
            // cdoCarList
            // 
            this.cdoCarList.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cdoCarList.FormattingEnabled = true;
            this.cdoCarList.Location = new System.Drawing.Point(23, 27);
            this.cdoCarList.Name = "cdoCarList";
            this.cdoCarList.Size = new System.Drawing.Size(300, 35);
            this.cdoCarList.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBoxState);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 307);
            this.panel3.TabIndex = 2;
            // 
            // listBoxState
            // 
            this.listBoxState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxState.FormattingEnabled = true;
            this.listBoxState.ItemHeight = 12;
            this.listBoxState.Location = new System.Drawing.Point(0, 0);
            this.listBoxState.Name = "listBoxState";
            this.listBoxState.Size = new System.Drawing.Size(602, 307);
            this.listBoxState.TabIndex = 0;
            // 
            // ParkingMgtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 428);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ParkingMgtForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCarOut;
        private System.Windows.Forms.Button btnCarIn;
        private System.Windows.Forms.ComboBox cdoCarList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBoxState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_CarCount;
    }
}

