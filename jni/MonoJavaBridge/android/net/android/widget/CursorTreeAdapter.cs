namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class CursorTreeAdapter : android.widget.BaseExpandableListAdapter, Filterable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static CursorTreeAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.CursorTreeAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected CursorTreeAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroupId10054; 
		public override long getGroupId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return @__env.CallLongMethod(this, global::android.widget.CursorTreeAdapter._getGroupId10054, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getGroupId10054, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilter10055; 
		public virtual global::android.widget.Filter getFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorTreeAdapter._getFilter10055)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getFilter10055)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds10056; 
		public override bool hasStableIds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return @__env.CallBooleanMethod(this, global::android.widget.CursorTreeAdapter._hasStableIds10056); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._hasStableIds10056); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroupCount10057; 
		public override int getGroupCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return @__env.CallIntMethod(this, global::android.widget.CursorTreeAdapter._getGroupCount10057); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getGroupCount10057); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildrenCount10058; 
		public override int getChildrenCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return @__env.CallIntMethod(this, global::android.widget.CursorTreeAdapter._getChildrenCount10058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getChildrenCount10058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroup10059; 
		public override global::java.lang.Object getGroup(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorTreeAdapter._getGroup10059, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getGroup10059, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChild10060; 
		public override global::java.lang.Object getChild(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorTreeAdapter._getChild10060, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getChild10060, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildId10061; 
		public override long getChildId(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return @__env.CallLongMethod(this, global::android.widget.CursorTreeAdapter._getChildId10061, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getChildId10061, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroupView10062; 
		public override global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorTreeAdapter._getGroupView10062, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getGroupView10062, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildView10063; 
		public override global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorTreeAdapter._getChildView10063, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getChildView10063, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isChildSelectable10064; 
		public override bool isChildSelectable(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return @__env.CallBooleanMethod(this, global::android.widget.CursorTreeAdapter._isChildSelectable10064, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._isChildSelectable10064, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGroupCollapsed10065; 
		public override void onGroupCollapsed(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				@__env.CallVoidMethod(this, global::android.widget.CursorTreeAdapter._onGroupCollapsed10065, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._onGroupCollapsed10065, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCursor10066; 
		public virtual global::android.database.Cursor getCursor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorTreeAdapter._getCursor10066)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getCursor10066)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetChanged10067; 
		public virtual void notifyDataSetChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				@__env.CallVoidMethod(this, global::android.widget.CursorTreeAdapter._notifyDataSetChanged10067, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._notifyDataSetChanged10067, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetChanged10068; 
		public override void notifyDataSetChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				@__env.CallVoidMethod(this, global::android.widget.CursorTreeAdapter._notifyDataSetChanged10068); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._notifyDataSetChanged10068); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetInvalidated10069; 
		public override void notifyDataSetInvalidated() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				@__env.CallVoidMethod(this, global::android.widget.CursorTreeAdapter._notifyDataSetInvalidated10069); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._notifyDataSetInvalidated10069); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _changeCursor10070; 
		public virtual void changeCursor(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				@__env.CallVoidMethod(this, global::android.widget.CursorTreeAdapter._changeCursor10070, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._changeCursor10070, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _convertToString10071; 
		public virtual global::java.lang.String convertToString(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorTreeAdapter._convertToString10071, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._convertToString10071, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _runQueryOnBackgroundThread10072; 
		public virtual global::android.database.Cursor runQueryOnBackgroundThread(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorTreeAdapter._runQueryOnBackgroundThread10072, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._runQueryOnBackgroundThread10072, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilterQueryProvider10073; 
		public virtual global::android.widget.FilterQueryProvider getFilterQueryProvider() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.FilterQueryProvider>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorTreeAdapter._getFilterQueryProvider10073)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.FilterQueryProvider>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._getFilterQueryProvider10073)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilterQueryProvider10074; 
		public virtual void setFilterQueryProvider(android.widget.FilterQueryProvider arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				@__env.CallVoidMethod(this, global::android.widget.CursorTreeAdapter._setFilterQueryProvider10074, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._setFilterQueryProvider10074, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildrenCursor10075; 
		protected abstract global::android.database.Cursor getChildrenCursor(android.database.Cursor arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setGroupCursor10076; 
		public virtual void setGroupCursor(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				@__env.CallVoidMethod(this, global::android.widget.CursorTreeAdapter._setGroupCursor10076, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._setGroupCursor10076, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChildrenCursor10077; 
		public virtual void setChildrenCursor(int arg0, android.database.Cursor arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				@__env.CallVoidMethod(this, global::android.widget.CursorTreeAdapter._setChildrenCursor10077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._setChildrenCursor10077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newGroupView10078; 
		protected abstract global::android.view.View newGroupView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _bindGroupView10079; 
		protected abstract void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _newChildView10080; 
		protected abstract global::android.view.View newChildView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _bindChildView10081; 
		protected abstract void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _CursorTreeAdapter10082; 
		public CursorTreeAdapter(android.database.Cursor arg0, android.content.Context arg1, bool arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._CursorTreeAdapter10082, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CursorTreeAdapter10083; 
		public CursorTreeAdapter(android.database.Cursor arg0, android.content.Context arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.CursorTreeAdapter.staticClass, global::android.widget.CursorTreeAdapter._CursorTreeAdapter10083, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.CursorTreeAdapter.staticClass = @__class; 
			global::android.widget.CursorTreeAdapter._getGroupId10054 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getGroupId", "(I)J"); 
			global::android.widget.CursorTreeAdapter._getFilter10055 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;"); 
			global::android.widget.CursorTreeAdapter._hasStableIds10056 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "hasStableIds", "()Z"); 
			global::android.widget.CursorTreeAdapter._getGroupCount10057 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getGroupCount", "()I"); 
			global::android.widget.CursorTreeAdapter._getChildrenCount10058 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getChildrenCount", "(I)I"); 
			global::android.widget.CursorTreeAdapter._getGroup10059 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getGroup", "(I)Ljava/lang/Object;"); 
			global::android.widget.CursorTreeAdapter._getChild10060 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getChild", "(II)Ljava/lang/Object;"); 
			global::android.widget.CursorTreeAdapter._getChildId10061 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getChildId", "(II)J"); 
			global::android.widget.CursorTreeAdapter._getGroupView10062 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.CursorTreeAdapter._getChildView10063 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.CursorTreeAdapter._isChildSelectable10064 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "isChildSelectable", "(II)Z"); 
			global::android.widget.CursorTreeAdapter._onGroupCollapsed10065 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "onGroupCollapsed", "(I)V"); 
			global::android.widget.CursorTreeAdapter._getCursor10066 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getCursor", "()Landroid/database/Cursor;"); 
			global::android.widget.CursorTreeAdapter._notifyDataSetChanged10067 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetChanged", "(Z)V"); 
			global::android.widget.CursorTreeAdapter._notifyDataSetChanged10068 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetChanged", "()V"); 
			global::android.widget.CursorTreeAdapter._notifyDataSetInvalidated10069 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetInvalidated", "()V"); 
			global::android.widget.CursorTreeAdapter._changeCursor10070 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "changeCursor", "(Landroid/database/Cursor;)V"); 
			global::android.widget.CursorTreeAdapter._convertToString10071 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/String;"); 
			global::android.widget.CursorTreeAdapter._runQueryOnBackgroundThread10072 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;"); 
			global::android.widget.CursorTreeAdapter._getFilterQueryProvider10073 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;"); 
			global::android.widget.CursorTreeAdapter._setFilterQueryProvider10074 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V"); 
			global::android.widget.CursorTreeAdapter._getChildrenCursor10075 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;"); 
			global::android.widget.CursorTreeAdapter._setGroupCursor10076 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "setGroupCursor", "(Landroid/database/Cursor;)V"); 
			global::android.widget.CursorTreeAdapter._setChildrenCursor10077 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "setChildrenCursor", "(ILandroid/database/Cursor;)V"); 
			global::android.widget.CursorTreeAdapter._newGroupView10078 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.CursorTreeAdapter._bindGroupView10079 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V"); 
			global::android.widget.CursorTreeAdapter._newChildView10080 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.CursorTreeAdapter._bindChildView10081 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V"); 
			global::android.widget.CursorTreeAdapter._CursorTreeAdapter10082 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "<init>", "(Landroid/database/Cursor;Landroid/content/Context;Z)V"); 
			global::android.widget.CursorTreeAdapter._CursorTreeAdapter10083 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "<init>", "(Landroid/database/Cursor;Landroid/content/Context;)V"); 
		} 
	} 
} 
