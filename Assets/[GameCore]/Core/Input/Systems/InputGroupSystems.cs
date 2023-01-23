﻿namespace Core.Input
{
    public sealed class InputGroupSystems : Entitas.Systems
    {
        public InputGroupSystems(Contexts contexts)
        {
            Add(new TouchDetectSystems(contexts.input));
            Add(new JoystickSystems(contexts.game, contexts.input, contexts.state, contexts.ui));

            Add(new UIButtonsInputSystems(contexts.input, contexts.level, contexts.state));

            Add(new ControlSystems(contexts));
        }
    }
}