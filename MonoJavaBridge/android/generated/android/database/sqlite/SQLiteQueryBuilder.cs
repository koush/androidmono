namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteQueryBuilder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteQueryBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _query4842;
		public virtual global::android.database.Cursor query(android.database.sqlite.SQLiteDatabase arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "query", "(Landroid/database/sqlite/SQLiteDatabase;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.database.sqlite.SQLiteQueryBuilder._query4842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6)) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _query4843;
		public virtual global::android.database.Cursor query(android.database.sqlite.SQLiteDatabase arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "query", "(Landroid/database/sqlite/SQLiteDatabase;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.database.sqlite.SQLiteQueryBuilder._query4843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7)) as android.database.Cursor;
		}
		public new bool Distinct
		{
			set
			{
				setDistinct(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDistinct4844;
		public virtual void setDistinct(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "setDistinct", "(Z)V", ref global::android.database.sqlite.SQLiteQueryBuilder._setDistinct4844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Tables
		{
			get
			{
				return getTables();
			}
			set
			{
				setTables(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTables4845;
		public virtual global::java.lang.String getTables()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "getTables", "()Ljava/lang/String;", ref global::android.database.sqlite.SQLiteQueryBuilder._getTables4845) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTables4846;
		public virtual void setTables(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "setTables", "(Ljava/lang/String;)V", ref global::android.database.sqlite.SQLiteQueryBuilder._setTables4846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _appendWhere4847;
		public virtual void appendWhere(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "appendWhere", "(Ljava/lang/CharSequence;)V", ref global::android.database.sqlite.SQLiteQueryBuilder._appendWhere4847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void appendWhere(string arg0)
		{
			appendWhere((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _appendWhereEscapeString4848;
		public virtual void appendWhereEscapeString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "appendWhereEscapeString", "(Ljava/lang/String;)V", ref global::android.database.sqlite.SQLiteQueryBuilder._appendWhereEscapeString4848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Map ProjectionMap
		{
			set
			{
				setProjectionMap(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setProjectionMap4849;
		public virtual void setProjectionMap(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "setProjectionMap", "(Ljava/util/Map;)V", ref global::android.database.sqlite.SQLiteQueryBuilder._setProjectionMap4849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.database.sqlite.SQLiteDatabase.CursorFactory CursorFactory
		{
			set
			{
				setCursorFactory(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCursorFactory4850;
		public virtual void setCursorFactory(android.database.sqlite.SQLiteDatabase.CursorFactory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "setCursorFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)V", ref global::android.database.sqlite.SQLiteQueryBuilder._setCursorFactory4850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setCursorFactory(global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg0)
		{
			setCursorFactory((global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _buildQueryString4851;
		public static global::java.lang.String buildQueryString(bool arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteQueryBuilder._buildQueryString4851.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteQueryBuilder._buildQueryString4851 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "buildQueryString", "(ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._buildQueryString4851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _appendColumns4852;
		public static void appendColumns(java.lang.StringBuilder arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteQueryBuilder._appendColumns4852.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteQueryBuilder._appendColumns4852 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "appendColumns", "(Ljava/lang/StringBuilder;[Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._appendColumns4852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _buildQuery4853;
		public virtual global::java.lang.String buildQuery(java.lang.String[] arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "buildQuery", "([Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::android.database.sqlite.SQLiteQueryBuilder._buildQuery4853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _buildUnionSubQuery4854;
		public virtual global::java.lang.String buildUnionSubQuery(java.lang.String arg0, java.lang.String[] arg1, java.util.Set arg2, int arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String[] arg6, java.lang.String arg7, java.lang.String arg8)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "buildUnionSubQuery", "(Ljava/lang/String;[Ljava/lang/String;Ljava/util/Set;ILjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::android.database.sqlite.SQLiteQueryBuilder._buildUnionSubQuery4854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _buildUnionQuery4855;
		public virtual global::java.lang.String buildUnionQuery(java.lang.String[] arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "buildUnionQuery", "([Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::android.database.sqlite.SQLiteQueryBuilder._buildUnionQuery4855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteQueryBuilder4856;
		public SQLiteQueryBuilder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteQueryBuilder._SQLiteQueryBuilder4856.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteQueryBuilder._SQLiteQueryBuilder4856 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._SQLiteQueryBuilder4856);
			Init(@__env, handle);
		}
		static SQLiteQueryBuilder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteQueryBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteQueryBuilder"));
		}
		internal static void InitJNI()
		{
		}
	}
}
