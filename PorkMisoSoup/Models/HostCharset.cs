namespace TransferCenturyPorkMisoSoup.Models {

    /// <summary>
    /// ホストの文字コード
    /// </summary>
    public enum HostCharset {

        /// <summary>
        /// 無変換
        /// </summary>
        NoConvertion = 0,

        /// <summary>
        /// Shift_JIS
        /// </summary>
        ShiftJis,

        /// <summary>
        /// JIS
        /// </summary>
        JIS,

        /// <summary>
        /// EUC
        /// </summary>
        EUC,

        /// <summary>
        /// UTF-8
        /// </summary>
        UTF8,

        /// <summary>
        /// UTF-8 BOM
        /// </summary>
        UTF8WithBOM,
    }
}