using Bushi.Models;
using Bushi.JsonDtos;
using System;
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

        public CardDeck GetAllCards()
        {
            var client = new RestClient(baseUri);
            var request = new RestRequest(cardsUri, Method.GET);

            var response = client.Execute(request);

            var content = response.Content;

            var cards = JsonConvert.DeserializeObject<List<Card>>(content);

            var cardDeck = new CardDeck(cards);

            return cardDeck;
        }
    }
}
