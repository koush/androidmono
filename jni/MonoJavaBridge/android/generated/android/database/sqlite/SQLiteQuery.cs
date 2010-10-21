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
		internal static global::MonoJavaBridge.MethodId _toString4818;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery._toString4818)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._toString4818)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close4819;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery._close4819);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._close4819);
		}
		internal static global::MonoJavaBridge.MethodId _bindNull4820;
		public override void bindNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery._bindNull4820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._bindNull4820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bindLong4821;
		public override void bindLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery._bindLong4821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._bindLong4821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bindDouble4822;
		public override void bindDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery._bindDouble4822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._bindDouble4822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bindString4823;
		public override void bindString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery._bindString4823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._bindString4823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteQuery.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteQuery"));
			global::android.database.sqlite.SQLiteQuery._toString4818 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQuery.staticClass, "toString", "()Ljava/lang/String;");
			global::android.database.sqlite.SQLiteQuery._close4819 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQuery.staticClass, "close", "()V");
			global::android.database.sqlite.SQLiteQuery._bindNull4820 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQuery.staticClass, "bindNull", "(I)V");
			global::android.database.sqlite.SQLiteQuery._bindLong4821 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQuery.staticClass, "bindLong", "(IJ)V");
			global::android.database.sqlite.SQLiteQuery._bindDouble4822 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQuery.staticClass, "bindDouble", "(ID)V");
			global::android.database.sqlite.SQLiteQuery._bindString4823 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQuery.staticClass, "bindString", "(ILjava/lang/String;)V");
		}
	}
}
