using Bushi.Enums;
using Bushi.Models;
using Bushi.JsonDtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace Bushi
{
    public class BushiQuery
    {
        private const string baseUri = "https://fiveringsdb.com/";
        private const string cardsUri = "/cards";

        private CardDeck Cards { get; set; }
        private DateTime LastRequestTime { get; set; }
        private BushiQueryOptions Options { get; set; }

        private bool ShouldDateBeRefreshed
        {
            get
            {
                return DateTime.Now > (this.LastRequestTime + this.Options.CacheTime);
            }
        }

        public BushiQuery()
        {
            this.Options = new BushiQueryOptions();
            this.LastRequestTime = DateTime.MinValue;
        }

        public BushiQuery(BushiQueryOptions options)
        {
            this.Options = options;
            this.LastRequestTime = DateTime.MinValue;
        }

        public CardDeck GetAllCards()
        {
            this.RefreshCardData();

            return this.Cards;
        }
        
        public IEnumerable GetCardsOfType(CardType type)
        {
            this.RefreshCardData();

            switch (type)
            {
                case CardType.Attachment:
                    return this.Cards.Attachments;                    
                case CardType.Character:
                    return this.Cards.Characters;                    
                case CardType.Event:
                    return this.Cards.Events;                    
                case CardType.Holding:
                    return this.Cards.Holdings;                    
                case CardType.Province:
                    return this.Cards.Provinces;                    
                case CardType.Role:
                    return this.Cards.Roles;                    
                case CardType.Stronghold:
                    return this.Cards.Strongholds;                    
                default:
                    return null;
            }
        }

        private void RefreshCardData()
        {
            if (this.ShouldDateBeRefreshed)
            {
                var client = new RestClient(baseUri);
                var request = new RestRequest(cardsUri, Method.GET);

                var response = client.Execute(request);

                var content = response.Content;

                var cards = JsonConvert.DeserializeObject<Records>(content);

                this.LastRequestTime = DateTime.Now;

                this.Cards = new CardDeck(cards.Cards);
            }
        }
    }
}
