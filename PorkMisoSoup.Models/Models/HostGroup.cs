using System.Collections.Generic;


namespace TransferCentury.PorkMisoSoup.Models {

    /// <summary>
    ///
    /// </summary>
    public class HostGroup {

        /// <summary>
        /// ホストグループの名前です。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ホストグループに含まれているホスト設定です。
        /// </summary>
        public IList<Host> Hosts { get; } = new List<Host>();
    }
}