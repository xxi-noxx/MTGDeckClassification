using DeckClassification.Entities;
using System;

namespace DeckClassification.Services
{
    /// <inheritdoc cref="IJudgeServiceFactory"/>
    public class JudgeServiceFactory : IJudgeServiceFactory
    {
        public IArchetypeJudge CreateArchetypeJudgeService(DeckList deckList)
        {
            return new ArchetypeJudge(deckList);
        }
    }
}
