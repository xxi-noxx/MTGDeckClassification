using DeckClassification.Constants;
using System.Collections.Generic;

namespace DeckClassification.Entities
{
    /// <summary>
    /// カード情報
    /// </summary>
    public class CardInfo
    {
        /// <summary>カード名称</summary>
        public string Name { get; set; }

        /// <summary>そのカードが持つ属性</summary>
        public IEnumerable<CardAttr> Attributes { get; set; }

        /// <summary>
        /// カード名を返します
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
