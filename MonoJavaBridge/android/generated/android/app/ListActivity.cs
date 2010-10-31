namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ListActivity : android.app.Activity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ListActivity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ListActivity.staticClass, "onDestroy", "()V", ref global::android.app.ListActivity._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void onRestoreInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ListActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V", ref global::android.app.ListActivity._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void onContentChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ListActivity.staticClass, "onContentChanged", "()V", ref global::android.app.ListActivity._m2);
		}
		public new global::android.widget.ListView ListView
		{
			get
			{
				return getListView();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.widget.ListView getListView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.ListActivity.staticClass, "getListView", "()Landroid/widget/ListView;", ref global::android.app.ListActivity._m3) as android.widget.ListView;
		}
		public new int SelectedItemPosition
		{
			get
			{
				return getSelectedItemPosition();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getSelectedItemPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.ListActivity.staticClass, "getSelectedItemPosition", "()I", ref global::android.app.ListActivity._m4);
		}
		public new long SelectedItemId
		{
			get
			{
				return getSelectedItemId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual long getSelectedItemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.app.ListActivity.staticClass, "getSelectedItemId", "()J", ref global::android.app.ListActivity._m5);
		}
		public new int Selection
		{
			set
			{
				setSelection(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setSelection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ListActivity.staticClass, "setSelection", "(I)V", ref global::android.app.ListActivity._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setListAdapter(android.widget.ListAdapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ListActivity.staticClass, "setListAdapter", "(Landroid/widget/ListAdapter;)V", ref global::android.app.ListActivity._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual void onListItemClick(android.widget.ListView arg0, android.view.View arg1, int arg2, long arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ListActivity.staticClass, "onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V", ref global::android.app.ListActivity._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.widget.ListAdapter ListAdapter
		{
			get
			{
				return getListAdapter();
			}
			set
			{
				setListAdapter(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.widget.ListAdapter getListAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.ListAdapter>(this, global::android.app.ListActivity.staticClass, "getListAdapter", "()Landroid/widget/ListAdapter;", ref global::android.app.ListActivity._m9) as android.widget.ListAdapter;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public ListActivity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.ListActivity._m10.native == global::System.IntPtr.Zero)
				global::android.app.ListActivity._m10 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ListActivity.staticClass, global::android.app.ListActivity._m10);
			Init(@__env, handle);
		}
		static ListActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.ListActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ListActivity"));
		}
	}
}
