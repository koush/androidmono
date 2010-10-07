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
		internal static global::net.sf.jni4net.jni.MethodId _init10736;
		protected virtual void init(android.content.Context arg0, android.database.Cursor arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CursorAdapter._init10736, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._init10736, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged10737;
		protected virtual void onContentChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CursorAdapter._onContentChanged10737);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._onContentChanged10737);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount10738;
		public override int getCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.CursorAdapter._getCount10738);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getCount10738);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItem10739;
		public override global::java.lang.Object getItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._getItem10739, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getItem10739, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemId10740;
		public override long getItemId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.CursorAdapter._getItemId10740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getItemId10740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFilter10741;
		public virtual global::android.widget.Filter getFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._getFilter10741));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getFilter10741));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds10742;
		public override bool hasStableIds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.CursorAdapter._hasStableIds10742);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._hasStableIds10742);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getView10743;
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._getView10743, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getView10743, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCursor10744;
		public virtual global::android.database.Cursor getCursor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._getCursor10744));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getCursor10744));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownView10745;
		public override global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._getDropDownView10745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getDropDownView10745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newView10746;
		public abstract global::android.view.View newView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2);
		internal static global::net.sf.jni4net.jni.MethodId _newDropDownView10747;
		public virtual global::android.view.View newDropDownView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._newDropDownView10747, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._newDropDownView10747, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindView10748;
		public abstract void bindView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2);
		internal static global::net.sf.jni4net.jni.MethodId _changeCursor10749;
		public virtual void changeCursor(android.database.Cursor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CursorAdapter._changeCursor10749, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._changeCursor10749, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _convertToString10750;
		public virtual global::java.lang.CharSequence convertToString(android.database.Cursor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._convertToString10750, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._convertToString10750, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _runQueryOnBackgroundThread10751;
		public virtual global::android.database.Cursor runQueryOnBackgroundThread(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._runQueryOnBackgroundThread10751, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._runQueryOnBackgroundThread10751, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		public android.database.Cursor runQueryOnBackgroundThread(string arg0)
		{
			return runQueryOnBackgroundThread((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFilterQueryProvider10752;
		public virtual global::android.widget.FilterQueryProvider getFilterQueryProvider() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.FilterQueryProvider>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CursorAdapter._getFilterQueryProvider10752));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.FilterQueryProvider>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getFilterQueryProvider10752));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFilterQueryProvider10753;
		public virtual void setFilterQueryProvider(android.widget.FilterQueryProvider arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CursorAdapter._setFilterQueryProvider10753, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._setFilterQueryProvider10753, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CursorAdapter10754;
		public CursorAdapter(android.content.Context arg0, android.database.Cursor arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._CursorAdapter10754, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CursorAdapter10755;
		public CursorAdapter(android.content.Context arg0, android.database.Cursor arg1, bool arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._CursorAdapter10755, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.CursorAdapter.staticClass = @__class;
			global::android.widget.CursorAdapter._init10736 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "init", "(Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.CursorAdapter._onContentChanged10737 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "onContentChanged", "()V");
			global::android.widget.CursorAdapter._getCount10738 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getCount", "()I");
			global::android.widget.CursorAdapter._getItem10739 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.CursorAdapter._getItemId10740 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getItemId", "(I)J");
			global::android.widget.CursorAdapter._getFilter10741 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.CursorAdapter._hasStableIds10742 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "hasStableIds", "()Z");
			global::android.widget.CursorAdapter._getView10743 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorAdapter._getCursor10744 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getCursor", "()Landroid/database/Cursor;");
			global::android.widget.CursorAdapter._getDropDownView10745 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorAdapter._newView10746 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorAdapter._newDropDownView10747 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "newDropDownView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorAdapter._bindView10748 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V");
			global::android.widget.CursorAdapter._changeCursor10749 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "changeCursor", "(Landroid/database/Cursor;)V");
			global::android.widget.CursorAdapter._convertToString10750 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;");
			global::android.widget.CursorAdapter._runQueryOnBackgroundThread10751 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;");
			global::android.widget.CursorAdapter._getFilterQueryProvider10752 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;");
			global::android.widget.CursorAdapter._setFilterQueryProvider10753 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V");
			global::android.widget.CursorAdapter._CursorAdapter10754 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;)V");
			global::android.widget.CursorAdapter._CursorAdapter10755 = @__env.GetMethodID(global::android.widget.CursorAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;Z)V");
		}
	}
}
