namespace android.database.sqlite 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SQLiteCursor : android.database.AbstractWindowedCursor
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SQLiteCursor() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.sqlite.SQLiteCursor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.sqlite.SQLiteCursor(@__env); 
			} 
		} 
		protected SQLiteCursor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close2260; 
		public override void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteCursor)) 
				@__env.CallVoidMethod(this, _close2260); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteCursor.staticClass, _close2260); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount2261; 
		public override int getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteCursor)) 
				return @__env.CallIntMethod(this, _getCount2261); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.sqlite.SQLiteCursor.staticClass, _getCount2261); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndex2262; 
		public override int getColumnIndex(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteCursor)) 
				return @__env.CallIntMethod(this, _getColumnIndex2262, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.sqlite.SQLiteCursor.staticClass, _getColumnIndex2262, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNames2263; 
		public override java.lang.String[] getColumnNames() 
		{ 
			if (GetType() == typeof(android.database.sqlite.SQLiteCursor)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getColumnNames2263)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.sqlite.SQLiteCursor.staticClass, _getColumnNames2263)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deactivate2264; 
		public override void deactivate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteCursor)) 
				@__env.CallVoidMethod(this, _deactivate2264); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteCursor.staticClass, _deactivate2264); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requery2265; 
		public override bool requery() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteCursor)) 
				return @__env.CallBooleanMethod(this, _requery2265); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.sqlite.SQLiteCursor.staticClass, _requery2265); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver2266; 
		public override void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteCursor)) 
				@__env.CallVoidMethod(this, _registerDataSetObserver2266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteCursor.staticClass, _registerDataSetObserver2266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMove2267; 
		public override bool onMove(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteCursor)) 
				return @__env.CallBooleanMethod(this, _onMove2267, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.sqlite.SQLiteCursor.staticClass, _onMove2267, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWindow2268; 
		public override void setWindow(android.database.CursorWindow arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteCursor)) 
				@__env.CallVoidMethod(this, _setWindow2268, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteCursor.staticClass, _setWindow2268, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDatabase2269; 
		public virtual android.database.sqlite.SQLiteDatabase getDatabase() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteCursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallObjectMethodPtr(this, _getDatabase2269)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.sqlite.SQLiteCursor.staticClass, _getDatabase2269)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelectionArguments2270; 
		public virtual void setSelectionArguments(java.lang.String[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteCursor)) 
				@__env.CallVoidMethod(this, _setSelectionArguments2270, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteCursor.staticClass, _setSelectionArguments2270, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteCursor2271; 
		public SQLiteCursor(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.sqlite.SQLiteCursor.staticClass, _SQLiteCursor2271, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.sqlite.SQLiteCursor.staticClass = @__class; 
			global::android.database.sqlite.SQLiteCursor._close2260 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "close", "()V"); 
			global::android.database.sqlite.SQLiteCursor._getCount2261 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "getCount", "()I"); 
			global::android.database.sqlite.SQLiteCursor._getColumnIndex2262 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "getColumnIndex", "(Ljava/lang/String;)I"); 
			global::android.database.sqlite.SQLiteCursor._getColumnNames2263 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;"); 
			global::android.database.sqlite.SQLiteCursor._deactivate2264 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "deactivate", "()V"); 
			global::android.database.sqlite.SQLiteCursor._requery2265 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "requery", "()Z"); 
			global::android.database.sqlite.SQLiteCursor._registerDataSetObserver2266 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.database.sqlite.SQLiteCursor._onMove2267 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "onMove", "(II)Z"); 
			global::android.database.sqlite.SQLiteCursor._setWindow2268 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "setWindow", "(Landroid/database/CursorWindow;)V"); 
			global::android.database.sqlite.SQLiteCursor._getDatabase2269 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "getDatabase", "()Landroid/database/sqlite/SQLiteDatabase;"); 
			global::android.database.sqlite.SQLiteCursor._setSelectionArguments2270 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "setSelectionArguments", "([Ljava/lang/String;)V"); 
			global::android.database.sqlite.SQLiteCursor._SQLiteCursor2271 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "<init>", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/database/sqlite/SQLiteCursorDriver;Ljava/lang/String;Landroid/database/sqlite/SQLiteQuery;)V"); 
		} 
	} 
} 
