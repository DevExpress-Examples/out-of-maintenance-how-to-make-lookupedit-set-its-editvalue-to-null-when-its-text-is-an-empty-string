using System;
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace CustomEditor
{
	class CustomLookUpEdit : LookUpEdit
	{
		static CustomLookUpEdit()
		{
			RepositoryItemCustomLookUpEdit.Register();
		}
		public CustomLookUpEdit()
			: base()
		{
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public new RepositoryItemCustomLookUpEdit Properties
		{
			get
			{
				return base.Properties as RepositoryItemCustomLookUpEdit;
			}
		}

		public override string EditorTypeName
		{
			get
			{
				return RepositoryItemCustomLookUpEdit.EditorName;
			}
		}

		protected override bool ProcessNewValueCore(bool partital, string text)
		{
			if ( this.Properties.IsNullInputAllowed && String.IsNullOrEmpty(text) )
			{
				this.EditValue = null;
				return true;
			}

			return base.ProcessNewValueCore(partital, text);
		}
	}
}
