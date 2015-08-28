# UNetConnectTest
UNetの接続テスト

# テスト項目
## 接続テスト
- [x] win8との接続
- [x] 接続数をカウント
    - 初期状態はhost1つにclient8つまで接続可能
    - NetworkManagerのAdvanced Configurationにチェックを入れて、Max Connectionsでクライアント数を調整できる
- [x] 20接続を試す(macへ、win1台から)
- [x] カスタマイズクラスからの接続(ユニティちゃんの機能は外す)

macで立てたサーバーに、winのクライアントから接続すると、5.1.3では正常に接続することが確認できた。
よって、本リポジトリの目的は達成。
