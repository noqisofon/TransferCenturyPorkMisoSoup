namespace TransferCentury.PorkMisoSoup.Models {

    /// <summary>
    ///ネットワークの種類
    /// </summary>
    public enum NetworkKind {

        /// <summary>
        /// 自動
        /// </summary>
        Auto = 0,

        /// <summary>
        /// TCP (IPv4)
        /// </summary>
        TCPAndIPv4,

        /// <summary>
        /// TCP (IPv6)
        /// </summary>
        TCPAndIPv6,
    }
}