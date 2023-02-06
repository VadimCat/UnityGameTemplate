﻿using System;
using System.Collections.Generic;
// using Client.Presenters;
using Ji2Core.Core;
using Ji2Core.Core.States;

namespace Client.States
{
    public class StateFactory : IStateFactory
    {
        private readonly Context context;
        
        public StateFactory(Context context)
        {
            this.context = context;
        }

        public Dictionary<Type, IExitableState> GetStates(StateMachine stateMachine)
        {
            var dict = new Dictionary<Type, IExitableState>();
            
            dict[typeof(InitialState)] = new InitialState(stateMachine,
                context.GetService<Ji2Core.Core.ScreenNavigation.ScreenNavigator>(),
                context.GetService<SceneLoader>());
            
            // dict[typeof(GameState)] = new GameState(context.GetService<LoadingPresenterFactory>());

            return dict;
        } 
    }
}