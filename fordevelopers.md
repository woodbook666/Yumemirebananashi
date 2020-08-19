# 開発者の方々へ
## 開発時の注意事項
- GitHub Flowを使用して開発してください。  
  ![GitHub Flowの解説画像](https://raw.githubusercontent.com/NanJ-Programming-Team/Yumemirebananashi/master/Images/GitHub-Flow.png)

- ver.**2020.1.2f1**のUnityを開発に使用してください。

- Assetは/Assets/直下にインポートしてください。

- シーンを追加する場合、/Assets/Scenes/にシーン名でフォルダを作り、作成したフォルダの中にシーンを作成してください。  
  追加したシーンを新しいステージとして使用する場合、フォルダ名とシーン名は「Stage 〇(数字)」にしてください。  
  作成したステージのテーマをリポジトリの管理者([ReNeeter](https://github.com/ReNeeter))に伝えてくれればありがたいです。

- 作成したシーン内で使用するファイルも、シーンが入っているフォルダの中にフォルダを作りそこに入れてください。  
  もし説明が理解できない場合は、「Stage 1」フォルダを参考にしてください。

- 基本的には他の人が作っているシーンを編集しないでください。  
  もし編集したい場合は編集してる人にDiscordのDM等で確認を取ってから編集してください。

- /Assets/Scenes/Common/フォルダは基本的には使用しないでください。  
  使用する場合はリポジトリの管理者([ReNeeter](https://github.com/ReNeeter))に確認を取ってから使用してください。

- プロジェクトの設定や.gitignoreは変更しないでください。

- どのステージでも主人公(操作するキャラ)は「[やきう民](https://bowlroll.net/file/67850)」で固定してください。

## 開発を始める前に
- [Stereoarts Homepage](http://stereoarts.jp/)から「MMD4Mecanim_Beta_yyyymmdd.zip」(「yyyymmdd」の部分は日付です)をダウンロードし、  
  解凍したファイルの中から「MMD4Mecanim.unitypackage」を/Assets/直下にインポートしてください。

- 「[やきう民](https://bowlroll.net/file/67850)」を/Assets/Scenes/Common/Models/に配置し、  
  MMD4Mecanimを使用して変換しHumanoid属性を付与してください。  
  必要であればモーション等も追加で付与していただいて構いません。  
  「[やきう民](https://bowlroll.net/file/67850)」のモデルを使用する際には必ずこのモデルを使用してください。

## シーンごとの編集者
| シーン名 | 編集者(GitHubのユーザー名) | 備考 |
----|----|----
| Stage 1 | [ReNeeter](https://github.com/ReNeeter) | ステージのテーマ:ハセカラ騒動 |
