using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferCenturyPorkMisoSoup.Models {


    /// <summary>
    /// 
    /// </summary>
    public class Host {
        /// <summary>
        /// ホストの設定名。
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// ホスト名または IP アドレス。
        /// </summary>
        public string HostNameOrIPAddress { get; set; }
        /// <summary>
        /// ユーザー名。
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// パスワードまたはパスフレーズ。
        /// </summary>
        public string PasswordOrPassPhrase { get; set; }

        /// <summary>
        /// anonymous でログインするかどうかを表します。
        /// </summary>
        /// <remarks>これは ViewModel に入れる方がいい？</remarks>
        public bool IsAnonymous { get; set; }

        /// <summary>
        /// ローカルの初期フォルダ。
        /// </summary>
        public string InitLocalSideDir { get; set; }
        /// <summary>
        /// ホストの初期フォルダ。
        /// </summary>
        public string InitHostSideDir { get; set; }

        /// <summary>
        /// 真の場合、最後にアクセスしたフォルダを初期フォルダとします。
        /// </summary>
        /// <remarks>これは ViewModel に入れる方がいい？</remarks>
        public bool SetLastAccessedFolderInInitFolder { get; set; }
    }
}
