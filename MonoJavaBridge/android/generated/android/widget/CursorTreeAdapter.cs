namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.CursorTreeAdapter_))]
	public abstract partial class CursorTreeAdapter : android.widget.BaseExpandableListAdapter, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CursorTreeAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getGroupId16915;
		public override long getGroupId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "getGroupId", "(I)J", ref global::android.widget.CursorTreeAdapter._getGroupId16915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFilter16916;
		public virtual global::android.widget.Filter getFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;", ref global::android.widget.CursorTreeAdapter._getFilter16916) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds16917;
		public override bool hasStableIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "hasStableIds", "()Z", ref global::android.widget.CursorTreeAdapter._hasStableIds16917);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupCount16918;
		public override int getGroupCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "getGroupCount", "()I", ref global::android.widget.CursorTreeAdapter._getGroupCount16918);
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCount16919;
		public override int getChildrenCount(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "getChildrenCount", "(I)I", ref global::android.widget.CursorTreeAdapter._getChildrenCount16919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGroup16920;
		public override global::java.lang.Object getGroup(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "getGroup", "(I)Ljava/lang/Object;", ref global::android.widget.CursorTreeAdapter._getGroup16920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChild16921;
		public override global::java.lang.Object getChild(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "getChild", "(II)Ljava/lang/Object;", ref global::android.widget.CursorTreeAdapter._getChild16921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChildId16922;
		public override long getChildId(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "getChildId", "(II)J", ref global::android.widget.CursorTreeAdapter._getChildId16922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getGroupView16923;
		public override global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.CursorTreeAdapter._getGroupView16923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getChildView16924;
		public override global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.CursorTreeAdapter._getChildView16924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isChildSelectable16925;
		public override bool isChildSelectable(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "isChildSelectable", "(II)Z", ref global::android.widget.CursorTreeAdapter._isChildSelectable16925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onGroupCollapsed16926;
		public override void onGroupCollapsed(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "onGroupCollapsed", "(I)V", ref global::android.widget.CursorTreeAdapter._onGroupCollapsed16926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCursor16927;
		public virtual global::android.database.Cursor getCursor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.widget.CursorTreeAdapter.staticClass, "getCursor", "()Landroid/database/Cursor;", ref global::android.widget.CursorTreeAdapter._getCursor16927) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged16928;
		public virtual void notifyDataSetChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetChanged", "(Z)V", ref global::android.widget.CursorTreeAdapter._notifyDataSetChanged16928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged16929;
		public override void notifyDataSetChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetChanged", "()V", ref global::android.widget.CursorTreeAdapter._notifyDataSetChanged16929);
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetInvalidated16930;
		public override void notifyDataSetInvalidated()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetInvalidated", "()V", ref global::android.widget.CursorTreeAdapter._notifyDataSetInvalidated16930);
		}
		internal static global::MonoJavaBridge.MethodId _changeCursor16931;
		public virtual void changeCursor(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "changeCursor", "(Landroid/database/Cursor;)V", ref global::android.widget.CursorTreeAdapter._changeCursor16931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _convertToString16932;
		public virtual global::java.lang.String convertToString(android.database.Cursor arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.widget.CursorTreeAdapter.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/String;", ref global::android.widget.CursorTreeAdapter._convertToString16932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _runQueryOnBackgroundThread16933;
		public virtual global::android.database.Cursor runQueryOnBackgroundThread(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.widget.CursorTreeAdapter.staticClass, "runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;", ref global::android.widget.CursorTreeAdapter._runQueryOnBackgroundThread16933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.database.Cursor;
		}
		public android.database.Cursor runQueryOnBackgroundThread(string arg0)
		{
			return runQueryOnBackgroundThread((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getFilterQueryProvider16934;
		public virtual global::android.widget.FilterQueryProvider getFilterQueryProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.FilterQueryProvider>(this, global::android.widget.CursorTreeAdapter.staticClass, "getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;", ref global::android.widget.CursorTreeAdapter._getFilterQueryProvider16934) as android.widget.FilterQueryProvider;
		}
		internal static global::MonoJavaBridge.MethodId _setFilterQueryProvider16935;
		public virtual void setFilterQueryProvider(android.widget.FilterQueryProvider arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V", ref global::android.widget.CursorTreeAdapter._setFilterQueryProvider16935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setFilterQueryProvider(global::android.widget.FilterQueryProviderDelegate arg0)
		{
			setFilterQueryProvider((global::android.widget.FilterQueryProviderDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCursor16936;
		protected abstract global::android.database.Cursor getChildrenCursor(android.database.Cursor arg0);
		internal static global::MonoJavaBridge.MethodId _setGroupCursor16937;
		public virtual void setGroupCursor(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "setGroupCursor", "(Landroid/database/Cursor;)V", ref global::android.widget.CursorTreeAdapter._setGroupCursor16937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildrenCursor16938;
		public virtual void setChildrenCursor(int arg0, android.database.Cursor arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CursorTreeAdapter.staticClass, "setChildrenCursor", "(ILandroid/database/Cursor;)V", ref global::android.widget.CursorTreeAdapter._setChildrenCursor16938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newGroupView16939;
		protected abstract global::android.view.View newGroupView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3);
		internal static global::MonoJavaBridge.MethodId _bindGroupView16940;
		protected abstract void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3);
		internal static global::MonoJavaBridge.MethodId _newChildView16941;
		protected abstract global::android.view.View newChildView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3);
		internal static global::MonoJavaBridge.MethodId _bindChildView16942;
		protected abstract void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3);
		internal static global::MonoJavaBridge.MethodId _CursorTreeAdapter16943;
		public CursorTreeAdapter(android.database.Cursor arg0, android.content.Context arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CursorTreeAdapter._CursorTreeAdapter16943.native == global::System.IntPtr.Zero)
				global::android.widget.CursorTreeAdapter._CursorTreeAdapter16943 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "<init>", "(Landroid/database/Cursor;Landroid/content/Context;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._CursorTreeAdapter16943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CursorTreeAdapter16944;
		public CursorTreeAdapter(android.database.Cursor arg0, android.content.Context arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CursorTreeAdapter._CursorTreeAdapter16944.native == global::System.IntPtr.Zero)
				global::android.widget.CursorTreeAdapter._CursorTreeAdapter16944 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "<init>", "(Landroid/database/Cursor;Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._CursorTreeAdapter16944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static CursorTreeAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CursorTreeAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CursorTreeAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.CursorTreeAdapter))]
	internal sealed partial class CursorTreeAdapter_ : android.widget.CursorTreeAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CursorTreeAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCursor16945;
		protected override global::android.database.Cursor getChildrenCursor(android.database.Cursor arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.widget.CursorTreeAdapter_.staticClass, "getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;", ref global::android.widget.CursorTreeAdapter_._getChildrenCursor16945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _newGroupView16946;
		protected override global::android.view.View newGroupView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.CursorTreeAdapter_.staticClass, "newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.CursorTreeAdapter_._newGroupView16946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _bindGroupView16947;
		protected override void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CursorTreeAdapter_.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V", ref global::android.widget.CursorTreeAdapter_._bindGroupView16947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _newChildView16948;
		protected override global::android.view.View newChildView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.CursorTreeAdapter_.staticClass, "newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.CursorTreeAdapter_._newChildView16948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _bindChildView16949;
		protected override void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CursorTreeAdapter_.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V", ref global::android.widget.CursorTreeAdapter_._bindChildView16949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		static CursorTreeAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CursorTreeAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CursorTreeAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
