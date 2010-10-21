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
		internal static global::MonoJavaBridge.MethodId _onDestroy1940;
		protected override void onDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._onDestroy1940);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._onDestroy1940);
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState1941;
		protected override void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._onRestoreInstanceState1941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._onRestoreInstanceState1941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged1942;
		public override void onContentChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._onContentChanged1942);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._onContentChanged1942);
		}
		public new global::android.widget.ListView ListView
		{
			get
			{
				return getListView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getListView1943;
		public virtual global::android.widget.ListView getListView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ListActivity._getListView1943)) as android.widget.ListView;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._getListView1943)) as android.widget.ListView;
		}
		public new int SelectedItemPosition
		{
			get
			{
				return getSelectedItemPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedItemPosition1944;
		public virtual int getSelectedItemPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.ListActivity._getSelectedItemPosition1944);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._getSelectedItemPosition1944);
		}
		public new long SelectedItemId
		{
			get
			{
				return getSelectedItemId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedItemId1945;
		public virtual long getSelectedItemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.app.ListActivity._getSelectedItemId1945);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._getSelectedItemId1945);
		}
		internal static global::MonoJavaBridge.MethodId _setSelection1946;
		public virtual void setSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._setSelection1946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._setSelection1946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setListAdapter1947;
		public virtual void setListAdapter(android.widget.ListAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._setListAdapter1947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._setListAdapter1947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onListItemClick1948;
		protected virtual void onListItemClick(android.widget.ListView arg0, android.view.View arg1, int arg2, long arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._onListItemClick1948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._onListItemClick1948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
		internal static global::MonoJavaBridge.MethodId _getListAdapter1949;
		public virtual global::android.widget.ListAdapter getListAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ListActivity._getListAdapter1949)) as android.widget.ListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._getListAdapter1949)) as android.widget.ListAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _ListActivity1950;
		public ListActivity()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ListActivity.staticClass, global::android.app.ListActivity._ListActivity1950);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.ListActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ListActivity"));
			global::android.app.ListActivity._onDestroy1940 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "onDestroy", "()V");
			global::android.app.ListActivity._onRestoreInstanceState1941 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.ListActivity._onContentChanged1942 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "onContentChanged", "()V");
			global::android.app.ListActivity._getListView1943 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "getListView", "()Landroid/widget/ListView;");
			global::android.app.ListActivity._getSelectedItemPosition1944 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "getSelectedItemPosition", "()I");
			global::android.app.ListActivity._getSelectedItemId1945 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "getSelectedItemId", "()J");
			global::android.app.ListActivity._setSelection1946 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "setSelection", "(I)V");
			global::android.app.ListActivity._setListAdapter1947 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "setListAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.app.ListActivity._onListItemClick1948 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V");
			global::android.app.ListActivity._getListAdapter1949 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "getListAdapter", "()Landroid/widget/ListAdapter;");
			global::android.app.ListActivity._ListActivity1950 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "<init>", "()V");
		}
	}
}
