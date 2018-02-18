using System;

namespace TransferCentury.PorkMisoSoup.Models {

    /// <summary>
    ///
    /// </summary>
    public class Host {

        #region ホスト / 基本

        /// <summary>
        /// ホストの設定名。
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// ホスト名または IP アドレス。
        /// </summary>
        public string HostNameOrIPAddress { get; set; } = string.Empty;

        /// <summary>
        /// ユーザー名。
        /// </summary>
        public string UserName { get; set; } = string.Empty;

        /// <summary>
        /// パスワードまたはパスフレーズ。
        /// </summary>
        public string PasswordOrPassPhrase { get; set; } = string.Empty;

        /// <summary>
        /// anonymous でログインするかどうかを表します。
        /// </summary>
        /// <remarks>
        /// これは ViewModel に入れる方がいい？
        /// </remarks>
        public bool IsAnonymous { get; set; } = false;

        /// <summary>
        /// ローカルの初期フォルダ。
        /// </summary>
        public string InitLocalSideDir { get; set; } = string.Empty;

        /// <summary>
        /// ホストの初期フォルダ。
        /// </summary>
        public string InitHostSideDir { get; set; } = string.Empty;

        /// <summary>
        /// 真の場合、最後にアクセスしたフォルダを初期フォルダとします。
        /// </summary>
        /// <remarks>
        /// これは ViewModel に入れる方がいい？
        /// </remarks>
        public bool SetLastAccessedFolderInInitFolder { get; set; } = false;

        #endregion ホスト / 基本

        #region ホスト / 拡張

        /// <summary>
        ///  Firewall を使うかどうかを表します。
        /// </summary>
        public bool UseFireWall { get; set; } = false;

        /// <summary>
        /// PASV モードを使うかどうかを表します。
        /// </summary>
        public bool UsePASVMode { get; set; } = true;

        /// <summary>
        /// フォルダ同時移動を使うかどうかを表します。
        /// </summary>
        public bool UseMovementFolderSameTime { get; set; } = false;

        /// <summary>
        /// ポート番号。
        /// </summary>
        public int Port { get; set; } = 21;

        /// <summary>
        /// アカウント。
        /// </summary>
        public string Account { get; set; } = string.Empty;

        /// <summary>
        /// ネットワークの種類。
        /// </summary>
        public NetworkKind NetworkKind { get; set; } = NetworkKind.Auto;

        /// <summary>
        /// ホストのタイムゾーン。
        /// </summary>
        public TimeZone HostTimeZone { get; set; } = TimeZone.CurrentTimeZone;

        /// <summary>
        /// ワンタイムパスワードの設定。
        /// </summary>
        public OneTimePassword Security { get; set; } = OneTimePassword.AutomaticRecognition;

        /// <summary>
        /// 接続時にホストに送るコマンド
        /// </summary>
        public string CommandToSendHostAtTimeOfConnection { get; set; } = string.Empty;

        #endregion ホスト / 拡張

        #region ホスト / 文字コード

        /// <summary>
        /// ホストの文字コード。
        /// </summary>
        /// <remarks>
        /// 多分、ファイルの内容の文字コードだと思われる。
        /// </remarks>
        public HostCharset HostCharset { get; set; } = HostCharset.NoConvertion;

        /// <summary>
        /// ホスト側の「半角カナを全角に変換」にチェックされたかどうかを表します。
        /// </summary>
        public bool HostSideConvertHalfKanaAsWide { get; set; } = true;

        /// <summary>
        /// ファイル名の文字コード。
        /// </summary>
        public FileNameCharset FileNameCharset { get; set; } = FileNameCharset.Auto;

        #endregion ホスト / 文字コード

        #region ホスト / ダイアルアップ

        /// <summary>
        /// ダイアルアップで接続するかどうかを表します。
        /// </summary>
        public bool ConnectWithDialUp { get; set; } = false;

        /// <summary>
        /// 接続する電話帳エントリ。
        /// </summary>
        public string ConnectTelephoneBookEntry { get; set; } = string.Empty;

