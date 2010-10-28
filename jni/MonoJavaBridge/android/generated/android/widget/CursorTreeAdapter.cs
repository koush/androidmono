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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getGroupId16915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getGroupId16915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFilter16916;
		public virtual global::android.widget.Filter getFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getFilter16916)) as android.widget.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getFilter16916)) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds16917;
		public override bool hasStableIds()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._hasStableIds16917);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._hasStableIds16917);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupCount16918;
		public override int getGroupCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getGroupCount16918);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getGroupCount16918);
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCount16919;
		public override int getChildrenCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getChildrenCount16919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getChildrenCount16919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGroup16920;
		public override global::java.lang.Object getGroup(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getGroup16920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getGroup16920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChild16921;
		public override global::java.lang.Object getChild(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getChild16921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getChild16921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChildId16922;
		public override long getChildId(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getChildId16922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getChildId16922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getGroupView16923;
		public override global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getGroupView16923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getGroupView16923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getChildView16924;
		public override global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getChildView16924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getChildView16924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isChildSelectable16925;
		public override bool isChildSelectable(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._isChildSelectable16925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._isChildSelectable16925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onGroupCollapsed16926;
		public override void onGroupCollapsed(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._onGroupCollapsed16926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._onGroupCollapsed16926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCursor16927;
		public virtual global::android.database.Cursor getCursor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getCursor16927)) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getCursor16927)) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged16928;
		public virtual void notifyDataSetChanged(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._notifyDataSetChanged16928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._notifyDataSetChanged16928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged16929;
		public override void notifyDataSetChanged()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._notifyDataSetChanged16929);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._notifyDataSetChanged16929);
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetInvalidated16930;
		public override void notifyDataSetInvalidated()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._notifyDataSetInvalidated16930);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._notifyDataSetInvalidated16930);
		}
		internal static global::MonoJavaBridge.MethodId _changeCursor16931;
		public virtual void changeCursor(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._changeCursor16931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._changeCursor16931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _convertToString16932;
		public virtual global::java.lang.String convertToString(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._convertToString16932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._convertToString16932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _runQueryOnBackgroundThread16933;
		public virtual global::android.database.Cursor runQueryOnBackgroundThread(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._runQueryOnBackgroundThread16933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._runQueryOnBackgroundThread16933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		public android.database.Cursor runQueryOnBackgroundThread(string arg0)
		{
			return runQueryOnBackgroundThread((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getFilterQueryProvider16934;
		public virtual global::android.widget.FilterQueryProvider getFilterQueryProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.FilterQueryProvider>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getFilterQueryProvider16934)) as android.widget.FilterQueryProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.FilterQueryProvider>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getFilterQueryProvider16934)) as android.widget.FilterQueryProvider;
		}
		internal static global::MonoJavaBridge.MethodId _setFilterQueryProvider16935;
		public virtual void setFilterQueryProvider(android.widget.FilterQueryProvider arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._setFilterQueryProvider16935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._setFilterQueryProvider16935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._setGroupCursor16937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._setGroupCursor16937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildrenCursor16938;
		public virtual void setChildrenCursor(int arg0, android.database.Cursor arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._setChildrenCursor16938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._setChildrenCursor16938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._CursorTreeAdapter16943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CursorTreeAdapter16944;
		public CursorTreeAdapter(android.database.Cursor arg0, android.content.Context arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._CursorTreeAdapter16944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static CursorTreeAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CursorTreeAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CursorTreeAdapter"));
			global::android.widget.CursorTreeAdapter._getGroupId16915 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getGroupId", "(I)J");
			global::android.widget.CursorTreeAdapter._getFilter16916 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.CursorTreeAdapter._hasStableIds16917 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "hasStableIds", "()Z");
			global::android.widget.CursorTreeAdapter._getGroupCount16918 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getGroupCount", "()I");
			global::android.widget.CursorTreeAdapter._getChildrenCount16919 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getChildrenCount", "(I)I");
			global::android.widget.CursorTreeAdapter._getGroup16920 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getGroup", "(I)Ljava/lang/Object;");
			global::android.widget.CursorTreeAdapter._getChild16921 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getChild", "(II)Ljava/lang/Object;");
			global::android.widget.CursorTreeAdapter._getChildId16922 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getChildId", "(II)J");
			global::android.widget.CursorTreeAdapter._getGroupView16923 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter._getChildView16924 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter._isChildSelectable16925 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "isChildSelectable", "(II)Z");
			global::android.widget.CursorTreeAdapter._onGroupCollapsed16926 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "onGroupCollapsed", "(I)V");
			global::android.widget.CursorTreeAdapter._getCursor16927 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getCursor", "()Landroid/database/Cursor;");
			global::android.widget.CursorTreeAdapter._notifyDataSetChanged16928 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetChanged", "(Z)V");
			global::android.widget.CursorTreeAdapter._notifyDataSetChanged16929 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetChanged", "()V");
			global::android.widget.CursorTreeAdapter._notifyDataSetInvalidated16930 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetInvalidated", "()V");
			global::android.widget.CursorTreeAdapter._changeCursor16931 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "changeCursor", "(Landroid/database/Cursor;)V");
			global::android.widget.CursorTreeAdapter._convertToString16932 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/String;");
			global::android.widget.CursorTreeAdapter._runQueryOnBackgroundThread16933 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;");
			global::android.widget.CursorTreeAdapter._getFilterQueryProvider16934 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;");
			global::android.widget.CursorTreeAdapter._setFilterQueryProvider16935 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V");
			global::android.widget.CursorTreeAdapter._getChildrenCursor16936 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;");
			global::android.widget.CursorTreeAdapter._setGroupCursor16937 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "setGroupCursor", "(Landroid/database/Cursor;)V");
			global::android.widget.CursorTreeAdapter._setChildrenCursor16938 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "setChildrenCursor", "(ILandroid/database/Cursor;)V");
			global::android.widget.CursorTreeAdapter._newGroupView16939 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter._bindGroupView16940 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.CursorTreeAdapter._newChildView16941 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter._bindChildView16942 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.CursorTreeAdapter._CursorTreeAdapter16943 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "<init>", "(Landroid/database/Cursor;Landroid/content/Context;Z)V");
			global::android.widget.CursorTreeAdapter._CursorTreeAdapter16944 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "<init>", "(Landroid/database/Cursor;Landroid/content/Context;)V");
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_._getChildrenCursor16945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_.staticClass, global::android.widget.CursorTreeAdapter_._getChildrenCursor16945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _newGroupView16946;
		protected override global::android.view.View newGroupView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_._newGroupView16946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_.staticClass, global::android.widget.CursorTreeAdapter_._newGroupView16946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _bindGroupView16947;
		protected override void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_._bindGroupView16947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_.staticClass, global::android.widget.CursorTreeAdapter_._bindGroupView16947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _newChildView16948;
		protected override global::android.view.View newChildView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_._newChildView16948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_.staticClass, global::android.widget.CursorTreeAdapter_._newChildView16948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _bindChildView16949;
		protected override void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_._bindChildView16949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_.staticClass, global::android.widget.CursorTreeAdapter_._bindChildView16949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		static CursorTreeAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CursorTreeAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CursorTreeAdapter"));
			global::android.widget.CursorTreeAdapter_._getChildrenCursor16945 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter_.staticClass, "getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;");
			global::android.widget.CursorTreeAdapter_._newGroupView16946 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter_.staticClass, "newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter_._bindGroupView16947 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter_.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.CursorTreeAdapter_._newChildView16948 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter_.staticClass, "newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter_._bindChildView16949 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter_.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
