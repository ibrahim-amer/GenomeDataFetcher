using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace GenomeDataFetcher
{
    public class BedFileRow
    {
        public string ChoromosomeNumber { get; set; }
        public string StartPosition { get; set; }
        public string EndPosition { get; set; }
    }
    public class Settings
    {
        public string UpStream { get; set; } = "0";
        public string DownStream { get; set; } = "0";
        public string MaskRepeats { get; set; } = "0";
        public string Casing { get; set; } = "upper";
        public string RepMasking { get; set; } = "lower";
        public string RevComplement { get; set; } = "0";

        public string GetJsonString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    public class DataFetcher
    {
        public string SavePath { get; private set; }

        /// <summary>
        /// "http://genome.ucsc.edu/cgi-bin/hgc?hgsid=680097427_
        /// ePQ4YRhpOh4woALlthOXdak1gGAG&g=htcGetDna2&table=&i=mixed&o=33031596&l=33031596&r=33041570&
        /// getDnaPos=CHRNUM%3ASTARTPOS-ENDPOS&db=hg19&hgSeq.cdsExon=1&hgSeq.padding5=UPSTREAM&hgSeq.padding3=DOWNSTREAM&
        /// hgSeq.casing=upper&boolshad.hgSeq.maskRepeats=0&hgSeq.repMasking=lower&boolshad.hgSeq.revComp=0&submit=get+DNA";
        /// </summary>
        public string GenomeURL { get; private set; }
        public string BedFilePath { get; private set; }
        private string ChromosomeNumberToken { get; } = "CHRNUM";
        private string StartPositionToken { get; } = "STARTPOS";
        private string EndPositionToken { get; } = "ENDPOS";
        private string UpStreamToken { get; } = "UPSTREAM";
        private string DownStreamToken { get; } = "DOWNSTREAM";
        private string CasingToken { get; } = "CASING";
        private string MaskRepeatsToken { get; } = "MASKREPEATS";
        private string RepMaskingToken { get; } = "REPMASKING";
        private string RevComplementToken { get; } = "REVCOMPLEMENT";


        public Settings DownloadSettings { get; private set; }

        public bool ResumeDownloading { get; private set; } = false;



        public DataFetcher(string savePath, string genomeUrl, string bedFilePath, 
            Settings downloadSettings, bool resumeDownloading = false)
        {
            this.SavePath = savePath;
            this.GenomeURL = genomeUrl;
            this.BedFilePath = bedFilePath;
            this.ResumeDownloading = resumeDownloading;
            this.DownloadSettings = downloadSettings;
        }

        public List<BedFileRow> ParseBedFile()
        {
            try
            {
                List<BedFileRow> result = new List<BedFileRow>();

                StreamReader sr = new StreamReader(this.BedFilePath);
                string row = "";
                while ((row = sr.ReadLine()) != null)
                {
                    var tokens = row.Split('\t');
                    var genomeName = tokens[3];
                    var positions = genomeName.Split(':')[1];
                    var chromName = genomeName.Split(':')[0];
                    var bedFileRow = new BedFileRow
                    {
                        ChoromosomeNumber = chromName,
                        StartPosition = positions.Split('-')[0],
                        EndPosition = positions.Split('-')[1]
                    };
                    result.Add(bedFileRow);
                }


                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task FetchAllGenomeDataAndSave()
        {
            try
            {
                string saveFolderPath = this.SavePath;
                if (this.ResumeDownloading)
                {
                    if (!File.Exists(Path.Combine(saveFolderPath, "settings.json")))
                    {
                        StreamWriter sw = new StreamWriter(Path.Combine(saveFolderPath, "settings.json"));

                        sw.Write(this.DownloadSettings.GetJsonString());
                        sw.Close();
                    }
                    saveFolderPath = Path.Combine(this.SavePath, "Data");
                }
                else
                {
                    saveFolderPath = Path.Combine(this.SavePath, "GenomeData_" + Guid.NewGuid().ToString());

                    Directory.CreateDirectory(saveFolderPath);

                    //Write settings to file settings.json
                    StreamWriter sw = new StreamWriter(Path.Combine(saveFolderPath, "settings.json"));

                    sw.Write(this.DownloadSettings.GetJsonString());
                    sw.Close();

                    saveFolderPath = Path.Combine(saveFolderPath, "Data");
                    Directory.CreateDirectory(Path.Combine(saveFolderPath, "Data"));
                }

                var bedFileRows = this.ParseBedFile();

                for (int i = 0; i < bedFileRows.Count; i++)
                {
                    var bedFileRow = bedFileRows[i];
                    string textFilename = bedFileRow.ChoromosomeNumber + "_" +
                       bedFileRow.StartPosition + "-"
                       + bedFileRow.EndPosition + ".txt";
                    string fileName = Path.Combine(saveFolderPath, textFilename);
                    if (!File.Exists(fileName))
                    {
                        var result = await FetchSingle(bedFileRow.ChoromosomeNumber,
                                    bedFileRow.StartPosition,
                                    bedFileRow.EndPosition
                                    ).ConfigureAwait(false);

                        if (!string.IsNullOrWhiteSpace(result))
                        {
                            StreamWriter sw = new StreamWriter(fileName);
                            sw.Write(result.Between("<PRE>", "</PRE>"));
                            sw.Close();
                        }
                        else
                            --i;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<string> FetchSingle(string chromosomeNum, string startPos, string endPos)
        {
            try
            {
                string urlcopy = this.GenomeURL;
                urlcopy = urlcopy.Replace(this.ChromosomeNumberToken, chromosomeNum)
                                 .Replace(this.StartPositionToken, startPos)
                                 .Replace(this.EndPositionToken, endPos)
                                 .Replace(this.UpStreamToken, this.DownloadSettings.UpStream)
                                 .Replace(this.DownStreamToken, this.DownloadSettings.DownStream)
                                 .Replace(this.CasingToken, this.DownloadSettings.Casing)
                                 .Replace(this.MaskRepeatsToken, this.DownloadSettings.MaskRepeats)
                                 .Replace(this.RepMaskingToken, this.DownloadSettings.RepMasking)
                                 .Replace(this.RevComplementToken, this.DownloadSettings.RevComplement);
                var result = await HttpHandler.Get(urlcopy, "").ConfigureAwait(false);
                return result.data;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
