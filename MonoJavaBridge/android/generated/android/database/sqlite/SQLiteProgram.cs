namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.sqlite.SQLiteProgram_))]
	public abstract partial class SQLiteProgram : android.database.sqlite.SQLiteClosable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteProgram(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual void compile(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "compile", "(Ljava/lang/String;Z)V", ref global::android.database.sqlite.SQLiteProgram._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "close", "()V", ref global::android.database.sqlite.SQLiteProgram._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onAllReferencesReleased()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "onAllReferencesReleased", "()V", ref global::android.database.sqlite.SQLiteProgram._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void onAllReferencesReleasedFromContainer()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "onAllReferencesReleasedFromContainer", "()V", ref global::android.database.sqlite.SQLiteProgram._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void bindNull(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "bindNull", "(I)V", ref global::android.database.sqlite.SQLiteProgram._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getUniqueId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "getUniqueId", "()I", ref global::android.database.sqlite.SQLiteProgram._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void bindLong(int arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "bindLong", "(IJ)V", ref global::android.database.sqlite.SQLiteProgram._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void bindDouble(int arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "bindDouble", "(ID)V", ref global::android.database.sqlite.SQLiteProgram._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void bindString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "bindString", "(ILjava/lang/String;)V", ref global::android.database.sqlite.SQLiteProgram._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void bindBlob(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "bindBlob", "(I[B)V", ref global::android.database.sqlite.SQLiteProgram._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void clearBindings()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "clearBindings", "()V", ref global::android.database.sqlite.SQLiteProgram._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected virtual void native_compile(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "native_compile", "(Ljava/lang/String;)V", ref global::android.database.sqlite.SQLiteProgram._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected virtual void native_finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "native_finalize", "()V", ref global::android.database.sqlite.SQLiteProgram._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected virtual void native_bind_null(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_null", "(I)V", ref global::android.database.sqlite.SQLiteProgram._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected virtual void native_bind_long(int arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_long", "(IJ)V", ref global::android.database.sqlite.SQLiteProgram._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected virtual void native_bind_double(int arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_double", "(ID)V", ref global::android.database.sqlite.SQLiteProgram._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected virtual void native_bind_string(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_string", "(ILjava/lang/String;)V", ref global::android.database.sqlite.SQLiteProgram._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected virtual void native_bind_blob(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_blob", "(I[B)V", ref global::android.database.sqlite.SQLiteProgram._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static SQLiteProgram()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteProgram.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteProgram"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.sqlite.SQLiteProgram))]
	internal sealed partial class SQLiteProgram_ : android.database.sqlite.SQLiteProgram
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SQLiteProgram_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static SQLiteProgram_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteProgram_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteProgram"));
		}
	}
}
