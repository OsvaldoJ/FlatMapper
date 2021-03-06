﻿#region License

// 
// Copyright (c) 2011-2015, João Matos Silva <kappy@acydburne.com.pt>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 

#endregion

using System;

namespace FlatMapper
{
    public interface IFieldSettings<T, TMember>
    {
        IFieldSettings<T, TMember> WithLength(int length);

        IFieldSettings<T, TMember> WithLeftPadding(char paddingChar);

        IFieldSettings<T, TMember> WithRightPadding(char paddingChar);

        IFieldSettings<T, TMember> AllowNull(string nullValue);

        IFieldSettings<T, TMember> UseValueConverter<TValueConverter>() where TValueConverter : FieldValueConverter<TMember>, new();

        IFieldSettings<T, TMember> WithFormat(IFormatProvider formatProvider);
    }
}
