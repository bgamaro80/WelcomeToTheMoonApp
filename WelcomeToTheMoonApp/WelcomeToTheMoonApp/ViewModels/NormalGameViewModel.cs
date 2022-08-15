using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WelcomeToTheMoon;
using WelcomeToTheMoonApp.Cards;

namespace WelcomeToTheMoonApp.ViewModels
{
    public class NormalGameViewModel : INotifyPropertyChanged
    {
        private State ActualState { get => (State)StateMng.CurrentState; }

        private StateManager StateMng { get; set; }

        public int Round { get; set; }

        public string AdventureTile => ActualState?.Scenario.GetAdventureTitle() ?? string.Empty;

        public Tuple<int, Symbol, Symbol> FirstCardInfo { get; set; }
        public Tuple<int, Symbol, Symbol> SecondCardInfo { get; set; }
        public Tuple<int, Symbol, Symbol> ThirdCardInfo { get; set; }



        public ObjectiveCard ObjectiveA { get => ActualState.ObjectiveCards.First(o => o.Letter.StartsWith("A")); }
        public ObjectiveCard ObjectiveB { get => ActualState.ObjectiveCards.First(o => o.Letter.StartsWith("B")); }
        public ObjectiveCard ObjectiveC { get => ActualState.ObjectiveCards.First(o => o.Letter.StartsWith("C")); }

        public void Init(Scenarios.Scenario scenario)
        {
            var initialState = new State
            {
                Scenario = scenario,
                ObjectiveCards = CardObjectiveGenerator.GetCardsForGame(scenario.Number),
                Deck = new DeckNormalMode(),
            };
            initialState.Deck.PrepareInitialState();

            StateMng = new StateManager(initialState);

            RefreshTurn();
        }

        public void NextTurn()
        {
            StateMng.Next();

            ActualState.Deck.NextTurn();

            RefreshTurn();
        }

        public void PreviousTurn()
        {
            StateMng.Undo();

            RefreshTurn();
        }

        private void RefreshTurn()
        {
            FirstCardInfo = ActualState.Deck.GetTurnCardInfo(0);
            SecondCardInfo = ActualState.Deck.GetTurnCardInfo(1);
            ThirdCardInfo = ActualState.Deck.GetTurnCardInfo(2);

            Round = ActualState.Deck.Round;

            OnPropertyChanged(nameof(Round));

            OnPropertyChanged(nameof(FirstCardInfo));
            OnPropertyChanged(nameof(SecondCardInfo));
            OnPropertyChanged(nameof(ThirdCardInfo));

            OnPropertyChanged(nameof(ObjectiveA));
            OnPropertyChanged(nameof(ObjectiveB));
            OnPropertyChanged(nameof(ObjectiveC));
        }

        public void AccomplishObjective(ObjectiveCard objectiveCard)
        {
            StateMng.Next();
            
            objectiveCard.IsAccomplished = !objectiveCard.IsAccomplished;

            RefreshTurn();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private class State : IState
        {
            public Scenarios.Scenario Scenario { get; set; }
            public DeckNormalMode Deck { get; set; }

            public List<ObjectiveCard> ObjectiveCards { get; set; }

            public object Clone()
            {
                State clone = (State)MemberwiseClone();

                //Scenario no hace falta clonarlo

                clone.Deck = (DeckNormalMode)Deck.Clone();
                clone.ObjectiveCards = ObjectiveCards.Select(c => (ObjectiveCard)c.Clone()).ToList();

                return clone;
            }
        }
    }
}
