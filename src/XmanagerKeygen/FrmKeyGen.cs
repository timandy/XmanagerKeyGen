using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.Windows.Forms;

namespace XmanagerKeygen
{
    public partial class FrmKeyGen : UIForm
    {
        private UILabel caption;
        private ComboBox cboProduct;
        private NumericUpDown nudVersion;
        private TextBox txtKey;
        private UIButton btnGen;
        private UIButton btnClose;

        public FrmKeyGen()
        {
            InitializeComponent();
            this.InitUI();
            this.InitLogic();
        }

        protected void InitUI()
        {
            this.SuspendLayout();
            //背景
            UIImage backImg = new UIImage();
            backImg.Padding = new Padding(1);
            backImg.Dock = DockStyle.Fill;
            backImg.AnimationRandom = true;
            backImg.AddFrame(Color.FromArgb(30, 30, 30));
            backImg.AddFrame(Color.FromArgb(50, 50, 50));
            backImg.AddFrame(Color.FromArgb(70, 70, 70));
            this.UIControls.Add(backImg);
            //标题
            this.caption = new UILabel();
            this.caption.Height = 25;
            this.caption.Dock = DockStyle.Top;
            this.caption.Text = this.Text;
            this.caption.TextAlign = ContentAlignment.MiddleLeft;
            backImg.UIControls.Add(this.caption);
            //分割线
            UILine line = new UILine();
            line.LineBlendStyle = BlendStyle.FadeInFadeOut;
            line.LineDashStyle = DashStyle.Dash;
            line.Dock = DockStyle.Top;
            backImg.UIControls.Add(line);
            //标签
            UILabel lbl1 = new UILabel();
            lbl1.Text = "产品: ";
            lbl1.Location = new Point(12, 37);
            lbl1.Size = new Size(39, 17);
            backImg.UIControls.Add(lbl1);
            //标签
            UILabel lbl2 = new UILabel();
            lbl2.Text = "版本: ";
            lbl2.Location = new Point(12, 70);
            lbl2.Size = new Size(39, 17);
            backImg.UIControls.Add(lbl2);
            //标签
            UILabel lbl3 = new UILabel();
            lbl3.Text = "秘钥: ";
            lbl3.Location = new Point(12, 103);
            lbl3.Size = new Size(39, 17);
            backImg.UIControls.Add(lbl3);
            //产品下拉框
            this.cboProduct = new ComboBox();
            this.cboProduct.Parent = this;
            this.cboProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboProduct.BackColor = this.BackColor;
            this.cboProduct.ForeColor = this.ForeColor;
            this.cboProduct.Location = new Point(57, 34);
            this.cboProduct.Size = new Size(238, 25);
            ProductCode[] productCodes = (ProductCode[])Enum.GetValues(typeof(ProductCode));
            var values = productCodes.Select(a => new
            {
                Text = a.ToString().Replace('_', ' '),
                Value = a
            }).ToList();
            this.cboProduct.DataSource = values;
            this.cboProduct.DisplayMember = "Text";
            this.cboProduct.ValueMember = "Value";
            this.cboProduct.SelectedValue = ProductCode.Xmanager_Enterprise;
            //版本文本框
            this.nudVersion = new NumericUpDown();
            this.nudVersion.Parent = this;
            this.nudVersion.BorderStyle = BorderStyle.FixedSingle;
            this.nudVersion.BackColor = this.BackColor;
            this.nudVersion.ForeColor = this.ForeColor;
            this.nudVersion.Location = new Point(57, 68);
            this.nudVersion.Size = new Size(238, 23);
            this.nudVersion.Minimum = ProductCollection.Default.Min(a => a.Version);
            this.nudVersion.Maximum = ProductCollection.Default.Max(a => a.Version);
            this.nudVersion.Value = this.nudVersion.Maximum;
            //秘钥文本框
            this.txtKey = new TextBox();
            this.txtKey.Parent = this;
            this.txtKey.BorderStyle = BorderStyle.FixedSingle;
            this.txtKey.BackColor = this.BackColor;
            this.txtKey.ForeColor = this.ForeColor;
            this.txtKey.ReadOnly = true;
            this.txtKey.Location = new Point(57, 100);
            this.txtKey.Size = new Size(238, 23);
            //生成秘钥
            this.btnGen = new UIButton();
            this.btnGen.Location = new Point(57, 132);
            this.btnGen.Size = new Size(75, 23);
            this.btnGen.Text = "生成秘钥";
            backImg.UIControls.Add(this.btnGen);
            //关闭
            this.btnClose = new UIButton();
            this.btnClose.Location = new Point(220, 132);
            this.btnClose.Size = new Size(75, 23);
            this.btnClose.Text = "关闭";
            backImg.UIControls.Add(this.btnClose);

            this.ResumeLayout();
        }

        protected void InitLogic()
        {
            this.caption.MouseDown += (sender, e) => Util.BeginDrag(this.Handle);
            this.btnGen.Click += (sender, e) =>
            {
                try
                {
                    this.txtKey.Focus();
                    ProductCode productCode = (ProductCode)this.cboProduct.SelectedValue;
                    int version = (int)this.nudVersion.Value;
                    this.txtKey.Text = KeyGen.GenerateKey(productCode, version, 999, DateTime.Now);
                    this.txtKey.SelectAll();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(this, exp.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            };
            this.btnClose.Click += (sender, e) => this.Close();
        }
    }
}
