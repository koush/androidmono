namespace android.app
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ListActivity : android.app.Activity
	{
		internal new static global::java.lang.Class staticClass;
		static ListActivity()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.ListActivity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.ListActivity(@__env);
			}
		}
		protected ListActivity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy644;
		protected override void onDestroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ListActivity._onDestroy644);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._onDestroy644);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState645;
		protected override void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ListActivity._onRestoreInstanceState645, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._onRestoreInstanceState645, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged646;
		public override void onContentChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ListActivity._onContentChanged646);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._onContentChanged646);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getListView647;
		public virtual global::android.widget.ListView getListView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ListView>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ListActivity._getListView647));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ListView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._getListView647));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedItemPosition648;
		public virtual int getSelectedItemPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.ListActivity._getSelectedItemPosition648);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._getSelectedItemPosition648);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedItemId649;
		public virtual long getSelectedItemId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.app.ListActivity._getSelectedItemId649);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._getSelectedItemId649);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelection650;
		public virtual void setSelection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ListActivity._setSelection650, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._setSelection650, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setListAdapter651;
		public virtual void setListAdapter(android.widget.ListAdapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ListActivity._setListAdapter651, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._setListAdapter651, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onListItemClick652;
		protected virtual void onListItemClick(android.widget.ListView arg0, android.view.View arg1, int arg2, long arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ListActivity._onListItemClick652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._onListItemClick652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getListAdapter653;
		public virtual global::android.widget.ListAdapter getListAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ListActivity._getListAdapter653));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ListActivity.staticClass, global::android.app.ListActivity._getListAdapter653));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ListActivity654;
		public ListActivity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.ListActivity.staticClass, global::android.app.ListActivity._ListActivity654, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.ListActivity.staticClass = @__class;
			global::android.app.ListActivity._onDestroy644 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "onDestroy", "()V");
			global::android.app.ListActivity._onRestoreInstanceState645 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.ListActivity._onContentChanged646 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "onContentChanged", "()V");
			global::android.app.ListActivity._getListView647 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "getListView", "()Landroid/widget/ListView;");
			global::android.app.ListActivity._getSelectedItemPosition648 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "getSelectedItemPosition", "()I");
			global::android.app.ListActivity._getSelectedItemId649 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "getSelectedItemId", "()J");
			global::android.app.ListActivity._setSelection650 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "setSelection", "(I)V");
			global::android.app.ListActivity._setListAdapter651 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "setListAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.app.ListActivity._onListItemClick652 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V");
			global::android.app.ListActivity._getListAdapter653 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "getListAdapter", "()Landroid/widget/ListAdapter;");
			global::android.app.ListActivity._ListActivity654 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "<init>", "()V");
		}
	}
}