        /// <summary>
        /// 別のエントリへ接続中でも上記へ接続し直すかどうかを表します。
        /// </summary>
        public bool AboveToDifferentTryAgain { get; set; } = false;

        /// <summary>
        /// 接続し直す際に確認するかどうかを表します。
        /// </summary>
        public bool ConfirmTryAgain { get; set; } = true;

        #endregion ホスト / ダイアルアップ

        #region ホスト / 高度

        /// <summary>
        /// LIST コマンドでファイル一覧を取得するかどうかを表します。
        /// </summary>
        public bool AcquireListOfFilesByListCommand { get; set; } = true;

        /// <summary>
        /// 可能であれば MLSD コマンドで一覧を取得するかどうかを表します。
        /// </summary>
        public bool WhenPossibleListIsAcquiredByMLSDCommand { get; set; } = true;

        /// <summary>
        /// NLST -R を使って高速に再帰検索するかどうかを表します。
        /// </summary>
        public bool FastRecursiveSearch { get; set; } = true;

        /// <summary>
        /// フルパスでファイルをアクセスしないかどうかを表します。
        /// </summary>
        public bool DoNotAccessFileInFullPath { get; set; } = false;

        /// <summary>
        /// 属性変更コマンドの名前を表します。
        /// </summary>
        public string AttributeChangeCommandName { get; set; } = "SITE CHMOD";

        /// <summary>
        /// ホストの種類。
        /// </summary>
        public HostKind HostKind { get; set; } = HostKind.AutomaticRecognition;

        /// <summary>
        /// NLST ファイル名/オプション。
        /// </summary>
        public string NLSTFileNameOrOption { get; set; } = "-alL";

        #endregion ホスト / 高度

        #region ホスト / 暗号化

        /// <summary>
        /// 暗号化なしで接続を許可するかどうかを表します。
        /// </summary>
        public bool AllowConnectionWithNoEnncryption { get; set; } = false;

        /// <summary>
        /// FTPS(Explicit)で接続するかどうかを表します。
        /// </summary>
        public bool ConnectFTPSExplicit { get; set; } = true;

        /// <summary>
        /// FTPS(Implicit)で接続するかどうかを表します。
        /// </summary>
        public bool ConnectFTPSImplicit { get; set; } = true;

        /// <summary>
        /// SFTP で接続するかどうかを表します。
        /// </summary>
        public bool ConnectSFTP { get; set; } = false;

        /// <summary>
        /// 秘密鍵のテキスト。
        /// </summary>
        /// <remarks>FFFTP では未実装なんだって。</remarks>
        public string TextOfPrivateKey { get; set; } = string.Empty;

        /// <summary>
        /// 弱い暗号化方式を使用しないかどうかを表します。
        /// </summary>
        /// <remarks>
        /// 真なら【弱い暗号化方式を使用しない】で
        /// 偽なら【弱い暗号化方式を使用する】。
        /// </remarks>
        public bool NotUseWeakEncryptionMethod { get; set; } = true;

        #endregion ホスト / 暗号化

        #region ホスト / 特殊機能

        /// <summary>
        /// 同時接続数。
        /// </summary>
        /// <remarks>
        /// FFFTP では 1..4。
        /// </remarks>
        public int MaximumConcurrentConnectionQuantity { get; set; } = 1;

        /// <summary>
        /// メインウィンドウのソケットを再利用するかどうかを表します。
        /// </summary>
        public bool RecycleSocket { get; set; } = true;

        /// <summary>
        /// 接続維持用コマンド周期。
        /// </summary>
        /// <remarks>
        /// FFFTP では 0..300 秒。0 は無効らしい。
        /// </remarks>
        public int CommandPeriodForConnectionMaintenance { get; set; } = 60;

        /// <summary>
        /// 転送エラー時の処理
        /// </summary>
        public ProcessingAtTimeTransferError ProcessingAtTimeTransferError { get; set; } = ProcessingAtTimeTransferError.AskItEveryTime;

        /// <summary>
        /// 転送エラー後に再接続するかどうかを表します。
        /// </summary>
        public bool ReconnectAfterTransferError { get; set; } = true;


        #endregion ホスト / 特殊機能
    }
}