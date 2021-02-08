﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Kuhpik
{
    public sealed class GameState
    {
        public IGameSystem[] Systems { get; private set; }
        public IUpdating[] UpdateSystems { get; private set; }
        public IFixedUpdating[] FixedUpdateSystems { get; private set; }
        public bool IsInited { get; private set; }
        public EGamestate[] AdditionalScreens { get; private set; }
        public EGamestate Type { get; private set; }

        bool isRestarting;

        public GameState(EGamestate type, bool isRestarting, EGamestate[] additionalScreens, params MonoBehaviour[] systems)
        {
            Systems = systems.Select(x => x as IGameSystem).ToArray();
            this.AdditionalScreens = additionalScreens;
            this.isRestarting = isRestarting;
            this.Type = type;
            Setup();
        }

        public void Activate(bool openScreen)
        {
            if (openScreen)
            {
                UIManager.OpenScreen(Type);

                foreach (var type in AdditionalScreens)
                {
                    UIManager.OpenScreenAdditionaly(type);
                }
            }

            if (isRestarting || !IsInited)
            {
                Perform<IIniting>();
                IsInited = true;
            }
        }

        public void Deactivate()
        {
            if (isRestarting && IsInited)
            {
                Perform<IDisposing>();
                IsInited = false;
            }
        }

        void Setup()
        {
            UpdateSystems = Systems.Where(x => x is IUpdating).Select(x => x as IUpdating).ToArray();
            FixedUpdateSystems = Systems.Where(x => x is IFixedUpdating).Select(x => x as IFixedUpdating).ToArray();
        }

        void Perform<T>() where T : IGameSystem
        {
            for (int i = 0; i < Systems.Length; i++)
            {
                Systems[i].PerformAction<T>();
            }
        }
    }
}