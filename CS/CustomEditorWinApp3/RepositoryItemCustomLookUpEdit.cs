using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace CustomEditor
{
	class RepositoryItemCustomLookUpEdit : RepositoryItemLookUpEdit
	{
		internal const string EditorName = "CustomLookUpEdit";

		static RepositoryItemCustomLookUpEdit()
		{
			Register();
		}
		public RepositoryItemCustomLookUpEdit()
		{
		}

		public static void Register()
		{
			EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName,
			  typeof(CustomLookUpEdit), typeof(RepositoryItemCustomLookUpEdit),
				typeof(ButtonEditViewInfo), new ButtonEditPainter(), true));
		}

		public override string EditorTypeName
		{
			get
			{
				return EditorName;
			}
		}

		protected internal new bool IsNullInputAllowed
		{
			get
			{
				return base.IsNullInputAllowed;
			}
		}
	}
}
