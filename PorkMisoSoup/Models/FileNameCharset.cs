namespace TransferCenturyPorkMisoSoup.Models {

    /// <summary>
    /// ファイル名の文字コード
    /// </summary>
    public enum FileNameCharset {

        /// <summary>
        /// 自動
        /// </summary>
        Auto = 0,

        /// <summary>
        /// Shift_JIS
        /// </summary>
        ShiftJIS,

        /// <summary>
        ///
        /// </summary>
        JIS,

        /// <summary>
        ///
        /// </summary>
        EUC,

        /// <summary>
        ///
        /// </summary>
        SambaHEX,

        /// <summary>
        ///
        /// </summary>
        SambaCAP,

        /// <summary>
        /// UTF-8
        /// </summary>
        UTF8,

        /// <summary>
        /// UTF-8 HFS+
        /// </summary>
        UTF8AandHFSPlus
    }
}