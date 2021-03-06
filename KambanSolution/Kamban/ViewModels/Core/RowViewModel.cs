﻿using Kamban.Repository.Attributes;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Kamban.ViewModels.Core
{
    public class RowViewModel : ReactiveObject, IDim
    {
        [Reactive] public int Id { get; set; }
        [AutoSave, Reactive] public int BoardId { get; set; }
        [AutoSave, Reactive] public string Name { get; set; }
        public string FullName => $"row '{Name}'";
        [AutoSave, Reactive] public int Size { get; set; }
        [AutoSave, Reactive] public int Order { get; set; }
        [Reactive] public int CurNumberOfCards { get; set; }
        [AutoSave, Reactive] public bool LimitSet { get; set; } 
        [AutoSave, Reactive] public int MaxNumberOfCards { get; set; } = 8;
    }
}
