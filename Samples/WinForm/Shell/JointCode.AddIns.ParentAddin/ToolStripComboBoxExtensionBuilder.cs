﻿using System;
using System.Windows.Forms;

namespace JointCode.AddIns.ParentAddin
{
    public class ToolStripComboBoxExtensionBuilder : IExtensionBuilder<ToolStripItem>
    {
        public string Name { get; set; }

        public ToolStripItem BuildExtension(IAddinContext adnContext)
        {
            return new ToolStripComboBox{Text = Name};
        }
    }
}
