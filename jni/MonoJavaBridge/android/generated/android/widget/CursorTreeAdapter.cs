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
		internal static global::MonoJavaBridge.MethodId _getGroupId11674;
		public override long getGroupId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getGroupId11674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getGroupId11674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFilter11675;
		public virtual global::android.widget.Filter getFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getFilter11675)) as android.widget.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getFilter11675)) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds11676;
		public override bool hasStableIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._hasStableIds11676);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._hasStableIds11676);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupCount11677;
		public override int getGroupCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getGroupCount11677);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getGroupCount11677);
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCount11678;
		public override int getChildrenCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getChildrenCount11678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getChildrenCount11678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGroup11679;
		public override global::java.lang.Object getGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getGroup11679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getGroup11679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChild11680;
		public override global::java.lang.Object getChild(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getChild11680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getChild11680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChildId11681;
		public override long getChildId(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getChildId11681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getChildId11681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getGroupView11682;
		public override global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getGroupView11682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getGroupView11682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getChildView11683;
		public override global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getChildView11683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getChildView11683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isChildSelectable11684;
		public override bool isChildSelectable(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._isChildSelectable11684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._isChildSelectable11684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onGroupCollapsed11685;
		public override void onGroupCollapsed(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._onGroupCollapsed11685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._onGroupCollapsed11685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCursor11686;
		public virtual global::android.database.Cursor getCursor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getCursor11686)) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getCursor11686)) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged11687;
		public virtual void notifyDataSetChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._notifyDataSetChanged11687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._notifyDataSetChanged11687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged11688;
		public override void notifyDataSetChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._notifyDataSetChanged11688);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._notifyDataSetChanged11688);
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetInvalidated11689;
		public override void notifyDataSetInvalidated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._notifyDataSetInvalidated11689);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._notifyDataSetInvalidated11689);
		}
		internal static global::MonoJavaBridge.MethodId _changeCursor11690;
		public virtual void changeCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._changeCursor11690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._changeCursor11690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _convertToString11691;
		public virtual global::java.lang.String convertToString(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._convertToString11691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._convertToString11691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _runQueryOnBackgroundThread11692;
		public virtual global::android.database.Cursor runQueryOnBackgroundThread(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._runQueryOnBackgroundThread11692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._runQueryOnBackgroundThread11692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		public android.database.Cursor runQueryOnBackgroundThread(string arg0)
		{
			return runQueryOnBackgroundThread((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getFilterQueryProvider11693;
		public virtual global::android.widget.FilterQueryProvider getFilterQueryProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.FilterQueryProvider>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._getFilterQueryProvider11693)) as android.widget.FilterQueryProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.FilterQueryProvider>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getFilterQueryProvider11693)) as android.widget.FilterQueryProvider;
		}
		internal static global::MonoJavaBridge.MethodId _setFilterQueryProvider11694;
		public virtual void setFilterQueryProvider(android.widget.FilterQueryProvider arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._setFilterQueryProvider11694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._setFilterQueryProvider11694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCursor11695;
		protected abstract global::android.database.Cursor getChildrenCursor(android.database.Cursor arg0);
		internal static global::MonoJavaBridge.MethodId _setGroupCursor11696;
		public virtual void setGroupCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._setGroupCursor11696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._setGroupCursor11696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildrenCursor11697;
		public virtual void setChildrenCursor(int arg0, android.database.Cursor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter._setChildrenCursor11697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._setChildrenCursor11697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newGroupView11698;
		protected abstract global::android.view.View newGroupView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3);
		internal static global::MonoJavaBridge.MethodId _bindGroupView11699;
		protected abstract void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3);
		internal static global::MonoJavaBridge.MethodId _newChildView11700;
		protected abstract global::android.view.View newChildView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3);
		internal static global::MonoJavaBridge.MethodId _bindChildView11701;
		protected abstract void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3);
		internal static global::MonoJavaBridge.MethodId _CursorTreeAdapter11702;
		public CursorTreeAdapter(android.database.Cursor arg0, android.content.Context arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._CursorTreeAdapter11702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CursorTreeAdapter11703;
		public CursorTreeAdapter(android.database.Cursor arg0, android.content.Context arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._CursorTreeAdapter11703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CursorTreeAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CursorTreeAdapter"));
			global::android.widget.CursorTreeAdapter._getGroupId11674 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getGroupId", "(I)J");
			global::android.widget.CursorTreeAdapter._getFilter11675 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.CursorTreeAdapter._hasStableIds11676 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "hasStableIds", "()Z");
			global::android.widget.CursorTreeAdapter._getGroupCount11677 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getGroupCount", "()I");
			global::android.widget.CursorTreeAdapter._getChildrenCount11678 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getChildrenCount", "(I)I");
			global::android.widget.CursorTreeAdapter._getGroup11679 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getGroup", "(I)Ljava/lang/Object;");
			global::android.widget.CursorTreeAdapter._getChild11680 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getChild", "(II)Ljava/lang/Object;");
			global::android.widget.CursorTreeAdapter._getChildId11681 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getChildId", "(II)J");
			global::android.widget.CursorTreeAdapter._getGroupView11682 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter._getChildView11683 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter._isChildSelectable11684 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "isChildSelectable", "(II)Z");
			global::android.widget.CursorTreeAdapter._onGroupCollapsed11685 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "onGroupCollapsed", "(I)V");
			global::android.widget.CursorTreeAdapter._getCursor11686 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getCursor", "()Landroid/database/Cursor;");
			global::android.widget.CursorTreeAdapter._notifyDataSetChanged11687 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetChanged", "(Z)V");
			global::android.widget.CursorTreeAdapter._notifyDataSetChanged11688 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetChanged", "()V");
			global::android.widget.CursorTreeAdapter._notifyDataSetInvalidated11689 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetInvalidated", "()V");
			global::android.widget.CursorTreeAdapter._changeCursor11690 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "changeCursor", "(Landroid/database/Cursor;)V");
			global::android.widget.CursorTreeAdapter._convertToString11691 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/String;");
			global::android.widget.CursorTreeAdapter._runQueryOnBackgroundThread11692 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;");
			global::android.widget.CursorTreeAdapter._getFilterQueryProvider11693 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;");
			global::android.widget.CursorTreeAdapter._setFilterQueryProvider11694 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V");
			global::android.widget.CursorTreeAdapter._getChildrenCursor11695 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;");
			global::android.widget.CursorTreeAdapter._setGroupCursor11696 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "setGroupCursor", "(Landroid/database/Cursor;)V");
			global::android.widget.CursorTreeAdapter._setChildrenCursor11697 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "setChildrenCursor", "(ILandroid/database/Cursor;)V");
			global::android.widget.CursorTreeAdapter._newGroupView11698 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter._bindGroupView11699 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.CursorTreeAdapter._newChildView11700 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter._bindChildView11701 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.CursorTreeAdapter._CursorTreeAdapter11702 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "<init>", "(Landroid/database/Cursor;Landroid/content/Context;Z)V");
			global::android.widget.CursorTreeAdapter._CursorTreeAdapter11703 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter.staticClass, "<init>", "(Landroid/database/Cursor;Landroid/content/Context;)V");
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
		internal static global::MonoJavaBridge.MethodId _getChildrenCursor11704;
		protected override global::android.database.Cursor getChildrenCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_._getChildrenCursor11704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_.staticClass, global::android.widget.CursorTreeAdapter_._getChildrenCursor11704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _newGroupView11705;
		protected override global::android.view.View newGroupView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_._newGroupView11705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_.staticClass, global::android.widget.CursorTreeAdapter_._newGroupView11705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _bindGroupView11706;
		protected override void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_._bindGroupView11706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_.staticClass, global::android.widget.CursorTreeAdapter_._bindGroupView11706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _newChildView11707;
		protected override global::android.view.View newChildView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_._newChildView11707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_.staticClass, global::android.widget.CursorTreeAdapter_._newChildView11707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _bindChildView11708;
		protected override void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_._bindChildView11708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorTreeAdapter_.staticClass, global::android.widget.CursorTreeAdapter_._bindChildView11708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CursorTreeAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CursorTreeAdapter"));
			global::android.widget.CursorTreeAdapter_._getChildrenCursor11704 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter_.staticClass, "getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;");
			global::android.widget.CursorTreeAdapter_._newGroupView11705 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter_.staticClass, "newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter_._bindGroupView11706 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter_.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.CursorTreeAdapter_._newChildView11707 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter_.staticClass, "newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorTreeAdapter_._bindChildView11708 = @__env.GetMethodIDNoThrow(global::android.widget.CursorTreeAdapter_.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
		}
	}
}
