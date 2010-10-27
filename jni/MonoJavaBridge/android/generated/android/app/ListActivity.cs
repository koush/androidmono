namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ListActivity : android.app.Activity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ListActivity()
		{
			InitJNI();
		}
		protected ListActivity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy1944;
		protected override void onDestroy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._onDestroy1944);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._onDestroy1944);
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState1945;
		protected override void onRestoreInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._onRestoreInstanceState1945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._onRestoreInstanceState1945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged1946;
		public override void onContentChanged()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._onContentChanged1946);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._onContentChanged1946);
		}
		public new global::android.widget.ListView ListView
		{
			get
			{
				return getListView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getListView1947;
		public virtual global::android.widget.ListView getListView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ListActivity._getListView1947)) as android.widget.ListView;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._getListView1947)) as android.widget.ListView;
		}
		public new int SelectedItemPosition
		{
			get
			{
				return getSelectedItemPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedItemPosition1948;
		public virtual int getSelectedItemPosition()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.ListActivity._getSelectedItemPosition1948);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._getSelectedItemPosition1948);
		}
		public new long SelectedItemId
		{
			get
			{
				return getSelectedItemId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedItemId1949;
		public virtual long getSelectedItemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.app.ListActivity._getSelectedItemId1949);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._getSelectedItemId1949);
		}
		public new int Selection
		{
			set
			{
				setSelection(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSelection1950;
		public virtual void setSelection(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._setSelection1950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._setSelection1950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setListAdapter1951;
		public virtual void setListAdapter(android.widget.ListAdapter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._setListAdapter1951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._setListAdapter1951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onListItemClick1952;
		protected virtual void onListItemClick(android.widget.ListView arg0, android.view.View arg1, int arg2, long arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._onListItemClick1952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._onListItemClick1952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
		internal static global::MonoJavaBridge.MethodId _getListAdapter1953;
		public virtual global::android.widget.ListAdapter getListAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ListActivity._getListAdapter1953)) as android.widget.ListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._getListAdapter1953)) as android.widget.ListAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _ListActivity1954;
		public ListActivity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ListActivity.staticClass, global::android.app.ListActivity._ListActivity1954);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.ListActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ListActivity"));
			global::android.app.ListActivity._onDestroy1944 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "onDestroy", "()V");
			global::android.app.ListActivity._onRestoreInstanceState1945 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.ListActivity._onContentChanged1946 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "onContentChanged", "()V");
			global::android.app.ListActivity._getListView1947 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "getListView", "()Landroid/widget/ListView;");
			global::android.app.ListActivity._getSelectedItemPosition1948 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "getSelectedItemPosition", "()I");
			global::android.app.ListActivity._getSelectedItemId1949 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "getSelectedItemId", "()J");
			global::android.app.ListActivity._setSelection1950 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "setSelection", "(I)V");
			global::android.app.ListActivity._setListAdapter1951 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "setListAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.app.ListActivity._onListItemClick1952 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V");
			global::android.app.ListActivity._getListAdapter1953 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "getListAdapter", "()Landroid/widget/ListAdapter;");
			global::android.app.ListActivity._ListActivity1954 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "<init>", "()V");
		}
	}
}
