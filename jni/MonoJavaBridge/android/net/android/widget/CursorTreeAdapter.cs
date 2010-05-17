namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class CursorTreeAdapter : android.widget.BaseExpandableListAdapter, Filterable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static CursorTreeAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.CursorTreeAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected CursorTreeAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroupId9336; 
		public override long getGroupId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return @__env.CallLongMethod(this, _getGroupId9336, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.CursorTreeAdapter.staticClass, _getGroupId9336, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilter9337; 
		public virtual android.widget.Filter getFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, _getFilter9337)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorTreeAdapter.staticClass, _getFilter9337)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds9338; 
		public override bool hasStableIds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return @__env.CallBooleanMethod(this, _hasStableIds9338); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.CursorTreeAdapter.staticClass, _hasStableIds9338); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroupCount9339; 
		public override int getGroupCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return @__env.CallIntMethod(this, _getGroupCount9339); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.CursorTreeAdapter.staticClass, _getGroupCount9339); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildrenCount9340; 
		public override int getChildrenCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return @__env.CallIntMethod(this, _getChildrenCount9340, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.CursorTreeAdapter.staticClass, _getChildrenCount9340, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroup9341; 
		public override java.lang.Object getGroup(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getGroup9341, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorTreeAdapter.staticClass, _getGroup9341, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChild9342; 
		public override java.lang.Object getChild(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getChild9342, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorTreeAdapter.staticClass, _getChild9342, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildId9343; 
		public override long getChildId(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return @__env.CallLongMethod(this, _getChildId9343, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.CursorTreeAdapter.staticClass, _getChildId9343, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroupView9344; 
		public override android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getGroupView9344, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorTreeAdapter.staticClass, _getGroupView9344, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildView9345; 
		public override android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getChildView9345, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorTreeAdapter.staticClass, _getChildView9345, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isChildSelectable9346; 
		public override bool isChildSelectable(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return @__env.CallBooleanMethod(this, _isChildSelectable9346, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.CursorTreeAdapter.staticClass, _isChildSelectable9346, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGroupCollapsed9347; 
		public override void onGroupCollapsed(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				@__env.CallVoidMethod(this, _onGroupCollapsed9347, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CursorTreeAdapter.staticClass, _onGroupCollapsed9347, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCursor9348; 
		public virtual android.database.Cursor getCursor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, _getCursor9348)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorTreeAdapter.staticClass, _getCursor9348)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetChanged9349; 
		public virtual void notifyDataSetChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				@__env.CallVoidMethod(this, _notifyDataSetChanged9349, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CursorTreeAdapter.staticClass, _notifyDataSetChanged9349, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetChanged9350; 
		public override void notifyDataSetChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				@__env.CallVoidMethod(this, _notifyDataSetChanged9350); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CursorTreeAdapter.staticClass, _notifyDataSetChanged9350); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetInvalidated9351; 
		public override void notifyDataSetInvalidated() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				@__env.CallVoidMethod(this, _notifyDataSetInvalidated9351); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CursorTreeAdapter.staticClass, _notifyDataSetInvalidated9351); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _changeCursor9352; 
		public virtual void changeCursor(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				@__env.CallVoidMethod(this, _changeCursor9352, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CursorTreeAdapter.staticClass, _changeCursor9352, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _convertToString9353; 
		public virtual java.lang.String convertToString(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _convertToString9353, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorTreeAdapter.staticClass, _convertToString9353, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _runQueryOnBackgroundThread9354; 
		public virtual android.database.Cursor runQueryOnBackgroundThread(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, _runQueryOnBackgroundThread9354, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorTreeAdapter.staticClass, _runQueryOnBackgroundThread9354, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilterQueryProvider9355; 
		public virtual android.widget.FilterQueryProvider getFilterQueryProvider() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.FilterQueryProvider>(@__env, @__env.CallObjectMethodPtr(this, _getFilterQueryProvider9355)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.FilterQueryProvider>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorTreeAdapter.staticClass, _getFilterQueryProvider9355)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilterQueryProvider9356; 
		public virtual void setFilterQueryProvider(android.widget.FilterQueryProvider arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				@__env.CallVoidMethod(this, _setFilterQueryProvider9356, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CursorTreeAdapter.staticClass, _setFilterQueryProvider9356, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildrenCursor9357; 
		protected abstract android.database.Cursor getChildrenCursor(android.database.Cursor arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setGroupCursor9358; 
		public virtual void setGroupCursor(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				@__env.CallVoidMethod(this, _setGroupCursor9358, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CursorTreeAdapter.staticClass, _setGroupCursor9358, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChildrenCursor9359; 
		public virtual void setChildrenCursor(int arg0, android.database.Cursor arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorTreeAdapter)) 
				@__env.CallVoidMethod(this, _setChildrenCursor9359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CursorTreeAdapter.staticClass, _setChildrenCursor9359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newGroupView9360; 
		protected abstract android.view.View newGroupView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _bindGroupView9361; 
		protected abstract void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _newChildView9362; 
		protected abstract android.view.View newChildView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _bindChildView9363; 
		protected abstract void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _CursorTreeAdapter9364; 
		public CursorTreeAdapter(android.database.Cursor arg0, android.content.Context arg1, bool arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.CursorTreeAdapter.staticClass, _CursorTreeAdapter9364, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CursorTreeAdapter9365; 
		public CursorTreeAdapter(android.database.Cursor arg0, android.content.Context arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.CursorTreeAdapter.staticClass, _CursorTreeAdapter9365, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.CursorTreeAdapter.staticClass = @__class; 
			global::android.widget.CursorTreeAdapter._getGroupId9336 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getGroupId", "(I)J"); 
			global::android.widget.CursorTreeAdapter._getFilter9337 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;"); 
			global::android.widget.CursorTreeAdapter._hasStableIds9338 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "hasStableIds", "()Z"); 
			global::android.widget.CursorTreeAdapter._getGroupCount9339 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getGroupCount", "()I"); 
			global::android.widget.CursorTreeAdapter._getChildrenCount9340 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getChildrenCount", "(I)I"); 
			global::android.widget.CursorTreeAdapter._getGroup9341 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getGroup", "(I)Ljava/lang/Object;"); 
			global::android.widget.CursorTreeAdapter._getChild9342 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getChild", "(II)Ljava/lang/Object;"); 
			global::android.widget.CursorTreeAdapter._getChildId9343 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getChildId", "(II)J"); 
			global::android.widget.CursorTreeAdapter._getGroupView9344 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.CursorTreeAdapter._getChildView9345 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.CursorTreeAdapter._isChildSelectable9346 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "isChildSelectable", "(II)Z"); 
			global::android.widget.CursorTreeAdapter._onGroupCollapsed9347 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "onGroupCollapsed", "(I)V"); 
			global::android.widget.CursorTreeAdapter._getCursor9348 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getCursor", "()Landroid/database/Cursor;"); 
			global::android.widget.CursorTreeAdapter._notifyDataSetChanged9349 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetChanged", "(Z)V"); 
			global::android.widget.CursorTreeAdapter._notifyDataSetChanged9350 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetChanged", "()V"); 
			global::android.widget.CursorTreeAdapter._notifyDataSetInvalidated9351 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "notifyDataSetInvalidated", "()V"); 
			global::android.widget.CursorTreeAdapter._changeCursor9352 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "changeCursor", "(Landroid/database/Cursor;)V"); 
			global::android.widget.CursorTreeAdapter._convertToString9353 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/String;"); 
			global::android.widget.CursorTreeAdapter._runQueryOnBackgroundThread9354 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;"); 
			global::android.widget.CursorTreeAdapter._getFilterQueryProvider9355 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;"); 
			global::android.widget.CursorTreeAdapter._setFilterQueryProvider9356 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V"); 
			global::android.widget.CursorTreeAdapter._getChildrenCursor9357 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;"); 
			global::android.widget.CursorTreeAdapter._setGroupCursor9358 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "setGroupCursor", "(Landroid/database/Cursor;)V"); 
			global::android.widget.CursorTreeAdapter._setChildrenCursor9359 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "setChildrenCursor", "(ILandroid/database/Cursor;)V"); 
			global::android.widget.CursorTreeAdapter._newGroupView9360 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.CursorTreeAdapter._bindGroupView9361 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V"); 
			global::android.widget.CursorTreeAdapter._newChildView9362 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.CursorTreeAdapter._bindChildView9363 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V"); 
			global::android.widget.CursorTreeAdapter._CursorTreeAdapter9364 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "<init>", "(Landroid/database/Cursor;Landroid/content/Context;Z)V"); 
			global::android.widget.CursorTreeAdapter._CursorTreeAdapter9365 = @__env.GetMethodID(global::android.widget.CursorTreeAdapter.staticClass, "<init>", "(Landroid/database/Cursor;Landroid/content/Context;)V"); 
		} 
	} 
} 
