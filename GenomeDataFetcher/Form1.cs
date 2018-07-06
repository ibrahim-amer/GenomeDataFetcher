using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GenomeDataFetcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                await RunFetchJob().ConfigureAwait(false);
                MessageBox.Show("All files have been downloaded successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task RunFetchJob()
        {
            try
            {
                string genomeUrl = "http://genome.ucsc.edu/cgi-bin/hgc?hgsid=680097427_ePQ4YRhpOh4woALlthOXdak1gGAG&g=htcGetDna2&table=&i=mixed&o=33031596&l=33031596&r=33041570&getDnaPos=CHRNUM%3ASTARTPOS-ENDPOS&db=hg19&hgSeq.cdsExon=1&hgSeq.padding5=UPSTREAM&hgSeq.padding3=DOWNSTREAM&hgSeq.casing=CASING&boolshad.hgSeq.maskRepeats=MASKREPEATS&hgSeq.repMasking=REPMASKING&boolshad.hgSeq.revComp=REVCOMPLEMENT&submit=get+DNA";
                Settings settings = new Settings
                {
                    UpStream = string.IsNullOrWhiteSpace(this.upstream_textBox.Text) ? "0" : this.upstream_textBox.Text,
                    DownStream = string.IsNullOrWhiteSpace(this.downstream_textBox.Text) ? "0" : this.downstream_textBox.Text,
                    MaskRepeats = this.maskRepeats_checkBox.Checked ? "on" : "0",
                    Casing = this.uppercase_radio.Checked ? "upper" : "lower",
                    RepMasking = this.mRepeats_lower_radio.Checked ? "lower" : "N",
                    RevComplement = this.revComplement_checkBox.Checked ? "on" : "0"
                };
                var dataFetcher = new DataFetcher(this.savePath_textBox.Text
                                                    , genomeUrl, this.bedFilePath_textBox.Text, settings, this.resume_chkBox.Checked);
                await dataFetcher.FetchAllGenomeDataAndSave();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
