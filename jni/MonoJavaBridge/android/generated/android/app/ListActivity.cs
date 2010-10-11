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
		internal static global::MonoJavaBridge.MethodId _onDestroy654;
		protected override void onDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._onDestroy654);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._onDestroy654);
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState655;
		protected override void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._onRestoreInstanceState655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._onRestoreInstanceState655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged656;
		public override void onContentChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._onContentChanged656);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._onContentChanged656);
		}
		internal static global::MonoJavaBridge.MethodId _getListView657;
		public virtual global::android.widget.ListView getListView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ListActivity._getListView657)) as android.widget.ListView;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._getListView657)) as android.widget.ListView;
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedItemPosition658;
		public virtual int getSelectedItemPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.ListActivity._getSelectedItemPosition658);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._getSelectedItemPosition658);
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedItemId659;
		public virtual long getSelectedItemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.app.ListActivity._getSelectedItemId659);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._getSelectedItemId659);
		}
		internal static global::MonoJavaBridge.MethodId _setSelection660;
		public virtual void setSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._setSelection660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._setSelection660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setListAdapter661;
		public virtual void setListAdapter(android.widget.ListAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._setListAdapter661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._setListAdapter661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onListItemClick662;
		protected virtual void onListItemClick(android.widget.ListView arg0, android.view.View arg1, int arg2, long arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ListActivity._onListItemClick662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._onListItemClick662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getListAdapter663;
		public virtual global::android.widget.ListAdapter getListAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ListActivity._getListAdapter663)) as android.widget.ListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._getListAdapter663)) as android.widget.ListAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _ListActivity664;
		public ListActivity()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ListActivity.staticClass, global::android.app.ListActivity._ListActivity664);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.ListActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ListActivity"));
			global::android.app.ListActivity._onDestroy654 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "onDestroy", "()V");
			global::android.app.ListActivity._onRestoreInstanceState655 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.ListActivity._onContentChanged656 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "onContentChanged", "()V");
			global::android.app.ListActivity._getListView657 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "getListView", "()Landroid/widget/ListView;");
			global::android.app.ListActivity._getSelectedItemPosition658 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "getSelectedItemPosition", "()I");
			global::android.app.ListActivity._getSelectedItemId659 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "getSelectedItemId", "()J");
			global::android.app.ListActivity._setSelection660 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "setSelection", "(I)V");
			global::android.app.ListActivity._setListAdapter661 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "setListAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.app.ListActivity._onListItemClick662 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V");
			global::android.app.ListActivity._getListAdapter663 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "getListAdapter", "()Landroid/widget/ListAdapter;");
			global::android.app.ListActivity._ListActivity664 = @__env.GetMethodIDNoThrow(global::android.app.ListActivity.staticClass, "<init>", "()V");
		}
	}
}
