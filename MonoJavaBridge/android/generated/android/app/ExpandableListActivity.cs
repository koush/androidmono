namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExpandableListActivity : android.app.Activity, android.view.View.OnCreateContextMenuListener, android.widget.ExpandableListView.OnChildClickListener, android.widget.ExpandableListView.OnGroupCollapseListener, android.widget.ExpandableListView.OnGroupExpandListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ExpandableListActivity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onRestoreInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V", ref global::android.app.ExpandableListActivity._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void onContentChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, "onContentChanged", "()V", ref global::android.app.ExpandableListActivity._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V", ref global::android.app.ExpandableListActivity._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.ExpandableListActivity.staticClass, "onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z", ref global::android.app.ExpandableListActivity._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void onGroupCollapse(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, "onGroupCollapse", "(I)V", ref global::android.app.ExpandableListActivity._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void onGroupExpand(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, "onGroupExpand", "(I)V", ref global::android.app.ExpandableListActivity._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.ExpandableListAdapter ListAdapter
		{
			set
			{
				setListAdapter(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setListAdapter(android.widget.ExpandableListAdapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, "setListAdapter", "(Landroid/widget/ExpandableListAdapter;)V", ref global::android.app.ExpandableListActivity._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.ExpandableListView ExpandableListView
		{
			get
			{
				return getExpandableListView();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.widget.ExpandableListView getExpandableListView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.ExpandableListActivity.staticClass, "getExpandableListView", "()Landroid/widget/ExpandableListView;", ref global::android.app.ExpandableListActivity._m7) as android.widget.ExpandableListView;
		}
		public new global::android.widget.ExpandableListAdapter ExpandableListAdapter
		{
			get
			{
				return getExpandableListAdapter();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.widget.ExpandableListAdapter getExpandableListAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.ExpandableListAdapter>(this, global::android.app.ExpandableListActivity.staticClass, "getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;", ref global::android.app.ExpandableListActivity._m8) as android.widget.ExpandableListAdapter;
		}
		public new long SelectedId
		{
			get
			{
				return getSelectedId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual long getSelectedId()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.app.ExpandableListActivity.staticClass, "getSelectedId", "()J", ref global::android.app.ExpandableListActivity._m9);
		}
		public new long SelectedPosition
		{
			get
			{
				return getSelectedPosition();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual long getSelectedPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.app.ExpandableListActivity.staticClass, "getSelectedPosition", "()J", ref global::android.app.ExpandableListActivity._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool setSelectedChild(int arg0, int arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.ExpandableListActivity.staticClass, "setSelectedChild", "(IIZ)Z", ref global::android.app.ExpandableListActivity._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int SelectedGroup
		{
			set
			{
				setSelectedGroup(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setSelectedGroup(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, "setSelectedGroup", "(I)V", ref global::android.app.ExpandableListActivity._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public ExpandableListActivity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.ExpandableListActivity._m13.native == global::System.IntPtr.Zero)
				global::android.app.ExpandableListActivity._m13 = @__env.GetMethodIDNoThrow(global::android.app.ExpandableListActivity.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._m13);
			Init(@__env, handle);
		}
		static ExpandableListActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.ExpandableListActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ExpandableListActivity"));
		}
		internal static void InitJNI()
		{
		}
	}
}
