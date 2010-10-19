namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.CursorAdapter_))]
	public abstract partial class CursorAdapter : android.widget.BaseAdapter, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CursorAdapter()
		{
			InitJNI();
		}
		protected CursorAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _init11652;
		protected virtual void init(android.content.Context arg0, android.database.Cursor arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorAdapter._init11652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._init11652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged11653;
		protected virtual void onContentChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorAdapter._onContentChanged11653);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._onContentChanged11653);
		}
		internal static global::MonoJavaBridge.MethodId _getCount11654;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.CursorAdapter._getCount11654);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getCount11654);
		}
		internal static global::MonoJavaBridge.MethodId _getItem11655;
		public override global::java.lang.Object getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter._getItem11655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getItem11655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId11656;
		public override long getItemId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.CursorAdapter._getItemId11656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getItemId11656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFilter11657;
		public virtual global::android.widget.Filter getFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter._getFilter11657)) as android.widget.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getFilter11657)) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds11658;
		public override bool hasStableIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CursorAdapter._hasStableIds11658);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._hasStableIds11658);
		}
		internal static global::MonoJavaBridge.MethodId _getView11659;
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter._getView11659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getView11659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getCursor11660;
		public virtual global::android.database.Cursor getCursor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter._getCursor11660)) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getCursor11660)) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _getDropDownView11661;
		public override global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter._getDropDownView11661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getDropDownView11661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _newView11662;
		public abstract global::android.view.View newView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2);
		internal static global::MonoJavaBridge.MethodId _newDropDownView11663;
		public virtual global::android.view.View newDropDownView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter._newDropDownView11663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._newDropDownView11663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _bindView11664;
		public abstract void bindView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2);
		internal static global::MonoJavaBridge.MethodId _changeCursor11665;
		public virtual void changeCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorAdapter._changeCursor11665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._changeCursor11665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _convertToString11666;
		public virtual global::java.lang.CharSequence convertToString(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter._convertToString11666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._convertToString11666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _runQueryOnBackgroundThread11667;
		public virtual global::android.database.Cursor runQueryOnBackgroundThread(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter._runQueryOnBackgroundThread11667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._runQueryOnBackgroundThread11667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		public android.database.Cursor runQueryOnBackgroundThread(string arg0)
		{
			return runQueryOnBackgroundThread((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getFilterQueryProvider11668;
		public virtual global::android.widget.FilterQueryProvider getFilterQueryProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.FilterQueryProvider>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter._getFilterQueryProvider11668)) as android.widget.FilterQueryProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.FilterQueryProvider>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._getFilterQueryProvider11668)) as android.widget.FilterQueryProvider;
		}
		internal static global::MonoJavaBridge.MethodId _setFilterQueryProvider11669;
		public virtual void setFilterQueryProvider(android.widget.FilterQueryProvider arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorAdapter._setFilterQueryProvider11669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._setFilterQueryProvider11669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CursorAdapter11670;
		public CursorAdapter(android.content.Context arg0, android.database.Cursor arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._CursorAdapter11670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CursorAdapter11671;
		public CursorAdapter(android.content.Context arg0, android.database.Cursor arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CursorAdapter.staticClass, global::android.widget.CursorAdapter._CursorAdapter11671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CursorAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CursorAdapter"));
			global::android.widget.CursorAdapter._init11652 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "init", "(Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.CursorAdapter._onContentChanged11653 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "onContentChanged", "()V");
			global::android.widget.CursorAdapter._getCount11654 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "getCount", "()I");
			global::android.widget.CursorAdapter._getItem11655 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.CursorAdapter._getItemId11656 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "getItemId", "(I)J");
			global::android.widget.CursorAdapter._getFilter11657 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.CursorAdapter._hasStableIds11658 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "hasStableIds", "()Z");
			global::android.widget.CursorAdapter._getView11659 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorAdapter._getCursor11660 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "getCursor", "()Landroid/database/Cursor;");
			global::android.widget.CursorAdapter._getDropDownView11661 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorAdapter._newView11662 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorAdapter._newDropDownView11663 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "newDropDownView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorAdapter._bindView11664 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V");
			global::android.widget.CursorAdapter._changeCursor11665 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "changeCursor", "(Landroid/database/Cursor;)V");
			global::android.widget.CursorAdapter._convertToString11666 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;");
			global::android.widget.CursorAdapter._runQueryOnBackgroundThread11667 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;");
			global::android.widget.CursorAdapter._getFilterQueryProvider11668 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;");
			global::android.widget.CursorAdapter._setFilterQueryProvider11669 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V");
			global::android.widget.CursorAdapter._CursorAdapter11670 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;)V");
			global::android.widget.CursorAdapter._CursorAdapter11671 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;Z)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.CursorAdapter))]
	public sealed partial class CursorAdapter_ : android.widget.CursorAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CursorAdapter_()
		{
			InitJNI();
		}
		internal CursorAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newView11672;
		public override global::android.view.View newView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter_._newView11672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CursorAdapter_.staticClass, global::android.widget.CursorAdapter_._newView11672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _bindView11673;
		public override void bindView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CursorAdapter_._bindView11673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CursorAdapter_.staticClass, global::android.widget.CursorAdapter_._bindView11673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CursorAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CursorAdapter"));
			global::android.widget.CursorAdapter_._newView11672 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter_.staticClass, "newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.CursorAdapter_._bindView11673 = @__env.GetMethodIDNoThrow(global::android.widget.CursorAdapter_.staticClass, "bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V");
		}
	}
}
