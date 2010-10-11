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
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState537;
		protected override void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity._onRestoreInstanceState537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onRestoreInstanceState537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged538;
		public override void onContentChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity._onContentChanged538);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onContentChanged538);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu539;
		public override void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity._onCreateContextMenu539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onCreateContextMenu539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onChildClick540;
		public virtual bool onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.ExpandableListActivity._onChildClick540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onChildClick540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onGroupCollapse541;
		public virtual void onGroupCollapse(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity._onGroupCollapse541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onGroupCollapse541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onGroupExpand542;
		public virtual void onGroupExpand(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity._onGroupExpand542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onGroupExpand542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setListAdapter543;
		public virtual void setListAdapter(android.widget.ExpandableListAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity._setListAdapter543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._setListAdapter543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExpandableListView544;
		public virtual global::android.widget.ExpandableListView getExpandableListView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ExpandableListActivity._getExpandableListView544)) as android.widget.ExpandableListView;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._getExpandableListView544)) as android.widget.ExpandableListView;
		}
		internal static global::MonoJavaBridge.MethodId _getExpandableListAdapter545;
		public virtual global::android.widget.ExpandableListAdapter getExpandableListAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ExpandableListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ExpandableListActivity._getExpandableListAdapter545)) as android.widget.ExpandableListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ExpandableListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._getExpandableListAdapter545)) as android.widget.ExpandableListAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedId546;
		public virtual long getSelectedId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.app.ExpandableListActivity._getSelectedId546);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._getSelectedId546);
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedPosition547;
		public virtual long getSelectedPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.app.ExpandableListActivity._getSelectedPosition547);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._getSelectedPosition547);
		}
		internal static global::MonoJavaBridge.MethodId _setSelectedChild548;
		public virtual bool setSelectedChild(int arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.ExpandableListActivity._setSelectedChild548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._setSelectedChild548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setSelectedGroup549;
		public virtual void setSelectedGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity._setSelectedGroup549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._setSelectedGroup549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ExpandableListActivity550;
		public ExpandableListActivity()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._ExpandableListActivity550);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.ExpandableListActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ExpandableListActivity"));
			global::android.app.ExpandableListActivity._onRestoreInstanceState537 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.ExpandableListActivity._onContentChanged538 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "onContentChanged", "()V");
			global::android.app.ExpandableListActivity._onCreateContextMenu539 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
			global::android.app.ExpandableListActivity._onChildClick540 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z");
			global::android.app.ExpandableListActivity._onGroupCollapse541 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "onGroupCollapse", "(I)V");
			global::android.app.ExpandableListActivity._onGroupExpand542 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "onGroupExpand", "(I)V");
			global::android.app.ExpandableListActivity._setListAdapter543 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "setListAdapter", "(Landroid/widget/ExpandableListAdapter;)V");
			global::android.app.ExpandableListActivity._getExpandableListView544 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "getExpandableListView", "()Landroid/widget/ExpandableListView;");
			global::android.app.ExpandableListActivity._getExpandableListAdapter545 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;");
			global::android.app.ExpandableListActivity._getSelectedId546 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "getSelectedId", "()J");
			global::android.app.ExpandableListActivity._getSelectedPosition547 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "getSelectedPosition", "()J");
			global::android.app.ExpandableListActivity._setSelectedChild548 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "setSelectedChild", "(IIZ)Z");
			global::android.app.ExpandableListActivity._setSelectedGroup549 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "setSelectedGroup", "(I)V");
			global::android.app.ExpandableListActivity._ExpandableListActivity550 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "<init>", "()V");
		}
	}
}
