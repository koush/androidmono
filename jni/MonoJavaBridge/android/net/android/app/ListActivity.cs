namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ListActivity : android.app.Activity
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ListActivity() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.ListActivity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState626; 
		protected override void onRestoreInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ListActivity)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState626, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ListActivity.staticClass, _onRestoreInstanceState626, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged627; 
		public override void onContentChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ListActivity)) 
				@__env.CallVoidMethod(this, _onContentChanged627); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ListActivity.staticClass, _onContentChanged627); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getListView628; 
		public virtual android.widget.ListView getListView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ListActivity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ListView>(@__env, @__env.CallObjectMethodPtr(this, _getListView628)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ListView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.ListActivity.staticClass, _getListView628)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedItemPosition629; 
		public virtual int getSelectedItemPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ListActivity)) 
				return @__env.CallIntMethod(this, _getSelectedItemPosition629); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.ListActivity.staticClass, _getSelectedItemPosition629); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedItemId630; 
		public virtual long getSelectedItemId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ListActivity)) 
				return @__env.CallLongMethod(this, _getSelectedItemId630); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.app.ListActivity.staticClass, _getSelectedItemId630); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelection631; 
		public virtual void setSelection(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ListActivity)) 
				@__env.CallVoidMethod(this, _setSelection631, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ListActivity.staticClass, _setSelection631, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setListAdapter632; 
		public virtual void setListAdapter(android.widget.ListAdapter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ListActivity)) 
				@__env.CallVoidMethod(this, _setListAdapter632, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ListActivity.staticClass, _setListAdapter632, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onListItemClick633; 
		protected virtual void onListItemClick(android.widget.ListView arg0, android.view.View arg1, int arg2, long arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ListActivity)) 
				@__env.CallVoidMethod(this, _onListItemClick633, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ListActivity.staticClass, _onListItemClick633, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getListAdapter634; 
		public virtual android.widget.ListAdapter getListAdapter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ListActivity)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallObjectMethodPtr(this, _getListAdapter634)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.ListActivity.staticClass, _getListAdapter634)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ListActivity635; 
		public ListActivity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.ListActivity.staticClass, _ListActivity635, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.ListActivity.staticClass = @__class; 
			global::android.app.ListActivity._onRestoreInstanceState626 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.app.ListActivity._onContentChanged627 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "onContentChanged", "()V"); 
			global::android.app.ListActivity._getListView628 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "getListView", "()Landroid/widget/ListView;"); 
			global::android.app.ListActivity._getSelectedItemPosition629 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "getSelectedItemPosition", "()I"); 
			global::android.app.ListActivity._getSelectedItemId630 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "getSelectedItemId", "()J"); 
			global::android.app.ListActivity._setSelection631 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "setSelection", "(I)V"); 
			global::android.app.ListActivity._setListAdapter632 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "setListAdapter", "(Landroid/widget/ListAdapter;)V"); 
			global::android.app.ListActivity._onListItemClick633 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V"); 
			global::android.app.ListActivity._getListAdapter634 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "getListAdapter", "()Landroid/widget/ListAdapter;"); 
			global::android.app.ListActivity._ListActivity635 = @__env.GetMethodID(global::android.app.ListActivity.staticClass, "<init>", "()V"); 
		} 
	} 
} 
