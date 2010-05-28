namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class CursorAdapter : android.widget.BaseAdapter, Filterable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static CursorAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.CursorAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected CursorAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _init10034; 
		protected virtual void init(android.content.Context arg0, android.database.Cursor arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				@__env.CallVoidMethod(this, global::android.widget.CursorAdapter._init10034, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._init10034, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged10035; 
		protected virtual void onContentChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				@__env.CallVoidMethod(this, global::android.widget.CursorAdapter._onContentChanged10035); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._onContentChanged10035); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount10036; 
		public override int getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return @__env.CallIntMethod(this, global::android.widget.CursorAdapter._getCount10036); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getCount10036); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItem10037; 
		public override global::java.lang.Object getItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._getItem10037, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getItem10037, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemId10038; 
		public override long getItemId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return @__env.CallLongMethod(this, global::android.widget.CursorAdapter._getItemId10038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getItemId10038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilter10039; 
		public virtual global::android.widget.Filter getFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._getFilter10039)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getFilter10039)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds10040; 
		public override bool hasStableIds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return @__env.CallBooleanMethod(this, global::android.widget.CursorAdapter._hasStableIds10040); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._hasStableIds10040); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getView10041; 
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._getView10041, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getView10041, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCursor10042; 
		public virtual global::android.database.Cursor getCursor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._getCursor10042)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getCursor10042)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownView10043; 
		public override global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._getDropDownView10043, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getDropDownView10043, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newView10044; 
		public abstract global::android.view.View newView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _newDropDownView10045; 
		public virtual global::android.view.View newDropDownView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._newDropDownView10045, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._newDropDownView10045, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bindView10046; 
		public abstract void bindView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _changeCursor10047; 
		public virtual void changeCursor(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				@__env.CallVoidMethod(this, global::android.widget.CursorAdapter._changeCursor10047, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._changeCursor10047, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _convertToString10048; 
		public virtual global::java.lang.CharSequence convertToString(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._convertToString10048, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._convertToString10048, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _runQueryOnBackgroundThread10049; 
		public virtual global::android.database.Cursor runQueryOnBackgroundThread(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._runQueryOnBackgroundThread10049, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._runQueryOnBackgroundThread10049, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilterQueryProvider10050; 
		public virtual global::android.widget.FilterQueryProvider getFilterQueryProvider() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.FilterQueryProvider>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._getFilterQueryProvider10050)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.FilterQueryProvider>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getFilterQueryProvider10050)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilterQueryProvider10051; 
		public virtual void setFilterQueryProvider(android.widget.FilterQueryProvider arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.CursorAdapter)) 
				@__env.CallVoidMethod(this, global::android.widget.CursorAdapter._setFilterQueryProvider10051, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._setFilterQueryProvider10051, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CursorAdapter10052; 
		public CursorAdapter(android.content.Context arg0, android.database.Cursor arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._CursorAdapter10052, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CursorAdapter10053; 
		public CursorAdapter(android.content.Context arg0, android.database.Cursor arg1, bool arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._CursorAdapter10053, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.CursorAdapter.staticClass = @__class; 
			global::android.widget.CursorAdapter._init10034 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "init", "(Landroid/content/Context;Landroid/database/Cursor;Z)V"); 
			global::android.widget.CursorAdapter._onContentChanged10035 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "onContentChanged", "()V"); 
			global::android.widget.CursorAdapter._getCount10036 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getCount", "()I"); 
			global::android.widget.CursorAdapter._getItem10037 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;"); 
			global::android.widget.CursorAdapter._getItemId10038 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getItemId", "(I)J"); 
			global::android.widget.CursorAdapter._getFilter10039 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;"); 
			global::android.widget.CursorAdapter._hasStableIds10040 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "hasStableIds", "()Z"); 
			global::android.widget.CursorAdapter._getView10041 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.CursorAdapter._getCursor10042 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getCursor", "()Landroid/database/Cursor;"); 
			global::android.widget.CursorAdapter._getDropDownView10043 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.CursorAdapter._newView10044 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.CursorAdapter._newDropDownView10045 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "newDropDownView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.CursorAdapter._bindView10046 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V"); 
			global::android.widget.CursorAdapter._changeCursor10047 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "changeCursor", "(Landroid/database/Cursor;)V"); 
			global::android.widget.CursorAdapter._convertToString10048 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;"); 
			global::android.widget.CursorAdapter._runQueryOnBackgroundThread10049 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;"); 
			global::android.widget.CursorAdapter._getFilterQueryProvider10050 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;"); 
			global::android.widget.CursorAdapter._setFilterQueryProvider10051 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V"); 
			global::android.widget.CursorAdapter._CursorAdapter10052 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;)V"); 
			global::android.widget.CursorAdapter._CursorAdapter10053 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;Z)V"); 
		} 
	} 
} 
