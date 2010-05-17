namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class CursorAdapter : android.widget.BaseAdapter, Filterable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static CursorAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.CursorAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected CursorAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _init9316; 
		protected virtual void init(android.content.Context arg0, android.database.Cursor arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				@__env.CallVoidMethod(this, _init9316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CursorAdapter.staticClass, _init9316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged9317; 
		protected virtual void onContentChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				@__env.CallVoidMethod(this, _onContentChanged9317); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CursorAdapter.staticClass, _onContentChanged9317); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount9318; 
		public override int getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return @__env.CallIntMethod(this, _getCount9318); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.CursorAdapter.staticClass, _getCount9318); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItem9319; 
		public override java.lang.Object getItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getItem9319, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorAdapter.staticClass, _getItem9319, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemId9320; 
		public override long getItemId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return @__env.CallLongMethod(this, _getItemId9320, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.CursorAdapter.staticClass, _getItemId9320, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilter9321; 
		public virtual android.widget.Filter getFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, _getFilter9321)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorAdapter.staticClass, _getFilter9321)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds9322; 
		public override bool hasStableIds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return @__env.CallBooleanMethod(this, _hasStableIds9322); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.CursorAdapter.staticClass, _hasStableIds9322); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getView9323; 
		public override android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getView9323, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorAdapter.staticClass, _getView9323, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCursor9324; 
		public virtual android.database.Cursor getCursor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, _getCursor9324)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorAdapter.staticClass, _getCursor9324)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownView9325; 
		public override android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getDropDownView9325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorAdapter.staticClass, _getDropDownView9325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newView9326; 
		public abstract android.view.View newView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _newDropDownView9327; 
		public virtual android.view.View newDropDownView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _newDropDownView9327, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorAdapter.staticClass, _newDropDownView9327, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bindView9328; 
		public abstract void bindView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _changeCursor9329; 
		public virtual void changeCursor(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				@__env.CallVoidMethod(this, _changeCursor9329, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CursorAdapter.staticClass, _changeCursor9329, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _convertToString9330; 
		public virtual java.lang.CharSequence convertToString(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _convertToString9330, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorAdapter.staticClass, _convertToString9330, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _runQueryOnBackgroundThread9331; 
		public virtual android.database.Cursor runQueryOnBackgroundThread(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, _runQueryOnBackgroundThread9331, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorAdapter.staticClass, _runQueryOnBackgroundThread9331, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilterQueryProvider9332; 
		public virtual android.widget.FilterQueryProvider getFilterQueryProvider() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.FilterQueryProvider>(@__env, @__env.CallObjectMethodPtr(this, _getFilterQueryProvider9332)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.FilterQueryProvider>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.CursorAdapter.staticClass, _getFilterQueryProvider9332)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilterQueryProvider9333; 
		public virtual void setFilterQueryProvider(android.widget.FilterQueryProvider arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				@__env.CallVoidMethod(this, _setFilterQueryProvider9333, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.CursorAdapter.staticClass, _setFilterQueryProvider9333, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CursorAdapter9334; 
		public CursorAdapter(android.content.Context arg0, android.database.Cursor arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.CursorAdapter.staticClass, _CursorAdapter9334, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CursorAdapter9335; 
		public CursorAdapter(android.content.Context arg0, android.database.Cursor arg1, bool arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.CursorAdapter.staticClass, _CursorAdapter9335, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.CursorAdapter.staticClass = @__class; 
			global::android.widget.CursorAdapter._init9316 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "init", "(Landroid/content/Context;Landroid/database/Cursor;Z)V"); 
			global::android.widget.CursorAdapter._onContentChanged9317 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "onContentChanged", "()V"); 
			global::android.widget.CursorAdapter._getCount9318 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getCount", "()I"); 
			global::android.widget.CursorAdapter._getItem9319 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;"); 
			global::android.widget.CursorAdapter._getItemId9320 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getItemId", "(I)J"); 
			global::android.widget.CursorAdapter._getFilter9321 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;"); 
			global::android.widget.CursorAdapter._hasStableIds9322 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "hasStableIds", "()Z"); 
			global::android.widget.CursorAdapter._getView9323 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.CursorAdapter._getCursor9324 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getCursor", "()Landroid/database/Cursor;"); 
			global::android.widget.CursorAdapter._getDropDownView9325 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.CursorAdapter._newView9326 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.CursorAdapter._newDropDownView9327 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "newDropDownView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.CursorAdapter._bindView9328 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V"); 
			global::android.widget.CursorAdapter._changeCursor9329 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "changeCursor", "(Landroid/database/Cursor;)V"); 
			global::android.widget.CursorAdapter._convertToString9330 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;"); 
			global::android.widget.CursorAdapter._runQueryOnBackgroundThread9331 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;"); 
			global::android.widget.CursorAdapter._getFilterQueryProvider9332 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;"); 
			global::android.widget.CursorAdapter._setFilterQueryProvider9333 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V"); 
			global::android.widget.CursorAdapter._CursorAdapter9334 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;)V"); 
			global::android.widget.CursorAdapter._CursorAdapter9335 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;Z)V"); 
		} 
	} 
} 
