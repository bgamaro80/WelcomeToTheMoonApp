using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using WelcomeToTheMoon;

namespace WelcomeToTheMoonApp.ViewModels
{
    public class NormalGameViewModel : INotifyPropertyChanged
    {
        private State ActualState { get => (State)StateMng.CurrentState; }

        private StateManager StateMng { get; set; }

        public int Round { get; set; }

        public Tuple<int, Symbol, Symbol> FirstCardInfo { get; set; }
        public Tuple<int, Symbol, Symbol> SecondCardInfo { get; set; }
        public Tuple<int, Symbol, Symbol> ThirdCardInfo { get; set; }

        public void Init()
        {
            var initialState = new State
            {
                Deck = new DeckNormalMode()
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
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private class State : IState
        {
            public DeckNormalMode Deck { get; set; }

            public object Clone()
            {
                State clone = (State)MemberwiseClone();

                clone.Deck = (DeckNormalMode)Deck.Clone();

                return clone;
            }
        }
    }
}
