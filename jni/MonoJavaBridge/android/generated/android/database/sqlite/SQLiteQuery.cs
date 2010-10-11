namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteQuery : android.database.sqlite.SQLiteProgram
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteQuery()
		{
			InitJNI();
		}
		protected SQLiteQuery(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString2908;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery._toString2908)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._toString2908)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close2909;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery._close2909);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._close2909);
		}
		internal static global::MonoJavaBridge.MethodId _bindNull2910;
		public override void bindNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery._bindNull2910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._bindNull2910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bindLong2911;
		public override void bindLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery._bindLong2911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._bindLong2911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bindDouble2912;
		public override void bindDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery._bindDouble2912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._bindDouble2912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bindString2913;
		public override void bindString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery._bindString2913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._bindString2913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteQuery.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteQuery"));
			global::android.database.sqlite.SQLiteQuery._toString2908 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQuery.staticClass, "toString", "()Ljava/lang/String;");
			global::android.database.sqlite.SQLiteQuery._close2909 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQuery.staticClass, "close", "()V");
			global::android.database.sqlite.SQLiteQuery._bindNull2910 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQuery.staticClass, "bindNull", "(I)V");
			global::android.database.sqlite.SQLiteQuery._bindLong2911 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQuery.staticClass, "bindLong", "(IJ)V");
			global::android.database.sqlite.SQLiteQuery._bindDouble2912 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQuery.staticClass, "bindDouble", "(ID)V");
			global::android.database.sqlite.SQLiteQuery._bindString2913 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQuery.staticClass, "bindString", "(ILjava/lang/String;)V");
		}
	}
}
