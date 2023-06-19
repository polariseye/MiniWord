namespace MiniSoftware
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // 参考文档: https://stackoverflow.com/questions/47098818/programmatically-add-checkbox-content-controls-to-word-document-using-openxml
    internal class MiniWordCheckBox
    {
        public bool Checked { get; set; }

        public string Text { get; set; }

        public int Size { get; set; }

        public bool AutoSize { get; set; }
    }
}
