﻿//------------------------------------------------------------
// Game Framework v2.x
// Copyright © 2014-2016 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using GameFramework;

namespace UnityGameFramework.Runtime
{
    public class VarBool : Variable<bool>
    {
        public VarBool()
        {

        }

        public VarBool(bool value)
            : base(value)
        {

        }

        public static implicit operator VarBool(bool value)
        {
            return new VarBool(value);
        }

        public static implicit operator bool(VarBool value)
        {
            return value.Value;
        }
    }
}
