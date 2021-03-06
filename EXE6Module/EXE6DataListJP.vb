﻿Public Class EXE6DataListJP
    Inherits EXE6DataList
    Public Overrides Function RemodelCardList() As String()
        Dim list As String() = {
            "01:キャノーダム",
            "02:アモナキュール",
            "03:コルドベア",
            "04:ジーラ",
            "05:メガリア",
            "06:メテファイア",
            "07:キルプラント",
            "08:ダークシャドー",
            "09:ボンビートル",
            "0A:ヘビーアレイ",
            "0B:アゾマータ",
            "0C:ジェライム",
            "0D:ボルカノ",
            "0E:ナンバーズ",
            "0F:マグテクト",
            "10:クーモス",
            "11:ボムボーイ",
            "12:ウドノート",
            "13:ピカラー",
            "14:エレオーガ",
            "15:ダルスト",
            "16:センボン",
            "17:ヒトデスタ",
            "18:グラサン",
            "19:カカジー",
            "1A:ゼロプレーン",
            "1B:レムゴン",
            "1C:アルマン",
            "1D:ヤカーン",
            "1E:ツボリュウ",
            "1F:ナンバーマン",
            "20:アイスマン",
            "21:スカルマン",
            "22:シャドーマン",
            "23:カットマン",
            "24:ナイトマン",
            "25:トードマン",
            "26:マグネットマン",
            "27:プラネットマン",
            "28:ビーストマン",
            "29:デザートマン",
            "2A:ヤマトマン",
            "2B:ビデオマン",
            "2C:バーナーマン",
            "2D:スターマン",
            "2E:ブリザードマン",
            "2F:スワローマン",
            "30:スラッシュマン",
            "31:キラーマン",
            "32:グランドマン",
            "33:ダストマン",
            "34:ブラストマン",
            "35:サーカスマン",
            "36:ハンディーズ",
            "37:プークル",
            "38:ジェリー",
            "39:ポイットン",
            "3A:サテラ",
            "3B:パララ＆リモコゴロー",
            "3C:ユラ",
            "3D:タコバル",
            "3E:シェルキー",
            "3F:マグニッカー",
            "40:メテマージ",
            "41:モモグラン",
            "42:ニドキャスター",
            "43:ツインズ",
            "44:ウォーラ",
            "45:キルブー",
            "46:トトポール",
            "47:キャノガード",
            "48:スカラビア",
            "49:ドラグリン",
            "4A:マリーナ",
            "4B:ドルダーラ",
            "4C:ガンナー",
            "4D:パルフォロン",
            "4E:ボムコーン",
            "4F:モリキュー",
            "50:ハニホー",
            "51:ナイトメア",
            "52:スナーム",
            "53:アサシンメカ",
            "54:ストーンマン",
            "55:カラードマン",
            "56:シャークマン",
            "57:ファラオマン",
            "58:エアーマン",
            "59:フリーズマン",
            "5A:サンダーマン",
            "5B:ナパームマン",
            "5C:プラントマン",
            "5D:ミストマン",
            "5E:ボウルマン",
            "5F:ダークマン",
            "60:タップマン",
            "61:ケンドーマン",
            "62:コールドマン",
            "63:サーチマン",
            "64:クラウドマン",
            "65:フットマン",
            "66:チャージマン",
            "67:テングマン",
            "68:ダイブマン",
            "69:ジャッジマン",
            "6A:エレメントマン",
            "6B:パンク",
            "6C:ダークロックマン",
            "6D:ソウルバトラーのカスタマイズ",
            "6E:名人のちょうぜつカスタマイズ",
            "6F:フォルテＢＸ",
            "70:ジャンゴ",
            "71:ハクシャク",
            "72:ロックマンゼロ",
            "73:電脳獣グレイガ",
            "74:電脳獣ファルザー",
            "75:フォルテクロスロックマン"
        }
        Return list
    End Function

    Public Overrides Function NaviCustName() As String()
        Dim list As String() = {
            "スーパーアーマー(赤)",
            "カスタム１(青)",
            "カスタム２(白)",
            "メガフォルダ１(緑)",
            "メガフォルダ２(白)",
            "ギガフォルダ１(赤)",
            "ファーストバリア(青)",
            "シールド(青)",
            "リフレクト(緑)",
            "カワリミマジック(緑)",
            "フロートシューズ(桃)",
            "エアシューズ(白)",
            "アンダーシャツ(白)",
            "サーチシャッフル(緑)",
            "ナンバーオープン(桃)",
            "シノビダッシュ(白)",
            "オイルボディ(赤)",
            "アイムフィッシュ(青)",
            "バッテリーモード(黄)",
            "ジャングルランド(緑)",
            "コレクターズアイ(桃)",
            "ミリオネア(赤)",
            "ユーモアセンス(桃)",
            "リズミカルポエム(黄)",
            "スリップランナー(黄)",
            "セルフリカバリー(桃)",
            "バスターパック(赤)",
            "ボディパック(桃)",
            "フォルダパック１(黄)",
            "フォルダパック２(桃)",
            "バグストッパー(黄)",
            "ラッシュサポート(黄)",
            "ビートサポート(青)",
            "タンゴサポート(緑)",
            "アタック＋１(桃)", "アタック＋１(赤)", "アタック＋１(青)",
            "ラピッド＋１(白)", "ラピッド＋１(桃)", "ラピッド＋１(緑)",
            "チャージ＋１(白)", "チャージ＋１(青)", "チャージ＋１(桃)",
            "アタックＭＡＸ(赤)",
            "ラピッドＭＡＸ(緑)",
            "チャージＭＡＸ(青)",
            "ＨＰ＋５０(白)", "ＨＰ＋５０(桃)", "ＨＰ＋５０(青)",
            "ＨＰ＋１００(白)", "ＨＰ＋１００(桃)", "ＨＰ＋１００(青)",
            "ＨＰ＋２００(白)", "ＨＰ＋２００(黄)", "ＨＰ＋２００(青)",
            "ＨＰ＋３００(白)", "ＨＰ＋３００(桃)", "ＨＰ＋３００(緑)",
            "ＨＰ＋４００(白)", "ＨＰ＋４００(黄)", "ＨＰ＋４００(緑)",
            "ＨＰ＋５００(白)", "ＨＰ＋５００(桃)", "ＨＰ＋５００(緑)"
        }
        Return list
    End Function

    Public Overrides Function KeyItemList() As String()
        Dim list As String() = {
            "ＰＥＴ", "せいとてちょう", "バケツ", "しょくいんパス",
            "ラクガキ", "ウォーターデータ", "カギデータ", "さかな",
            "こうぐプログラム", "あそびどうぐ", "いやしの水", "タッグチップ",
            "じけんのしりょう", "えいぞうデータ", "きょかデータ", "あまガサ",
            "しょうりカードＡ", "しょうりカードＢ", "しょうりカードＣ", "しょうりカードＤ",
            "サイバーでんち１", "サイバーでんち２", "サイバーでんち３", "サイバーでんち４",
            "サイバーでんち５", "つきのいし", "秋原のカギデータ", "エリアパスポート",
            "バキュームデータ", "かいちゅうどけい", "トロデータ", "イクラデータ",
            "アナゴデータ", "エビデータ", "カズノコデータ", "ハマチデータ",
            "ウニデータ", "タイデータ", "タイムカプセル", "キャッシュデータ",
            "テキストデータ", "ペンダント", "へんじのてがみ", "スタンプカード",
            "ラッシュフード", "電脳オノ", "チューリップ", "アップデートデータ",
            "コーヒー", "きみつデータ", "クロスバッチ", "コウモリのカギ",
            "ひみつのメモ", "クイズデータ", "はしりがきデータ", "ペンギンのおれい",
            "さんこうしょ", "クイズのほん", "しょうたいけん", "かんしゃじょう",
            "シリアルデータ", "科学にゅうもん", "ソウルエンブレム", "ナビのざんがい",
            "バトラーカード", "フライドポテト", "マサカリ", "よやくけん",
            "ＷＷＷＩＤ", "太陽のカギ", "シーサードのカギ",
            "", "", "", "", "", "", "", "", "",
            "スピンホワイト", "スピンイエロー", "スピンピンク", "スピンレッド",
            "スピンブルー", "スピングリーン",
            "", "", "", "", "", "", "", "", "", "",
            "学校のPコード",
            "", "", "", "", "", "", "",
            "水のバナー", "グリーンバナー", "スカイバナー", "秋原のバナー",
            "ＨＰメモリ", "ＰＥＴ", "ＨＰメモリ", "ＨＰメモリ"
        }
        Return list
    End Function

    Public Overrides Function ChipNameList() As String()
        Dim list As String() = {
            "キャノン（A", "キャノン（B", "キャノン（C", "キャノン（*",
            "ハイキャノン（L", "ハイキャノン（M", "ハイキャノン（N", "ハイキャノン（*",
            "メガキャノン（R", "メガキャノン（S", "メガキャノン（T", "メガキャノン（*",
            "エアシュ－ト（*",
            "バルカン１（B", "バルカン１（D", "バルカン１（S", "バルカン１（*",
            "バルカン２（D", "バルカン２（F", "バルカン２（L",
            "バルカン３（A", "バルカン３（G", "バルカン３（R",
            "ス－パ－バルカン（V",
            "スプレッドガン１（L", "スプレッドガン１（M", "スプレッドガン１（N", "スプレッドガン１（*",
            "スプレッドガン２（A", "スプレッドガン２（B", "スプレッドガン２（C", "スプレッドガン２（*",
            "スプレッドガン３（Q", "スプレッドガン３（R", "スプレッドガン３（S", "スプレッドガン３（*",
            "センシャホウ１（A", "センシャホウ１（G", "センシャホウ１（R",
            "センシャホウ２（L", "センシャホウ２（S", "センシャホウ２（V",
            "センシャホウ３（B", "センシャホウ３（M", "センシャホウ３（P",
            "ガンデルソル１（C", "ガンデルソル１（M", "ガンデルソル１（T", "ガンデルソル１（*",
            "ガンデルソル２（B", "ガンデルソル２（E", "ガンデルソル２（R",
            "ガンデルソル３（N", "ガンデルソル３（Q", "ガンデルソル３（W",
            "ガンデルソルＥＸ（G",
            "ヨ－ヨ－（L", "ヨ－ヨ－（M", "ヨ－ヨ－（N", "ヨ－ヨ－（*",
            "ヘルズバ－ナ－１（F", "ヘルズバ－ナ－１（G", "ヘルズバ－ナ－１（H", "ヘルズバ－ナ－１（*",
            "ヘルズバ－ナ－２（S", "ヘルズバ－ナ－２（T", "ヘルズバ－ナ－２（U",
            "ヘルズバ－ナ－３（C", "ヘルズバ－ナ－３（D", "ヘルズバ－ナ－３（E",
            "ワイドショット（P", "ワイドショット（Q", "ワイドショット（R",
            "トレインアロ－１（A", "トレインアロ－１（F", "トレインアロ－１（K",
            "トレインアロ－２（G", "トレインアロ－２（M", "トレインアロ－２（Z",
            "トレインアロ－３（M", "トレインアロ－３（S", "トレインアロ－３（Y",
            "バブルスタ－１（B", "バブルスタ－１（E", "バブルスタ－１（T",
            "バブルスタ－２（C", "バブルスタ－２（L", "バブルスタ－２（V",
            "バブルスタ－３（G", "バブルスタ－３（R", "バブルスタ－３（S",
            "サンダ－ボ－ル（B", "サンダ－ボ－ル（R", "サンダ－ボ－ル（S", "サンダ－ボ－ル（*",
            "ド－ルサンダ－１（A", "ド－ルサンダ－１（E", "ド－ルサンダ－１（Q",
            "ド－ルサンダ－２（C", "ド－ルサンダ－２（L", "ド－ルサンダ－２（P",
            "ド－ルサンダ－３（B", "ド－ルサンダ－３（R", "ド－ルサンダ－３（V",
            "エレキパルス１（J", "エレキパルス１（L", "エレキパルス１（S",
            "エレキパルス２（A", "エレキパルス２（E", "エレキパルス２（J",
            "エレキパルス３（A", "エレキパルス３（J", "エレキパルス３（S",
            "リスキ－ハニ－１（B", "リスキ－ハニ－１（G", "リスキ－ハニ－１（S",
            "リスキ－ハニ－２（C", "リスキ－ハニ－２（R", "リスキ－ハニ－２（V",
            "リスキ－ハニ－３（A", "リスキ－ハニ－３（D", "リスキ－ハニ－３（M",
            "ロ－リングログ１（I", "ロ－リングログ１（K", "ロ－リングログ１（P",
            "ロ－リングログ２（E", "ロ－リングログ２（Q", "ロ－リングログ２（Z",
            "ロ－リングログ３（F", "ロ－リングログ３（N", "ロ－リングログ３（W",
            "マシンガン１（A", "マシンガン１（R", "マシンガン１（T", "マシンガン１（*",
            "マシンガン２（E", "マシンガン２（G", "マシンガン２（S",
            "マシンガン３（B", "マシンガン３（F", "マシンガン３（M",
            "ヒ－トドラゴン（G", "ヒ－トドラゴン（R", "ヒ－トドラゴン（T",
            "エレキドラゴン（A", "エレキドラゴン（L", "エレキドラゴン（V",
            "アクアドラゴン（H", "アクアドラゴン（P", "アクアドラゴン（S",
            "ウッドドラゴン（G", "ウッドドラゴン（T", "ウッドドラゴン（V",
            "エアホッケ－（L", "エアホッケ－（M", "エアホッケ－（N",
            "ドリルア－ム（G", "ドリルア－ム（M", "ドリルア－ム（W",
            "トルネ－ド（L", "トルネ－ド（R", "トルネ－ド（T",
            "ノイズスト－ム（G", "ノイズスト－ム（S", "ノイズスト－ム（V",
            "ミニボム（B", "ミニボム（L", "ミニボム（R", "ミニボム（*",
            "エナジ－ボム（C", "エナジ－ボム（K", "エナジ－ボム（V", "エナジ－ボム（*",
            "メガエナジ－ボム（G", "メガエナジ－ボム（M", "メガエナジ－ボム（O", "メガエナジ－ボム（*",
            "フラッシュボム１（J", "フラッシュボム１（L", "フラッシュボム１（Q", "フラッシュボム１（*",
            "フラッシュボム２（G", "フラッシュボム２（K", "フラッシュボム２（R",
            "フラッシュボム３（H", "フラッシュボム３（P", "フラッシュボム３（S",
            "ブラックボム（B", "ブラックボム（F", "ブラックボム（O",
            "アクアニ－ドル１（C", "アクアニ－ドル１（J", "アクアニ－ドル１（P",
            "アクアニ－ドル２（F", "アクアニ－ドル２（K", "アクアニ－ドル２（T",
            "アクアニ－ドル３（A", "アクアニ－ドル３（L", "アクアニ－ドル３（U",
            "コ－ンショット１（J", "コ－ンショット１（K", "コ－ンショット１（L",
            "コ－ンショット２（C", "コ－ンショット２（D", "コ－ンショット２（E",
            "コ－ンショット３（P", "コ－ンショット３（Q", "コ－ンショット３（R",
            "バグボム（G", "バグボム（S", "バグボム（V",
            "クサムラシ－ド（A", "クサムラシ－ド（F", "クサムラシ－ド（S", "クサムラシ－ド（*",
            "アイスシ－ド（A", "アイスシ－ド（L", "アイスシ－ド（R", "アイスシ－ド（*",
            "ポイズンシ－ド（H", "ポイズンシ－ド（N", "ポイズンシ－ド（P", "ポイズンシ－ド（*",
            "ソ－ド（H", "ソ－ド（L", "ソ－ド（S", "ソ－ド（*",
            "ワイドソ－ド（H", "ワイドソ－ド（L", "ワイドソ－ド（S", "ワイドソ－ド（*",
            "ロングソ－ド（H", "ロングソ－ド（L", "ロングソ－ド（S", "ロングソ－ド（*",
            "ワイドブレ－ド（B", "ワイドブレ－ド（R", "ワイドブレ－ド（W",
            "ロングブレ－ド（B", "ロングブレ－ド（M", "ロングブレ－ド（V",
            "フレイムソ－ド（F", "フレイムソ－ド（O", "フレイムソ－ド（Z",
            "アクアソ－ド（A", "アクアソ－ド（I", "アクアソ－ド（Y",
            "エレキソ－ド（E", "エレキソ－ド（K", "エレキソ－ド（N",
            "バンブ－ソ－ド（H", "バンブ－ソ－ド（S", "バンブ－ソ－ド（W",
            "フウジンラケット（F", "フウジンラケット（J", "フウジンラケット（R", "フウジンラケット（*",
            "フミコミザン（B", "フミコミザン（L", "フミコミザン（P",
            "バリアブルソ－ド（K", "バリアブルソ－ド（V", "バリアブルソ－ド（W",
            "ネオバリアブル（N",
            "エンゲツクナイ（A", "エンゲツクナイ（M", "エンゲツクナイ（T",
            "ムラマサブレ－ド（M",
            "マシ－ンソ－ド（H", "マシ－ンソ－ド（L", "マシ－ンソ－ド（Q",
            "エレメントソ－ド（J", "エレメントソ－ド（M", "エレメントソ－ド（U",
            "アサシンソ－ド（N", "アサシンソ－ド（R", "アサシンソ－ド（Y",
            "クラックシュ－ト（A", "クラックシュ－ト（G", "クラックシュ－ト（T", "クラックシュ－ト（*",
            "ダブルシュ－ト（C", "ダブルシュ－ト（R", "ダブルシュ－ト（U", "ダブルシュ－ト（*",
            "トリプルシュ－ト（J", "トリプルシュ－ト（L", "トリプルシュ－ト（V", "トリプルシュ－ト（*",
            "ウェ－ブア－ム１（E", "ウェ－ブア－ム１（F", "ウェ－ブア－ム１（G",
            "ウェ－ブア－ム２（L", "ウェ－ブア－ム２（M", "ウェ－ブア－ム２（N",
            "ウェ－ブア－ム３（R", "ウェ－ブア－ム３（S", "ウェ－ブア－ム３（T",
            "オ－ラヘッド１（B", "オ－ラヘッド１（C", "オ－ラヘッド１（D",
            "オ－ラヘッド２（D", "オ－ラヘッド２（E", "オ－ラヘッド２（F",
            "オ－ラヘッド３（F", "オ－ラヘッド３（G", "オ－ラヘッド３（H",
            "リトルボイラ－１（F", "リトルボイラ－１（K", "リトルボイラ－１（L",
            "リトルボイラ－２（E", "リトルボイラ－２（M", "リトルボイラ－２（V",
            "リトルボイラ－３（G", "リトルボイラ－３（S", "リトルボイラ－３（Z",
            "サンドワ－ム１（A", "サンドワ－ム１（G", "サンドワ－ム１（L",
            "サンドワ－ム２（B", "サンドワ－ム２（R", "サンドワ－ム２（Y",
            "サンドワ－ム３（H", "サンドワ－ム３（J", "サンドワ－ム３（S",
            "エアレイド１（G", "エアレイド１（K", "エアレイド１（R",
            "エアレイド２（O", "エアレイド２（T", "エアレイド２（Y",
            "エアレイド３（N", "エアレイド３（U", "エアレイド３（Z",
            "ファイアパンチ１（D", "ファイアパンチ１（E", "ファイアパンチ１（F",
            "ファイアパンチ２（R", "ファイアパンチ２（S", "ファイアパンチ２（T",
            "ファイアパンチ３（A", "ファイアパンチ３（B", "ファイアパンチ３（C",
            "バ－ンスクエア１（H", "バ－ンスクエア１（P", "バ－ンスクエア１（V",
            "バ－ンスクエア２（D", "バ－ンスクエア２（M", "バ－ンスクエア２（T",
            "バ－ンスクエア３（E", "バ－ンスクエア３（O", "バ－ンスクエア３（Z",
            "キラ－センサ－１（J", "キラ－センサ－１（O", "キラ－センサ－１（W",
            "キラ－センサ－２（N", "キラ－センサ－２（U", "キラ－センサ－２（Y",
            "キラ－センサ－３（I", "キラ－センサ－３（K", "キラ－センサ－３（Q",
            "ブ－メラン（J", "ブ－メラン（K", "ブ－メラン（T",
            "ハイブ－メラン（B", "ハイブ－メラン（L", "ハイブ－メラン（V",
            "メガブ－メラン（I", "メガブ－メラン（M", "メガブ－メラン（W",
            "バンブ－ランス（A", "バンブ－ランス（R", "バンブ－ランス（W", "バンブ－ランス（*",
            "ゴ－レムパンチ１（I", "ゴ－レムパンチ１（K", "ゴ－レムパンチ１（Y",
            "ゴ－レムパンチ２（D", "ゴ－レムパンチ２（P", "ゴ－レムパンチ２（U",
            "ゴ－レムパンチ３（H", "ゴ－レムパンチ３（M", "ゴ－レムパンチ３（V",
            "アイアンシェル１（J", "アイアンシェル１（K", "アイアンシェル１（L",
            "アイアンシェル２（C", "アイアンシェル２（D", "アイアンシェル２（E",
            "アイアンシェル３（L", "アイアンシェル３（M", "アイアンシェル３（N",
            "エアホイ－ル１（F", "エアホイ－ル１（G", "エアホイ－ル１（R",
            "エアホイ－ル２（A", "エアホイ－ル２（L", "エアホイ－ル２（T",
            "エアホイ－ル３（N", "エアホイ－ル３（O", "エアホイ－ル３（T",
            "トップウ（*",
            "スイコミ（*",
            "リフレクメット１（A", "リフレクメット１（C", "リフレクメット１（P", "リフレクメット１（*",
            "リフレクメット２（B", "リフレクメット２（G", "リフレクメット２（Y", "リフレクメット２（*",
            "リフレクメット３（E", "リフレクメット３（F", "リフレクメット３（O", "リフレクメット３（*",
            "カモンスネ－ク（H", "カモンスネ－ク（M", "カモンスネ－ク（L",
            "サモンブラック１（E", "サモンブラック１（I", "サモンブラック１（P",
            "サモンブラック２（H", "サモンブラック２（O", "サモンブラック２（V",
            "サモンブラック３（W", "サモンブラック３（Y", "サモンブラック３（Z",
            "ナンバ－ボ－ル（N",
            "リュウセイグン（R",
            "ジャスティスワン（J",
            "マグナム（F", "マグナム（L", "マグナム（W",
            "サ－クルガン（P", "サ－クルガン（T", "サ－クルガン（V",
            "スト－ンキュ－ブ（*",
            "カウントボム１（F", "カウントボム１（G", "カウントボム１（H",
            "ステルスマイン（A", "ステルスマイン（S", "ステルスマイン（T",
            "オウエンカ（P", "オウエンカ（S", "オウエンカ（Z", "オウエンカ（*",
            "ディスコ－ド（A", "ディスコ－ド（G", "ディスコ－ド（S", "ディスコ－ド（*",
            "ティンパニ－（I", "ティンパニ－（O", "ティンパニ－（T", "ティンパニ－（*",
            "サイレンス（B", "サイレンス（R", "サイレンス（W", "サイレンス（*",
            "ワラニンギョウ（F", "ワラニンギョウ（N", "ワラニンギョウ（S", "ワラニンギョウ（*",
            "オジゾウサン（O",
            "ポイズンアヌビス（P",
            "オテンコサマ（O",
            "リカバリ－１０（A", "リカバリ－１０（D", "リカバリ－１０（L", "リカバリ－１０（*",
            "リカバリ－３０（E", "リカバリ－３０（L", "リカバリ－３０（Q", "リカバリ－３０（*",
            "リカバリ－５０（C", "リカバリ－５０（M", "リカバリ－５０（P", "リカバリ－５０（*",
            "リカバリ－８０（H", "リカバリ－８０（K", "リカバリ－８０（V", "リカバリ－８０（*",
            "リカバリ－１２０（F", "リカバリ－１２０（P", "リカバリ－１２０（S",
            "リカバリ－１５０（J", "リカバリ－１５０（M", "リカバリ－１５０（T",
            "リカバリ－２００（I", "リカバリ－２００（Q", "リカバリ－２００（Z",
            "リカバリ－３００（J", "リカバリ－３００（O", "リカバリ－３００（Y",
            "パネルスチ－ル（*",
            "エリアスチ－ル（B", "エリアスチ－ル（F", "エリアスチ－ル（S", "エリアスチ－ル（*",
            "スチ－ルパニシュ（B", "スチ－ルパニシュ（M", "スチ－ルパニシュ（S",
            "スチ－ルリベンジ（I", "スチ－ルリベンジ（Q", "スチ－ルリベンジ（Z",
            "パネルリタ－ン（*",
            "デスマッチ（A", "デスマッチ（L", "デスマッチ（R", "デスマッチ（*",
            "ホ－リ－パネル（A", "ホ－リ－パネル（B", "ホ－リ－パネル（S", "ホ－リ－パネル（*",
            "サンクチュアリ（Z",
            "カミングロ－ド（*",
            "ゴ－イングロ－ド（*",
            "ヘビ－ゲ－ジ（A", "ヘビ－ゲ－ジ（B", "ヘビ－ゲ－ジ（G", "ヘビ－ゲ－ジ（*",
            "クイックゲ－ジ（E", "クイックゲ－ジ（M", "クイックゲ－ジ（R", "クイックゲ－ジ（*",
            "フルカスタム（*",
            "バスタ－アップ（*",
            "バグシュウセイ（K", "バグシュウセイ（P", "バグシュウセイ（Z", "バグシュウセイ（*",
            "インビジブル（*",
            "バリア（A", "バリア（F", "バリア（R", "バリア（*",
            "バリア１００（H", "バリア１００（O", "バリア１００（Y",
            "バリア２００（K", "バリア２００（U", "バリア２００（W",
            "バブルラップ（I", "バブルラップ（Q", "バブルラップ（Z",
            "ドリ－ムオ－ラ（U",
            "マグネコイル（*",
            "ホワイトカプセル（*",
            "アンインスト－ル（G", "アンインスト－ル（L", "アンインスト－ル（R",
            "ナビスカウト（F", "ナビスカウト（L", "ナビスカウト（T", "ナビスカウト（*",
            "カワリミ（G", "カワリミ（R", "カワリミ（V", "カワリミ（*",
            "シラハドリ（A", "シラハドリ（R", "シラハドリ（Z", "シラハドリ（*",
            "バッドメディスン（A", "バッドメディスン（F", "バッドメディスン（V", "バッドメディスン（*",
            "コピ－ダメ－ジ（*",
            "ライフシンクロ（*",
            "アタック＋１０（*",
            "ナビ＋２０（*",
            "カラ－ポイント（*",
            "アタック＋３０（*",
            "ダブルポイント（*",
            "エレメントラップ（G", "エレメントラップ（S", "エレメントラップ（U", "エレメントラップ（*",
            "カ－ネルア－ミ－（B", "カ－ネルア－ミ－（G", "カ－ネルア－ミ－（R", "カ－ネルア－ミ－（*",
            "ブリザ－ドボ－ル（H", "ブリザ－ドボ－ル（N", "ブリザ－ドボ－ル（T",
            "カウントボム２（C", "カウントボム２（D", "カウントボム２（E",
            "カウントボム３（L", "カウントボム３（M", "カウントボム３（N",
            "ビッグボム（O", "ビッグボム（P", "ビッグボム（V",
            "ロ－ル（R", "ロ－ル（*",
            "ロ－ルＶ２（R",
            "ロ－ルＶ３（R",
            "ブル－ス（B", "ブル－ス（*",
            "ブル－スEX（B",
            "ブル－スSP（B",
            "ヒ－トマン（H", "ヒ－トマン（*",
            "ヒ－トマンEX（H",
            "ヒ－トマンSP（H",
            "エレキマン（E", "エレキマン（*",
            "エレキマンEX（E",
            "エレキマンSP（E",
            "スラッシュマン（S", "スラッシュマン（*",
            "スラッシュマンEX（S",
            "スラッシュマンSP（S",
            "キラ－マン（K", "キラ－マン（*",
            "キラ－マンEX（K",
            "キラ－マンSP（K",
            "チャ－ジマン（C", "チャ－ジマン（*",
            "チャ－ジマンEX（C",
            "チャ－ジマンSP（C",
            "アクアマン（A", "アクアマン（*",
            "アクアマンEX（A",
            "アクアマンSP（A",
            "トマホ－クマン（T", "トマホ－クマン（*",
            "トマホ－クマンEX（T",
            "トマホ－クマンSP（T",
            "テングマン（T", "テングマン（*",
            "テングマンEX（T",
            "テングマンSP（T",
            "グランドマン（G", "グランドマン（*",
            "グランドマンEX（G",
            "グランドマンSP（G",
            "ダストマン（D", "ダストマン（*",
            "ダストマンEX（D",
            "ダストマンSP（D",
            "ブラストマン（B", "ブラストマン（*",
            "ブラストマンEX（B",
            "ブラストマンSP（B",
            "ダイブマン（D", "ダイブマン（*",
            "ダイブマンEX（D",
            "ダイブマンSP（D",
            "サ－カスマン（C", "サ－カスマン（*",
            "サ－カスマンEX（C",
            "サ－カスマンSP（C",
            "ジャッジマン（J", "ジャッジマン（*",
            "ジャッジマンEX（J",
            "ジャッジマンSP（J",
            "エレメントマン（E", "エレメントマン（*",
            "エレメントマンEX（E",
            "エレメントマンSP（E",
            "カ－ネル（C", "カ－ネル（*",
            "カ－ネルEX（C",
            "カ－ネルSP（C",
            "ハクシャク（H", "ハクシャク（*",
            "ハクシャクEX（H",
            "ハクシャクSP（H",
            "ジャンゴ（D", "ジャンゴ（*",
            "ジャンゴＶ２（D",
            "ジャンゴＶ３（D",
            "パンチア－ム（A", "パンチア－ム（B", "パンチア－ム（C", "パンチア－ム（*",
            "ニ－ドルア－ム（A", "ニ－ドルア－ム（B", "ニ－ドルア－ム（C", "ニ－ドルア－ム（*",
            "パルスア－ム（A", "パルスア－ム（B", "パルスア－ム（C", "パルスア－ム（*",
            "ブ－メランア－ム（A", "ブ－メランア－ム（B", "ブ－メランア－ム（C", "ブ－メランア－ム（*",
            "シンクロトリガ－（A", "シンクロトリガ－（B", "シンクロトリガ－（C", "シンクロトリガ－（*",
            "ダ－クソ－ド（A", "ダ－クソ－ド（B", "ダ－クソ－ド（C", "ダ－クソ－ド（*",
            "ダ－クサンダ－（A", "ダ－クサンダ－（B", "ダ－クサンダ－（C", "ダ－クサンダ－（*",
            "ダ－クリカバリ－（A", "ダ－クリカバリ－（B", "ダ－クリカバリ－（C", "ダ－クリカバリ－（*",
            "ダ－クインビジ（A", "ダ－クインビジ（B", "ダ－クインビジ（C", "ダ－クインビジ（*",
            "ダ－クプラス（A", "ダ－クプラス（B", "ダ－クプラス（C", "ダ－クプラス（*",
            "フォルテ（F",
            "ギガントフック（H",
            "デルタレイエッジ（Z",
            "カ－ネルフォ－ス（Q",
            "バグライズソ－ド（V",
            "フォルテアナザ－（F",
            "メテオナックル（N",
            "クロスディバイド（D",
            "サイトバッチ（J",
            "バグデスサンダ－（V",
            "ダブルビ－スト（W",
            "グレイガ（X",
            "ファルザ－（X"
        }
        Return list
    End Function

    Public Overrides Function MapListName() As String()
        Dim list As String() = {
            "秋原町",
            "６×Ａ教室",
            "セントラルタウン",
            "熱斗のリビング",
            "熱斗のへや",
            "トイレ",
            "アスタランド",
            "６－１教室",
            "６－２教室",
            "１－１教室",
            "１－２教室",
            "１Ｆろうか",
            "２Ｆろうか",
            "げんかんホ－ル",
            "職員室",
            "校長室",
            "だい１けんきゅう室",
            "だい２けんきゅう室",
            "シ－サイドタウン",
            "すいぞくかん１",
            "すいぞくかん２",
            "ショーかいじょう",
            "かんせいしつ",
            "グリ－ンタウン",
            "さいばんしょ　げんかん",
            "さいばんしょ　ほうてい",
            "おしおきべや",
            "ちか室",
            "かんりきょく",
            "スカイタウン",
            "オペレ－トル－ム",
            "フォ－スル－ム",
            "ばんぱくかいじょう",
            "セントラルかん",
            "シ－サイドかん",
            "グリ－ンかん",
            "スカイかん",
            "",
            "ロボせいぎょＰＣの電脳１",
            "ロボせいぎょＰＣの電脳２",
            "すいぞくかんの電脳１",
            "すいぞくかんの電脳２",
            "すいぞくかんの電脳３",
            "しんぱんの木の電脳１",
            "しんぱんの木の電脳２",
            "しんぱんの木の電脳３",
            "ウェザ－くんの電脳１",
            "ウェザ－くんの電脳２",
            "ウェザ－くんの電脳３",
            "パビリオンの電脳１",
            "パビリオンの電脳２",
            "パビリオンの電脳３",
            "パビリオンの電脳４",
            "コピ－ロイドの電脳",
            "熱斗のＨＰ",
            "秋原町のＨＰ",
            "すいぞくかんのＨＰ",
            "グリーンのＨＰ",
            "スカイのＨＰ",
            "ロボット犬の電脳",
            "パソコンの電脳１",
            "６－１の電脳",
            "６－２の電脳",
            "１－１の電脳",
            "１－２の電脳",
            "トイレの電脳",
            "エレベ－タ－の電脳",
            "タイヤキやの電脳",
            "かんしカメラの電脳",
            "じてんの電脳",
            "せんぷうきの電脳",
            "ク－ラ－の電脳",
            "ヒ－タ－の電脳",
            "シャワ－の電脳",
            "ヘリポ－トの電脳",
            "パソコンの電脳２",
            "じはんきの電脳",
            "おしおきイスの電脳",
            "水はんばいきの電脳",
            "シンボルぞうの電脳",
            "モニタ－の電脳",
            "ポップコーン屋の電脳",
            "職員室の電脳",
            "すいどうかんの電脳",
            "かんそくきの電脳",
            "ボンベの電脳",
            "校長室の電脳",
            "マスコットの電脳",
            "ヌイグルミヤの電脳",
            "イヌ小屋の電脳",
            "あんないパネルの電脳",
            "セントラルエリア１",
            "セントラルエリア２",
            "セントラルエリア３",
            "シ－サイドエリア１",
            "シ－サイドエリア２",
            "シ－サイドエリア３",
            "グリ－ンエリア１",
            "グリ－ンエリア２",
            "アンダ－グラウンド１",
            "アンダ－グラウンド２",
            "スカイエリア１",
            "スカイエリア２",
            "秋原エリア",
            "ウラインタ－ネット１",
            "ウラインタ－ネットゼロ",
            "ウラインタ－ネット２",
            "ウラインタ－ネット３",
            "グレイブヤ－ド１",
            "グレイブヤ－ド２",
            "イモータルエリア"
        }
        Return list
    End Function

    Public Overrides Function LibStandardChipNameList() As String()
        Dim list As String() = {
            "キャノン",
            "ハイキャノン",
            "メガキャノン",
            "エアシュート",
            "バルカン１",
            "バルカン２",
            "バルカン３",
            "スーパーバルカン",
            "スプレッドガン１",
            "スプレッドガン２",
            "スプレッドガン３",
            "センシャホウ１",
            "センシャホウ２",
            "センシャホウ３",
            "ガンデルソル１",
            "ガンデルソル２",
            "ガンデルソル３",
            "ヨーヨー",
            "ヘルズバーナー１",
            "ヘルズバーナー２",
            "ヘルズバーナー３",
            "ワイドショット",
            "トレインアロー１",
            "トレインアロー２",
            "トレインアロー３",
            "バブルスター１",
            "バブルスター２",
            "バブルスター３",
            "サンダーボール",
            "ドールサンダー１",
            "ドールサンダー２",
            "ドールサンダー３",
            "エレキパルス１",
            "エレキパルス２",
            "エレキパルス３",
            "コーンショット１",
            "コーンショット２",
            "コーンショット３",
            "リスキーハニー１",
            "リスキーハニー２",
            "リスキーハニー３",
            "ローリングログ１",
            "ローリングログ２",
            "ローリングログ３",
            "アイアンシェル１",
            "アイアンシェル２",
            "アイアンシェル３",
            "オーラヘッド１",
            "オーラヘッド２",
            "オーラヘッド３",
            "エアホッケー",
            "ドリルアーム",
            "トルネード",
            "ノイズストーム",
            "マシンガン１",
            "マシンガン２",
            "マシンガン３",
            "ミニボム",
            "ビッグボム",
            "エナジーボム",
            "メガエナジーボム",
            "フラッシュボム１",
            "フラッシュボム２",
            "フラッシュボム３",
            "ブラックボム",
            "バグボム",
            "クサムラシード",
            "アイスシード",
            "ポイズンシード",
            "ソード",
            "ワイドソード",
            "ロングソード",
            "ワイドブレード",
            "ロングブレード",
            "フレイムソード",
            "アクアソード",
            "エレキソード",
            "バンブーソード",
            "フウジンラケット",
            "フミコミザン",
            "バリアブルソード",
            "ネオバリアブル",
            "エンゲツクナイ",
            "ムラマサブレード",
            "マシーンソード",
            "エレメントソード",
            "アサシンソード",
            "クラックシュート",
            "ダブルシュート",
            "トリプルシュート",
            "リフレクメット１",
            "リフレクメット２",
            "リフレクメット３",
            "ウェーブアーム１",
            "ウェーブアーム２",
            "ウェーブアーム３",
            "サンドワーム１",
            "サンドワーム２",
            "サンドワーム３",
            "サモンブラック１",
            "サモンブラック２",
            "サモンブラック３",
            "カモンスネーク",
            "ナンバーボール",
            "ファイアパンチ１",
            "ファイアパンチ２",
            "ファイアパンチ３",
            "バーンスクエア１",
            "バーンスクエア２",
            "バーンスクエア３",
            "リュウセイグン",
            "アクアニードル１",
            "アクアニードル２",
            "アクアニードル３",
            "ブリザードボール",
            "キラーセンサー１",
            "キラーセンサー２",
            "キラーセンサー３",
            "ブーメラン",
            "ハイブーメラン",
            "メガブーメラン",
            "バンブーランス",
            "ヒートドラゴン",
            "エレキドラゴン",
            "アクアドラゴン",
            "ウッドドラゴン",
            "ゴーレムパンチ１",
            "ゴーレムパンチ２",
            "ゴーレムパンチ３",
            "ジャスティスワン",
            "エアホイール１",
            "エアホイール２",
            "エアホイール３",
            "トップウ",
            "スイコミ",
            "マグナム",
            "サークルガン",
            "ストーンキューブ",
            "リトルボイラー１",
            "リトルボイラー２",
            "リトルボイラー３",
            "エアレイド１",
            "エアレイド２",
            "エアレイド３",
            "カウントボム１",
            "カウントボム２",
            "カウントボム３",
            "ステルスマイン",
            "オウエンカ",
            "ディスコード",
            "ティンパニー",
            "サイレンス",
            "ワラニンギョウ",
            "オジゾウサン",
            "ポイズンアヌビス",
            "リカバリー１０",
            "リカバリー３０",
            "リカバリー５０",
            "リカバリー８０",
            "リカバリー１２０",
            "リカバリー１５０",
            "リカバリー２００",
            "リカバリー３００",
            "パネルスチール",
            "エリアスチール",
            "スチールパニシュ",
            "スチールリベンジ",
            "パネルリターン",
            "デスマッチ",
            "ホーリーパネル",
            "サンクチュアリ",
            "カミングロード",
            "ゴーイングロード",
            "ヘビーゲージ",
            "クイックゲージ",
            "フルカスタム",
            "バスターアップ",
            "バグシュウセイ",
            "インビジブル",
            "バリア",
            "バリア１００",
            "バリア２００",
            "バブルラップ",
            "ドリームオーラ",
            "マグネコイル",
            "カーネルアーミー",
            "エレメントラップ",
            "ナビスカウト",
            "カワリミ",
            "シラハドリ",
            "バッドメディスン",
            "ホワイトカプセル",
            "アンインストール",
            "コピーダメージ",
            "ライフシンクロ",
            "アタック＋１０",
            "ナビ＋２０",
            "カラーポイント",
            "アタック＋３０",
            "ダブルポイント"
        }
        Return list
    End Function

    Public Overrides Function LibMegaChipNameList() As String()
        Dim list As String() = {
            "ロール", "ロールＶ２", "ロールＶ３",
            "ブルース", "ブルースEX", "ブルースSP",
            "ヒートマン", "ヒートマンEX", "ヒートマンSP",
            "エレキマン", "エレキマンEX", "エレキマンSP",
            "スラッシュマン", "スラッシュマンEX", "スラッシュマンSP",
            "キラーマン", "キラーマンEX", "キラーマンSP",
            "チャージマン", "チャージマンEX", "チャージマンSP",
            "ブラストマン", "ブラストマンEX", "ブラストマンSP",
            "ダイブマン", "ダイブマンEX", "ダイブマンSP",
            "サーカスマン", "サーカスマンEX", "サーカスマンSP",
            "ジャッジマン", "ジャッジマンEX", "ジャッジマンSP",
            "エレメントマン", "エレメントマンEX", "エレメントマンSP",
            "カーネル", "カーネルEX", "カーネルSP",
            "ハクシャク", "ハクシャクEX", "ハクシャクSP",
            "ジャンゴ", "ジャンゴＶ２", "ジャンゴＶ３"
        }
        Return list
    End Function

    Public Overrides Function LibGigaChipNameListGregar() As String()
        Dim list As String() = {
            "フォルテ",
            "ギガントフック",
            "デルタレイエッジ",
            "カーネルフォース",
            "バグライズソード"
        }
        Return list
    End Function

    Public Overrides Function LibGigaChipNameListFalzar() As String()
        Dim list As String() = {
            "フォルテアナザー",
            "メテオナックル",
            "クロスディバイド",
            "サイトバッチ",
            "バグデスサンダー"
        }
        Return list
    End Function

    Public Overrides Function LibSecretChipNameList() As String()
        Dim list As String() = {
            "オテンコサマ",
            "ガンデルソルＥＸ",
            "アクアマン", "アクアマンEX", "アクアマンSP",
            "トマホークマン", "トマホークマンEX", "トマホークマンSP",
            "テングマン", "テングマンEX", "テングマンSP",
            "グランドマン", "グランドマンEX", "グランドマンSP",
            "ダストマン", "ダストマンEX", "ダストマンSP"
        }
        Return list
    End Function

    Public Overrides Function LibPaNameList() As String()
        Dim list As String() = {
            "ギガキャノン１", "ギガキャノン２", "ギガキャノン３",
            "ワイドバーナー１", "ワイドバーナー２", "ワイドバーナー３",
            "フレイムフック１", "フレイムフック２", "フレイムフック３",
            "パワーウェーブ１", "パワーウェーブ２", "パワーウェーブ３",
            "コーンパーティー",
            "パラレルシェル",
            "デストロイパルス",
            "ギガカウントボム",
            "ストリームヘッド",
            "スーパーワイド",
            "ハイパーバースト",
            "ドリームソード",
            "ヨーヨーグレート",
            "ジゴクホッケー",
            "ポイズンファラオ",
            "ボディガード",
            "ダブルヒーロー",
            "ダークメシア",
            "マスタークロス",
            "サンアンドムーン",
            "ツインリーダーズ",
            "クロスオーバー"
        }
        Return list
    End Function
End Class
