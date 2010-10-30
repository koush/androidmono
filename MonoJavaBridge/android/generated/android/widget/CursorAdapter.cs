namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.CursorAdapter_))]
	public abstract partial class CursorAdapter : android.widget.BaseAdapter, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CursorAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _init16893;
		protected virtual void init(android.content.Context arg0, android.database.Cursor arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CursorAdapter.staticClass, "init", "(Landroid/content/Context;Landroid/database/Cursor;Z)V", ref global::android.widget.CursorAdapter._init16893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged16894;
		protected virtual void onContentChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CursorAdapter.staticClass, "onContentChanged", "()V", ref global::android.widget.CursorAdapter._onContentChanged16894);
		}
		internal static global::MonoJavaBridge.MethodId _getCount16895;
		public override int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.CursorAdapter.staticClass, "getCount", "()I", ref global::android.widget.CursorAdapter._getCount16895);
		}
		internal static global::MonoJavaBridge.MethodId _getItem16896;
		public override global::java.lang.Object getItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.CursorAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;", ref global::android.widget.CursorAdapter._getItem16896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId16897;
		public override long getItemId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.CursorAdapter.staticClass, "getItemId", "(I)J", ref global::android.widget.CursorAdapter._getItemId16897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFilter16898;
		public virtual global::android.widget.Filter getFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.CursorAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;", ref global::android.widget.CursorAdapter._getFilter16898) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds16899;
		public override bool hasStableIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.CursorAdapter.staticClass, "hasStableIds", "()Z", ref global::android.widget.CursorAdapter._hasStableIds16899);
		}
		internal static global::MonoJavaBridge.MethodId _getView16900;
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.CursorAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.CursorAdapter._getView16900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getCursor16901;
		public virtual global::android.database.Cursor getCursor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.widget.CursorAdapter.staticClass, "getCursor", "()Landroid/database/Cursor;", ref global::android.widget.CursorAdapter._getCursor16901) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _getDropDownView16902;
		public override global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.CursorAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.CursorAdapter._getDropDownView16902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _newView16903;
		public abstract global::android.view.View newView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2);
		internal static global::MonoJavaBridge.MethodId _newDropDownView16904;
		public virtual global::android.view.View newDropDownView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.CursorAdapter.staticClass, "newDropDownView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.CursorAdapter._newDropDownView16904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _bindView16905;
		public abstract void bindView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2);
		internal static global::MonoJavaBridge.MethodId _changeCursor16906;
		public virtual void changeCursor(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CursorAdapter.staticClass, "changeCursor", "(Landroid/database/Cursor;)V", ref global::android.widget.CursorAdapter._changeCursor16906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _convertToString16907;
		public virtual global::java.lang.CharSequence convertToString(android.database.Cursor arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.CursorAdapter.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;", ref global::android.widget.CursorAdapter._convertToString16907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _runQueryOnBackgroundThread16908;
		public virtual global::android.database.Cursor runQueryOnBackgroundThread(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.widget.CursorAdapter.staticClass, "runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;", ref global::android.widget.CursorAdapter._runQueryOnBackgroundThread16908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.database.Cursor;
		}
		public android.database.Cursor runQueryOnBackgroundThread(string arg0)
		{
			return runQueryOnBackgroundThread((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getFilterQueryProvider16909;
		public virtual global::android.widget.FilterQueryProvider getFilterQueryProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.FilterQueryProvider>(this, global::android.widget.CursorAdapter.staticClass, "getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;", ref global::android.widget.CursorAdapter._getFilterQueryProvider16909) as android.widget.FilterQueryProvider;
		}
		internal static global::MonoJavaBridge.MethodId _setFilterQueryProvider16910;
		public virtual void setFilterQueryProvider(android.widget.FilterQueryProvider arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CursorAdapter.staticClass, "setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V", ref global::android.widget.CursorAdapter._setFilterQueryProvider16910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setFilterQueryProvider(global::android.widget.FilterQueryProviderDelegate arg0)
		{
			setFilterQueryProvider((global::android.widget.FilterQueryProviderDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _CursorAdapter16911;
		public CursorAdapter(android.content.Context arg0, android.database.Cursor arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CursorAdapter._CursorAdapter16911.native == global::System.IntPtr.Zero)
				global::android.widget.CursorAdapter._CursorAdapter16911 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._CursorAdapter16911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CursorAdapter16912;
		public CursorAdapter(android.content.Context arg0, android.database.Cursor arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CursorAdapter._CursorAdapter16912.native == global::System.IntPtr.Zero)
				global::android.widget.CursorAdapter._CursorAdapter16912 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._CursorAdapter16912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static CursorAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CursorAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CursorAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.CursorAdapter))]
	internal sealed partial class CursorAdapter_ : android.widget.CursorAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CursorAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newView16913;
		public override global::android.view.View newView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.CursorAdapter_.staticClass, "newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.CursorAdapter_._newView16913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _bindView16914;
		public override void bindView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CursorAdapter_.staticClass, "bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V", ref global::android.widget.CursorAdapter_._bindView16914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static CursorAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CursorAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CursorAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
