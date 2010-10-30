namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteQueryBuilder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteQueryBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.database.Cursor query(android.database.sqlite.SQLiteDatabase arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "query", "(Landroid/database/sqlite/SQLiteDatabase;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.database.sqlite.SQLiteQueryBuilder._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6)) as android.database.Cursor;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.database.Cursor query(android.database.sqlite.SQLiteDatabase arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "query", "(Landroid/database/sqlite/SQLiteDatabase;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.database.sqlite.SQLiteQueryBuilder._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7)) as android.database.Cursor;
		}
		public new bool Distinct
		{
			set
			{
				setDistinct(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setDistinct(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "setDistinct", "(Z)V", ref global::android.database.sqlite.SQLiteQueryBuilder._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getTables()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "getTables", "()Ljava/lang/String;", ref global::android.database.sqlite.SQLiteQueryBuilder._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setTables(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "setTables", "(Ljava/lang/String;)V", ref global::android.database.sqlite.SQLiteQueryBuilder._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void appendWhere(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "appendWhere", "(Ljava/lang/CharSequence;)V", ref global::android.database.sqlite.SQLiteQueryBuilder._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void appendWhere(string arg0)
		{
			appendWhere((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void appendWhereEscapeString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "appendWhereEscapeString", "(Ljava/lang/String;)V", ref global::android.database.sqlite.SQLiteQueryBuilder._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Map ProjectionMap
		{
			set
			{
				setProjectionMap(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setProjectionMap(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "setProjectionMap", "(Ljava/util/Map;)V", ref global::android.database.sqlite.SQLiteQueryBuilder._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.database.sqlite.SQLiteDatabase.CursorFactory CursorFactory
		{
			set
			{
				setCursorFactory(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setCursorFactory(android.database.sqlite.SQLiteDatabase.CursorFactory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "setCursorFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)V", ref global::android.database.sqlite.SQLiteQueryBuilder._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setCursorFactory(global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg0)
		{
			setCursorFactory((global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.lang.String buildQueryString(bool arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteQueryBuilder._m9.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteQueryBuilder._m9 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "buildQueryString", "(ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static void appendColumns(java.lang.StringBuilder arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteQueryBuilder._m10.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteQueryBuilder._m10 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "appendColumns", "(Ljava/lang/StringBuilder;[Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.String buildQuery(java.lang.String[] arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "buildQuery", "([Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::android.database.sqlite.SQLiteQueryBuilder._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.lang.String buildUnionSubQuery(java.lang.String arg0, java.lang.String[] arg1, java.util.Set arg2, int arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String[] arg6, java.lang.String arg7, java.lang.String arg8)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "buildUnionSubQuery", "(Ljava/lang/String;[Ljava/lang/String;Ljava/util/Set;ILjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::android.database.sqlite.SQLiteQueryBuilder._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.String buildUnionQuery(java.lang.String[] arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "buildUnionQuery", "([Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::android.database.sqlite.SQLiteQueryBuilder._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public SQLiteQueryBuilder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteQueryBuilder._m14.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteQueryBuilder._m14 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._m14);
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
