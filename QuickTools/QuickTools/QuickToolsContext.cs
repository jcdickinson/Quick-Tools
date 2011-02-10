using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using QuickTools.Core;

namespace QuickTools
{
    /// <summary>
    /// Represents the application context for QuickTools.
    /// </summary>
    [Export(typeof(QuickToolsContext))]
    [Export(typeof(ApplicationContext))]
    public sealed class QuickToolsContext : ApplicationContext, IPartImportsSatisfiedNotification
    {
        /// <summary>
        /// The imported verbs.
        /// </summary>
        [ImportMany(typeof(IVerb))]
        private IEnumerable<IVerb> _importedVerbs;

        private ContextMenuStrip _contextMenu;
        private bool _clicked;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuickToolsContext"/> class.
        /// </summary>
        public QuickToolsContext()
        {

        }

        void IPartImportsSatisfiedNotification.OnImportsSatisfied()
        {
            CreateContextMenu();
            _contextMenu.Show(Control.MousePosition);
        }

        private void CreateContextMenu()
        {
            _contextMenu = new ContextMenuStrip();
            CreateContextMenu(_contextMenu.Items, _importedVerbs);

            var sepItem = new ToolStripSeparator();
            _contextMenu.Items.Add(sepItem);

            var exitItem = new ToolStripMenuItem();
            exitItem.Text = "&Cancel";
            exitItem.Click += new EventHandler(exitItem_Click);
            _contextMenu.Items.Add(exitItem);

            _contextMenu.Closed += new ToolStripDropDownClosedEventHandler(_contextMenu_Closed);
        }

        void _contextMenu_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            if (!_clicked &&
                e.CloseReason != ToolStripDropDownCloseReason.AppFocusChange)
                ExitThread();
        }

        void exitItem_Click(object sender, EventArgs e)
        {
            ExitThread();
        }

        private void CreateContextMenu(ToolStripItemCollection menuItems, IEnumerable<IVerb> verbs)
        {
            var alreadyCreatedItems = new Dictionary<string, ToolStripMenuItem>(StringComparer.Ordinal);
            foreach (var verb in verbs.OrderBy(x => x.Title))
            {
                ToolStripMenuItem menuItem;
                if (!alreadyCreatedItems.TryGetValue(verb.Name, out menuItem))
                {
                    menuItem = new ToolStripMenuItem(verb.Title);
                    menuItem.Tag = verb;
                    if (verb.CanExecute)
                        menuItem.Click += new EventHandler(menuItem_Click);
                    menuItems.Add(menuItem);
                    alreadyCreatedItems.Add(verb.Name, menuItem);
                }

                CreateContextMenu(menuItem.DropDownItems, verb);
            }
        }

        void menuItem_Click(object sender, EventArgs e)
        {
            _clicked = true;
            ((IVerb)((ToolStripMenuItem)sender).Tag).Execute();
            ExitThread();
        }
    }
}
