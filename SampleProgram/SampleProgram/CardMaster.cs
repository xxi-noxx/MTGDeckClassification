using DeckClassification.Entities;
using SampleProgram.CardDataStubs;
using System.Collections.Generic;

namespace SampleProgram
{
    static class CardMaster
    {
        /// <summary>
        /// スタブのカードデータ
        /// </summary>
        public static readonly Dictionary<string, CardInfo> CardData = new Dictionary<string, CardInfo>()
        {
            { "Uro, Titan of Nature's Wrath", new Uro__Titan_of_Nature_s_Wrath() },
            { "Opt", new Opt() },
            { "Growth Spiral", new Growth_Spiral() },
            { "Negate", new Negate() },
            { "Scorching Dragonfire", new Scorching_Dragonfire() },
            { "Thassa's Intervention", new Thassa_s_Intervention() },
            { "Mystical Dispute", new Mystical_Dispute() },
            { "Chemister's Insight", new Chemister_s_Insight() },
            { "Expansion/Explosion", new Expansion___Explosion() },
            { "Wilderness Reclamation", new Wilderness_Reclamation() },
            { "Shark Typhoon", new Shark_Typhoon() },
            { "Blast Zone", new Blast_Zone() },
            { "Breeding Pool", new Breeding_Pool() },
            { "Castle Vantress", new Castle_Vantress() },
            { "Fabled Passage", new Fabled_Passage() },
            { "Forest", new Forest() },
            { "Island", new Island() },
            { "Ketria Triome", new Ketria_Triome() },
            { "Mountain", new Mountain() },
            { "Steam Vents", new Steam_Vents() },
            { "Stomping Ground", new Stomping_Ground() },
            { "Temple of Epiphany", new Temple_of_Epiphany() },
            { "Aether Gust", new Aether_Gust() },
            { "Fry", new Fry() },
            { "Flame Sweep", new Flame_Sweep() },
            { "Nightpack Ambusher", new Nightpack_Ambusher() },
            { "Beanstalk Giant", new Beanstalk_Giant() },
            { "Bonecrusher Giant", new Bonecrusher_Giant() },
            { "Brazen Borrower", new Brazen_Borrower() },
            { "Claim the Firstborn", new Claim_the_Firstborn() },
            { "Domri's Ambush", new Domri_s_Ambush() },
            { "Edgewall Innkeeper", new Edgewall_Innkeeper() },
            { "Escape to the Wilds", new Escape_to_the_Wilds() },
            { "Fae of Wishes", new Fae_of_Wishes() },
            { "Fling", new Fling() },
            { "Lovestruck Beast", new Lovestruck_Beast() },
            { "Lucky Clover", new Lucky_Clover() },
            { "Nissa, Who Shakes the World", new Nissa__Who_Shakes_the_World() },
            { "Once and Future", new Once_and_Future() },
            { "Redcap Melee", new Redcap_Melee() },
            { "Return to Nature", new Return_to_Nature() },
            { "Shadowspear", new Shadowspear() },
            { "Sorcerous Spyglass", new Sorcerous_Spyglass() },
            { "Storm's Wrath", new Storm_s_Wrath() },
            { "Temple of Abandon", new Temple_of_Abandon() },
            { "Temple of Mystery", new Temple_of_Mystery() },
            { "The Great Henge", new The_Great_Henge() },
            { "Unsummon", new Unsummon() },
        };
    }
}
