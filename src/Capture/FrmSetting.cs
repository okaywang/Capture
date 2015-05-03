using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capture
{
    public partial class FrmSetting : Form
    {
        private FrmPackets _frmPackets;
        public FrmSetting(FrmPackets frm)
        {
            InitializeComponent();

            _frmPackets = frm;

            this.chkCss.Checked = _frmPackets.CaptureCss;
            this.chkJs.Checked = _frmPackets.CaptureJavascript;
            this.chkImage.Checked = _frmPackets.CaptureImage;
            this.chkAjax.Checked = _frmPackets.CaptureAjax;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _frmPackets.CaptureCss = this.chkCss.Checked;
            _frmPackets.CaptureJavascript = this.chkJs.Checked;
            _frmPackets.CaptureImage = this.chkImage.Checked;
            _frmPackets.CaptureAjax = this.chkAjax.Checked;
            this.Close();
        }
    }
}
