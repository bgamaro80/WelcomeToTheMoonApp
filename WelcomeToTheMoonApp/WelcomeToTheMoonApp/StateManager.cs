using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToTheMoon
{
    public class StateManager
    {
        private List<IState> mStates = new List<IState>();

        private IState mCurrentState;
        public IState CurrentState { get => mCurrentState ?? throw new NullReferenceException("Current state is null."); }

        public StateManager(IState initialState)
        {
            mCurrentState = initialState;

            mStates.Add((IState)mCurrentState.Clone());
        }

        public void Next()
        {
            mStates.Add((IState)mCurrentState.Clone());
        }

        public void Undo()
        {
            if (mStates.Count <= 1)
                return;

            mCurrentState = mStates.Last();
            mStates.RemoveAt(mStates.Count - 1);
        }

        public void Clear()
        { 
            mCurrentState = null;
            mStates.Clear();
        }
    }

    public interface IState : ICloneable
    { }
}
