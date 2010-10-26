namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExpandableListActivity : android.app.Activity, android.view.View.OnCreateContextMenuListener, android.widget.ExpandableListView.OnChildClickListener, android.widget.ExpandableListView.OnGroupCollapseListener, android.widget.ExpandableListView.OnGroupExpandListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExpandableListActivity()
		{
			InitJNI();
		}
		protected ExpandableListActivity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState1824;
		protected override void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity._onRestoreInstanceState1824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onRestoreInstanceState1824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged1825;
		public override void onContentChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity._onContentChanged1825);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onContentChanged1825);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu1826;
		public override void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity._onCreateContextMenu1826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onCreateContextMenu1826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onChildClick1827;
		public virtual bool onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.ExpandableListActivity._onChildClick1827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onChildClick1827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onGroupCollapse1828;
		public virtual void onGroupCollapse(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity._onGroupCollapse1828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onGroupCollapse1828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onGroupExpand1829;
		public virtual void onGroupExpand(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity._onGroupExpand1829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onGroupExpand1829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setListAdapter1830;
		public virtual void setListAdapter(android.widget.ExpandableListAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity._setListAdapter1830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._setListAdapter1830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.ExpandableListView ExpandableListView
		{
			get
			{
				return getExpandableListView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExpandableListView1831;
		public virtual global::android.widget.ExpandableListView getExpandableListView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ExpandableListActivity._getExpandableListView1831)) as android.widget.ExpandableListView;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._getExpandableListView1831)) as android.widget.ExpandableListView;
		}
		public new global::android.widget.ExpandableListAdapter ExpandableListAdapter
		{
			get
			{
				return getExpandableListAdapter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExpandableListAdapter1832;
		public virtual global::android.widget.ExpandableListAdapter getExpandableListAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ExpandableListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ExpandableListActivity._getExpandableListAdapter1832)) as android.widget.ExpandableListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ExpandableListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._getExpandableListAdapter1832)) as android.widget.ExpandableListAdapter;
		}
		public new long SelectedId
		{
			get
			{
				return getSelectedId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedId1833;
		public virtual long getSelectedId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.app.ExpandableListActivity._getSelectedId1833);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._getSelectedId1833);
		}
		public new long SelectedPosition
		{
			get
			{
				return getSelectedPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedPosition1834;
		public virtual long getSelectedPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.app.ExpandableListActivity._getSelectedPosition1834);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._getSelectedPosition1834);
		}
		internal static global::MonoJavaBridge.MethodId _setSelectedChild1835;
		public virtual bool setSelectedChild(int arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.ExpandableListActivity._setSelectedChild1835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._setSelectedChild1835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setSelectedGroup1836;
		public virtual void setSelectedGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity._setSelectedGroup1836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._setSelectedGroup1836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ExpandableListActivity1837;
		public ExpandableListActivity()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._ExpandableListActivity1837);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.ExpandableListActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ExpandableListActivity"));
			global::android.app.ExpandableListActivity._onRestoreInstanceState1824 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.ExpandableListActivity._onContentChanged1825 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "onContentChanged", "()V");
			global::android.app.ExpandableListActivity._onCreateContextMenu1826 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
			global::android.app.ExpandableListActivity._onChildClick1827 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z");
			global::android.app.ExpandableListActivity._onGroupCollapse1828 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "onGroupCollapse", "(I)V");
			global::android.app.ExpandableListActivity._onGroupExpand1829 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "onGroupExpand", "(I)V");
			global::android.app.ExpandableListActivity._setListAdapter1830 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "setListAdapter", "(Landroid/widget/ExpandableListAdapter;)V");
			global::android.app.ExpandableListActivity._getExpandableListView1831 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "getExpandableListView", "()Landroid/widget/ExpandableListView;");
			global::android.app.ExpandableListActivity._getExpandableListAdapter1832 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;");
			global::android.app.ExpandableListActivity._getSelectedId1833 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "getSelectedId", "()J");
			global::android.app.ExpandableListActivity._getSelectedPosition1834 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "getSelectedPosition", "()J");
			global::android.app.ExpandableListActivity._setSelectedChild1835 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "setSelectedChild", "(IIZ)Z");
			global::android.app.ExpandableListActivity._setSelectedGroup1836 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "setSelectedGroup", "(I)V");
			global::android.app.ExpandableListActivity._ExpandableListActivity1837 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "<init>", "()V");
		}
	}
}
