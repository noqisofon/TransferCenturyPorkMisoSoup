namespace TransferCentury.PorkMisoSoup.Models {

    /// <summary>
    /// 転送エラー時の処理
    /// </summary>
    public enum ProcessingAtTimeTransferError {
        /// <summary>
        /// 毎回尋ねる。
        /// </summary>
        AskItEveryTime = -1,
        
        /// <summary>
        /// 後で上書き転送。
        /// </summary>
        OverwriteLaterTransferIt,
        
        /// <summary>
        /// 後でレジュームして転送。
        /// </summary>
        ResumeLaterTransferIt,
        
        /// <summary>
        /// スキップする。
        /// </summary>
        Skip,
        
    }
}