namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.CursorTreeAdapter_))]
	public abstract partial class CursorTreeAdapter : android.widget.BaseExpandableListAdapter, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CursorTreeAdapter()
		{
			InitJNI();
		}
		protected CursorTreeAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getGroupId16819;
		public override long getGroupId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getGroupId16819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getGroupId16819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFilter16820;
		public virtual global::android.widget.Filter getFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getFilter16820)) as android.widget.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getFilter16820)) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds16821;
		public override bool hasStableIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._hasStableIds16821);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._hasStableIds16821);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupCount16822;
		public override int getGroupCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getGroupCount16822);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getGroupCount16822);
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCount16823;
		public override int getChildrenCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getChildrenCount16823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getChildrenCount16823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGroup16824;
		public override global::java.lang.Object getGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getGroup16824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getGroup16824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChild16825;
		public override global::java.lang.Object getChild(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getChild16825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getChild16825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChildId16826;
		public override long getChildId(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getChildId16826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getChildId16826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getGroupView16827;
		public override global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getGroupView16827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getGroupView16827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getChildView16828;
		public override global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getChildView16828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getChildView16828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isChildSelectable16829;
		public override bool isChildSelectable(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._isChildSelectable16829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._isChildSelectable16829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onGroupCollapsed16830;
		public override void onGroupCollapsed(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._onGroupCollapsed16830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._onGroupCollapsed16830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCursor16831;
		public virtual global::android.database.Cursor getCursor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getCursor16831)) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getCursor16831)) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged16832;
		public virtual void notifyDataSetChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._notifyDataSetChanged16832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._notifyDataSetChanged16832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged16833;
		public override void notifyDataSetChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._notifyDataSetChanged16833);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._notifyDataSetChanged16833);
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetInvalidated16834;
		public override void notifyDataSetInvalidated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._notifyDataSetInvalidated16834);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._notifyDataSetInvalidated16834);
		}
		internal static global::MonoJavaBridge.MethodId _changeCursor16835;
		public virtual void changeCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._changeCursor16835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._changeCursor16835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _convertToString16836;
		public virtual global::java.lang.String convertToString(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._convertToString16836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._convertToString16836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _runQueryOnBackgroundThread16837;
		public virtual global::android.database.Cursor runQueryOnBackgroundThread(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._runQueryOnBackgroundThread16837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._runQueryOnBackgroundThread16837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		public android.database.Cursor runQueryOnBackgroundThread(string arg0)
		{
			return runQueryOnBackgroundThread((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getFilterQueryProvider16838;
		public virtual global::android.widget.FilterQueryProvider getFilterQueryProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.FilterQueryProvider>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getFilterQueryProvider16838)) as android.widget.FilterQueryProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.FilterQueryProvider>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getFilterQueryProvider16838)) as android.widget.FilterQueryProvider;
		}
		internal static global::MonoJavaBridge.MethodId _setFilterQueryProvider16839;
		public virtual void setFilterQueryProvider(android.widget.FilterQueryProvider arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._setFilterQueryProvider16839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._setFilterQueryProvider16839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCursor16840;
		protected abstract global::android.database.Cursor getChildrenCursor(android.database.Cursor arg0);
		internal static global::MonoJavaBridge.MethodId _setGroupCursor16841;
		public virtual void setGroupCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._setGroupCursor16841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._setGroupCursor16841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildrenCursor16842;
		public virtual void setChildrenCursor(int arg0, android.database.Cursor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._setChildrenCursor16842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._setChildrenCursor16842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newGroupView16843;
		protected abstract global::android.view.View newGroupView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3);
		internal static global::MonoJavaBridge.MethodId _bindGroupView16844;
		protected abstract void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3);
		internal static global::MonoJavaBridge.MethodId _newChildView16845;
		protected abstract global::android.view.View newChildView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3);
		internal static global::MonoJavaBridge.MethodId _bindChildView16846;
		protected abstract void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3);
		internal static global::MonoJavaBridge.MethodId _CursorTreeAdapter16847;
		public CursorTreeAdapter(android.database.Cursor arg0, android.content.Context arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._CursorTreeAdapter16847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CursorTreeAdapter16848;
		public CursorTreeAdapter(android.database.Cursor arg0, android.content.Context arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._CursorTreeAdapter16848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CursorTreeAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CursorTreeAdapter"));
			global::android.widget.CursorTreeAdapter._getGroupId16819 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getGroupId", "(I)J");
			global::android.widget.CursorTreeAdapter._getFilter16820 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.CursorTreeAdapter._hasStableIds16821 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "hasStableIds", "()Z");
			global::android.widget.CursorTreeAdapter._getGroupCount16822 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getGroupCount", "()I");
			global::android.widget.CursorTreeAdapter._getChildrenCount16823 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getChildrenCount", "(I)I");
			global::android.widget.CursorTreeAdapter._getGroup16824 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getGroup", "(I)Ljava/lang/Object;");
			global::android.widget.CursorTreeAdapter._getChild16825 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getChild", "(II)Ljava/lang/Object;");
			global::android.widget.CursorTreeAdapter._getChildId16826 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getChildId", "(II)J");
			global::android.widget.CursorTreeAdapter._getGroupView16827 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter._getChildView16828 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter._isChildSelectable16829 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "isChildSelectable", "(II)Z");
			global::android.widget.CursorTreeAdapter._onGroupCollapsed16830 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "onGroupCollapsed", "(I)V");
			global::android.widget.CursorTreeAdapter._getCursor16831 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getCursor", "()Landroid/database/Cursor;");
			global::android.widget.CursorTreeAdapter._notifyDataSetChanged16832 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetChanged", "(Z)V");
			global::android.widget.CursorTreeAdapter._notifyDataSetChanged16833 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetChanged", "()V");
			global::android.widget.CursorTreeAdapter._notifyDataSetInvalidated16834 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetInvalidated", "()V");
			global::android.widget.CursorTreeAdapter._changeCursor16835 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "changeCursor", "(Landroid/database/Cursor;)V");
			global::android.widget.CursorTreeAdapter._convertToString16836 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/String;");
			global::android.widget.CursorTreeAdapter._runQueryOnBackgroundThread16837 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;");
			global::android.widget.CursorTreeAdapter._getFilterQueryProvider16838 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;");
			global::android.widget.CursorTreeAdapter._setFilterQueryProvider16839 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V");
			global::android.widget.CursorTreeAdapter._getChildrenCursor16840 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;");
			global::android.widget.CursorTreeAdapter._setGroupCursor16841 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "setGroupCursor", "(Landroid/database/Cursor;)V");
			global::android.widget.CursorTreeAdapter._setChildrenCursor16842 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "setChildrenCursor", "(ILandroid/database/Cursor;)V");
			global::android.widget.CursorTreeAdapter._newGroupView16843 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter._bindGroupView16844 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.CursorTreeAdapter._newChildView16845 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter._bindChildView16846 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.CursorTreeAdapter._CursorTreeAdapter16847 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "<init>", "(Landroid/database/Cursor;Landroid/content/Context;Z)V");
			global::android.widget.CursorTreeAdapter._CursorTreeAdapter16848 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "<init>", "(Landroid/database/Cursor;Landroid/content/Context;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.CursorTreeAdapter))]
	public sealed partial class CursorTreeAdapter_ : android.widget.CursorTreeAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CursorTreeAdapter_()
		{
			InitJNI();
		}
		internal CursorTreeAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCursor16849;
		protected override global::android.database.Cursor getChildrenCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_._getChildrenCursor16849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_.staticClass, global::android.widget.CursorTreeAdapter_._getChildrenCursor16849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _newGroupView16850;
		protected override global::android.view.View newGroupView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_._newGroupView16850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_.staticClass, global::android.widget.CursorTreeAdapter_._newGroupView16850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _bindGroupView16851;
		protected override void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_._bindGroupView16851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_.staticClass, global::android.widget.CursorTreeAdapter_._bindGroupView16851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _newChildView16852;
		protected override global::android.view.View newChildView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_._newChildView16852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_.staticClass, global::android.widget.CursorTreeAdapter_._newChildView16852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _bindChildView16853;
		protected override void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_._bindChildView16853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_.staticClass, global::android.widget.CursorTreeAdapter_._bindChildView16853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CursorTreeAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CursorTreeAdapter"));
			global::android.widget.CursorTreeAdapter_._getChildrenCursor16849 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter_.staticClass, "getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;");
			global::android.widget.CursorTreeAdapter_._newGroupView16850 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter_.staticClass, "newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter_._bindGroupView16851 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter_.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.CursorTreeAdapter_._newChildView16852 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter_.staticClass, "newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter_._bindChildView16853 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter_.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
		}
	}
}
