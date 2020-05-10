# MTGDeckClassification

Magic: the Gathering のデッキ情報を分析します。

## IClassification インターフェース

名前空間： DeckClassification  
アセンブリ： DeckClassification.dll

デッキの分析処理の機能を提供します。

### メソッド

#### GetArchetype(DeckList)

デッキのアーキタイプを取得します

- deckList：DeckList  
アーキタイプを分析するデッキ情報

----

## Classification クラス

名前空間： DeckClassification  
アセンブリ： DeckClassification.dll

デッキの分析処理の機能です。

### Classification() コンストラクタ

既定の判定処理を備えた、Classificationクラスのインスタンスを生成します。

### Classification(IJudgeServiceFactory) コンストラクタ

指定した判定処理オブジェクト生成インスタンスを備えた、、Classificationクラスのインスタンスを生成します。

- factory：IJudgeServiceFactory  
判定処理を行うオブジェクトを生成するFactoryクラス

### GetArchetype(DeckList) メソッド

デッキのアーキタイプを取得します

- deckList：DeckList  
アーキタイプを分析するデッキ情報

#### 詳細

デッキを以下の6つのアーキタイプに分類します。
（参考：[M:TG Wiki アーキタイプ](http://mtgwiki.com/wiki/%E3%82%A2%E3%83%BC%E3%82%AD%E3%82%BF%E3%82%A4%E3%83%97)）

- アグロ
- ミッドレンジ
- ランプ
- コンボ
- コントロール
- 撹乱的アグロ


何れのアーキタイプにも属さないデッキの場合は「未分類」とします。

#### 実装例

次の例は、あらかじめ用意したデッキ情報を渡してアーキタイプを取得し、それをコンソールに表示します。

```csharp:sample.cs
using System;
using System.Linq;
using DeckClassification;
using DeckClassification.Entities;

public class Example
{
    static void Main()
    {
        // 分析したいデッキ情報を用意
        var main = new[]
        {
            new DeckItem() { Number = 60, Card = new CardInfo() { Name = "Mountain" }},
            new DeckItem() { Number = 60, Card = new CardInfo() { Name = "Forest" }}
        };
        var deck = new DeckList()
        {
            Mainboard = main,
            Sideboard = Enumerable.Empty<DeckItem>()
        };

        // 分析処理クラスを生成し、デッキ情報を渡してアーキタイプ情報取得
        IClassification classification = new Classification();
        var archetype = classification.GetArchetype(deck);

        // 取得したアーキタイプの表示
        Console.WriteLine($"Example Deck のアーキタイプは {archetype} です。");
        /* Output : Example Deck のアーキタイプは Other です。*/
    }
}
```